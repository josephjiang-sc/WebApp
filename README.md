# ASP.NET MVC CRUD Mini Application

## Overview
This is a mini application demonstrating how to perform CRUD (Create, Read, Update, Delete) operations using ASP.NET MVC. The application is built with ASP.NET MVC framework and styled using Bootstrap. It utilizes a repository pattern for data storage and incorporates several best practices in MVC development.

### Structure
![image](https://github.com/josephjiang-sc/WebApp/assets/161648753/ec7bed51-b290-40e1-97ee-1f3007ee02bb)

## Features
- ASP.NET MVC structure
- Bootstrap for responsive design
- Customizable models with decorators and nullable fields
- Static file repository for data storage
- Simplified view management with `_ViewImports`, `_ViewStart`, and partial views
- Embedded JavaScript within views for enhanced functionality
- Routing and services implementation for CRUD operations

## Technologies Used
- ASP.NET MVC
- Bootstrap
- C#
- HTML/CSS
- JavaScript

## Getting Started

### Prerequisites
- .NET SDK installed on your machine
- Visual Studio or any C# compatible IDE

### Installation
1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/aspnet-mvc-crud-app.git
   ```
2. Navigate to the project directory:
   ```bash
   cd aspnet-mvc-crud-app
   ```
3. Open the project in Visual Studio:
   ```bash
   start aspnet-mvc-crud-app.sln
   ```
4. Restore the dependencies:
   ```bash
   dotnet restore
   ```

### Running the Application
1. Build the project:
   ```bash
   dotnet build
   ```
2. Run the application:
   ```bash
   dotnet run
   ```
3. Open your web browser and navigate to:
   ```
   http://localhost:5000
   ```

## Project Structure

### Models
- Models are decorated with attributes to handle validation and nullable fields.

### Views
- Views are organized with `_ViewImports` and `_ViewStart` for common imports and layout settings.
- Partial views are used to reuse code across different views.
- Static file repository is used for data storage.
- Example of embedding JavaScript in views:
  ```html
  <script>
      function showAlert(message) {
          alert(message);
      }
  </script>
  ```

### Controllers
- Controllers manage routing and service interactions for CRUD operations.

## Contributing
Feel free to submit issues or pull requests. Contributions are welcome!
