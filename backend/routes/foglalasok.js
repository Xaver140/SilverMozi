import express from "express";
import db from "../db.js";
import authMiddleware from "../middleware/authmiddleware.js";

const router = express.Router();

router.post("/", authMiddleware, async (req, res) => {
  const { vetites_id, ules_ids, final_price } = req.body;

  // 🔥 LIMIT IDE KELL
  if (!ules_ids || ules_ids.length === 0) {
    return res.status(400).json({ error: "Nincs kiválasztott szék" });
  }

  if (ules_ids.length > 5) {
    return res.status(400).json({ error: "Maximum 5 hely foglalható" });
  }

  const conn = await db.getConnection();

  try {
    await conn.beginTransaction();

    for (const ules_id of ules_ids) {
      await conn.query(`
        INSERT INTO konyveles (vetites_id, user_id, ules_id, final_price)
        VALUES (?, ?, ?, ?)
      `, [vetites_id, req.user.user_id, ules_id, final_price]);
    }

    await conn.commit();
    res.json({ message: "Foglalás sikeres" });

  } catch (err) {
    await conn.rollback();
    res.status(400).json({ error: "A szék már foglalt" });
  } finally {
    conn.release();
  }
});

export default router;
