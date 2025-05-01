# Hotel Oazis – Desktop Management System

A Windows Forms desktop application for managing hotel operations at Hotel "Oazis". Built as a diploma project by Dimitar Stoyanov Tashkov at PMG "Yane Sandanski".

## Features

- **User Roles**: Administrator & Client
- **Authentication**: Login, Registration, Profile Management
- **Room Management**: Add, edit, delete, view rooms
- **Service Management**: Manage hotel services
- **Reservations**: Book, cancel, view personal bookings
- **Review System**: Write, edit, delete, and moderate reviews
- **Admin Panel**: Manage users, approve content, adjust pricing
- **Multilingual Support**: Bulgarian & English

## Tech Stack

- **Frontend**: C# with WinForms
- **Backend**: .NET Framework
- **Database**: Microsoft SQL Server
- **ORM**: Entity Framework
- **Data Access**: LINQ

## Database Structure

- `Users`, `Roles`, `UsersRoles`
- `Rooms`, `Reservations`, `Services`, `Reviews`

Relationships:
- Users ↔ Roles (many-to-many)
- Users → Reservations, Reviews (one-to-many)
- Rooms → Reservations (one-to-many)

## Usage

1. Clone the repo:
   ```bash
   git clone https://github.com/yourusername/hotel-oazis.git
