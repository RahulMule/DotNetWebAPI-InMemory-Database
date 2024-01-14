# DotNetWebAPI_InMemoryDatabase

This is a simple .NET Web API project for managing books, created to explore .NET 8 with Entity Framework Core using an in-memory database. The project follows the repository pattern to handle book-related operations.

## Table of Contents

- [Introduction](#introduction)
- [Features](#features)
- [Prerequisites](#prerequisites)
- [Getting Started](#getting-started)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)

## Introduction

The project is a RESTful Web API that provides endpoints to perform CRUD operations on books. It utilizes Entity Framework Core with an in-memory database for data storage.

## Features

- **Get All Books**: Retrieve a list of all books.
- **Add Book**: Add a new book to the database.

## Prerequisites

Before you begin, ensure you have the following prerequisites:

- .NET 8 SDK installed. [Download here](https://dotnet.microsoft.com/download)
- An Integrated Development Environment (IDE) like Visual Studio or Visual Studio Code.
- Git installed. [Download here](https://git-scm.com/downloads)

## Getting Started

1. Clone the repository:

    ```bash
    git clone https://github.com/RahulMule/DotNetWebAPI_InMemoryDatabase.git
    ```

2. Open the project in your preferred IDE.

3. Build the solution.

4. Run the application.

## Usage

The API provides the following endpoints:

- **GET /api/books**: Retrieve a list of all books.

- **POST /api/books**: Add a new book to the database.

    Example Request:
    ```json
    {
        "title": "The Great Gatsby",
        "description": "A novel by F. Scott Fitzgerald",
        "author": "F. Scott Fitzgerald",
        "price": 10.99
    }
    ```

    Example Response:
    ```json
    {
        "status": "OK"
    }
    ```

Feel free to explore and customize the code to suit your needs.

## Contributing

Contributions are welcome! Fork the repository, make your changes, and submit a pull request.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
