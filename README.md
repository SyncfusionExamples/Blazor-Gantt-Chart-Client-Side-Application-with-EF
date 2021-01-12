# Blazor-Gantt-Chart-Client-Side-Application-with-EF
In the Gantt Chart, we can fetch data from the SQL database using the Entity Framework Data Model and the update the changes in CRUD action to the server by using DataManager support. To communicate with the remote data, we are using CustomAdaptor of DataManager property to call the server method.

## Project pre-requisites
Make sure that you have the compatible versions of Visual Studio Code and .NET Core SDK 3.1.2 in your machine before starting to work on this project.

## How to run this application?
To run this application, you need to first clone the `Blazor-Gantt-Chart-Client-Side-Application-with-EF` repository and then open the project or solution file in Visual Studio 2019. 

* Need to create SQL database.

* Need to install below packages for Entity Framework support.

```bash
Install-Package Microsoft.EntityFrameworkCore.Tools -Version 3.0.0

Install-Package Microsoft.EntityFrameworkCore.SqlServer -Version 3.0.0
```

* Need to create BDContext class.

```bash
Scaffold-DbContext “Server=ServerName;Database=DatabaseName;Integrated Security=True” Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
```

* Now, run the run the project Visual Studio and able to get the output in Browser