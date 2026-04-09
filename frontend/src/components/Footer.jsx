export default function Footer() {
  return (
    <footer style={{
      background: "#111",
      color: "white",
      padding: "15px",
      textAlign: "center",
      borderTop: "1px solid #333"
    }}>
      Minden jog fenntartva © {new Date().getFullYear()}
    </footer>
  );
}