import express from "express";
import db from "../db.js";
import authMiddleware from "../middleware/authmiddleware.js";

const router = express.Router();

router.post("/", authMiddleware, async (req, res) => {
  const { konyveles_id, amount, method } = req.body;

  try {
    for (const id of konyveles_id) {
      await db.query(`
        INSERT INTO fizetes (konyveles_id, amount, method, status)
        VALUES (?, ?, ?, 'completed')
      `, [id, amount, method]);

      await db.query(`
        UPDATE konyveles SET status = 'confirmed'
        WHERE konyveles_id = ?
      `, [id]);
    }

    res.json({ message: "Fizetés sikeres" });

  } catch (err) {
    console.error("FIZETÉS HIBA:", err);
    console.error("SQL:", err.sqlMessage);
  
    res.status(500).json({
      error: err.message,
      sql: err.sqlMessage
    });
  }
});

export default router;