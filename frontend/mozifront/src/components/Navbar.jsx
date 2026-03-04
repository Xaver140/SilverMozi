import { Link } from "react-router-dom";
import SearchBar from "./SearchBar";

export default function Navbar({ search, setSearch, isAdmin }) {
  const logout = () => {
    localStorage.removeItem("token");
    window.location.href = "/";
  };

  return (
    <nav style={{
      display: "flex",
      justifyContent: "space-between",
      alignItems: "center",
      padding: "10px 20px",
      borderBottom: "1px solid gray"
    }}>

      <div style={{ display: "flex", gap: "20px", alignItems: "center" }}>
        <h2>🎬 Mozi</h2>

        <Link to="/">Főoldal</Link>
        <Link to="/filmek">Filmek</Link>
        <Link to="/profil">Profil</Link>

        {isAdmin && <Link to="/admin">Admin</Link>}
      </div>

      <div style={{ display: "flex", gap: "10px", alignItems: "center" }}>
        {search !== undefined && (
          <SearchBar search={search} setSearch={setSearch} />
        )}

        <button onClick={logout}>Kijelentkezés</button>
      </div>

    </nav>
  );
}