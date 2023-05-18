# ASP.NET Core + Dapper Project

This is a repository for an ASP.NET Core project that utilizes Dapper as the ORM (Object-Relational Mapping) framework. It provides a basic structure for building web applications using ASP.NET Core and interacting with a database using Dapper.

## Prerequisites
To run this project on your local machine, you need to have the following software installed:

- [.NET Core SDK](https://dotnet.microsoft.com/download) 
- [Visual Studio](https://visualstudio.microsoft.com/downloads/) (latest version)

## Installation

1. Download the project repository as a ZIP file by clicking on the **Code** button in the repository and selecting **Download ZIP**.
2. Extract the downloaded ZIP file to your preferred location on your local machine.

## Setting up the Project

1. Open the extracted project folder using Visual Studio.
2. Locate the `appsettings.json` file in the project. It is located in the root directory.
3. Open the `appsettings.json` file in a text editor.
4. Find the **ConnectionStrings** section in the `appsettings.json` file.
5. Update the connection string value to match the settings for your database. Make sure to replace the placeholders (`<your-database>` and `<your-connection-string>`) with the appropriate values. For example:

```json
"ConnectionStrings": {
  "Conn": "Server=<your-database>;Database=YourDatabaseName;User Id=YourUsername;Password=YourPassword;"
}
```

6. Save the `appsettings.json` file.

## Running the Project

1. Make sure you have selected the correct project as the startup project. To do this, right-click on the project name in the Solution Explorer, select **Set as Startup Project**.
2. Press **F5** or click on the **Start** button in the Visual Studio toolbar to run the project.
3. The application will start and you can access it by navigating to the specified URL in your preferred web browser.

## Contributing

If you'd like to contribute to this project, please follow these steps:

1. Fork the repository on GitHub.
2. Clone your forked repository to your local machine.
3. Make the necessary changes and additions.
4. Commit your changes and push them to your forked repository.
5. Submit a pull request explaining your changes.

## Acknowledgments

- [ASP.NET Core](https://dotnet.microsoft.com/aspnet)
- [Dapper](https://dapper-tutorial.net/)
