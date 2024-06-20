using CnrMigrationData.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePOSApp
{
    public partial class AddUpdateProductForm : Form
    {
        
        public AddUpdateProductForm()
        {
            InitializeComponent();
        }

        private void btn_product_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_product_save_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new myDbContext())
                {
                    Product product = null;
                    Vendor vendor = db.Vendor.Where(x=>x.vendor_name == cmb_vendor.Text).FirstOrDefault();

                    product = db.Product.Where(x => x.product_code == txt_product_code.Text).FirstOrDefault();

                    if (product != null)
                    {
                        product.product_code = txt_product_code.Text;
                        product.product_name = txt_product_name.Text;
                        product.product_qty  = Convert.ToInt16(txt_product_qty.Text);
                        product.cost_price = Convert.ToDecimal(txt_product_cost_price.Text);
                        product.sell_price = Convert.ToDecimal(txt_product_sell_price.Text);
                        product.product_status = cmb_product_status.Text;
                        product.VendorId = vendor.vendor_id;
                        product.Vendor = vendor;

                        db.SaveChanges();
                    }
                    else
                    {
                        product = new Product();
                        product.product_code = txt_product_code.Text;
                        product.product_name = txt_product_name.Text;
                        product.product_qty = Convert.ToInt16(txt_product_qty.Text);
                        product.cost_price = Convert.ToDecimal(txt_product_cost_price.Text);
                        product.sell_price = Convert.ToDecimal(txt_product_sell_price.Text);
                        product.product_status = cmb_product_status.Text;
                        product.VendorId = vendor.vendor_id;
                        product.Vendor = vendor;

                        db.Product.Add(product);
                        db.SaveChanges();
                    }

                    // Clear the text boxes after saving
                    ClearTextBoxes();

                    // Show success message
                    MessageBox.Show("Product data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            catch (Exception ex)
            {
                // Show error message if an exception occurs
                MessageBox.Show($"Error saving product data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearTextBoxes()
        {
            txt_product_code.Text = string.Empty;
            txt_product_name.Text = string.Empty;
            txt_product_cost_price.Text = string.Empty;
            txt_product_sell_price.Text = string.Empty;
            txt_product_qty.Text = string.Empty;
        }
        private void txt_product_code_TextChanged(object sender, EventArgs e)
        {
            string product_code = txt_product_code.Text.Trim();

            using (var db = new myDbContext())
            {
                Product product = db.Product.Include(p => p.Vendor).Where(x => x.product_code == product_code).AsNoTracking().FirstOrDefault();

                if (product != null)
                {
                    txt_product_code.Text = product.product_code;
                    txt_product_name.Text = product.product_name;
                    txt_product_qty.Text = product.product_qty.ToString();
                    txt_product_cost_price.Text = product.cost_price.ToString();
                    txt_product_sell_price.Text = product.sell_price.ToString();
                    cmb_product_status.Text = product.product_status;
                    cmb_vendor.Text = product.Vendor?.vendor_name;

                    txt_product_code.BackColor = Color.AliceBlue;

                }
                else
                {
                    txt_product_name.Text = string.Empty;
                    txt_product_cost_price.Text = string.Empty;
                    txt_product_sell_price.Text = string.Empty;
                    txt_product_qty.Text = string.Empty;
                    cmb_vendor.Text = string.Empty;
                    cmb_product_status.Text = "Active";

                    txt_product_code.BackColor = SystemColors.Window;
                }
            }
        }

        private void AddUpdateProductForm_Load(object sender, EventArgs e)
        {
            LoadVendorNamesForProducts();
            cmb_product_status.Text = "Active";
        }

        private void LoadVendorNamesForProducts()
        {
            using (var db = new myDbContext())
            {
                List<Vendor> vendorList = db.Vendor.AsNoTracking().ToList();

                // Clear existing items in the ComboBox
                cmb_vendor.Items.Clear();

                // Add vendor names to the ComboBox
                foreach (Vendor vendor in vendorList)
                {
                    if(vendor != null)
                        cmb_vendor.Items.Add(vendor.vendor_name);
                }
            }
        }

        private void btn_del_product_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string product_code = txt_product_code.Text.Trim();

                using (var db = new myDbContext())
                {

                    Product product = db.Product.Where(x => x.product_code == product_code).FirstOrDefault();

                    if (product != null)
                    {
                        db.Product.Remove(product);
                        db.SaveChanges();
                        ClearTextBoxes();
                    }
                }
            }
        }
    }
}
