# car-register

// dotnet new web -o minimal-api
//aceitar estenção

//dotnet watch run

//dotnet add package Microsoft.EntityFrameworkCore --version 7.0.14
//dotnet add package Microsoft.EntityFrameworkCore.Design --version 7.0.14
//dotnet add package Microsoft.EntityFrameworkCore.Tools --version 7.0.14
//dotnet add package Pomelo.EntityFrameworkCore.MySql --version 7.0.0

//dotnet ef migrations add AdministradorMigration
//dotnet ef database update

//dotnet ef migrations add SeedAdministrador
//dotnet ef database update

// appsetting.json
"ConnectionStrings": {
    "mysql": "Server=localhost;Database=minimal_api;Uid=myUser;Pwd=Password;"
}