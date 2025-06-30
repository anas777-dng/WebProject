# UniVerse Events - Event Management System

A comprehensive event management system built with ASP.NET Core, designed to help manage student events, registrations, and feedback.

## Architecture

This project follows Clean Architecture principles with the following layers:

- **Domain Layer** (`UniVerseEvents.Domain`): Contains core entities and business logic
- **Application Layer** (`UniVerseEvents.Application`): Contains business logic, DTOs, and service interfaces
- **Infrastructure Layer** (`UniVerseEvents.Infrastructure`): Contains data access, repositories, and external services
- **API Layer** (`StudentEventManagement.API`): Contains controllers and API endpoints

## Features

- **Event Management**: Create, read, update, and delete events
- **Registration System**: Allow students to register for events
- **Feedback System**: Collect and manage event feedback
- **RESTful API**: Clean API endpoints for all operations

## Technologies Used

- **Framework**: ASP.NET Core 9.0
- **Database**: Entity Framework Core with SQL Server
- **Architecture**: Clean Architecture / Onion Architecture
- **ORM**: Entity Framework Core
- **API Documentation**: Built-in Swagger/OpenAPI

## Project Structure

```
EventManagementSystem/
├── StudentEventManagement.API/          # Web API layer
│   ├── Controllers/                     # API controllers
│   ├── Properties/                      # Launch settings
│   └── wwwroot/                        # Static files
├── StudentEventManagement.Application/  # Application layer
│   ├── DTOs/                           # Data Transfer Objects
│   ├── Interfaces/                     # Service interfaces
│   ├── Mappings/                       # AutoMapper profiles
│   └── Services/                       # Service implementations
├── StudentEventManagement.Domain/       # Domain layer
│   └── Entities/                       # Domain entities
└── StudentEventManagement.Infrastructure/ # Infrastructure layer
    ├── Data/                           # Database context
    ├── Migrations/                     # EF Core migrations
    └── Repositories/                   # Repository implementations
```

## Getting Started

### Prerequisites

- .NET 9.0 SDK
- SQL Server (LocalDB or full instance)
- Visual Studio 2022 or Visual Studio Code

### Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/anas777-dng/WebProject.git
   cd WebProject
   ```

2. Restore NuGet packages:
   ```bash
   dotnet restore
   ```

3. Update the database connection string in `appsettings.json` and `appsettings.Development.json`

4. Run database migrations:
   ```bash
   dotnet ef database update --project StudentEventManagement.Infrastructure --startup-project StudentEventManagement.API
   ```

5. Run the application:
   ```bash
   dotnet run --project StudentEventManagement.API
   ```

The API will be available at `https://localhost:7xxx` and `http://localhost:5xxx`.

## API Endpoints

### Events
- `GET /api/events` - Get all events
- `GET /api/events/{id}` - Get specific event
- `POST /api/events` - Create new event
- `PUT /api/events/{id}` - Update event
- `DELETE /api/events/{id}` - Delete event

### Registrations
- `GET /api/registrations` - Get all registrations
- `GET /api/registrations/{id}` - Get specific registration
- `POST /api/registrations` - Create new registration
- `PUT /api/registrations/{id}` - Update registration
- `DELETE /api/registrations/{id}` - Delete registration

### Feedback
- `GET /api/feedback` - Get all feedback
- `GET /api/feedback/{id}` - Get specific feedback
- `POST /api/feedback` - Create new feedback
- `PUT /api/feedback/{id}` - Update feedback
- `DELETE /api/feedback/{id}` - Delete feedback

## Database Schema

### Entities

- **Event**: Represents an event with details like title, description, date, location
- **Student**: Represents a student who can register for events
- **Registration**: Links students to events they've registered for
- **Feedback**: Contains feedback from students about events

## Contributing

1. Fork the repository
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Contact

Muhammad Anas - [@anas777-dng](https://github.com/anas777-dng) - muhammadanasevans@gmail.com

Project Link: [https://github.com/anas777-dng/WebProject](https://github.com/anas777-dng/WebProject)
