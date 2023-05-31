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

## API Endpoints


**Auth:**

- **POST /api/Auth** : Authenticates a user using their username and password.
  - Input: **{ "userName": "string", "password": "string" }**
  - Output: **200 Success**
- **POST /api/Auth/register** : Registers a new user using their email, player name, and password.
  - Input: **{ "email": "string", "playerName": "string", "password": "string" }**
  - Output: **200 Success**
- **POST /api/Auth/logout** : Logs out the current user.
  - Input: **No parameters**
  - Output: **200 Success**

**Data:**

- **POST /api/Data/import/topics** : Imports topics from a provided file. The file details are provided in the request body.
  - Input: **{ "ContentType": "string", "ContentDisposition": "string", "Headers": "object", "Length": "integer($int64)", "Name": "string", "FileName": "string" }**
  - Output: **200 Success**
- **GET /api/Data/export/topics** : Exports all topics.
  - Input: **No parameters**
  - Output: **200 Success**
- **POST /api/Data/import/words** : Imports words from a provided file. The file details are provided in the request body.
  - Input: **{ "ContentType": "string", "ContentDisposition": "string", "Headers": "object", "Length": "integer($int64)", "Name": "string", "FileName": "string" }**
  - Output: **200 Success**
- **GET /api/Data/export/{dataType}** : Exports data of a specific type (words, users, wordstatistics). The type of data to be exported is specified in the path parameter.
  - Input: **{ "dataType": "string" }**
  - Output: **200 Success**
- **GET /api/Data/user/wordstatistics** : Retrieves the word statistics for a specific user.
  - Input: **No parameters**
  - Output: **200 Success**

**Game:**

- **POST /api/Game/StartGameNoUserNoTopic** : Starts a game without a user and without a specific topic. The number of words for the game is specified in the query parameter.
  - Input: **{ "numberOfWords": "integer($int32)" }**
  - Output: **200 Success**
- **POST /api/Game/StartGameNoUserWithTopic** : Starts a game without a user but with a specific topic. The number of words for the game and the topics are specified in the query parameter and request body respectively.
  - Input: **{ "numberOfWords": "integer($int32)", "topics": ["string"] }**
  - Output: **200 Success**
- **POST /api/Game/StartGameWeighted** : Starts a weighted game, likely taking into account the user's previous performance. The number of words for the game and the topics are specified in the query parameter and request body respectively.
  - Input: **{ "numberOfWords": "integer($int32)", "topics": ["string"] }**
  - Output: **200 Success**
- **POST /api/Game/EndGame** : Ends a game session and updates word statistics. The original words and the user's guesses are provided in the request body.
  - Input: **{ "original": "string", "guess": "string" }**
  - Output: **200 Success**

**Player:**

- **GET /api/Player/all** : Retrieves all players.
- Input: **No parameters**
- Output: **200 Success**
- **GET /api/Player/{id}** : Retrieves a specific player by their ID. The player ID is specified in the path parameter.
  - Input: **{ "id": "string" }**
  - Output: **200 Success**
- **PUT /api/Player/{id}** : Updates a specific player's information. The player ID is specified in the path parameter and the updated player details are provided in the request body.
  - Input: **{ "id": "string", "userName": "string", "normalizedUserName": "string", "email": "string", "normalizedEmail": "string", "emailConfirmed": true, "passwordHash": "string", "securityStamp": "string", "concurrencyStamp": "string", "phoneNumber": "string", "phoneNumberConfirmed": true, "twoFactorEnabled": true, "lockoutEnd": "2023-05-31T06:47:58.225Z", "lockoutEnabled": true, "accessFailedCount": 0, "playerName": "string", "wordStatistics": ["string"] }**
  - Output: **200 Success**
- **DELETE /api/Player/{id}** : Deletes a specific player. The player ID is specified in the path parameter.
  - Input: **{ "id": "string" }**
  - Output: **200 Success**
- **GET /api/Player** : Retrieves the current player's information.
  - Input: **No parameters**
  - Output: **200 Success**

**Topic:**

- **GET /api/Topic** : Retrieves all topics.
  - Input: **No parameters**
  - Output: **200 Success**
- **POST /api/Topic** : Adds a new topic. The topic details are provided in the request body.
  - Input: **{ "id": "string", "title": "string", "description": "string" }**
  - Output: **200 Success**
- **GET /api/Topic/{id}** : Retrieves a specific topic by its ID. The topic ID is specified in the path parameter.
  - Input: **{ "id": "string" }**
  - Output: **200 Success**
- **PUT /api/Topic/{id}** : Updates a specific topic. The topic ID is specified in the path parameter and the updated topic details are provided in the request body.
  - Input: **{ "id": "string", "title": "string", "description": "string" }**
  - Output: **200 Success**
- **DELETE /api/Topic/{id}** : Deletes a specific topic. The topic ID is specified in the path parameter.
  - Input: **{ "id": "string" }**
  - Output: **200 Success**
- **GET /api/Topic/ExportTopics** : Exports all topics.
  - Input: **No parameters**
  - Output: **200 Success**

**Word:**

- **GET /api/Word/Random/{idRandom}** : Retrieves a random word. The ID is specified in the path parameter.
  - Input: **{ "idRandom": "integer($int32)" }**
  - Output: **200 Success**
- **GET /api/Word/RandomWithTopics/{idRandomWithTopic}** : Retrieves a random word from a specific topic. The ID and topics are specified in the path parameter and query parameter respectively.
  - Input: **{ "idRandomWithTopic": "integer($int32)", "mytopicstitle": ["string"] }**
  - Output: **200 Success**
- **POST //api/Word** : Adds a new word. The word details are provided in the request body.
  - Input: **{ "id": "string", "original": "string", "translation": "string", "topicId": "string" }**
  - Output: **200 Success**
- **PUT /api/Word/{id}** : Updates a specific word. The word ID is specified in the path parameter and the updated word details are provided in the request body.
  - Input: **{ "id": "string", "original": "string", "translation": "string", "topicId": "string" }**
  - Output: **200 Success**
- **DELETE /api/Word/{id}** : Deletes a specific word. The word ID is specified in the path parameter.
  - Input: **{ "id": "string" }**
  - Output: **200 Success**
- **POST /api/Word/ImportWords** : Imports words from a provided file. The word details are provided in the request body.
  - Input: **{ "id": "string", "original": "string", "translation": "string", "topicId": "string" }**
  - Output: **200 Success**

**WordStatistic:**

- **GET /api/WordStatistic** : Retrieves all word statistics.
  - Input: **No parameters**
  - Output: **200 Success**
- **POST /api/WordStatistic** : Adds a new word statistic. The word statistic details are provided in the request body.
  - Input: **{ "id": "string", "playerId": "string", "wordId": "string", "score": 0, "player": { "id": "string", "userName": "string", "normalizedUserName": "string", "email": "string", "normalizedEmail": "string", "emailConfirmed": true, "passwordHash": "string", "securityStamp": "string", "concurrencyStamp": "string", "phoneNumber": "string", "phoneNumberConfirmed": true, "twoFactorEnabled": true, "lockoutEnd": "2023-05-31T06:47:58.225Z", "lockoutEnabled": true, "accessFailedCount": 0, "playerName": "string", "wordStatistics": ["string"] }, "word": { "id": "string", "original": "string", "translation": "string", "topicId": "string" } }**
  - Output: **200 Success**
- **GET /api/WordStatistic/{id}** : Retrieves a specific word statistic by its ID. The word and ID are specified in the query parameter and path parameter respectively.
  - Input: **{ "word": "string", "id": "string" }**
  - Output: **200 Success**
- **PUT /api/WordStatistic/{id}** : Updates a specific word statistic. The word statistic ID is specified in the path parameter and the updated word statistic details are provided in the request body.
  - Input: **{ "id": "string", "playerId": "string", "wordId": "string", "score": 0, "player": { "id": "string", "userName": "string", "normalizedUserName": "string", "email": "string", "normalizedEmail": "string", "emailConfirmed": true, "passwordHash": "string", "securityStamp": "string", "concurrencyStamp": "string", "phoneNumber": "string", "phoneNumberConfirmed": true, "twoFactorEnabled": true, "lockoutEnd": "2023-05-31T06:47:58.225Z", "lockoutEnabled": true, "accessFailedCount": 0, "playerName": "string", "wordStatistics": ["string"] }, "word": { "id": "string", "original": "string", "translation": "string", "topicId": "string" } }**
  - Output: **200 Success**
- **DELETE /api/WordStatistic/{id}** : Deletes a specific word statistic. The word statistic ID is specified in the path parameter.
  - Input: **{ "id": "string" }**
  - Output: **200 Success**
- **DELETE /all** : Deletes all word statistics.
  - Input: **No parameters**
  - Output: **200 Success**
- **GET /api/WordStatistic/{idRandom}** : Retrieves a random word statistic. The player and ID are specified in the query parameter and path parameter respectively.
  - Input: `{ "idRandom": "integer($int32)", "player": "string"}`
  - Output: **200 Success**
  - **GET /api/WordStatistic/{idRandomWithTopic}** : Retrieves a random word statistic from a specific topic. The player, ID, and topics are specified in the query parameter, path parameter, and request body respectively.
  - Input: **{ "idRandomWithTopic": "integer($int32)", "player": "string", "topics": ["string"] }**
  - Output: **200 Success**

## Difficulties

TODO
