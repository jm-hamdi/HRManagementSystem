
# HR Management System

## Description
The HR Management System is a web-based application designed to manage employee data, attendance tracking, and payroll processing. The backend is built using .NET Core, C#, ASP.NET MVC, Entity Framework, and Dapper for database interactions with SQL Server. The project follows the MVC architecture and includes unit tests to ensure reliable functionality.

## Technologies Used
- .NET Core
- C#
- ASP.NET MVC
- Entity Framework Core
- Dapper (for optimized database queries)
- SQL Server
- xUnit (for unit testing)

## Architecture
The project follows the MVC (Model-View-Controller) architectural pattern:

- **Model**: Contains the data models that represent database entities such as Employee, Attendance, and Payroll. Entity Framework Core and Dapper are used for database interactions.
  
- **View**: Uses ASP.NET MVC's Razor views to present data to the user.
  
- **Controller**: Manages HTTP requests, communicates with models, and returns appropriate views or API responses.

### Data Layer:
- **Entity Framework Core**: Manages database migrations and simplifies CRUD operations.
- **Dapper**: Optimizes SQL queries for specific performance-critical operations.

### Unit Testing:
- **xUnit**: Used for unit testing the backend services and controllers.
- **Moq**: Utilized for mocking services and repositories in unit tests to ensure isolation of the system's components.

## Getting Started

### Prerequisites
- .NET SDK 6.0 or later
- SQL Server
- Visual Studio or VS Code

### Backend Setup
1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/HRManagementSystem.git
   ```

2. Navigate to the project directory and restore the packages:
   ```bash
   cd HRManagementSystem
   dotnet restore
   ```

3. Set up the database:
   - Ensure SQL Server is running.
   - Update the `appsettings.json` with your SQL Server connection string.
   - Run the following command to apply migrations and seed the database:
     ```bash
     dotnet ef database update
     ```

4. Run the backend server:
   ```bash
   dotnet run
   ```

### Unit Tests Setup
1. Navigate to the test project directory:
   ```bash
   cd HRManagementSystem.Tests
   ```

2. Run the unit tests:
   ```bash
   dotnet test
   ```

## Project Structure
The project follows a modular folder structure:

- **/Controllers**: Contains the MVC controllers that handle HTTP requests.
- **/Models**: Contains the entity models that represent database tables.
- **/Views**: Razor views that handle UI rendering.
- **/Data**: Contains the `DbContext` class and Dapper repositories for database operations.
- **/Services**: Business logic services (e.g., EmployeeService).
- **/Tests**: Unit tests for services and controllers using xUnit and Moq.
- **/wwwroot**: Static files for the web app (CSS, JS, images).

## Usage
After the backend is running, users can:
- View and manage employee data.
- Track attendance.
- Process payroll.

You can interact with the system through the web interface or API endpoints.

## Unit Testing

Unit tests are implemented using the **xUnit** testing framework, and **Moq** is used to mock dependencies to ensure isolation of the system's components.

To run unit tests:
```bash
dotnet test
```

Tests cover:
- Controller logic (e.g., EmployeeController)
- Business services (e.g., EmployeeService)

## Contributing
Contributions are welcome! Feel free to submit a pull request or open an issue.

## License
This project is licensed under the MIT License.
```

