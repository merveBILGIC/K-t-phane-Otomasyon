namespace KütüphaneOtomasyon
{
    partial class Form2GRS
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
            this.frm2grs = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Hmsj = new System.Windows.Forms.Label();
            this.Umsj1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // frm2grs
            // 
            this.frm2grs.Location = new System.Drawing.Point(180, 172);
            this.frm2grs.Name = "frm2grs";
            this.frm2grs.Size = new System.Drawing.Size(75, 23);
            this.frm2grs.TabIndex = 0;
            this.frm2grs.Text = "GİRİŞ";
            this.frm2grs.UseVisualStyleBackColor = true;
            this.frm2grs.Click += new System.EventHandler(this.frm2grs_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "TC NO:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(252, 104);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // Hmsj
            // 
            this.Hmsj.AutoSize = true;
            this.Hmsj.ForeColor = System.Drawing.Color.DarkRed;
            this.Hmsj.Location = new System.Drawing.Point(142, 21);
            this.Hmsj.Name = "Hmsj";
            this.Hmsj.Size = new System.Drawing.Size(189, 13);
            this.Hmsj.TabIndex = 5;
            this.Hmsj.Text = "YANLIŞ KULLANICI ADI VEYA ŞİFRE";
            this.Hmsj.Visible = false;
            // 
            // Umsj1
            // 
            this.Umsj1.AutoSize = true;
            this.Umsj1.ForeColor = System.Drawing.Color.Maroon;
            this.Umsj1.Location = new System.Drawing.Point(156, 46);
            this.Umsj1.Name = "Umsj1";
            this.Umsj1.Size = new System.Drawing.Size(146, 13);
            this.Umsj1.TabIndex = 6;
            this.Umsj1.Text = "EKSİK BİLGİLER MEVCUT!!!\r\n";
            this.Umsj1.Visible = false;
            // 
            // Form2GRS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 349);
            this.Controls.Add(this.Umsj1);
            this.Controls.Add(this.Hmsj);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.frm2grs);
            this.Name = "Form2GRS";
            this.Text = "GİRİŞ SAYFASI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2GRS_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button frm2grs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Hmsj;
        private System.Windows.Forms.Label Umsj1;
    }
}