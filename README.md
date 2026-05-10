# Ebda3Soft Accounting & Inventory System
### *Technical Assessment Project for Ebda3Soft*

A robust, modular accounting and inventory management system built with **C#** and **SQL Server**. This project demonstrates the implementation of professional software engineering patterns, focusing on scalability, data integrity, and clean code architecture.

---

## 🏗️ Architecture: 3-Tier Pattern
The system is strictly divided into three logical layers to ensure separation of concerns:

1. **AccountingSystem_Presentation (UI):** - Windows Forms application handling user interaction.
   - Implements input validation and asynchronous UI updates.
2. **AccountingSystem_Business (BLL):** - Acts as the intermediary between UI and Data layers.
   - Contains Domain Models and Business Rules (e.g., balance calculations).
3. **AccountingSystem_DataAccess (DAL):** - Handles all database communications.
   - Implements a **Generic Repository Pattern** to handle CRUD operations efficiently.

---

## 🛠️ Key Technical Features

* **Generics:** Used in the DAL to create reusable data access methods, reducing code duplication by over 60%.
* **Data Integrity (SQL Triggers):** Critical business logic, such as updating stock levels during sales/purchases, is handled via **Database Triggers** to prevent data inconsistency.
* **SQL Functions:** Custom scalar functions are used to calculate real-time account balances directly on the server for high performance.
* **Dynamic Configuration:** The system uses a dynamic `connectionString` stored in `App.config`, making the application highly **portable** across different environments.
* **Error Handling:** Global exception handling and logging to ensure the system gracefully recovers from unexpected failures.

---

## 🛠 Prerequisites
* **Visual Studio 2022** (or 19) with .NET desktop development workload.
* **SQL Server** (LocalDB or Express).
* **Git** installed.

## 🚀 Quick Start (Setup)

### 1. Database Configuration
* Navigate to the `/Database` folder.
* Open `Ebda3Db_Script.sql` in SQL Server Management Studio (SSMS).
* Execute the script to create the `Ebda3SoftDB` and its objects (Tables, Triggers, Functions).

### 2. Connection String
* Open the solution in Visual Studio.
* Go to the **AccountingSystem_Presentation** project.
* Open `App.config`.
* Modify the `connectionString` to match your server instance:
  `Data Source=YOUR_SERVER_NAME;Initial Catalog=BusinessDB;Integrated Security=True`

### 3. Dependencies
* Right-click the **Solution** -> **Rebuild Solution**. 
* (Ensure the Reference links between Presentation -> Business -> DataAccess are active).

---

## 📂 Project Structure
```text
├── AccountingSystem_Presentation/  # Windows Forms UI
├── AccountingSystem_Business/      # Business Logic & Models
├── AccountingSystem_DataAccess/    # Data Access & Generics
└── Database/                       # SQL Scripts & Documentation
    └── Ebda3Db_Script.sql          # Full DB Schema & Seed Data
