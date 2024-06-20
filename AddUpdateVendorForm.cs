using CnrMigrationData.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CnrMigrationData
{
    public partial class AddUpdateVendorForm : Form
    {
        public AddUpdateVendorForm()
        {
            InitializeComponent();
        }

        private void btn_vendor_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_vendor_code_TextChanged(object sender, EventArgs e)
        {
            string vendor_code = txt_vendor_code.Text.Trim();

            using (var db = new myDbContext())
            {

                Vendor vendor = db.Vendor.Where(x => x.vendor_code == vendor_code).AsNoTracking().FirstOrDefault();

                if (vendor != null)
                {
                    txt_vendor_code.Text = vendor.vendor_code;
                    txt_vendor_name.Text = vendor.vendor_name;
                    cmb_vendor_status.Text = vendor.vendor_status;

                    txt_vendor_code.BackColor = Color.AliceBlue;
                }
                else
                {
                    txt_vendor_name.Text = string.Empty;
                    cmb_vendor_status.Text = "Active";
                    txt_vendor_code.BackColor = SystemColors.Window;
                }

            }
        }

        private void ClearTextBoxes()
        {
            txt_vendor_code.Text = string.Empty;
            txt_vendor_name.Text = string.Empty;
        }
        private void btn_vendor_save_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new myDbContext())
                {
                    Vendor vendor = null;

                    vendor = db.Vendor.Where(x => x.vendor_code == txt_vendor_code.Text).FirstOrDefault();

                    if (vendor != null)
                    {
                        vendor.vendor_code = txt_vendor_code.Text;
                        vendor.vendor_name = txt_vendor_name.Text;
                        vendor.vendor_status = cmb_vendor_status.Text;

                        db.SaveChanges();
                    }
                    else
                    {
                        vendor = new Vendor();
                        vendor.vendor_code = txt_vendor_code.Text;
                        vendor.vendor_name = txt_vendor_name.Text;
                        vendor.vendor_status = cmb_vendor_status.Text;

                        db.Vendor.Add(vendor);
                        db.SaveChanges();
                    }

                    // Clear the text boxes after saving
                    ClearTextBoxes();

                    // Show success message
                    MessageBox.Show("Vendor data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                // Show error message if an exception occurs
                MessageBox.Show($"Error saving Vendor data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddUpdateVendorForm_Load(object sender, EventArgs e)
        {
            cmb_vendor_status.Text = "Active";
        }

        private void btn_del_vendor_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if(result == DialogResult.Yes)
            {
                string vendor_code = txt_vendor_code.Text.Trim();

                using (var db = new myDbContext())
                {

                    Vendor vendor = db.Vendor.Where(x => x.vendor_code == vendor_code).FirstOrDefault();

                    if (vendor != null)
                    {
                        db.Vendor.Remove(vendor);
                        db.SaveChanges();
                        ClearTextBoxes();
                    }
                }
            }
        }
    }
}
