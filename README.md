Full-Stack Student Management SystemThis is a modern, full-stack web application designed to manage student records. It provides a clean user interface for performing CRUD (Create, Read, Update, Delete) operations. This project was built to showcase proficiency in C#, ASP.NET Core, React, and SQL.(Optional: You can take a screenshot of your running application and upload it to a site like Imgur to include a preview here.)✨ FeaturesView All Students: Display a list of all students in a clean, sortable table.Add New Students: A user-friendly modal form for adding new student records.Edit Student Information: Update the details of any existing student.Delete Students: Remove student records from the database.Responsive UI: The user interface is designed to work seamlessly on both desktop and mobile devices.🛠️ Tech StackThis project is built using a modern technology stack, separated into a monorepo structure.Backend:Framework: ASP.NET Core Web API (.NET 8)Language: C#Database: MySQLORM: Entity Framework CoreAPI Testing: Swagger (OpenAPI)Frontend:Framework: React.js (with Next.js)UI Library: Material-UI (MUI)HTTP Client: AxiosPackage Manager: npm📋 PrerequisitesBefore you begin, ensure you have the following software installed on your machine:.NET 8 SDKNode.js (which includes npm)[suspicious link removed] or a tool like XAMPPA code editor like Visual Studio Code🚀 Getting StartedFollow these steps to get the project up and running on your local machine.1. Clone the Repositorygit clone <your-repository-url>
cd StudentManagementSystem
2. Database SetupMake sure your MySQL server is running.Connect to your MySQL instance and run the following SQL script to create the database and the students table:CREATE DATABASE IF NOT EXISTS student_db;

USE student_db;

CREATE TABLE IF NOT EXISTS students (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    Email VARCHAR(100) NOT NULL UNIQUE,
    DateOfBirth DATE NOT NULL
);
3. Backend ConfigurationNavigate to the backend directory:cd backend/StudentManagement.Api
Open the appsettings.json file.Update the DefaultConnection string with your MySQL username and password:"ConnectionStrings": {
  "DefaultConnection": "server=localhost;port=3306;database=student_db;user=your_mysql_user;password=your_mysql_password"
}
Restore the dependencies and run the backend server:dotnet restore
dotnet run
The API should now be running, typically on http://localhost:5267. You can verify this by navigating to http://localhost:5267/swagger.4. Frontend ConfigurationOpen a new terminal and navigate to the frontend directory:cd frontend
Install the required npm packages:npm install
Run the frontend development server:npm run dev
The React application will open in your browser at http://localhost:3000.You should now have the full application running and be able to interact with the student data.🌐 API EndpointsThe backend API provides the following endpoints, which are consumed by the React frontend.MethodEndpointDescriptionGET/api/studentsGet a list of all students.GET/api/students/{id}Get a single student by ID.POST/api/studentsCreate a new student.PUT/api/students/{id}Update an existing student.DELETE/api/students/{id}Delete a student by ID.