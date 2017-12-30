namespace OOPBANK
{
    partial class ParaCek
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParaCek));
            this.cbHesapNo = new System.Windows.Forms.ComboBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.lbMusteriAdi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnParaCek = new System.Windows.Forms.Button();
            this.lbBakiye = new System.Windows.Forms.Label();
            this.lbEkHesap = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbHesapNo
            // 
            this.cbHesapNo.FormattingEnabled = true;
            this.cbHesapNo.Location = new System.Drawing.Point(288, 92);
            this.cbHesapNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbHesapNo.Name = "cbHesapNo";
            this.cbHesapNo.Size = new System.Drawing.Size(180, 30);
            this.cbHesapNo.TabIndex = 0;
            this.cbHesapNo.SelectedIndexChanged += new System.EventHandler(this.cbHesapNo_SelectedIndexChanged);
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(288, 192);
            this.txtMiktar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(148, 31);
            this.txtMiktar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(18, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Paranın çekileceği hesap :";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.BackColor = System.Drawing.Color.Transparent;
            this.lbID.Location = new System.Drawing.Point(30, 25);
            this.lbID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(49, 22);
            this.lbID.TabIndex = 3;
            this.lbID.Text = "ID #";
            // 
            // lbMusteriAdi
            // 
            this.lbMusteriAdi.AutoSize = true;
            this.lbMusteriAdi.BackColor = System.Drawing.Color.Transparent;
            this.lbMusteriAdi.Location = new System.Drawing.Point(310, 25);
            this.lbMusteriAdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMusteriAdi.Name = "lbMusteriAdi";
            this.lbMusteriAdi.Size = new System.Drawing.Size(117, 22);
            this.lbMusteriAdi.TabIndex = 4;
            this.lbMusteriAdi.Text = "-Müşteri Ad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(18, 199);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Çekilmek istenen miktar :";
            // 
            // btnParaCek
            // 
            this.btnParaCek.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnParaCek.Location = new System.Drawing.Point(170, 300);
            this.btnParaCek.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnParaCek.Name = "btnParaCek";
            this.btnParaCek.Size = new System.Drawing.Size(195, 92);
            this.btnParaCek.TabIndex = 6;
            this.btnParaCek.Text = "Para Çek";
            this.btnParaCek.UseVisualStyleBackColor = false;
            this.btnParaCek.Click += new System.EventHandler(this.btnParaCek_Click);
            // 
            // lbBakiye
            // 
            this.lbBakiye.AutoSize = true;
            this.lbBakiye.BackColor = System.Drawing.Color.Transparent;
            this.lbBakiye.Location = new System.Drawing.Point(296, 129);
            this.lbBakiye.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBakiye.Name = "lbBakiye";
            this.lbBakiye.Size = new System.Drawing.Size(83, 22);
            this.lbBakiye.TabIndex = 7;
            this.lbBakiye.Text = "Bakiye :";
            // 
            // lbEkHesap
            // 
            this.lbEkHesap.AutoSize = true;
            this.lbEkHesap.Location = new System.Drawing.Point(296, 65);
            this.lbEkHesap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEkHesap.Name = "lbEkHesap";
            this.lbEkHesap.Size = new System.Drawing.Size(0, 22);
            this.lbEkHesap.TabIndex = 8;
            // 
            // ParaCek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(570, 408);
            this.Controls.Add(this.lbEkHesap);
            this.Controls.Add(this.lbBakiye);
            this.Controls.Add(this.btnParaCek);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbMusteriAdi);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.cbHesapNo);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ParaCek";
            this.Text = "ParaCek";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ParaCek_FormClosed);
            this.Load += new System.EventHandler(this.ParaCek_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbHesapNo;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbMusteriAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnParaCek;
        private System.Windows.Forms.Label lbBakiye;
        private System.Windows.Forms.Label lbEkHesap;
    }
}