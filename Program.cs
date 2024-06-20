using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CnrMigrationData
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //// Specify the connection string for SQLite
            //string connectionString = "Data Source=mydatabase.db;Version=3;";

            //// Check if the database file already exists
            //if (!System.IO.File.Exists("mydatabase.db"))
            //{
            //    // If the database file doesn't exist, create it
            //    SQLiteConnection.CreateFile("mydatabase.db");

            //    // Open a connection to the database
            //    using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            //    {
            //        connection.Open();

            //        // Database file created
            //        Console.WriteLine("SQLite database created successfully.");
            //    }
            //}
            //else
            //{
            //    // Database file already exists
            //    Console.WriteLine("SQLite database already exists.");
            //}

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainForm());
        }
    }
}
