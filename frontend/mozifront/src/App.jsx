import { BrowserRouter, Routes, Route } from "react-router-dom";
import Fooldal from "./pages/Fooldal";
import Login from "./pages/Login";
import Adminkezelo from "./pages/Admin";
import Userkezelo from "./pages/Filmek";
export default function App() {
  return (
    <BrowserRouter>
      <Routes>
        <Route path="/" element={<Fooldal />} />
        <Route path="/login" element={<Login />} />
        <Route path="/admin" element={<Adminkezelo />} />
        <Route path="/filmek" element={<Userkezelo />} />
      </Routes>
    </BrowserRouter>
  );
}