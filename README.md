# 📚 Library Management - ASP.NET MVC

Aplicación web desarrollada con **ASP.NET Core MVC (.NET 8 LTS)** para la gestión básica de una biblioteca.
Permite visualizar libros registrados, agregar nuevos libros y gestionar autores.

Este proyecto fue desarrollado como parte de una prueba técnica para la posición de **Desarrollador Junior .NET**.

---

## 🚀 Tecnologías Utilizadas

- ASP.NET Core MVC (.NET 8 LTS)
- C#
- Entity Framework Core
- SQL Server
- Tailwind CSS (para el diseño)
- Razor Views

> Se utiliza **Tailwind CSS** en lugar de Bootstrap debido a experiencia previa con este framework.

---

## 📌 Funcionalidades Principales

- 📖 Listado de libros registrados
- ✍️ Registro de nuevos autores
- ➕ Registro de nuevos libros asociados a un autor
- ✅ Validaciones básicas en formularios frontend y backend
- 🔗 Relación Autor – Libros (uno a muchos)

---

## 🗂️ Estructura del Proyecto

LibraryManagement
│
├── Controllers
│ ├── HomeController.cs
│ ├── BooksController.cs
│ └── AuthorsController.cs
│
├── Models
│ ├── Book.cs
│ └── Author.cs
│
├── Data
│ └── LibraryContext.cs
│
├── Views
│ ├── Home
│ ├── Books
│ └── Authors
│
├── wwwroot
│ └── css
│
└── README.md


---

## 🛠️ Configuración y Ejecución del Proyecto

### 1️. Requisitos Previos
- .NET SDK 8
- SQL Server
- Visual Studio / Visual Studio Code

### 2️. Clonar el repositorio
```bash
git clone <url-del-repositorio>

### 3. Configurar la base de datos
Actualizar la cadena de conexión en `appsettings.json`:
Server=.\SQLEXPRESS;
Database=LibraryManagementDb;
Trusted_Connection=True;


### 4. Crear la base de datos
Ejecutar el script SQL incluido en el repositorio.

### 5. Ejecutar la aplicación
dotnet run

Acceder desde el navegador a:

https://localhost:xxxx

Base de Datos:

 - Script SQL:

CREATE TABLE Authors (
    AuthorID INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL
);

CREATE TABLE Books (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    Title NVARCHAR(150) NOT NULL,
    AuthorID INT NOT NULL,
    CONSTRAINT FK_Books_Authors
        FOREIGN KEY (AuthorID) REFERENCES Authors(AuthorID)
);

Diagrama Entidad-Relación (ER):
┌───────────────┐        1        ┌───────────────┐
│    Authors    │─────────────────│     Books     │
├───────────────┤        N        ├───────────────┤
│ AuthorID (PK) │                 │ ID (PK)       │
│ Name          │                 │ Title         │
│               │                 │ AuthorID (FK) │
└───────────────┘                 └───────────────┘

- Un Autor puede tener muchos Libros
- Un Libro pertenece a un solo Autor

🖼️ Capturas de Pantalla
📍 Página Principal – Listado de Libros

Se muestra la lista de libros registrados junto con su autor.

Accesos directos para agregar libros y autores.

📍 Formulario – Agregar Autor

Formulario con validación para registrar un nuevo autor.

📍 Formulario – Agregar Libro

Formulario para registrar un libro.

Selección de autor desde un dropdown.

📌 Nota: Las capturas deben agregarse en la carpeta /screenshots del repositorio.

📎 Autor

Desarrollado por Daniel Alberto Vega Bejarano
Prueba técnica – Desarrollador Junior .NET