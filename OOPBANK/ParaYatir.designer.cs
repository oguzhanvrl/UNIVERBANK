namespace OOPBANK
{
    partial class ParaYatir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParaYatir));
            this.rbBH = new System.Windows.Forms.RadioButton();
            this.rbKH = new System.Windows.Forms.RadioButton();
            this.rbHH = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkboxNakit = new System.Windows.Forms.CheckBox();
            this.cbHH = new System.Windows.Forms.ComboBox();
            this.cbSH = new System.Windows.Forms.ComboBox();
            this.txtHH = new System.Windows.Forms.TextBox();
            this.txtYP = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.Yatır = new System.Windows.Forms.Button();
            this.lbBakiye = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.lbAD = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbBH
            // 
            this.rbBH.AutoSize = true;
            this.rbBH.Location = new System.Drawing.Point(18, 87);
            this.rbBH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbBH.Name = "rbBH";
            this.rbBH.Size = new System.Drawing.Size(184, 26);
            this.rbBH.TabIndex = 0;
            this.rbBH.TabStop = true;
            this.rbBH.Text = "Banka Hesabıma";
            this.rbBH.UseVisualStyleBackColor = true;
            this.rbBH.CheckedChanged += new System.EventHandler(this.rbBH_CheckedChanged);
            this.rbBH.Click += new System.EventHandler(this.rbBH_Click);
            // 
            // rbKH
            // 
            this.rbKH.AutoSize = true;
            this.rbKH.Location = new System.Drawing.Point(18, 124);
            this.rbKH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbKH.Name = "rbKH";
            this.rbKH.Size = new System.Drawing.Size(179, 26);
            this.rbKH.TabIndex = 2;
            this.rbKH.TabStop = true;
            this.rbKH.Text = "Kredi Hesabıma";
            this.rbKH.UseVisualStyleBackColor = true;
            this.rbKH.Click += new System.EventHandler(this.rbKH_Click);
            // 
            // rbHH
            // 
            this.rbHH.AutoSize = true;
            this.rbHH.Location = new System.Drawing.Point(18, 161);
            this.rbHH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbHH.Name = "rbHH";
            this.rbHH.Size = new System.Drawing.Size(158, 26);
            this.rbHH.TabIndex = 3;
            this.rbHH.TabStop = true;
            this.rbHH.Text = "Başka Hesaba";
            this.rbHH.UseVisualStyleBackColor = true;
            this.rbHH.Click += new System.EventHandler(this.rbHH_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seçilen Hesap";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Yatırılacak Tutar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hedef Hesap";
            // 
            // chkboxNakit
            // 
            this.chkboxNakit.AutoSize = true;
            this.chkboxNakit.Location = new System.Drawing.Point(4, 236);
            this.chkboxNakit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkboxNakit.Name = "chkboxNakit";
            this.chkboxNakit.Size = new System.Drawing.Size(129, 26);
            this.chkboxNakit.TabIndex = 7;
            this.chkboxNakit.Text = "Nakit Yatır";
            this.chkboxNakit.UseVisualStyleBackColor = true;
            this.chkboxNakit.CheckedChanged += new System.EventHandler(this.chkboxNakit_CheckedChanged);
            this.chkboxNakit.Click += new System.EventHandler(this.chkboxNakit_Click);
            // 
            // cbHH
            // 
            this.cbHH.FormattingEnabled = true;
            this.cbHH.Location = new System.Drawing.Point(231, 74);
            this.cbHH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbHH.Name = "cbHH";
            this.cbHH.Size = new System.Drawing.Size(246, 30);
            this.cbHH.TabIndex = 9;
            this.cbHH.SelectedIndexChanged += new System.EventHandler(this.cbHH_SelectedIndexChanged);
            // 
            // cbSH
            // 
            this.cbSH.FormattingEnabled = true;
            this.cbSH.Location = new System.Drawing.Point(231, 4);
            this.cbSH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSH.Name = "cbSH";
            this.cbSH.Size = new System.Drawing.Size(246, 30);
            this.cbSH.TabIndex = 10;
            this.cbSH.SelectedIndexChanged += new System.EventHandler(this.cbSH_SelectedIndexChanged);
            // 
            // txtHH
            // 
            this.txtHH.Location = new System.Drawing.Point(231, 74);
            this.txtHH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHH.Name = "txtHH";
            this.txtHH.Size = new System.Drawing.Size(226, 31);
            this.txtHH.TabIndex = 11;
            // 
            // txtYP
            // 
            this.txtYP.Location = new System.Drawing.Point(231, 125);
            this.txtYP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtYP.Name = "txtYP";
            this.txtYP.Size = new System.Drawing.Size(148, 31);
            this.txtYP.TabIndex = 12;
            this.txtYP.TextChanged += new System.EventHandler(this.txtYP_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb1);
            this.panel1.Controls.Add(this.lb2);
            this.panel1.Controls.Add(this.Yatır);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbBakiye);
            this.panel1.Controls.Add(this.txtYP);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.chkboxNakit);
            this.panel1.Controls.Add(this.txtHH);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbSH);
            this.panel1.Controls.Add(this.cbHH);
            this.panel1.Location = new System.Drawing.Point(18, 235);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 270);
            this.panel1.TabIndex = 13;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(488, 14);
            this.lb1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(0, 22);
            this.lb1.TabIndex = 17;
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(488, 78);
            this.lb2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(0, 22);
            this.lb2.TabIndex = 16;
            // 
            // Yatır
            // 
            this.Yatır.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Yatır.Location = new System.Drawing.Point(262, 192);
            this.Yatır.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Yatır.Name = "Yatır";
            this.Yatır.Size = new System.Drawing.Size(216, 73);
            this.Yatır.TabIndex = 14;
            this.Yatır.Text = "Yatır";
            this.Yatır.UseVisualStyleBackColor = false;
            this.Yatır.Click += new System.EventHandler(this.Yatır_Click);
            // 
            // lbBakiye
            // 
            this.lbBakiye.AutoSize = true;
            this.lbBakiye.Location = new System.Drawing.Point(488, 8);
            this.lbBakiye.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBakiye.Name = "lbBakiye";
            this.lbBakiye.Size = new System.Drawing.Size(0, 22);
            this.lbBakiye.TabIndex = 15;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(18, 12);
            this.lbID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(49, 22);
            this.lbID.TabIndex = 16;
            this.lbID.Text = "ID #";
            // 
            // lbAD
            // 
            this.lbAD.AutoSize = true;
            this.lbAD.Location = new System.Drawing.Point(276, 12);
            this.lbAD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAD.Name = "lbAD";
            this.lbAD.Size = new System.Drawing.Size(89, 22);
            this.lbAD.TabIndex = 17;
            this.lbAD.Text = "Müşteri Adı";
            // 
            // ParaYatir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(632, 521);
            this.Controls.Add(this.lbAD);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rbHH);
            this.Controls.Add(this.rbKH);
            this.Controls.Add(this.rbBH);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ParaYatir";
            this.Text = "ParaYatir";
            this.Load += new System.EventHandler(this.ParaYatir_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbBH;
        private System.Windows.Forms.RadioButton rbKH;
        private System.Windows.Forms.RadioButton rbHH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkboxNakit;
        private System.Windows.Forms.ComboBox cbHH;
        private System.Windows.Forms.ComboBox cbSH;
        private System.Windows.Forms.TextBox txtHH;
        private System.Windows.Forms.TextBox txtYP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Yatır;
        private System.Windows.Forms.Label lbBakiye;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbAD;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
    }
}