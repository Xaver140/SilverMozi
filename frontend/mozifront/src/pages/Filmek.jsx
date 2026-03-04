import { useEffect, useState } from "react";
import api from "../api/api";
import Navbar from "../components/Navbar";

export default function Filmek() {

  const [films, setFilms] = useState([]);
  const [vetitesek, setVetitesek] = useState({});
  const [selectedDate, setSelectedDate] = useState(new Date());

  // következő 7 nap egyenlőre, később lehetne egy datepicker
  const days = [];
  for (let i = 0; i < 7; i++) {
    const d = new Date();
    d.setDate(d.getDate() + i);
    days.push(d);
  }

  // filmek betöltése és vetítések betöltése minden filmhez
  const fetchVetitesek = async (filmId) => {
    const res = await api.get(`/vetites/${filmId}`);

    setVetitesek(prev => ({
      ...prev,
      [filmId]: res.data
    }));
  };

  const fetchFilms = async () => {
    const res = await api.get("/filmek");
    setFilms(res.data);

    res.data.forEach(film => {
      fetchVetitesek(film.film_id);
    });
  };

  useEffect(() => {
    fetchFilms();
  }, []);

  return (
    <div>

      <Navbar />

      <h1>Előadások</h1>

      {/* Nap választó */}
      <div style={{ display: "flex", gap: "10px", marginBottom: "20px" }}>
        {days.map((day, i) => (
          <button
            key={i}
            onClick={() => setSelectedDate(day)}
            style={{
              padding: "8px",
              background:
                day.toDateString() === selectedDate.toDateString()
                  ? "orange"
                  : "lightgray"
            }}
          >
            {day.toLocaleDateString("hu-HU", { weekday: "short" })}
            <br />
            {day.getDate()}
          </button>
        ))}
      </div>

      {/* Film lista */}
      {films.map(film => (

        <div
          key={film.film_id}
          style={{
            borderBottom: "1px solid gray",
            padding: "20px 0"
          }}
        >

          <h2>{film.title}</h2>

          <p>
            {film.genre} | {film.duration_minutes} perc
          </p>

          <div style={{ marginTop: "10px" }}>

            {vetitesek[film.film_id]
              ?.filter(v => {
                const vetitesDate = new Date(v.start_time);

                return (
                  vetitesDate.toDateString() ===
                  selectedDate.toDateString()
                );
              })
              .map(v => (

                <button
                  key={v.vetites_id}
                  style={{
                    marginRight: "10px",
                    padding: "8px 12px",
                    background: "orange",
                    border: "none",
                    borderRadius: "5px",
                    cursor: "pointer"
                  }}
                >
                  {new Date(v.start_time).toLocaleTimeString("hu-HU", {
                    hour: "2-digit",
                    minute: "2-digit"
                  })}
                </button>

              ))}

          </div>

        </div>

      ))}

    </div>
  );
}