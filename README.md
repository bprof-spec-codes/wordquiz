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
Change the connection string in appsettings.json to match your database configuration.


The API should be up and running at https://localhost:5001. You can test the endpoints using a REST client like Postman or the built-in Swagger UI at https://localhost:5001/swagger.

API Documentation
API documentation is available through the Swagger UI, which can be accessed at https://localhost:5001/swagger after running the application.

Contributing
Feel free to submit issues or pull requests for bug fixes, new features, or improvements.

License
This project is licensed under the MIT License. See the LICENSE file for details.


 Game Features:
 
A fun and interactive word quiz game
Test your vocabulary and language skills
Learn new words and track your progress
Random word generation
Word statistics tracking
Topic selection for personalized gameplay


 Technology Stack :
 
 Backend
ASP.NET Core RESTful API
Entity Framework Core for database access
SQL Server or any other supported relational database
JWT tokens for authentication
SignalR for real-time communication

 Word Quiz API:
 
Backend service for the Word Quiz game
Handles user authentication, word and topic management, and game logic
Exposes RESTful endpoints for client applications

 User Authentication & Authorization :
 
Secure user registration and login
Role-based access control
JWT tokens for secure API access

 Word & Topic Management:
 
CRUD operations for words and topics
Retrieve random words based on player's statistics and selected topics

Word Statistics Tracking:

Monitor player's progress and performance
Update statistics after each game session
Encourage improvement and learning


Future Plans:

Multiplayer mode
Leaderboards and achievements
Integration with other language learning tools
Support for additional languages


## Difficulties

TODO
