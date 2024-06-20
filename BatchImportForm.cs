using CnrMigrationData.Models;
using LumenWorks.Framework.IO.Csv;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CnrMigrationData
{
    public partial class BatchImportForm : Form
    {
        public BatchImportForm()
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

        private void btn_import_Click(object sender, EventArgs e)
        {
            // Prompt the user for confirmation
            DialogResult result = MessageBox.Show("Are you sure you want to import the selected data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check the user's response
            if (result == DialogResult.Yes)
            {
                // User confirmed, proceed with import
                if (!string.IsNullOrEmpty(cmb_import_type.Text))
                {
                    if (cmb_import_type.Text == "Products")
                    {
                        // Import products
                        ImportProducts(txt_file_path.Text);
                    }
                    else
                    {
                        // Import vendors
                        ImportVendors(txt_file_path.Text);
                    }
                }
                else
                {
                    MessageBox.Show("Please choose one of the data types you want to import!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ImportProducts(string filePath)
        {
            try
            {
                // Create a CsvReader instance to read the CSV file
                using (var csvReader = new CsvReader(new StreamReader(filePath), true, ','))
                using (var db = new myDbContext())
                {
                    // Read the CSV records one by one
                    while (csvReader.ReadNextRecord())
                    {
                        // Access fields by index or name
                        string productCode = csvReader[0];
                        string productName = csvReader[1];
                        int qty = int.Parse(csvReader[2]);
                        decimal costPrice = decimal.Parse(csvReader[3]);
                        decimal sellPrice = decimal.Parse(csvReader[4]);
                        string vendorName = csvReader[5];

                        // Look for the vendor in the database with case-insensitive search
                        Vendor vendor = null;
                        if (!string.IsNullOrEmpty(vendorName))
                        {
                            string searchVendorName = vendorName.ToLower();
                            vendor = db.Vendor.FirstOrDefault(x => x.vendor_name.ToLower() == searchVendorName);
                        }

                        // Look for the product in the database based on the product code
                        Product product = db.Product.FirstOrDefault(x => x.product_code == productCode);

                        if (product != null)
                        {
                            // Update the existing product
                            product.product_name = productName;
                            product.product_qty = qty;
                            product.cost_price = costPrice;
                            product.sell_price = sellPrice;
                            product.Vendor = vendor;
                            product.VendorId = vendor?.vendor_id;
                        }
                        else
                        {
                            // Create a new product
                            product = new Product
                            {
                                product_code = productCode,
                                product_name = productName,
                                product_qty = qty,
                                cost_price = costPrice,
                                sell_price = sellPrice,
                                product_status = "Active",
                                Vendor = vendor,
                                VendorId = vendor?.vendor_id
                            };

                            // Add the new product to the database
                            db.Product.Add(product);
                        }
                    }

                    // Save changes to the database
                    db.SaveChanges();
                }

                MessageBox.Show("Data imported successfully!!", "Import Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmb_import_type.Text = string.Empty;
                txt_file_path.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }


        }

        private void ImportVendors(string filePath)
        {

            try
            {
                // Create a CsvReader instance to read the CSV file
                using (var csvReader = new CsvReader(new StreamReader(filePath), true, ','))
                using (var db = new myDbContext())
                {
                    // Read the CSV records one by one
                    while (csvReader.ReadNextRecord())
                    {
                        // Access fields by index or name
                        string vendorCode = csvReader[0];
                        string vendorName = csvReader[1];

                        Vendor vendor = null;

                        if (!string.IsNullOrEmpty(vendorCode))
                        {
                            string searchVendorCode = vendorCode.ToLower();

                            vendor = db.Vendor.Where(x => x.vendor_name.ToLower() == searchVendorCode).FirstOrDefault();

                        }

                        if (vendor != null)
                        {
                            // Update the existing vendor
                            vendor.vendor_code = vendorCode;
                            vendor.vendor_name = vendorName;

                            // Save changes to the database
                            db.SaveChanges();
                        }
                        else
                        {
                            // Create a new vendor
                            Vendor newVendor = new Vendor
                            {
                                vendor_code = vendorCode,
                                vendor_name = vendorName,
                                vendor_status = "Active"
                            };

                            // Add the new vendor to the database
                            db.Vendor.Add(newVendor);

                            // Save changes to the database
                            db.SaveChanges();
                        }


                        MessageBox.Show("Data imported successfully!!", "Import Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cmb_import_type.Text = string.Empty;
                        txt_file_path.Text = string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }

        }
    }
}
