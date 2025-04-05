# Library Management System – WPF Version

This repository is part of a multi-platform Library Management System built in three different .NET frameworks:
	•	WPF (this repo)
	•	Blazor – Provides a REST API and a web front end.
	•	.NET MAUI (mobile version)

All three versions share the same goal: to manage books, students, and borrowing/return operations in a library. The WPF version highlights desktop application development using MVVM and a local SQL database.

> Why multiple versions?
These projects were created during my apprenticeship to demonstrate how the same functionality can be implemented across desktop (WPF), web (Blazor), and mobile (.NET MAUI) platforms.

## Table of Contents
	1.	Overview
	2.	Core Features
	3.	Installation and Usage
	•	Database Setup
	•	Build and Run

## Overview

The WPF version of the Library Management System is a traditional desktop application that provides:
	•	Desktop UI built using WPF (Windows Presentation Foundation).
	•	MVVM Architecture to separate concerns between UI and business logic.
	•	Repository Pattern for data access (e.g., BookRepository, StudentRepository, BorrowRepository).

This application allows librarians or administrators to:
	•	Manage Books: Add, edit, and delete book records.
	•	Manage Students: Add, edit, and delete student records.
	•	Track Borrowing/Returning: Keep a log of which students borrowed which books and when they are returned.
	•	Import/Export Data: (Optional) for backup or data transfer.
	•	View Statistics: For instance, most borrowed books or most active students (if implemented).

## Core Features
	1.	Add/Edit/Delete Books: Perform CRUD operations on book data (title, author, ISBN, etc.).
	2.	Add/Edit/Delete Students: Manage library members (names, IDs, etc.).
	3.	Borrow/Return Tracking: Log when students borrow and return books.
	4.	Data Import/Export: Optionally import existing data or export current data for backup.
	5.	Statistics (Optional): Generate statistics like most frequently borrowed books or top borrowers.

## Installation and Usage

### Database Setup
	1.	Create/Initialize the Database
	•	Run LibraryManagementDB.sql to create the database schema.
	•	Run DB-initializationScript.sql to create necessary tables.
	•	Run InsertValuesScript.sql to insert sample data (if desired).
	2.	Configure the Connection String
	•	In the WPF project, locate the configuration for the connection string (e.g., in App.config or wherever you store it).
	•	Ensure it points to the SQL Server instance where you ran the scripts.

Note: The Blazor project can also use the same database; if you plan to set up both WPF and Blazor to share data, make sure they point to the exact same database instance.

### Build and Run
	1.	Clone the Repository

git clone https://github.com/your-username/library-management-wpf.git
cd library-management-wpf


	2.	Open the Solution
	•	Open LibraryManagement.sln in Visual Studio.
	3.	Restore NuGet Packages
	•	Visual Studio should automatically restore packages; otherwise, use dotnet restore.
	4.	Build the Project

dotnet build


	5.	Run the Application

dotnet run --project LibraryManagement

Alternatively, press F5 or click Start in Visual Studio.

Enjoy managing your library with the WPF edition! For more details on other platforms, explore the related Blazor and .NET MAUI repositories.
