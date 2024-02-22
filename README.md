# asp-net-mvc-boiler-plate
* I am creating a basic project layout for this repository without using any N-Tier Architecture pattern

## Necessary Packages to install 
- I am using asp .net core version 6 and adding necessary packages based on these version specific
- I will using Code First Approach of Entity Framework for creating necessar migration steps
---
```
 01. Microsoft.EntityFrameworkCore.Design - Version 6.0.27
 02. Microsoft.EntityFrameworkCore.Tools  - Version 6.0.27
 03. Microsoft.EntityFrameworkCore.SqlServer - Version 6.0.27
```

---
* Connection String Format for appsettings.json file
```
"ConnectionStrings": {
    "DefaultConnection": "Server=server-name;Database=database-name;Trusted_Connection=True;TrustServerCertificate=True"
  }
```

* Then we need to setup ApplicationDbContext and program.cs file for properly setting up ApplicationDbContext
* After that we need to run 'update-database' command for creating the database instance to the server
* In the Creating Database part after modifying the 'ApplicationDbContext' we need to run following two command in the package manager console for displaying the applying the changes in the database
```
    add-migration AddEmployeeTableToDb
    update-database
```
- If no errors shows we will display the tables in the Database