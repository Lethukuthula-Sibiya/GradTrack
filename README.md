# GradTrack

GradTrack is a personal web application developed to help students and graduates manage graduate programmes, internships and bursary applications in one place.

The project is inspired by my own experience applying for multiple opportunities and wanting a better way to keep track of deadlines, application statuses and important notes.

This project is being actively developed as part of my software engineering portfolio while completing my BSc Honours in Computer Science at the University of Pretoria.

---

## Features

### Completed

- [x] Dashboard analytics
- [x] Opportunity CRUD
- [x] SQL Server integration
- [x] Search
- [x] Status filtering
- [x] Deadline monitoring
- [x] Overdue tracking
- [x] Status badges
- [x] Responsive Bootstrap UI

### Planned

- [ ] Opportunity sorting
- [ ] Priority levels
- [ ] Interview scheduling
- [ ] Company website links
- [ ] Authentication
- [ ] Azure deployment

---

## Technologies Used

- C#
- ASP.NET Core MVC (.NET 8)
- Entity Framework Core
- SQL Server
- Bootstrap 5
- Git
- GitHub

---

## Project Structure

GradTrack follows the ASP.NET Core MVC architecture.

```
Controllers/
Models/
Views/
ViewModels/
Data/
Migrations/
wwwroot/
```

---

## Future Improvements

Some planned enhancements include:

- Opportunity sorting
- Interview scheduling
- Company website links
- Application URL tracking
- Priority levels
- Dashboard improvements
- Authentication
- Azure deployment

---

## Screenshots

*(Screenshots will be added as development progresses.)*

---

## Getting Started

### Prerequisites

- .NET 8 SDK
- SQL Server Express
- SQL Server Management Studio (optional)

### Clone the repository

```bash
git clone https://github.com/YourUsername/GradTrack.git
```

### Run the project

```bash
dotnet restore

dotnet ef database update

dotnet run
```

