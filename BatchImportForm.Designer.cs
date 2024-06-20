namespace CnrMigrationData
{
    partial class BatchImportForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_import_type = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_browse_file = new System.Windows.Forms.Button();
            this.lbl_file_path = new System.Windows.Forms.Label();
            this.txt_file_path = new System.Windows.Forms.TextBox();
            this.btn_import = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Data :";
            // 
            // cmb_import_type
            // 
            this.cmb_import_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_import_type.FormattingEnabled = true;
            this.cmb_import_type.Items.AddRange(new object[] {
            "Products",
            "Vendors"});
            this.cmb_import_type.Location = new System.Drawing.Point(162, 33);
            this.cmb_import_type.Name = "cmb_import_type";
            this.cmb_import_type.Size = new System.Drawing.Size(121, 21);
            this.cmb_import_type.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_browse_file
            // 
            this.btn_browse_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_browse_file.Location = new System.Drawing.Point(162, 118);
            this.btn_browse_file.Name = "btn_browse_file";
            this.btn_browse_file.Size = new System.Drawing.Size(76, 36);
            this.btn_browse_file.TabIndex = 2;
            this.btn_browse_file.Text = "Browse";
            this.btn_browse_file.UseVisualStyleBackColor = true;
            this.btn_browse_file.Click += new System.EventHandler(this.btn_browse_file_Click);
            // 
            // lbl_file_path
            // 
            this.lbl_file_path.AutoSize = true;
            this.lbl_file_path.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_file_path.Location = new System.Drawing.Point(45, 71);
            this.lbl_file_path.Name = "lbl_file_path";
            this.lbl_file_path.Size = new System.Drawing.Size(81, 16);
            this.lbl_file_path.TabIndex = 3;
            this.lbl_file_path.Text = "File Path :";
            // 
            // txt_file_path
            // 
            this.txt_file_path.Enabled = false;
            this.txt_file_path.Location = new System.Drawing.Point(162, 71);
            this.txt_file_path.Multiline = true;
            this.txt_file_path.Name = "txt_file_path";
            this.txt_file_path.Size = new System.Drawing.Size(182, 41);
            this.txt_file_path.TabIndex = 4;
            // 
            // btn_import
            // 
            this.btn_import.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_import.Location = new System.Drawing.Point(253, 118);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(75, 36);
            this.btn_import.TabIndex = 5;
            this.btn_import.Text = "Import";
            this.btn_import.UseVisualStyleBackColor = true;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Control;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Please take note of the following before proceeding with the import:",
            "",
            "1. Ensure that you have selected the appropriate data type ",
            "    from the dropdown menu.",
            "2. Ensure that the file you are importing is in CSV format.\"",
            "3. Do not rearrange the columns in the CSV file before importing.\""});
            this.listBox1.Location = new System.Drawing.Point(350, 59);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(330, 95);
            this.listBox1.TabIndex = 6;
            // 
            // BatchImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 213);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_import);
            this.Controls.Add(this.txt_file_path);
            this.Controls.Add(this.lbl_file_path);
            this.Controls.Add(this.btn_browse_file);
            this.Controls.Add(this.cmb_import_type);
            this.Controls.Add(this.label1);
            this.Name = "BatchImportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BatchImportForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_import_type;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_browse_file;
        private System.Windows.Forms.Label lbl_file_path;
        private System.Windows.Forms.TextBox txt_file_path;
        private System.Windows.Forms.Button btn_import;
        private System.Windows.Forms.ListBox listBox1;
    }
}