using SimplePOSApp;
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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addUpdateProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUpdateProductForm addUpdateProductForm = new AddUpdateProductForm();
            addUpdateProductForm.Show();
        }

        private void browseProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrowseProductsForm browseProductsForm = new BrowseProductsForm();
            browseProductsForm.Show();
        }

        private void addUpdateVendorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUpdateVendorForm addUpdateVendorForm = new AddUpdateVendorForm();
            addUpdateVendorForm.Show();
        }

        private void browseVendorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrowseVendorsForm browseVendorsForm = new BrowseVendorsForm();
            browseVendorsForm.Show();
        }

        private void bathImportDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BatchImportForm batchImportForm = new BatchImportForm();
            batchImportForm.Show();
        }

        private void dataMappingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataMappingForm dataMappingForm = new DataMappingForm();
            dataMappingForm.Show();
        }
    }
}
