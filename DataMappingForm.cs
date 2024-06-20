using CnrMigrationData.Models;
using LumenWorks.Framework.IO.Csv;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CnrMigrationData
{
    public partial class DataMappingForm : Form
    {
        public DataMappingForm()
        {
            InitializeComponent();
        }

        private void btn_browse_file_Click(object sender, EventArgs e)
        {
            using (System.Windows.Forms.OpenFileDialog openFileDialog = new System.Windows.Forms.OpenFileDialog())
            {
                openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Display the selected file path
                    txt_file_path.Text = openFileDialog.FileName;
                    //MessageBox.Show($"Selected file: {openFileDialog.FileName}", "File Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btn_mapping_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_file_path.Text))
            {
                // Prompt the user for confirmation
                DialogResult result = MessageBox.Show("Are you sure you want to mapiing the selected data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Check the user's response
                if (result == DialogResult.Yes)
                {
                    MappingVendorByProductCode(txt_file_path.Text);
                }
            }
            else
            {
                MessageBox.Show("Browse the file before mapping!", "File not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void MappingVendorByProductCode(string inputFilePath)
        {
            string defaultOutputDirectory = @"C:\ExportedData";
            string defaultOutputFileName = $"MappedData_{DateTime.Now:yyyyMMdd_HHmmss}.csv";
            string outputFilePath = Path.Combine(defaultOutputDirectory, defaultOutputFileName);

            try
            {
                // Create a StreamReader to read the input CSV file
                using (var reader = new StreamReader(inputFilePath))
                // Create a StreamWriter to write to the output CSV file
                using (var writer = new StreamWriter(outputFilePath))
                {
                    // Read the header row from the input CSV file
                    string headerRow = reader.ReadLine();

                    // Write the header row to the output CSV file
                    writer.WriteLine(headerRow);

                    // Read and process each data row
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Split the line into fields
                        string[] fields = line.Split(',');

                        // Access fields by index
                        string productCode = fields[0];
                        string vendorName = null;

                        // Look up the product in the database
                        using (var db = new myDbContext())
                        {
                            Product product = db.Product.Include(p => p.Vendor)
                                .FirstOrDefault(p => p.product_code.ToLower() == productCode.ToLower());

                            if (product != null)
                            {
                                // Get the vendor name from the database
                                vendorName = product.Vendor?.vendor_name;
                            }
                        }

                        // Replace the vendor name field
                        fields[5] = vendorName;

                        // Write the modified row to the output CSV file
                        writer.WriteLine(string.Join(",", fields));
                        txt_file_path.Text = string.Empty;
                    }
                }

                MessageBox.Show("Data mapping and export successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
