To-Do List Full-Stack Project Documentation

1. Project Overview

This project is a full-stack To-Do List application built using ASP.NET Core for the backend and HTML, CSS, and JavaScript for the frontend. The application allows users to create, edit, and delete tasks. The backend replaces local storage by persisting tasks in a database, ensuring data consistency and scalability.

2. Technologies Used

Frontend: HTML, CSS (custom styling), JavaScript (vanilla)

Backend: ASP.NET Core MVC (C#)

Database: Entity Framework Core with a relational database

Tools & Frameworks:

Visual Studio

.NET Core SDK

Entity Framework Core


3. Frontend Description

HTML (Index.cshtml)

Uses Razor syntax to dynamically render task data.

Contains a form for adding and editing tasks.

Displays a list of tasks fetched from the backend.

CSS (style.css)

Responsive design using flexbox for layouts.

Custom fonts and color themes for a clean UI.

Styled buttons for adding, editing, and deleting tasks.

JavaScript (main.js)

Handles DOM manipulation for adding and editing tasks.

Adds event listeners for buttons and dynamically updates the UI.

Scrolls to the latest task after adding.

Dynamically changes button states between Add and Edit modes.

4. Backend Overview

Program.cs

Configures the web host and application startup.

Sets up middleware and routing for the application.

HomeController.cs

Handles HTTP requests (GET, POST, PUT, DELETE).

Actions:

Index(): Renders the home page with tasks.

AddTask(Task task): Adds a new task to the database.

EditTask(Task task): Updates existing tasks.

DeleteTask(int id): Deletes tasks by ID.

Task.cs (Model)

Represents the task entity with:

Id (int): Primary key

Title (string): Task description

ToDoDBContext.cs

Inherits from DbContext.

Configures the Tasks DbSet for database interactions.

5. Database Integration

Entity Framework Core handles all database operations.

DbContext manages database connections.

Code-first approach used for database creation.

Tasks are stored in a relational database with CRUD support.

6. API Endpoints

GET /: Retrieves all tasks and renders them.

POST /AddTask: Adds a new task.

POST /EditTask: Edits a task based on its ID.

POST /DeleteTask: Deletes a task by ID.

7. Setup and Installation

Prerequisites:

.NET Core SDK installed

Visual Studio or Visual Studio Code

SQL Server or any configured database provider

Steps:

Clone the repository.

Restore NuGet packages: dotnet restore.

Apply migrations:

dotnet ef migrations add InitialCreate
dotnet ef database update

Run the project:

dotnet run

Access the app at https://localhost:5001 or http://localhost:5000.

8. Running the Project

Use the Add New Task button to create tasks.

Edit button allows inline editing of tasks.

Delete button removes tasks from both UI and database.

9. Key Features & Future Improvements

Key Features:

Fully functional CRUD operations.

Responsive UI with custom styling.

Dynamic frontend interactions without page reloads.

Persistent storage using Entity Framework Core.

Future Improvements:

Implement user authentication and authorization.

Enhance UI/UX with animations and transitions.

Add due dates and task priorities.

Deploy the application to Azure App Services.

Add API endpoint testing with Postman or Swagger.

11. Conclusion

This project demonstrates core principles of full-stack web development using ASP.NET Core, including MVC architecture, database integration, and responsive frontend design. The application is scalable, with a clean codebase and structured design, making it ready for further enhancements like deployment and user management.

