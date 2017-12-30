namespace OOPBANK
{
    partial class Personeller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Personeller));
            this.lbOnline = new System.Windows.Forms.Label();
            this.lbVSayi = new System.Windows.Forms.Label();
            this.lbMHSayi = new System.Windows.Forms.Label();
            this.lbYSayi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbOnline
            // 
            this.lbOnline.AutoSize = true;
            this.lbOnline.BackColor = System.Drawing.Color.Transparent;
            this.lbOnline.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOnline.Location = new System.Drawing.Point(18, 481);
            this.lbOnline.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbOnline.Name = "lbOnline";
            this.lbOnline.Size = new System.Drawing.Size(258, 38);
            this.lbOnline.TabIndex = 0;
            this.lbOnline.Text = "PID #### - Adı";
            // 
            // lbVSayi
            // 
            this.lbVSayi.AutoSize = true;
            this.lbVSayi.BackColor = System.Drawing.Color.Transparent;
            this.lbVSayi.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVSayi.Location = new System.Drawing.Point(18, 76);
            this.lbVSayi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbVSayi.Name = "lbVSayi";
            this.lbVSayi.Size = new System.Drawing.Size(285, 38);
            this.lbVSayi.TabIndex = 1;
            this.lbVSayi.Text = "Veznedar Sayısı :";
            // 
            // lbMHSayi
            // 
            this.lbMHSayi.AutoSize = true;
            this.lbMHSayi.BackColor = System.Drawing.Color.Transparent;
            this.lbMHSayi.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMHSayi.Location = new System.Drawing.Point(18, 150);
            this.lbMHSayi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMHSayi.Name = "lbMHSayi";
            this.lbMHSayi.Size = new System.Drawing.Size(423, 38);
            this.lbMHSayi.TabIndex = 2;
            this.lbMHSayi.Text = "Müşteri Hizmetleri Sayısı :";
            // 
            // lbYSayi
            // 
            this.lbYSayi.AutoSize = true;
            this.lbYSayi.BackColor = System.Drawing.Color.Transparent;
            this.lbYSayi.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbYSayi.Location = new System.Drawing.Point(18, 113);
            this.lbYSayi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbYSayi.Name = "lbYSayi";
            this.lbYSayi.Size = new System.Drawing.Size(263, 38);
            this.lbYSayi.TabIndex = 3;
            this.lbYSayi.Text = "Yönetici Sayısı :";
            // 
            // Personeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 528);
            this.Controls.Add(this.lbYSayi);
            this.Controls.Add(this.lbMHSayi);
            this.Controls.Add(this.lbVSayi);
            this.Controls.Add(this.lbOnline);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Personeller";
            this.Text = "Personeller";
            this.Load += new System.EventHandler(this.Personeller_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbOnline;
        private System.Windows.Forms.Label lbVSayi;
        private System.Windows.Forms.Label lbMHSayi;
        private System.Windows.Forms.Label lbYSayi;
    }
}