# Identity Email

Identity Email is an ASP.NET Core MVC project for building a secure, category-based messaging experience. The project is currently in its foundation phase and brings together ASP.NET Core Identity, Entity Framework Core, and SQL Server.

## Project status

The repository currently contains:

- an ASP.NET Core MVC application targeting .NET 10;
- ASP.NET Core Identity and Entity Framework Core dependencies;
- SQL Server provider and EF Core design-time tooling;
- the initial `Category` and `Message` domain entities;
- the default MVC routing and static asset pipeline.

Authentication, persistence, and messaging workflows are planned next and are not wired into the application yet.

## Tech stack

- .NET 10
- ASP.NET Core MVC
- ASP.NET Core Identity
- Entity Framework Core
- SQL Server
- Bootstrap and jQuery

## Getting started

### Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)
- SQL Server or SQL Server Express for the upcoming persistence layer

### Run locally

```bash
git clone https://github.com/poyrazavsever/identity-email-app.git
cd identity-email-app
dotnet restore
dotnet run --project IdentityEmailProject/IdentityEmailProject.csproj
```

The application prints its local HTTP and HTTPS addresses to the terminal when it starts.

## Solution structure

```text
.
|-- IdentityEmailProject.slnx
`-- IdentityEmailProject/
    |-- Controllers/
    |-- Entities/
    |-- Models/
    |-- Views/
    |-- wwwroot/
    |-- Program.cs
    `-- IdentityEmailProject.csproj
```

## Roadmap

- [ ] Configure the EF Core database context and SQL Server connection
- [ ] Add ASP.NET Core Identity registration, login, and authorization flows
- [ ] Create and apply the initial database migration
- [ ] Implement inbox, sent, draft, and category views
- [ ] Add message compose, read-state, and search workflows
- [ ] Add validation, tests, and CI checks

## Development notes

Keep credentials and connection strings out of source control. Use .NET user secrets or environment variables for local development.

```bash
dotnet user-secrets init --project IdentityEmailProject/IdentityEmailProject.csproj
```

## License

No license has been selected yet. All rights are reserved by the repository owner.
