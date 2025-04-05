# Library Management System – Blazor Version

This repository is part of a multi-platform Library Management System built in three different .NET frameworks:
	•	WPF – A desktop application using MVVM and a local SQL database.
	•	Blazor (this repository) – Provides a REST API and a web front end.
	•	.NET MAUI – A mobile version that consumes the Blazor REST API.

All three versions share the same goal: managing books, students, and borrowing/return operations in a library. They differ in their user interface layer and some architectural details.

> Why multiple versions?
These projects were created during my apprenticeship to demonstrate how the same core functionality can be adapted for desktop (WPF), web (Blazor), and mobile (.NET MAUI) platforms.

## Table of Contents
	1.	Overview
	2.	Core Features
	3.	Installation and Usage
	•	Database Setup
	•	Build and Run

## Overview

The Blazor version of the Library Management System provides:
	•	Web UI built with Blazor (Server or WebAssembly).
	•	REST API endpoints (if separating your front end from your backend).
	•	Entity Framework Core for data access to the same SQL database used by the WPF version.

Highlights
	•	Responsive Web Front End: Access the library management system via any modern browser.
	•	Separation of Concerns: Blazor pages and components connect to your data layer through a repository or direct EF Core usage.
	•	Shared Database: Optionally share the same SQL database used by the WPF and .NET MAUI versions.

This web application allows librarians or administrators to:
	•	Manage Books: Add, edit, and delete book records.
	•	Manage Students: Add, edit, and delete student records.
	•	Track Borrowing/Returning: Keep a log of which students borrowed which books, and track when they are returned.
	•	(Optional) Statistics: View analytics (e.g., top borrowed books).
	•	(Optional) User Management/Authentication: If implemented, handle user accounts for different roles (e.g., admin, guest).

## Core Features

	1.	Add/Edit/Delete Books: Perform CRUD operations on book data (title, author, ISBN, etc.).
	2.	Add/Edit/Delete Students: Manage library members (names, IDs, etc.).
	3.	Borrow/Return Tracking: Log when students borrow and return books, including due dates or timestamps.
	4.	REST API: Expose library data for consumption by other clients (like the .NET MAUI version).
	5.	Statistics (Optional): Generate statistics such as most frequently borrowed books or top borrowers.

## Installation and Usage

### Database Setup

	1.	Create/Initialize the Database
	•	Run LibraryManagementDB.sql to create the database schema.
	•	Run DB-initializationScript.sql to create necessary tables.
	•	Run InsertValuesScript.sql to insert sample data (if desired).
	2.	Configure the Connection String
	•	In your Blazor project, find the appsettings.json (or appsettings.Development.json if you prefer) and update the "ConnectionStrings" section to match your SQL database.
	•	Ensure your server name, database name, user credentials (if any), and other settings are correct.

Note: If you have already set up the database for the WPF version, you can reuse the same database for the Blazor app. Just make sure the connection string points to the same DB instance.

### Build and Run

	1.	Clone the Repository

git clone https://github.com/your-username/cs-librarymanager-blazor.git
cd cs-librarymanager-blazor


	2.	Open in Visual Studio
	•	Open the .sln file in Visual Studio (or your preferred IDE).
	3.	Restore NuGet Packages
	•	Visual Studio typically handles this automatically, but if needed, run:

dotnet restore


	4.	Build the Project

dotnet build


	5.	Run the Application

dotnet run
