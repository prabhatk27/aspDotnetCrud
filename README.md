ASP.NET Core Web App(MVC) using Entity Framework [Crud operation Steps]
----------------------------------------------------------------------------------------------------------

🔹 Method 1: Manual Setup (MVC + Entity Framework Core)

✅ Best when you want full control over architecture and learning depth.

1️⃣ Create a New Project

Open Visual Studio

Select ASP.NET Core Web App (Model-View-Controller)

Enter Project Name

Choose correct .NET version

Click Create

2️⃣ Install Required NuGet Packages

Right-click Project → Manage NuGet Packages

Install:

Microsoft.EntityFrameworkCore

Microsoft.EntityFrameworkCore.SqlServer

Microsoft.EntityFrameworkCore.Design

Microsoft.EntityFrameworkCore.Tools

Microsoft.VisualStudio.Web.CodeGeneration.Design

⚠️ Important: Package versions must match your .NET version.

3️⃣ Create Model Class

Right-click Models → Add → Class

Name it: Student.cs (example)

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}

4️⃣ Create Controller with Views

Right-click Controllers → Add → Controller

Select MVC Controller with views, using Entity Framework

Choose Model Class

Click ➕ Add DbContext

Name it: ApplicationDbContext

Click Add

5️⃣ Configure Database Connection

Open appsettings.json

"ConnectionStrings": {
  "DefaultConnection": 
  "Server=YOUR_SERVER_NAME;Database=YourDB;
   Trusted_Connection=True;
   TrustServerCertificate=True;"
}

6️⃣ Register DbContext

In Program.cs

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")));

7️⃣ Add Navigation Link (Optional)

Go to:
Views → Shared → _Layout.cshtml

Inside navbar:

<li class="nav-item">
    <a class="nav-link text-dark"
       asp-controller="Students"
       asp-action="Index">
       Student Management
    </a>
</li>

8️⃣ Apply Migration

Open:
Tools → NuGet Package Manager → Package Manager Console

Run:

Add-Migration Init
Update-Database

9️⃣ Run the Application 🎉

Press F5 or Run
Your CRUD pages are ready!
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
🔹 Method 2: Using Scaffolded Items (Faster Way)

✅ Recommended for beginners & rapid development

Steps

Create ASP.NET Core MVC Project

Add Model Class

Right-click Controllers → Add → New Scaffolded Item

Select MVC Controller with views, using Entity Framework

Choose Model

Click ➕ Add DbContext

Add Navigation Link (same as Method 1)

Run Migrations:

Add-Migration Init
Update-Database


Run the app 🚀

✨ Final Notes (Important for Exams & Interviews)

✔ Scaffolded approach = fast & beginner-friendly
✔ Manual approach = better architecture control
✔ Always match EF Core version with .NET version
✔ Migrations = bridge between Model & Database
