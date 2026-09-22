
# Api_connection

A .NET Web API project for connecting to and consuming external APIs, built with ASP.NET Core.

## Overview

**Api_connection** is a backend service built using ASP.NET Core Web API. It provides a structured foundation for handling HTTP requests, managing configuration across environments, and exposing endpoints via controllers.

## Project Structure

```
Api_connection/
├── Controllers/                     # API controllers and route handlers
├── Properties/                      # Project launch settings
├── Api_connection.csproj            # Project file and dependencies
├── Api_connection.http              # Sample HTTP requests for testing endpoints
├── Program.cs                       # Application entry point and startup configuration
├── appsettings.json                 # Base application configuration
├── appsettings.Development.json     # Development-specific configuration
└── Api_connection.sln               # Solution file
```

## Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (version 6.0 or later recommended)
- An IDE such as Visual Studio, Visual Studio Code, or JetBrains Rider
- (Optional) [Postman](https://www.postman.com/) or the built-in `.http` file support in VS Code / Visual Studio for testing endpoints

## Getting Started

1. **Clone the repository**
   ```bash
   git clone https://github.com/Achumile01/Api_connection.git
   cd Api_connection
   ```

2. **Restore dependencies**
   ```bash
   dotnet restore
   ```

3. **Run the application**
   ```bash
   dotnet run
   ```

4. **Test the API**
   Use the included `Api_connection.http` file, or navigate to the Swagger UI (if enabled) at:
   ```
   https://localhost:<port>/swagger
   ```

## Configuration

Application settings are managed in:
- `appsettings.json` — default/shared configuration
- `appsettings.Development.json` — overrides used during local development

Update these files to configure connection strings, API keys, or other environment-specific values.

## Contributing

Contributions are welcome. Please open an issue or submit a pull request with a clear description of your changes.

