# Blazor Gantt Chart Client-Side Application with EF

This repository contains a sample Blazor client-side application that demonstrates how to integrate the Syncfusion Blazor Gantt Chart with a SQL database using the Entity Framework Data Model. The sample highlights server communication for data operations while maintaining a responsive client-side experience.

## Project overview

In this sample, the Blazor Gantt Chart retrieves and persists task data through a server‑side API backed by Entity Framework. Although the Gantt Chart runs in a client‑side Blazor application, all data operations such as create, update, and delete—are processed on the server.

The Gantt Chart communicates with the server using the SfDataManager and a URL adaptor, which routes data requests to ASP.NET Core controller endpoints. This ensures that changes made in the Gantt Chart UI are reliably persisted to the database and reflected back in the client.

This architecture is suitable for applications that require centralized data management, database integrity, and scalable server‑side processing, while still providing a rich client‑side experience.

## Key features

- Client-side Blazor Gantt Chart integration
- Data retrieval from a SQL database using Entity Framework
- CRUD operations processed through DataManager
- CustomAdaptor implementation for server communication
- Consistent synchronization between client and server data

## Prerequisites

- Visual Studio 2022 (or later)
- .NET SDK 8.0 or later
- ASP.NET and Blazor workloads installed in Visual Studio
- SQL Server or a compatible SQL database
- Syncfusion Blazor Gantt NuGet package
- A valid Syncfusion license (Community or Trial)

## How to run the project

- Clone or download this repository to your local system.
- Open the project file (.csproj) in Visual Studio 2022 or later.
- Restore the required NuGet packages.
- Update the database connection string in the server project - configuration.
- Ensure the database is accessible and matches the Entity Framework model.
- Run the server project.
- Run the client application.
- Verify that Gantt data loads correctly and that CRUD operations are persisted in the database.

## Reference

For additional details, refer to the documentation:  
https://blazor.syncfusion.com/documentation/gantt-chart/connecting-to-adaptors/url-adaptor

## Syncfusion License

This sample uses the Syncfusion Blazor components, which require a valid Syncfusion license.

- Community License: https://www.syncfusion.com/products/communitylicense
- Trial License: https://www.syncfusion.com/account/manage-trials/start-trials

Ensure the license key is registered before running the application.