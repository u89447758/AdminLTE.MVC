# ASP.NET Core MVC with AdminLTE Integration

This project is a demonstration of how to integrate the popular **AdminLTE v3.2.0** dashboard template into an **ASP.NET Core 8.0 MVC** application. It includes a fully styled user authentication system using ASP.NET Core Identity.

This implementation is based on the detailed tutorial by [codewithmukesh](https://codewithmukesh.com/blog/integrating-adminlte-with-aspnet-core/), updated to work with the latest .NET standards.

## ✨ Final Look

<img width="1920" height="1219" alt="image" src="https://github.com/user-attachments/assets/d9e6d683-59ef-4638-a3d4-4980357638f2" />

---

## 🚀 Features

*   **AdminLTE 3.2.0 Integration**: A clean, responsive, and modern dashboard UI.
*   **ASP.NET Core 8.0 MVC**: Built on the latest long-term support version of .NET.
*   **ASP.NET Core Identity**: Full user authentication system (Register, Login, Logout).
*   **Styled Identity Pages**: The default login and registration pages are restyled to match the AdminLTE theme.
*   **Dynamic Layout**:
    *   Uses partial views for a clean and maintainable layout structure (`_Layout`, `_TopNavigation`, `_MainNavigation`, etc.).
    *   The user interface conditionally renders elements based on authentication status.
*   **Secure by Default**: Implements a global authorization policy requiring users to be logged in for all pages, with explicit exceptions for public pages (Home, Login, Register).
*   **Full Dashboard**: Includes the complete Dashboard v1 from AdminLTE with interactive charts and widgets.
*   **Dynamic Sidebar**: Navigation menu that highlights the currently active page.

---

## 🛠️ Tech Stack

*   **Framework**: ASP.NET Core 8.0
*   **UI Template**: [AdminLTE v3.2.0](https://adminlte.io/)
*   **CSS Framework**: Bootstrap 4 (as part of AdminLTE)
*   **Database**: Entity Framework Core with SQL Server (using LocalDB by default)
*   **Authentication**: ASP.NET Core Identity
*   **JavaScript Plugins**: Chart.js, JQVMap, jQuery

---

## 🏁 Getting Started

Follow these instructions to get a copy of the project up and running on your local machine.

### Prerequisites

*   [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
*   [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) with the "ASP.NET and web development" workload installed.
*   A SQL Server instance (SQL Server Express or the LocalDB version included with Visual Studio is sufficient).

### Installation

1.  **Clone the repository**
    ```bash
    git clone https://github.com/u89447758/AdminLTE.MVC.git
    cd AdminLTE.MVC
    ```

2.  **Open the solution**
    *   Open the `AdminLTE.MVC.sln` file in Visual Studio.

3.  **Update the database connection string**
    *   Open the `appsettings.json` file.
    *   Ensure the `DefaultConnection` string points to your SQL Server instance. The default configuration for SQL LocalDB should work out-of-the-box with Visual Studio.

4.  **Apply Entity Framework Migrations**
    *   This will create the database and all the necessary tables for user authentication.
    *   In Visual Studio, go to **Tools -> NuGet Package Manager -> Package Manager Console**.
    *   Run the following command:
        ```powershell
        Update-Database
        ```

5.  **Run the application**
    *   Press `F5` or click the green play button in Visual Studio to build and run the project.
    *   Your browser should open to the home page, displaying the full dashboard.

---

## 📂 Project Structure

*   `/wwwroot/`: Contains all static assets, including the AdminLTE `css`, `js`, `img`, and `plugins` folders.
*   `/Views/Shared/AdminLTE/`: Contains the partial views that make up the AdminLTE layout.
*   `/Views/Home/Index.cshtml`: Contains the HTML content for the main dashboard page.
*   `/Areas/Identity/Pages/Account/`: Contains the customized `Login.cshtml` and `Register.cshtml` pages.
*   `/Helpers/`: Contains the C# helper class for dynamic navigation.
*   `Program.cs`: Contains the application's service configuration, including the global authorization policy.

---

## 🙏 Acknowledgements

*   **AdminLTE Team** for creating an amazing open-source dashboard template.
*   **Mukesh Murugan** for the excellent and detailed original tutorial at [codewithmukesh.com](https://codewithmukesh.com/blog/integrating-adminlte-with-aspnet-core/).

---

## 📜 License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.
