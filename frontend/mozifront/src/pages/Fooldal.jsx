import { Link } from "react-router-dom";

export default function Fooldal() {
  return (
    <div>
      <h1>🎬 Szaftos Mozi</h1>

      <p>Üdvözlünk a mozi foglalási rendszerben.</p>

      <div>
        <Link to="/filmek">Filmek megtekintése</Link>
      </div>

      <div>
        <Link to="/login">Bejelentkezés</Link>
      </div>
    </div>
  );
}