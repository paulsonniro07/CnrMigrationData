namespace CnrMigrationData
{
    partial class AddUpdateVendorForm
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
            this.listView2 = new System.Windows.Forms.ListView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btn_vendor_exit = new System.Windows.Forms.Button();
            this.btn_vendor_save = new System.Windows.Forms.Button();
            this.txt_vendor_name = new System.Windows.Forms.TextBox();
            this.lbl_vendor_name = new System.Windows.Forms.Label();
            this.txt_vendor_code = new System.Windows.Forms.TextBox();
            this.lbl_vendor_code = new System.Windows.Forms.Label();
            this.cmb_vendor_status = new System.Windows.Forms.ComboBox();
            this.lbl_status = new System.Windows.Forms.Label();
            this.btn_del_vendor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(28, 336);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(473, 52);
            this.listView2.TabIndex = 33;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(28, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(54, 318);
            this.listView1.TabIndex = 32;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btn_vendor_exit
            // 
            this.btn_vendor_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vendor_exit.Location = new System.Drawing.Point(380, 160);
            this.btn_vendor_exit.Name = "btn_vendor_exit";
            this.btn_vendor_exit.Size = new System.Drawing.Size(121, 49);
            this.btn_vendor_exit.TabIndex = 29;
            this.btn_vendor_exit.Text = "&Exit";
            this.btn_vendor_exit.UseVisualStyleBackColor = true;
            this.btn_vendor_exit.Click += new System.EventHandler(this.btn_vendor_exit_Click);
            // 
            // btn_vendor_save
            // 
            this.btn_vendor_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vendor_save.Location = new System.Drawing.Point(109, 160);
            this.btn_vendor_save.Name = "btn_vendor_save";
            this.btn_vendor_save.Size = new System.Drawing.Size(121, 49);
            this.btn_vendor_save.TabIndex = 28;
            this.btn_vendor_save.Text = "&Save";
            this.btn_vendor_save.UseVisualStyleBackColor = true;
            this.btn_vendor_save.Click += new System.EventHandler(this.btn_vendor_save_Click);
            // 
            // txt_vendor_name
            // 
            this.txt_vendor_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_vendor_name.Location = new System.Drawing.Point(228, 61);
            this.txt_vendor_name.Multiline = true;
            this.txt_vendor_name.Name = "txt_vendor_name";
            this.txt_vendor_name.Size = new System.Drawing.Size(208, 39);
            this.txt_vendor_name.TabIndex = 20;
            // 
            // lbl_vendor_name
            // 
            this.lbl_vendor_name.AutoSize = true;
            this.lbl_vendor_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vendor_name.Location = new System.Drawing.Point(106, 58);
            this.lbl_vendor_name.Name = "lbl_vendor_name";
            this.lbl_vendor_name.Size = new System.Drawing.Size(94, 15);
            this.lbl_vendor_name.TabIndex = 19;
            this.lbl_vendor_name.Text = "Vendor Name";
            // 
            // txt_vendor_code
            // 
            this.txt_vendor_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_vendor_code.Location = new System.Drawing.Point(228, 23);
            this.txt_vendor_code.Name = "txt_vendor_code";
            this.txt_vendor_code.Size = new System.Drawing.Size(100, 21);
            this.txt_vendor_code.TabIndex = 18;
            this.txt_vendor_code.TextChanged += new System.EventHandler(this.txt_vendor_code_TextChanged);
            // 
            // lbl_vendor_code
            // 
            this.lbl_vendor_code.AutoSize = true;
            this.lbl_vendor_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vendor_code.Location = new System.Drawing.Point(106, 23);
            this.lbl_vendor_code.Name = "lbl_vendor_code";
            this.lbl_vendor_code.Size = new System.Drawing.Size(89, 15);
            this.lbl_vendor_code.TabIndex = 17;
            this.lbl_vendor_code.Text = "Vendor Code";
            // 
            // cmb_vendor_status
            // 
            this.cmb_vendor_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_vendor_status.FormattingEnabled = true;
            this.cmb_vendor_status.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cmb_vendor_status.Location = new System.Drawing.Point(228, 116);
            this.cmb_vendor_status.Name = "cmb_vendor_status";
            this.cmb_vendor_status.Size = new System.Drawing.Size(121, 21);
            this.cmb_vendor_status.TabIndex = 35;
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(106, 116);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(47, 15);
            this.lbl_status.TabIndex = 34;
            this.lbl_status.Text = "Status";
            // 
            // btn_del_vendor
            // 
            this.btn_del_vendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del_vendor.Location = new System.Drawing.Point(236, 161);
            this.btn_del_vendor.Name = "btn_del_vendor";
            this.btn_del_vendor.Size = new System.Drawing.Size(138, 49);
            this.btn_del_vendor.TabIndex = 36;
            this.btn_del_vendor.Text = "Delete";
            this.btn_del_vendor.UseVisualStyleBackColor = true;
            this.btn_del_vendor.Click += new System.EventHandler(this.btn_del_vendor_Click);
            // 
            // AddUpdateVendorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 414);
            this.Controls.Add(this.btn_del_vendor);
            this.Controls.Add(this.cmb_vendor_status);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btn_vendor_exit);
            this.Controls.Add(this.btn_vendor_save);
            this.Controls.Add(this.txt_vendor_name);
            this.Controls.Add(this.lbl_vendor_name);
            this.Controls.Add(this.txt_vendor_code);
            this.Controls.Add(this.lbl_vendor_code);
            this.Name = "AddUpdateVendorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUpdateVendorForm";
            this.Load += new System.EventHandler(this.AddUpdateVendorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btn_vendor_exit;
        private System.Windows.Forms.Button btn_vendor_save;
        private System.Windows.Forms.TextBox txt_vendor_name;
        private System.Windows.Forms.Label lbl_vendor_name;
        private System.Windows.Forms.TextBox txt_vendor_code;
        private System.Windows.Forms.Label lbl_vendor_code;
        private System.Windows.Forms.ComboBox cmb_vendor_status;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Button btn_del_vendor;
    }
}