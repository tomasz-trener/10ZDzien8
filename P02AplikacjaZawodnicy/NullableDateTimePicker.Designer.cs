namespace P02AplikacjaZawodnicy
{
    partial class NullableDateTimePicker
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.txtData = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dtpData
            // 
            this.dtpData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(0, 0);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(175, 20);
            this.dtpData.TabIndex = 0;
            this.dtpData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpData_KeyDown);
            // 
            // txtData
            // 
            this.txtData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtData.Location = new System.Drawing.Point(0, 0);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(175, 20);
            this.txtData.TabIndex = 1;
            this.txtData.Click += new System.EventHandler(this.txtData_Click);
            // 
            // NullableDateTimePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.dtpData);
            this.Name = "NullableDateTimePicker";
            this.Size = new System.Drawing.Size(175, 21);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.TextBox txtData;
    }
}
