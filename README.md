# LibraryCoreApi

## Overview

**LibraryCoreApi** is an ASP.NET Core Web API designed for managing library resources, including authors, books, categories, and publishers. The API provides CRUD (Create, Read, Update, Delete) operations for these entities and supports various search and filter functionalities.

## Features

- **Author Management**: Add, update, delete, and retrieve authors.
- **Book Management**: Manage books, including searching, filtering by active/inactive status, and CRUD operations.
- **Category Management**: Add, update, delete, and retrieve categories.
- **Publisher Management**: Add, update, delete, and retrieve publishers.
- **CORS Support**: Configured to allow cross-origin requests.

## API Endpoints

### Authors

- **Get All Authors**: `GET /api/Author/GetAuthors`
- **Get Author by ID**: `GET /api/Author/GetAuthor/{id}`
- **Insert Author**: `POST /api/Author/InsertAuthor`
- **Update Author**: `PUT /api/Author/UpdateAuthor/{id}`
- **Delete Author**: `DELETE /api/Author/DeleteAuthor/{id}`

### Books

- **Get All Books**: `GET /api/Book/GetBooks`
- **Get Book by ID**: `GET /api/Book/GetBooks/{id}`
- **Search Books**: `GET /api/Book/SearchBook/{searchString}`
- **Get Active Books**: `GET /api/Book/GetActiveBook`
- **Get Inactive Books**: `GET /api/Book/GetInActiveBook`
- **Insert Book**: `POST /api/Book/InsertBook`
- **Update Book**: `PUT /api/Book/UpdateBook/{id}`
- **Delete Book**: `DELETE /api/Book/DeleteBooks/{id}`

### Categories

- **Get All Categories**: `GET /api/Category/GetCategories`
- **Get Category by ID**: `GET /api/Category/GetCategory/{id}`
- **Insert Category**: `POST /api/Category/InsertCategory`
- **Update Category**: `PUT /api/Category/UpdateCategory/{id}`
- **Delete Category**: `DELETE /api/Category/DeleteCategory/{id}`

### Publishers

- **Get All Publishers**: `GET /api/Publisher/GetPublishers`
- **Get Publisher by ID**: `GET /api/Publisher/GetPublisher/{id}`
- **Insert Publisher**: `POST /api/Publisher/InsertPublisher`
- **Update Publisher**: `PUT /api/Publisher/UpdatePublisher/{id}`
- **Delete Publisher**: `DELETE /api/Publisher/DeletePublisher/{id}`

## Setup Instructions

### Prerequisites

- **.NET 6.0 SDK** or later
- **SQL Server** or any other supported database
- **Visual Studio 2022** or later

### Installation Steps

1. **Clone the Repository**

   Clone the repository to your local machine:

   ```bash
   git clone https://github.com/yourusername/LibraryCoreApi.git
   ```

2. **Open the Project**

   Open the solution file (`LibraryCoreApi.sln`) in Visual Studio.

3. **Configure Database Connection**

   Update the connection string in `appsettings.json` to match your database configuration:

   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=your_server;Database=your_database;User Id=your_user;Password=your_password;"
   }
   ```

4. **Run Migrations**

   Apply any pending migrations to the database:

   ```bash
   dotnet ef database update
   ```

5. **Build and Run**

   Build the project and run the API using Visual Studio or the .NET CLI:

   ```bash
   dotnet run
   ```

## Usage

- **Access API Documentation**: Use tools like Postman or Swagger (if configured) to interact with the API endpoints.
- **Testing**: Ensure all endpoints work as expected by testing with different scenarios.

## Contribution

Contributions are welcome! Please fork the repository, make your changes, and submit a pull request.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## Contact

For questions, suggestions, or issues, please contact the project maintainer at [your.email@example.com](mailto:your.email@example.com).

---

Feel free to adjust any sections according to your project specifics and needs!
