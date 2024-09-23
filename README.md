---

# Student CRUD API in ASP.NET Core Web API

This repository contains a simple **ASP.NET Core Web API** project that demonstrates CRUD (Create, Read, Update, Delete) operations for managing student records. The project is built using **C#** with **Entity Framework Core** and **SQL Server** as the database.

## Features

- **CRUD Operations**: Create, Read, Update, and Delete student data via a RESTful API.
- **Entity Framework Core**: Used for database access and management.
- **SQL Server**: Used as the relational database for storing student records.
- **Swagger UI**: Integrated for easy API testing and documentation.

## Endpoints

- **GET** `/api/student` - Retrieve all students.
- **GET** `/api/student/{id}` - Retrieve a student by ID.
- **POST** `/api/student` - Add a new student.
- **PUT** `/api/student/{id}` - Update an existing student.
- **DELETE** `/api/student/{id}` - Delete a student.

## Setup Instructions

### Prerequisites

- .NET 6 SDK or higher
- SQL Server (LocalDB or full SQL Server instance)
- Visual Studio or any .NET compatible IDE

### Running the Project

1. Clone the repository:

   ```bash
   git clone https://github.com/your-username/student-crud-api.git
   cd student-crud-api
   ```

2. Update the **appsettings.json** file with your SQL Server connection string:

   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=YOUR_SERVER;Database=StudentDb;Trusted_Connection=True;"
   }
   ```

3. Run database migrations to set up the database schema:

   ```bash
   dotnet ef migrations add InitialCreate
   dotnet ef database update
   ```

4. Run the application:

   ```bash
   dotnet run
   ```

5. Open your browser and navigate to `https://localhost:{port}/swagger` to explore and test the API using Swagger UI.

## Technologies Used

- **ASP.NET Core 6**
- **Entity Framework Core**
- **SQL Server**
- **Swagger UI**

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for more details.

---
