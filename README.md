# Full-Stack Student Management System

This is a full-stack web application designed to manage student records. It provides a clean user interface for performing CRUD (Create, Read, Update, Delete) operations. This project was built to showcase proficiency in C#, ASP.NET Core, and SQL.

---

## ✨ Features

- **View All Students:** Display a list of all students in a clean, sortable table.
- **Add New Students:** A user-friendly modal form for adding new student records.
- **Edit Student Information:** Update the details of any existing student.
- **Delete Students:** Remove student records from the database.
- **Responsive UI:** The user interface is designed to work seamlessly on both desktop and mobile devices.

---

## 🛠️ Tech Stack

This project is built using a modern technology stack, separated into a monorepo structure.

- **Backend:**
  - **Framework:** ASP.NET Core Web API (.NET 8)
  - **Language:** C#
  - **Database:** MySQL
  - **ORM:** Entity Framework Core
  - **API Testing:** Swagger (OpenAPI)
- **Frontend:**
  - **Stack:** Plain HTML, CSS, and JavaScript
  - **No build step, no dependencies** — just a single self-contained `index.html` file
  - **HTTP Client:** Native `fetch` API

---

## 📋 Prerequisites

Before you begin, ensure you have the following software installed on your machine:

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [MySQL Server](https://dev.mysql.com/downloads/mysql/) or a tool like [XAMPP](https://www.apachefriends.org/index.html)
- A code editor like [Visual Studio Code](https://code.visualstudio.com/)
- A modern web browser

---

## 🚀 Getting Started

Follow these steps to get the project up and running on your local machine.

### 1. Clone the Repository

```
git clone <your-repository-url>
cd StudentManagementSystem
```

### 2. Database Setup

1. Make sure your MySQL server is running.
2. Connect to your MySQL instance and run the following SQL script to create the database and the `students` table:

```sql
CREATE DATABASE IF NOT EXISTS student_db;

USE student_db;

CREATE TABLE IF NOT EXISTS students (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    Email VARCHAR(100) NOT NULL UNIQUE,
    DateOfBirth DATE NOT NULL
);
```

### 3. Backend Configuration

1. Navigate to the backend directory:

```
cd Backend/StudentManagement.Api
```

2. Open the `appsettings.json` file.
3. Update the `DefaultConnection` string with your MySQL username and password:

```json
"ConnectionStrings": {
  "DefaultConnection": "server=localhost;port=3306;database=student_db;user=your_mysql_user;password=your_mysql_password"
}
```

4. Restore the dependencies and run the backend server:

```
dotnet restore
dotnet run
```

The API should now be running, typically on `http://localhost:5267`. You can verify this by navigating to `http://localhost:5267/swagger`.

CORS is enabled on the API (`AllowAnyOrigin`) so the frontend can call it during local development, regardless of how it's served.

### 4. Frontend

The frontend is a single static file — `Frontend/index.html` — with no npm install, no build step, and no dependencies.

1. Make sure the backend API is running (step 3 above).
2. Open `Frontend/index.html` directly in your browser, **or** serve it with a lightweight local server (recommended, to avoid `file://` origin quirks):

```
cd Frontend
python -m http.server 5500
```

Then visit `http://localhost:5500`.

**Features:**
- Full CRUD — view, add, edit, and delete students via a table and modal forms
- Client-side search by name or email
- Connection status indicator with an editable API address (in case your backend isn't running on `http://localhost:5267`)
- Loading, empty, and error states

If you see CORS errors in the browser console, confirm the backend's `Program.cs` has CORS enabled and that `app.UseCors(...)` is called before `app.MapControllers()`.

You should now have the full application running and be able to interact with the student data.

---

## 🌐 API Endpoints

The backend API provides the following endpoints, consumed by the frontend.

| Method   | Endpoint              | Description                 |
| -------- | ---------------------- | --------------------------- |
| `GET`    | `/api/students`        | Get a list of all students. |
| `GET`    | `/api/students/{id}`   | Get a single student by ID. |
| `POST`   | `/api/students`        | Create a new student.       |
| `PUT`    | `/api/students/{id}`   | Update an existing student. |
| `DELETE` | `/api/students/{id}`   | Delete a student by ID.     |
