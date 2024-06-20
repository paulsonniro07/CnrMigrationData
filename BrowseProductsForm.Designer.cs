namespace SimplePOSApp
{
    partial class BrowseProductsForm
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
            this.dgv_products_list = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_browse_product = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products_list)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_products_list
            // 
            this.dgv_products_list.AllowUserToAddRows = false;
            this.dgv_products_list.AllowUserToDeleteRows = false;
            this.dgv_products_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_products_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_products_list.Location = new System.Drawing.Point(45, 58);
            this.dgv_products_list.Name = "dgv_products_list";
            this.dgv_products_list.ReadOnly = true;
            this.dgv_products_list.Size = new System.Drawing.Size(716, 309);
            this.dgv_products_list.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filter Product Code / Name :";
            // 
            // txt_browse_product
            // 
            this.txt_browse_product.Location = new System.Drawing.Point(190, 20);
            this.txt_browse_product.Name = "txt_browse_product";
            this.txt_browse_product.Size = new System.Drawing.Size(158, 20);
            this.txt_browse_product.TabIndex = 2;
            this.txt_browse_product.TextChanged += new System.EventHandler(this.txt_browse_product_TextChanged);
            // 
            // BrowseProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 411);
            this.Controls.Add(this.txt_browse_product);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_products_list);
            this.Name = "BrowseProductsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BrowseProductsForm";
            this.Load += new System.EventHandler(this.BrowseProductsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_products_list;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_browse_product;
    }
}