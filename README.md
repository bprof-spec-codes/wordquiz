# Word Quiz

## Team

| Name          | Role in group |
| ------------- | ------------- |
| Török Tamás   | Frontend      |
| Kusztos Dávid | Backend       |
| Budai Dávid   | Backend       |
| Bognár Bence  | Teamleader    |

## User manual

Features
User authentication and authorization using JWT tokens
CRUD operations for words, word statistics, and topics
Fetch random words based on player's statistics and selected topics
SignalR integration for real-time communication

Prerequisites
.NET SDK 6.0 or later
Visual Studio 2022 or Visual Studio Code with C# extension
SQL Server or any other supported relational database

Getting Started
Clone the repository:
bash
Copy code
git clone https://github.com/yourusername/WordQuizAPI.git
Change the connection string in appsettings.json to match your database configuration:
json

{
  "ConnectionStrings": {
    "DefaultConnection": "Server=YourServer;Database=YourDatabase;User Id=YourUser;Password=YourPassword;"
  }
}

In a terminal or command prompt, navigate to the project folder and run the following command to apply database migrations:
sql
Copy code
dotnet ef database update
Open the project in Visual Studio or Visual Studio Code and run the application.

The API should be up and running at https://localhost:5001. You can test the endpoints using a REST client like Postman or the built-in Swagger UI at https://localhost:5001/swagger.

API Documentation
API documentation is available through the Swagger UI, which can be accessed at https://localhost:5001/swagger after running the application.

Contributing
Feel free to submit issues or pull requests for bug fixes, new features, or improvements.

License
This project is licensed under the MIT License. See the LICENSE file for details.

## Difficulties

TODO
