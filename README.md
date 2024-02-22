# asp-net-mvc-boiler-plate

## Overview
This project is a basic ASP.NET Core web application that demonstrates how to use Entity Framework Core with `Code First approach` to interact with a SQL Server database.
## Prerequisite
Before running the application, ensure you have the following installed:
- .NET 6 SDK
- SQL Server (or SQL Server Express) installed and running

## Getting Started
01. Clone the repository to your local machine.
02. Open the solution in Visual Studio 
03. Open the `appsettings.json` file and replace `server-name` and `database-name` in the `DefaultConnection` connection string with your actual server and database name
---
```
"ConnectionStrings": {
    "DefaultConnection": "Server=your-server-name;Database=your-database-name;Trusted_Connection=True;TrustServerCertificate=True"
}
```
---

## Install Necessary Packages  
- I am using asp .net core version 6 and adding necessary packages based on these version specific

---
```
 01. Microsoft.EntityFrameworkCore.Design - Version 6.0.27
 02. Microsoft.EntityFrameworkCore.Tools  - Version 6.0.27
 03. Microsoft.EntityFrameworkCore.SqlServer - Version 6.0.27
```

---

## Setting Up ApplicationDbContext
01. Create a new Folder name `Data`
02. Create a new class `ApplicationDbContext.cs` in that Data folder 

---
```
using Microsoft.EntityFrameworkCore;

namespace WebApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Add DbSet properties for your entities here
    }
}

```
---
01. Update the `Program.cs` to configure `ApplicationDbContext`
---
```
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))) ;
```
---
## Update Database
To create the database instance on the server, run the following commands in the Package Manager Console:
---
```
add-migration suitableMigrationName
update-database
```
---
## Seeding Database
If you need to seed data into the database, modify the `ApplicationDbContext` class and override the `OnModelCreating` method to define seeding logic using the `ModelBuilder` API. After making changes, run the migration and database update commands again.

## Additional Notes
- Ensure you have the necessary permissions to create databases on the target server.
- Consider handling database migrations carefully in production environments to avoid data loss or downtime.
---
This README file provides a step-by-step guide for setting up and using Entity Framework Core in your ASP.NET Core project, along with additional notes and considerations. Feel free to customize it further based on your project's specific requirements.
`Thanks`