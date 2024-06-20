namespace SimplePOSApp
{
    partial class AddUpdateProductForm
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
            this.lbl_product_code = new System.Windows.Forms.Label();
            this.txt_product_code = new System.Windows.Forms.TextBox();
            this.txt_product_name = new System.Windows.Forms.TextBox();
            this.lbl_product_name = new System.Windows.Forms.Label();
            this.txt_product_cost_price = new System.Windows.Forms.TextBox();
            this.lbl_product_cost_price = new System.Windows.Forms.Label();
            this.txt_product_sell_price = new System.Windows.Forms.TextBox();
            this.lbl_product_sell_price = new System.Windows.Forms.Label();
            this.txt_product_qty = new System.Windows.Forms.TextBox();
            this.lbl_product_qty = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.btn_product_save = new System.Windows.Forms.Button();
            this.btn_product_exit = new System.Windows.Forms.Button();
            this.cmb_product_status = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.cmb_vendor = new System.Windows.Forms.ComboBox();
            this.lbl_vendor = new System.Windows.Forms.Label();
            this.listView3 = new System.Windows.Forms.ListView();
            this.btn_del_product = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_product_code
            // 
            this.lbl_product_code.AutoSize = true;
            this.lbl_product_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_code.Location = new System.Drawing.Point(90, 26);
            this.lbl_product_code.Name = "lbl_product_code";
            this.lbl_product_code.Size = new System.Drawing.Size(93, 15);
            this.lbl_product_code.TabIndex = 0;
            this.lbl_product_code.Text = "Product Code";
            // 
            // txt_product_code
            // 
            this.txt_product_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_product_code.Location = new System.Drawing.Point(212, 26);
            this.txt_product_code.Name = "txt_product_code";
            this.txt_product_code.Size = new System.Drawing.Size(100, 21);
            this.txt_product_code.TabIndex = 1;
            this.txt_product_code.TextChanged += new System.EventHandler(this.txt_product_code_TextChanged);
            // 
            // txt_product_name
            // 
            this.txt_product_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_product_name.Location = new System.Drawing.Point(212, 64);
            this.txt_product_name.Multiline = true;
            this.txt_product_name.Name = "txt_product_name";
            this.txt_product_name.Size = new System.Drawing.Size(208, 39);
            this.txt_product_name.TabIndex = 3;
            // 
            // lbl_product_name
            // 
            this.lbl_product_name.AutoSize = true;
            this.lbl_product_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_name.Location = new System.Drawing.Point(90, 61);
            this.lbl_product_name.Name = "lbl_product_name";
            this.lbl_product_name.Size = new System.Drawing.Size(98, 15);
            this.lbl_product_name.TabIndex = 2;
            this.lbl_product_name.Text = "Product Name";
            // 
            // txt_product_cost_price
            // 
            this.txt_product_cost_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_product_cost_price.Location = new System.Drawing.Point(212, 119);
            this.txt_product_cost_price.Name = "txt_product_cost_price";
            this.txt_product_cost_price.Size = new System.Drawing.Size(100, 21);
            this.txt_product_cost_price.TabIndex = 5;
            // 
            // lbl_product_cost_price
            // 
            this.lbl_product_cost_price.AutoSize = true;
            this.lbl_product_cost_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_cost_price.Location = new System.Drawing.Point(90, 119);
            this.lbl_product_cost_price.Name = "lbl_product_cost_price";
            this.lbl_product_cost_price.Size = new System.Drawing.Size(72, 15);
            this.lbl_product_cost_price.TabIndex = 4;
            this.lbl_product_cost_price.Text = "Cost Price";
            // 
            // txt_product_sell_price
            // 
            this.txt_product_sell_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_product_sell_price.Location = new System.Drawing.Point(212, 155);
            this.txt_product_sell_price.Name = "txt_product_sell_price";
            this.txt_product_sell_price.Size = new System.Drawing.Size(100, 21);
            this.txt_product_sell_price.TabIndex = 7;
            // 
            // lbl_product_sell_price
            // 
            this.lbl_product_sell_price.AutoSize = true;
            this.lbl_product_sell_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_sell_price.Location = new System.Drawing.Point(90, 155);
            this.lbl_product_sell_price.Name = "lbl_product_sell_price";
            this.lbl_product_sell_price.Size = new System.Drawing.Size(69, 15);
            this.lbl_product_sell_price.TabIndex = 6;
            this.lbl_product_sell_price.Text = "Sell Price";
            // 
            // txt_product_qty
            // 
            this.txt_product_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_product_qty.Location = new System.Drawing.Point(212, 191);
            this.txt_product_qty.Name = "txt_product_qty";
            this.txt_product_qty.Size = new System.Drawing.Size(100, 21);
            this.txt_product_qty.TabIndex = 9;
            // 
            // lbl_product_qty
            // 
            this.lbl_product_qty.AutoSize = true;
            this.lbl_product_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_qty.Location = new System.Drawing.Point(90, 191);
            this.lbl_product_qty.Name = "lbl_product_qty";
            this.lbl_product_qty.Size = new System.Drawing.Size(59, 15);
            this.lbl_product_qty.TabIndex = 8;
            this.lbl_product_qty.Text = "Quantity";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(90, 262);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(47, 15);
            this.lbl_status.TabIndex = 10;
            this.lbl_status.Text = "Status";
            // 
            // btn_product_save
            // 
            this.btn_product_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_product_save.Location = new System.Drawing.Point(93, 302);
            this.btn_product_save.Name = "btn_product_save";
            this.btn_product_save.Size = new System.Drawing.Size(121, 49);
            this.btn_product_save.TabIndex = 12;
            this.btn_product_save.Text = "&Save";
            this.btn_product_save.UseVisualStyleBackColor = true;
            this.btn_product_save.Click += new System.EventHandler(this.btn_product_save_Click);
            // 
            // btn_product_exit
            // 
            this.btn_product_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_product_exit.Location = new System.Drawing.Point(347, 302);
            this.btn_product_exit.Name = "btn_product_exit";
            this.btn_product_exit.Size = new System.Drawing.Size(121, 49);
            this.btn_product_exit.TabIndex = 13;
            this.btn_product_exit.Text = "&Exit";
            this.btn_product_exit.UseVisualStyleBackColor = true;
            this.btn_product_exit.Click += new System.EventHandler(this.btn_product_exit_Click);
            // 
            // cmb_product_status
            // 
            this.cmb_product_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_product_status.FormattingEnabled = true;
            this.cmb_product_status.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cmb_product_status.Location = new System.Drawing.Point(212, 262);
            this.cmb_product_status.Name = "cmb_product_status";
            this.cmb_product_status.Size = new System.Drawing.Size(121, 21);
            this.cmb_product_status.TabIndex = 14;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 15);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(54, 336);
            this.listView1.TabIndex = 16;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(12, 366);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(490, 52);
            this.listView2.TabIndex = 16;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // cmb_vendor
            // 
            this.cmb_vendor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_vendor.FormattingEnabled = true;
            this.cmb_vendor.Location = new System.Drawing.Point(212, 228);
            this.cmb_vendor.Name = "cmb_vendor";
            this.cmb_vendor.Size = new System.Drawing.Size(121, 21);
            this.cmb_vendor.TabIndex = 18;
            // 
            // lbl_vendor
            // 
            this.lbl_vendor.AutoSize = true;
            this.lbl_vendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vendor.Location = new System.Drawing.Point(90, 228);
            this.lbl_vendor.Name = "lbl_vendor";
            this.lbl_vendor.Size = new System.Drawing.Size(52, 15);
            this.lbl_vendor.TabIndex = 17;
            this.lbl_vendor.Text = "Vendor";
            // 
            // listView3
            // 
            this.listView3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(508, 82);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(54, 336);
            this.listView3.TabIndex = 19;
            this.listView3.UseCompatibleStateImageBehavior = false;
            // 
            // btn_del_product
            // 
            this.btn_del_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del_product.Location = new System.Drawing.Point(220, 302);
            this.btn_del_product.Name = "btn_del_product";
            this.btn_del_product.Size = new System.Drawing.Size(121, 49);
            this.btn_del_product.TabIndex = 20;
            this.btn_del_product.Text = "Delete";
            this.btn_del_product.UseVisualStyleBackColor = true;
            this.btn_del_product.Click += new System.EventHandler(this.btn_del_product_Click);
            // 
            // AddUpdateProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(585, 456);
            this.Controls.Add(this.btn_del_product);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.cmb_vendor);
            this.Controls.Add(this.lbl_vendor);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.cmb_product_status);
            this.Controls.Add(this.btn_product_exit);
            this.Controls.Add(this.btn_product_save);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.txt_product_qty);
            this.Controls.Add(this.lbl_product_qty);
            this.Controls.Add(this.txt_product_sell_price);
            this.Controls.Add(this.lbl_product_sell_price);
            this.Controls.Add(this.txt_product_cost_price);
            this.Controls.Add(this.lbl_product_cost_price);
            this.Controls.Add(this.txt_product_name);
            this.Controls.Add(this.lbl_product_name);
            this.Controls.Add(this.txt_product_code);
            this.Controls.Add(this.lbl_product_code);
            this.Name = "AddUpdateProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.AddUpdateProductForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_product_code;
        private System.Windows.Forms.TextBox txt_product_code;
        private System.Windows.Forms.TextBox txt_product_name;
        private System.Windows.Forms.Label lbl_product_name;
        private System.Windows.Forms.TextBox txt_product_cost_price;
        private System.Windows.Forms.Label lbl_product_cost_price;
        private System.Windows.Forms.TextBox txt_product_sell_price;
        private System.Windows.Forms.Label lbl_product_sell_price;
        private System.Windows.Forms.TextBox txt_product_qty;
        private System.Windows.Forms.Label lbl_product_qty;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Button btn_product_save;
        private System.Windows.Forms.Button btn_product_exit;
        private System.Windows.Forms.ComboBox cmb_product_status;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ComboBox cmb_vendor;
        private System.Windows.Forms.Label lbl_vendor;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.Button btn_del_product;
    }
}