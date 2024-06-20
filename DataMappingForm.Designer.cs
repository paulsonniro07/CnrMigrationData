namespace CnrMigrationData
{
    partial class DataMappingForm
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
            this.txt_file_path = new System.Windows.Forms.TextBox();
            this.lbl_file_path = new System.Windows.Forms.Label();
            this.btn_browse_file = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_mapping = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txt_file_path
            // 
            this.txt_file_path.Enabled = false;
            this.txt_file_path.Location = new System.Drawing.Point(123, 33);
            this.txt_file_path.Multiline = true;
            this.txt_file_path.Name = "txt_file_path";
            this.txt_file_path.Size = new System.Drawing.Size(182, 41);
            this.txt_file_path.TabIndex = 7;
            // 
            // lbl_file_path
            // 
            this.lbl_file_path.AutoSize = true;
            this.lbl_file_path.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_file_path.Location = new System.Drawing.Point(36, 33);
            this.lbl_file_path.Name = "lbl_file_path";
            this.lbl_file_path.Size = new System.Drawing.Size(81, 16);
            this.lbl_file_path.TabIndex = 6;
            this.lbl_file_path.Text = "File Path :";
            // 
            // btn_browse_file
            // 
            this.btn_browse_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_browse_file.Location = new System.Drawing.Point(311, 33);
            this.btn_browse_file.Name = "btn_browse_file";
            this.btn_browse_file.Size = new System.Drawing.Size(76, 36);
            this.btn_browse_file.TabIndex = 5;
            this.btn_browse_file.Text = "Browse";
            this.btn_browse_file.UseVisualStyleBackColor = true;
            this.btn_browse_file.Click += new System.EventHandler(this.btn_browse_file_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_mapping
            // 
            this.btn_mapping.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mapping.Location = new System.Drawing.Point(393, 33);
            this.btn_mapping.Name = "btn_mapping";
            this.btn_mapping.Size = new System.Drawing.Size(76, 36);
            this.btn_mapping.TabIndex = 8;
            this.btn_mapping.Text = "Mapping";
            this.btn_mapping.UseVisualStyleBackColor = true;
            this.btn_mapping.Click += new System.EventHandler(this.btn_mapping_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 9;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Before importing, please ensure that a folder named \'ExportedData\' exists ",
            "on the C:\\ drive. If not, please create it to enable exporting of data."});
            this.listBox1.Location = new System.Drawing.Point(123, 80);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(356, 43);
            this.listBox1.TabIndex = 10;
            // 
            // DataMappingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 176);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_mapping);
            this.Controls.Add(this.txt_file_path);
            this.Controls.Add(this.lbl_file_path);
            this.Controls.Add(this.btn_browse_file);
            this.Name = "DataMappingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataMappingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_file_path;
        private System.Windows.Forms.Label lbl_file_path;
        private System.Windows.Forms.Button btn_browse_file;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_mapping;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
    }
}