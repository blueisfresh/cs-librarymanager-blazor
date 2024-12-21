# CS Library Manager

A Web library manager written with .NET.

## Table of Contents

- [Description](#description)
- [Features](#features)
- [Installation](#installation)
- [Usage](#usage)

## Description

CS Library Manager is a web-based application designed to manage library resources efficiently. It allows users to perform library management tasks, such as adding new books, updating book information, and managing user accounts. The application is built using .NET and Blazor, providing a robust and scalable solution.

## Features

- Add, update, and delete books
- Manage user accounts
- Search for books by title, author, or ISBN
- Responsive web design

## Installation

To set up the project locally, follow these steps:

1. **Clone the repository:**
   ```bash
   git clone https://github.com/blueisfresh/cs-librarymanager-blazor.git
   cd cs-librarymanager-blazor
   ```

2. **Initialize the Database:**
   First, you need to initialize the database. The database initialization script is located in the `cs-librarymanager-wpf` repository in the `DB` folder. Follow the instructions in that repository to set up the database.

   Repository link: [cs-librarymanager-wpf](https://github.com/blueisfresh/cs-librarymanager-wpf)

3. **Open the project in Visual Studio:**
   Open Visual Studio and load the solution file (.sln) from the cloned repository.

4. **Build and Run the project:**
   - Build the project by clicking on `Build` > `Build Solution`.
   - Run the project by clicking on `Debug` > `Start Debugging` or pressing `F5`.

5. **Open the application in your browser:**
   Navigate to `http://localhost:5000` to see the application in action.

## Usage

1. **Add New Book:**
   - Go to the "Add Book" section.
   - Fill in the book details and click "Submit".

2. **Update Book Information:**
   - Search for the book you want to update.
   - Click on the "Edit" button and modify the details.

3. **Manage User Accounts:**
   - Go to the "User Management" section to add, update, or remove user accounts.
