# 🎬 Mozifoglaló API Dokumentáció

Ez a dokumentáció a backend API végpontjait tartalmazza, amelyek a mozi foglalási rendszer működéséhez szükségesek.

Base URL (fejlesztői környezetben):

```
http://localhost:3001
```

---

# 🔐 Auth végpontok

## Regisztráció

**POST** `/auth/register`

Új felhasználó regisztrálása.

### Request body

```json
{
  "email": "user@email.com",
  "password": "password123",
  "full_name": "Teszt Elek"
}
```

---

## Bejelentkezés

**POST** `/auth/login`

Felhasználó bejelentkezése.

### Request body

```json
{
  "email": "user@email.com",
  "password": "password123"
}
```

### Response (példa)

```json
{
  "token": "JWT_TOKEN"
}
```

---

# 🎬 Film végpontok

## Filmek listázása

**GET** `/filmek`

Az összes aktív film lekérése.

### Response példa

```json
[
  {
    "id": 1,
    "title": "Film neve",
    "genre": "Akció",
    "release_year": 2024
  }
]
```

---

## Film vetítések lekérése

**GET** `/vetites/:filmId`

Egy filmhez tartozó vetítések lekérése.

### Paraméter

| Paraméter | Leírás |
|-----------|--------|
| filmId | A film azonosítója |

---

## Foglalt ülések lekérése

**GET** `/vetites/:vetitesId/ulesek`

A kiválasztott vetítéshez tartozó foglalt ülések.

### Paraméter

| Paraméter | Leírás |
|-----------|--------|
| vetitesId | Vetítés azonosító |

---

# 🎟 Foglalás

## Ülés foglalása

**POST** `/foglalas`

Új foglalás létrehozása.

### Request body

```json
{
  "vetites_id": 1,
  "ules_id": 15,
  "final_price": 2500
}
```

---

# 👤 Profil

## Profil adatok lekérése

**GET** `/profil`

A bejelentkezett felhasználó profil adatai.

⚠️ Auth token szükséges.

---

# 🛠 Admin végpontok

## Új film létrehozása

**POST** `/admin/filmek`

### Request body

```json
{
  "title": "Film címe",
  "description": "Film leírása",
  "duration_minutes": 120,
  "release_year": 2024,
  "genre": "Sci-Fi"
}
```

---

## Film módosítása

**PUT** `/admin/filmek/:id`

Egy meglévő film adatainak módosítása.

### Paraméter

| Paraméter | Leírás |
|-----------|--------|
| id | Film azonosító |

---

## Film törlése (Soft Delete)

**DELETE** `/admin/filmek/:id`

A film törlése soft delete módszerrel történik:

```
active = 0
```

---

## Új vetítés létrehozása

**POST** `/admin/vetitesek`

### Request body

```json
{
  "film_id": 1,
  "terem_id": 2,
  "start_time": "2025-06-01 18:00:00",
  "end_time": "2025-06-01 20:00:00",
  "base_price": 2500
}
```

---

## Vetítés módosítása

**PUT** `/admin/vetitesek/:id`

Meglévő vetítés módosítása.

---

## Vetítés törlése

**DELETE** `/admin/vetitesek/:id`

Vetítés törlése az adatbázisból.

---

# 🔑 Autentikáció

Az admin és profil végpontokhoz **JWT token** szükséges.

Header példa:

```
Authorization: Bearer YOUR_JWT_TOKEN
```

---

# 🧰 Használt technológiák

- Node.js
- Express
- MySQL
- JWT Authentication
- bcrypt
