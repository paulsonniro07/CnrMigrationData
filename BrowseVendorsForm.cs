using CnrMigrationData.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CnrMigrationData
{
    public partial class BrowseVendorsForm : Form
    {
        public BrowseVendorsForm()
        {
            InitializeComponent();
        }

        private void BrowseVendorsForm_Load(object sender, EventArgs e)
        {
            ShowVendorsRecords();
        }

        private void ShowVendorsRecords()
        {
            try
            {

                using (var db = new myDbContext())
                {
                    List<Vendor> vendors = db.Vendor.AsNoTracking().ToList();

                    dgv_vendors_list.DataSource = vendors;

                    dgv_vendors_list.Columns["vendor_id"].Visible = false;

                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur
                MessageBox.Show($"Error loading Vendors records: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_browse_vendor_TextChanged(object sender, EventArgs e)
        {
            string searchText = txt_browse_vendor.Text.Trim();

            if (!string.IsNullOrEmpty(searchText))
            {
                string searchTextLower = searchText.ToLower();
                try
                {
                    using (var db = new myDbContext())
                    {
                        // Query to select products where the product code or name contains the search text
                        var filteredVendors = db.Vendor
                            .Where(p => p.vendor_code.ToLower().Contains(searchTextLower) || p.vendor_name.ToLower().Contains(searchTextLower))
                            .ToList();

                        // Bind the list of filtered products directly to the DataGridView
                        dgv_vendors_list.DataSource = filteredVendors;
                    }
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that may occur
                    MessageBox.Show($"Error searching product records: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // If the search text is empty, show all products
                ShowVendorsRecords();
            }
        }
    }
}
