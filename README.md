# Blazor Gantt Chart Client-Side Application with EF

This repository contains a sample Blazor client-side application that demonstrates how to integrate the Syncfusion Blazor Gantt Chart with a SQL database using the Entity Framework Data Model. The sample highlights server communication for data operations while maintaining a responsive client-side experience.

## Project overview

The Blazor Gantt Chart in this application retrieves task data from a SQL database through Entity Framework. Data operations such as create, update, and delete are processed on the server by using DataManager support. A CustomAdaptor is configured to handle communication between the Gantt Chart component and server-side methods, ensuring that changes made in the Gantt Chart interface are persisted to the database.

This approach enables centralized data handling while allowing the client-side application to reflect real-time updates from the data source. The sample focuses on demonstrating data binding, CRUD synchronization, and adaptor-based server interaction.

## Key features

- Client-side Blazor Gantt Chart integration
- Data retrieval from a SQL database using Entity Framework
- CRUD operations processed through DataManager
- CustomAdaptor implementation for server communication
- Consistent synchronization between client and server data

## Prerequisites

- Visual Studio 2026
- .NET SDK compatible with Blazor
- SQL Server or a compatible SQL database
- Syncfusion Blazor Gantt NuGet package

## How to Run the Project

1. Clone or checkout this repository to a local folder.
2. Open the solution file in Visual Studio 2026.
3. Rebuild the solution to restore required NuGet packages.
4. Update the database connection string in the project configuration.
5. Ensure the database is accessible and matches the Entity Framework model.
6. Run the application and verify data loading and CRUD operations in the Gantt Chart.