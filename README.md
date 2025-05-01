# VideoGame API

A clean-architecture ASP.NET Core Web API project to manage video games — providing basic CRUD operations through a structured, testable, and scalable codebase.

---


---

## 🏗 Clean Architecture Overview

**API Layer** → **Application Layer** → **Infrastructure Layer** → **Domain Layer** 

Decoupled, scalable, and testable architecture ensuring clean code practices.

---

## 📚 API Endpoints

| Method | Endpoint               | Description               |
|:--------|:------------------------|:---------------------------|
| GET    | `/api/videogame/{id}`  | Get a video game by ID    |
| GET    | `/api/videogame`       | Get all video games       |
| POST   | `/api/videogame`       | Add a new video game      |
| PUT    | `/api/videogame/{id}`  | Update an existing game   |
| DELETE | `/api/videogame/{id}`  | Delete a game by ID       |

---

## ⚙️ Technologies Used

- ASP.NET Core Web API
- Entity Framework Core
- FluentAssertions
- Moq
- NUnit
- Scalar.AspNetCore (for OpenAPI)

---

