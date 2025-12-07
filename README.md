# ASP.NET Core Student CRUD Web API

This is a simple Web API built with **ASP.NET Core 7** and **Entity Framework Core** that performs full CRUD (Create, Read, Update, Delete) operations on a `Student` entity.  
The project uses **SQL Server** as the database provider.

---

## 🚀 Features

- Get all students  
- Get a single student by ID  
- Create a new student  
- Update student information  
- Delete a student  
- Connected with SQL Server using EF Core  
- Follows clean dependency injection pattern  
- Swagger UI enabled for API testing  

---

## 🛠️ Technologies Used

- ASP.NET Core Web API
- Entity Framework Core
- SQL Server
- Swagger / OpenAPI

---

## 📁 Project Structure

WebApiDemo/
│── Controllers/
│ └── StudentController.cs
│── Data/
│ └── ApplicationDbContext.cs
│── Models/
│ └── Student.cs
│── appsettings.json
└── Program.cs

---

## 🔧 Database Configuration

Update your connection string from **appsettings.json**:

"ConnectionStrings": {
"DefaultConnection": "Server=YOUR_SERVER;Database=StudentApiDb;Trusted_Connection=True;TrustServerCertificate=True"
}

---

## ▶️ How to Run the Project

1. Navigate to the project folder:
cd aspnetcore-student-crud-webapi

2. Restore all dependencies:
dotnet restore

3. Run the application:
dotnet run

4. Open Swagger UI in browser:
https://localhost:7000/swagger

---

## 📌 API Endpoints

### **GET** /api/student  
Returns all students  

### **GET** /api/student/{id}  
Returns a single student  

### **POST** /api/student  
Creates a new student  

### **PUT** /api/student/{id}  
Updates an existing student  

### **DELETE** /api/student/{id}  
Deletes a student  

---

## 🙌 Author
**Your Name**  
Beginner ASP.NET Developer practicing Web API with EF Core.

---

## 📄 License
This project is open-source and free to use.
