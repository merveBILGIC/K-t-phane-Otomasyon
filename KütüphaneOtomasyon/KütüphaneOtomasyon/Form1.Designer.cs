namespace KütüphaneOtomasyon
{
    partial class anaform
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
            this.button1_GRS = new System.Windows.Forms.Button();
            this.button2_UYE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1_GRS
            // 
            this.button1_GRS.Location = new System.Drawing.Point(156, 71);
            this.button1_GRS.Name = "button1_GRS";
            this.button1_GRS.Size = new System.Drawing.Size(75, 33);
            this.button1_GRS.TabIndex = 0;
            this.button1_GRS.Text = "GİRİŞ";
            this.button1_GRS.UseVisualStyleBackColor = true;
            this.button1_GRS.Click += new System.EventHandler(this.button1_GRS_Click);
            // 
            // button2_UYE
            // 
            this.button2_UYE.Location = new System.Drawing.Point(156, 134);
            this.button2_UYE.Name = "button2_UYE";
            this.button2_UYE.Size = new System.Drawing.Size(75, 33);
            this.button2_UYE.TabIndex = 1;
            this.button2_UYE.Text = "ÜYE OL";
            this.button2_UYE.UseVisualStyleBackColor = true;
            this.button2_UYE.Click += new System.EventHandler(this.button2_UYE_Click);
            // 
            // anaform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 261);
            this.Controls.Add(this.button2_UYE);
            this.Controls.Add(this.button1_GRS);
            this.Name = "anaform";
            this.Text = "BİLGİÇ KÜTÜPHANESİ GİRİŞ";
           
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1_GRS;
        private System.Windows.Forms.Button button2_UYE;
    }
}

