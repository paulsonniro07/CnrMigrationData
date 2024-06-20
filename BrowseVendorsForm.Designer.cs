namespace CnrMigrationData
{
    partial class BrowseVendorsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_browse_vendor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_vendors_list = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vendors_list)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_browse_vendor
            // 
            this.txt_browse_vendor.Location = new System.Drawing.Point(181, 28);
            this.txt_browse_vendor.Name = "txt_browse_vendor";
            this.txt_browse_vendor.Size = new System.Drawing.Size(158, 20);
            this.txt_browse_vendor.TabIndex = 5;
            this.txt_browse_vendor.TextChanged += new System.EventHandler(this.txt_browse_vendor_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filter Vendor Code / Name :";
            // 
            // dgv_vendors_list
            // 
            this.dgv_vendors_list.AllowUserToAddRows = false;
            this.dgv_vendors_list.AllowUserToDeleteRows = false;
            this.dgv_vendors_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_vendors_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vendors_list.Location = new System.Drawing.Point(36, 66);
            this.dgv_vendors_list.Name = "dgv_vendors_list";
            this.dgv_vendors_list.ReadOnly = true;
            this.dgv_vendors_list.Size = new System.Drawing.Size(716, 309);
            this.dgv_vendors_list.TabIndex = 3;
            // 
            // BrowseVendorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 409);
            this.Controls.Add(this.txt_browse_vendor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_vendors_list);
            this.Name = "BrowseVendorsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BrowseVendorsForm";
            this.Load += new System.EventHandler(this.BrowseVendorsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vendors_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_browse_vendor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_vendors_list;
    }
}