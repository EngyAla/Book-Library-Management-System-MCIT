# BookVerse - Book Library Management System

BookVerse is a production-quality, responsive personal book library management system built using **ASP.NET Core MVC 8** and **Entity Framework Core**. It showcases core MVC concepts, database context configuration, strongly-typed model validation, searching/filtering, and sequential database migrations with SQLite.

---

## 🚀 Key Features

*   **Full CRUD Operations**: Create, view details, edit, and delete books in a personal library collection.
*   **Sequential EF Core Migrations**: Demonstrates the workflow of evolving models using two sequential migrations:
    1.  `InitialCreate`: Defines the base model with `Title`, `Author`, `Category`, and `Price`.
    2.  `UpdateBookModel`: Evolves the model by adding `Language`, `Description`, `Pages`, `PublishDate`, and `CreatedAt` without breaking existing schemas.
*   **Automatic Seeding**: Seeds 12 books across 6 distinct categories (*Programming, Science, Business, History, Self Development, and Fiction*) upon database initialization.
*   **Strongly-Typed Form Validations**: Utilizes C# Data Annotations for server-side and client-side form validation (Title lengths, Price ranges, Page bounds).
*   **Case-Insensitive Searching**: Allows searching by Title, Author, or Category from the search bar.
*   **Premium Modern Interface**: Customized using CSS3, Google Fonts (Inter), Bootstrap Icons, rounded layouts, soft shadows, responsive grids, and subtle micro-animations.

---

## 🛠️ Technology Stack

*   **Backend**: ASP.NET Core 8.0 MVC (C#)
*   **ORM**: Entity Framework Core 8.0
*   **Database**: SQLite (No external installation required)
*   **Frontend**: Razor Views, HTML5, CSS3, Bootstrap 5, Bootstrap Icons, jQuery Validation

---

## 📂 Folder Structure

```text
BookVerse/
│
├── BookVerse.db                       # Generated SQLite database file
├── Controllers/
│   └── BooksController.cs             # Asynchronous actions for CRUD operations
│
├── Models/
│   ├── Book.cs                        # Strongly typed data annotations model
│   └── LibraryDbContext.cs            # Entity Framework database context
│
├── Data/
│   └── SeedData.cs                    # Automatically seeds database if empty
│
├── Migrations/                        # Generated EF Core migrations
│
├── Views/
│   ├── Books/
│   │   ├── Create.cshtml              # Create book form layout
│   │   ├── Delete.cshtml              # Delete warning layout
│   │   ├── Details.cshtml             # Card-based details viewer
│   │   ├── Edit.cshtml                # Preloaded edit form layout
│   │   └── Index.cshtml               # Grid table lists with filters and search
│   │
│   ├── Shared/
│   │   ├── _Layout.cshtml             # Main layout with sticky header/footer navigation
│   │   └── _ValidationScriptsPartial.cshtml # Clientside validation scripts
│   │
│   └── _ViewImports.cshtml            # Global using directives for views
│
├── wwwroot/
│   ├── css/
│   │   └── site.css                   # Custom global premium design rules
│   └── js/
│       └── site.js                    # Global JS scripts
│
├── Program.cs                         # Application entrypoint & dependency registration
├── appsettings.json                   # SQLite Connection string configuration
└── BookVerse.csproj                   # Project configuration file
```

---

## 📦 How to Apply Migrations

To apply the database migrations in sequence to simulate model updates, execute the following commands in your terminal from the project root:

1.  **Generate and apply the initial schema**:
    ```bash
    dotnet ef migrations add InitialCreate
    dotnet ef database update
    ```

2.  **Generate and apply the evolved schema (model update)**:
    ```bash
    dotnet ef migrations add UpdateBookModel
    dotnet ef database update
    ```

---

## 💻 How to Run

1.  **Restore dependencies**:
    ```bash
    dotnet restore
    ```
2.  **Verify the build**:
    ```bash
    dotnet build
    ```
3.  **Run the application**:
    ```bash
    dotnet watch run
    ```
    Open your browser and navigate to the local HTTPS/HTTP port printed in the console (usually `http://localhost:5000` or similar). Seeding will automatically run and verify connection with the SQLite database.

