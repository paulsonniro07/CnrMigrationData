using CnrMigrationData.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePOSApp
{
    public partial class BrowseProductsForm : Form
    {
        public BrowseProductsForm()
        {
            InitializeComponent();
        }
        private void BrowseProductsForm_Load(object sender, EventArgs e)
        {
            ShowProductRecords();
        }

        private void ShowProductRecords()
        {
            try
            {
                using (var db = new myDbContext())
                {
                    List<Product> products = db.Product.Include("Vendor").AsNoTracking().ToList();

                    var productData = products.Select(p => new
                    {
                        p.product_id,
                        p.product_code,
                        p.product_name,
                        p.cost_price,
                        p.sell_price,
                        p.product_qty,
                        p.product_status,
                        VendorName = p.Vendor != null ? p.Vendor.vendor_name : ""
                    }).ToList();

                    dgv_products_list.DataSource = productData;

                    MoveProductCodeColumnToFirst();

                    dgv_products_list.Columns["product_id"].Visible = false;

                    dgv_products_list.Columns["product_code"].HeaderText = "Product Code";
                    dgv_products_list.Columns["product_name"].HeaderText = "Product Name";
                    dgv_products_list.Columns["cost_price"].HeaderText = "Cost Price";
                    dgv_products_list.Columns["sell_price"].HeaderText = "Sell Price";
                    dgv_products_list.Columns["product_qty"].HeaderText = "Product Quantity";
                    dgv_products_list.Columns["product_status"].HeaderText = "Product Status";
                    dgv_products_list.Columns["VendorName"].HeaderText = "Vendor Name";
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur
                MessageBox.Show($"Error loading product records: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void MoveProductCodeColumnToFirst()
        {
            // Find the product_code column by name
            DataGridViewColumn productCodeColumn = dgv_products_list.Columns["product_code"];

            if (productCodeColumn != null)
            {
                // Set the DisplayIndex of the product_code column to 0
                productCodeColumn.DisplayIndex = 0;

                // Adjust the DisplayIndex of other columns accordingly
                int displayIndex = 1;
                foreach (DataGridViewColumn column in dgv_products_list.Columns)
                {
                    if (column != productCodeColumn)
                    {
                        column.DisplayIndex = displayIndex;
                        displayIndex++;
                    }
                }
            }
        }

        private void txt_browse_product_TextChanged(object sender, EventArgs e)
        {
            string searchText = txt_browse_product.Text.Trim();

            if (!string.IsNullOrEmpty(searchText))
            {
                string searchTextLower = searchText.ToLower();
                try
                {
                    using (var db = new myDbContext())
                    {
                        // Query to select products where the product code or name contains the search text
                        var filteredProducts = db.Product
                            .Where(p => p.product_code.ToLower().Contains(searchTextLower) || p.product_name.ToLower().Contains(searchTextLower))
                            .ToList();

                        // Bind the list of filtered products directly to the DataGridView
                        dgv_products_list.DataSource = filteredProducts;
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
                ShowProductRecords();
            }
        }
    }
}
