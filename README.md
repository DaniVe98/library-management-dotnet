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
- ➕ Gestión de Stock
- ➕ Módulo de Préstamos
- ✅ Validaciones básicas en formularios (Frontend y Backend)
    * La validación del formulario del lado del cliente se maneja a través de la vista compartida _ValidationScriptsPartial.

- 🔗 Relación Autor – Libros (uno a muchos)

---

## 🗂️ Estructura del Proyecto

LibraryManagement  
│  
├── Controllers  
│ ├── HomeController.cs  
│ ├── BooksController.cs  
│ └── AuthorsController.cs  
│ └── LoansController.cs  
│  
├── Models  
│ ├── Book.cs  
│ └── Author.cs  
│ └── Loan.cs  
│  
├── Data  
│ └── LibraryContext.cs  
│  
├── Views  
│ ├── Home  
│ ├── Books  
│ └── Authors  
│ └── Loans  
│  
├── wwwroot  
│ └── css  
│  
└── README.md  


---

## 🛠️ Configuración y Ejecución del Proyecto

### 1. Requisitos Previos
- .NET SDK 8
- SQL Server (Express o superior)
- SQL Server Management Studio (SSMS)
- Visual Studio o Visual Studio Code

### 2. Clonar el repositorio
```bash
git clone https://github.com/DaniVe98/library-management-dotnet.git
cd library-management-dotnet
```

### 3. Configurar la base de datos
Actualizar la cadena de conexión en el archivo appsettings.json:
```bash
"ConnectionStrings": {
    "DefaultConnection": "Server=.\\SQLEXPRESS;Database=LibraryManagementDb;Trusted_Connection=True;MultipleActiveResultSets=true;Encrypt=False;TrustServerCertificate=True"
  }
```


### 4. Crear la base de datos
El proyecto utiliza SQL Server y Entity Framework Core para la persistencia de datos.
Existen dos formas de crear la base de datos:

**Opción A – Usando el script SQL**  
1. Abrir SQL Server Management Studio (SSMS).
2. Conectarse a la instancia de SQL Server.
3. Ejecutar el archivo database.sql incluido en el repositorio.
4. Verificar que las tablas Authors y Books se hayan creado correctamente.

**Opción B – Usando Entity Framework (opcional)**  
Si se desea utilizar Entity Framework para crear la base de datos:

```bash
dotnet ef database update
```

### 5. Ejecutar la aplicación
```bash
dotnet run
```

Acceder desde el navegador a:
```bash
https://localhost:xxxx
```

---



## 🖼️ Capturas de Pantalla  

**📍 Página Principal – Listado de Libros**  
Se muestra la lista de libros registrados junto con su autor:  
<img width="1366" height="638" alt="image" src="https://github.com/user-attachments/assets/c916179c-e537-4f08-863f-93bdaeab8acf" />

Accesos directos para agregar libros y autores:  
<img width="349" height="71" alt="image" src="https://github.com/user-attachments/assets/55505b47-0261-4337-b3bb-2915f8efe3a3" />

**📍 Formulario – Agregar Autor**  
Formulario con validación para registrar un nuevo autor:  
<img width="1366" height="638" alt="image" src="https://github.com/user-attachments/assets/201b501a-3536-4f21-bb67-fd0d31a7a4fc" />

**📍 Formulario – Agregar Libro**  
Formulario para registrar un libro:  
<img width="1294" height="492" alt="image" src="https://github.com/user-attachments/assets/b1f6b1e5-e7a1-479c-a145-5fc93c50e866" />

Selección de autor desde un dropdown:  
<img width="1237" height="284" alt="image" src="https://github.com/user-attachments/assets/f0818070-c6ab-4152-bf85-e2017ab3ce91" />

**📍 Formulario – Prestar Libro**  
Formulario para prestar un libro: 
 * Campos requeridos, en donde no es posible seleccionar una fecha de devolución anterior a la fecha actual.
<img width="1294" height="385" alt="image" src="https://github.com/user-attachments/assets/82920dd6-d3a4-46ef-ba58-acb143fc9a4b" />


 ## - Diagrama Entidad-Relación (ER):  
<img width="591" height="230" alt="image" src="https://github.com/user-attachments/assets/9ce7edee-2342-4621-a089-c2896938b1b3" />

- Un Autor puede tener muchos Libros
- Un Libro pertenece a un solo Autor

**📎 Autor**  
Desarrollado por Daniel Alberto Vega Bejarano  
Prueba técnica – Desarrollador Junior .NET
