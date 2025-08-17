# Full-Stack Student Management System

This is a modern, full-stack web application designed to manage student records. It provides a clean user interface for performing CRUD (Create, Read, Update, Delete) operations. This project was built to showcase proficiency in C#, ASP.NET Core, React, and SQL.



---

## ✨ Features

* **View All Students:** Display a list of all students in a clean, sortable table.
* **Add New Students:** A user-friendly modal form for adding new student records.
* **Edit Student Information:** Update the details of any existing student.
* **Delete Students:** Remove student records from the database.
* **Responsive UI:** The user interface is designed to work seamlessly on both desktop and mobile devices.

---

## 🛠️ Tech Stack

This project is built using a modern technology stack, separated into a monorepo structure.

* **Backend:**
    * **Framework:** ASP.NET Core Web API (.NET 8)
    * **Language:** C#
    * **Database:** MySQL
    * **ORM:** Entity Framework Core
    * **API Testing:** Swagger (OpenAPI)
* **Frontend:**
    * **Framework:** React.js (with Next.js)
    * **UI Library:** Material-UI (MUI)
    * **HTTP Client:** Axios
    * **Package Manager:** npm

---

## 📋 Prerequisites

Before you begin, ensure you have the following software installed on your machine:

* [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
* [Node.js](https://nodejs.org/) (which includes npm)
* [MySQL Server](https://dev.mysql.com/downloads/mysql/) or a tool like [XAMPP](https://www.apachefriends.org/index.html)
* A code editor like [Visual Studio Code](https://code.visualstudio.com/)

---

## 🚀 Getting Started

Follow these steps to get the project up and running on your local machine.

### 1. Clone the Repository

```bash
git clone <your-repository-url>
cd StudentManagementSystem
```

### 2. Database Setup

1.  Make sure your MySQL server is running.
2.  Connect to your MySQL instance and run the following SQL script to create the database and the `students` table:

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

1.  Navigate to the backend directory:
    ```bash
    cd backend/StudentManagement.Api
    ```
2.  Open the `appsettings.json` file.
3.  Update the `DefaultConnection` string with your MySQL username and password:
    ```json
    "ConnectionStrings": {
      "DefaultConnection": "server=localhost;port=3306;database=student_db;user=your_mysql_user;password=your_mysql_password"
    }
    ```
4.  Restore the dependencies and run the backend server:
    ```bash
    dotnet restore
    dotnet run
    ```
    The API should now be running, typically on `http://localhost:5267`. You can verify this by navigating to `http://localhost:5267/swagger`.

### 4. Frontend Configuration

1.  Open a **new terminal** and navigate to the frontend directory:
    ```bash
    cd frontend
    ```
2.  Install the required npm packages:
    ```bash
    npm install
    ```
3.  Run the frontend development server:
    ```bash
    npm run dev
    ```
    The React application will open in your browser at `http://localhost:3000`.

You should now have the full application running and be able to interact with the student data.

---

## 🌐 API Endpoints

The backend API provides the following endpoints, which are consumed by the React frontend.

| Method   | Endpoint             | Description                  |
| :------- | :------------------- | :--------------------------- |
| `GET`    | `/api/students`      | Get a list of all students.  |
| `GET`    | `/api/students/{id}` | Get a single student by ID.  |
| `POST`   | `/api/students`      | Create a new student.        |
| `PUT`    | `/api/students/{id}` | Update an existing student.  |
| `DELETE` | `/api/students/{id}` | Delete a student by ID.      |

