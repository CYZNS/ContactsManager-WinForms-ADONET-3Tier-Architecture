# 📇 Contacts Manager - 3-Tier Architecture

> A robust C# Windows Forms application for contact management, implementing a 3-Tier Architecture with Event-Driven UI updates and performance-optimized ADO.NET database interactions.

## 🌟 Overview
This desktop application allows users to seamlessly manage their contacts (Add, Edit, Delete, and List). Beyond the basic CRUD operations, this project was built with a strong focus on **Clean Code**, **Performance Optimization**, and **Separation of Concerns**.

## 🏗️ Architecture (3-Tier)
The solution is structurally divided into three distinct layers to ensure maintainability and scalability:
* **Presentation Layer (UI):** Windows Forms. Handles user interactions and displays data without writing direct database queries.
* **Business Logic Layer (BLL):** Acts as a bridge, containing the business rules, validation, and logic of the application.
* **Data Access Layer (DAL):** Manages all data transactions and interactions with the SQL Server database using `ADO.NET`.

## 🚀 Technical Highlights & Problem Solving

### 1. Performance Optimization (Reducing Database Hits)
**The Challenge:** Fetching the `CountryID` associated with a selected `CountryName` from a ComboBox typically requires an additional database query, which degrades performance (Bad Practice).
**The Solution:** Implemented a custom `struct` (`CountryItem`) to encapsulate both `CountryName` and `CountryID` within the ComboBox items in-memory. This completely eliminated the need for redundant database round-trips when reading the selected values.

### 2. Cross-Form Communication via Events & Delegates
**The Challenge:** Updating the main DataGridView after adding or editing a contact in a separate form often leads to "Tight Coupling" if forms reference each other directly.
**The Solution:** Implemented **Delegates and Events** (`onContactSaved`). The Add/Edit form simply "fires" an event upon a successful save, and the Main form listens to this event to trigger a clean UI refresh. This ensures loose coupling and highly professional form-to-form communication.

## 💻 Technologies Used
* **Language:** C#
* **Framework:** .NET Framework (Windows Forms)
* **Database Access:** ADO.NET
* **Database:** Microsoft SQL Server
* **Architecture Design:** 3-Tier / Layered Architecture

## 📸 Screenshots
*(Placeholder for UI screenshots. I will update this section soon!)*
* `![Main Screen](link)`
* `![Add/Edit Screen](link)`

## ⚙️ How to Run
1. Clone the repository.
2. Open `Contacts Project.sln` in Visual Studio.
3. Ensure the connection string in the Data Access Layer points to your local SQL Server database.
4. Set the Windows Forms UI project as the **Startup Project**.
5. Run the application (`F5`).<img width="542" height="230" alt="Screenshot 2026-06-11 165327" src="https://github.com/user-attachments/assets/b94293a6-719c-4b70-a349-b0dc201bb52b" />
