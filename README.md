# Ebda3Soft Accounting & Inventory System
### *Technical Assessment Project for Ebda3Soft*

A robust, modular, and enterprise-grade accounting and inventory management system built with **C# (.NET)** and **SQL Server**. This project demonstrates the implementation of professional software engineering patterns, focusing on scalability, strict data integrity, and clean architectural separation.

---

## 🏗️ Architecture: 3-Tier Pattern
The system strictly adheres to the **3-Tier Architecture** to maintain a clean separation of concerns, making the application highly maintainable and easily scalable:

1. **AccountingSystem_Presentation (UI):** A Windows Forms application handling all user interactions, UI states, and responsive data presentation.
2. **AccountingSystem_Business (BLL):** The domain logic layer that bridges the UI and Data layers. It enforces business rules (e.g., preventing negative stock or validating monetary thresholds).
3. **AccountingSystem_DataAccess (DAL):** The core data-interaction engine. It isolates raw T-SQL commands from the rest of the application, communicating safely with SQL Server.

---

## 🛠️ Key Technical Features

* **Advanced Backup & Restore System:** Implements an automated database recovery system. The application can establish an initial connection via the `master` database to dynamically check, create, and safely restore the database from a `.bak` file using `WITH REPLACE` and exclusive lock handling (`SINGLE_USER`).
* **Strict Inventory Control (No Negative Stock):** Seamlessly packed with 11 core commercial items pre-seeded with optimal quantities and balanced pricing to ensure flawless transactional workflows.
* **Data Integrity via SQL Triggers:** Critical ledger balancing and real-time inventory adjustments (sales vs. purchases) are executed directly on the server level using **Database Triggers** to prevent data inconsistency.
* **SMS Communication Infrastructure (SMS_Log):** Includes a complete database schema and decoupled layer integration for logging and sending SMS balance alerts to clients instantly upon invoice updates.
* **Dynamic Configuration & Portability:** Uses a dynamic `connectionString` inside `App.config`, allowing the application to be deployed across different environments without recompiling the source code.

---

## 🚀 Quick Start (Deployment Guide)

You can choose **either** of the following two deployment paths depending on your testing environment:

### Path 1: Fully Automated Setup (Recommended)
1. Go to the project release folder: `AccountingSystem_Presentation/bin/Release/`.
2. Run **`AccountingSystem_Presentaion.exe`** (Preferably as Administrator).
3. Navigate to the Settings/Maintenance section on the dashboard and click **Restore Backup**.
4. Browse and select the backup file located in the repository at: `/Database/BusinessDB_Backup.bak`.
5. The system will automatically spin up the database server, safely configure `BusinessDB`, and load all seed tables instantly.

### Path 2: Manual SQL Script Generation
1. Open **SQL Server Management Studio (SSMS)** and connect to your local server.
2. Open and execute the comprehensive script file found at: `/Database/BusinessDB_Full_Setup.sql` (Press `F5` to generate tables, triggers, and the 11 pre-seeded items).
3. Open `AccountingSystem_Presentaion.exe.config` in a text editor and ensure the `Data Source` matches your local server instance (e.g., `.` or `SQLEXPRESS`).
4. Launch the application executable.

---

## 📂 Project Structure
```text
├── AccountingSystem_Presentation/  # Windows Forms UI Controls & Forms
├── AccountingSystem_Business/      # Business Logic Models & Evaluation Rules
├── AccountingSystem_DataAccess/    # Data Access Layer & DB Connectivity
└── Database/                       # Production Deployment Files
    ├── BusinessDB_Backup.bak       # Full Automated DB Backup Image
    └── BusinessDB_Full_Setup.sql   # Raw T-SQL Schema & Pre-seeded Data Script
