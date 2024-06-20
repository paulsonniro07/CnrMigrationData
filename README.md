# CnrMigrationData

**CnrMigrationData** is a Windows Forms application designed to simplify the process of importing and mapping product and vendor data from CSV files into a SQLite database. The application supports data integrity by preventing duplicate product codes and ensures seamless integration with Entity Framework for database management.

## Features

- **Batch Import:** Import product and vendor data from CSV files.
- **Data Mapping:** Automatically map products to vendors based on product codes.
- **Data Integrity:** Prevent duplicate entries for product codes.
- **User Interface:** Easy-to-use UI with comprehensive feedback and guidance for users.
- **SQLite Integration:** Utilize SQLite for lightweight and efficient database management.
- **Entity Framework Integration:** Leverage Entity Framework for database operations and migrations.

## Prerequisites

- .NET Framework 4.8 or later
- Visual Studio 2019 or later
  
**Usage**
Select the import type: Choose between importing products or vendors.
Import CSV file: Browse and select the CSV file to import.
View logs: Check the logs and messages displayed in the application to ensure successful import.
Mapping Tool: Use the mapping tool to automatically populate missing vendor names based on product codes.
Note to Users
Please take note of the following before using the import feature:

Select the data type from the combo box before importing.
The import file must be in CSV format.
Do not reorder columns in the CSV file.

Contact
For any inquiries or feedback, please contact me via www.linkedin.com/in/paulson-niro-6879191a5.
