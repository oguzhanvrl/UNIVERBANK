namespace OOPBANK
{
    partial class RaporDokumGoruntuleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RaporDokumGoruntuleForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioVadesizHesap = new System.Windows.Forms.RadioButton();
            this.radioVadeliHesap = new System.Windows.Forms.RadioButton();
            this.radioKrediHesap = new System.Windows.Forms.RadioButton();
            this.radioGenelMusteri = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radioGenelPersonel = new System.Windows.Forms.RadioButton();
            this.radioBankaGider = new System.Windows.Forms.RadioButton();
            this.radioPersonelMaas = new System.Windows.Forms.RadioButton();
            this.radioBankaGelir = new System.Windows.Forms.RadioButton();
            this.radioGenelBanka = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dataGridView1.Location = new System.Drawing.Point(10, 110);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(973, 463);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioVadesizHesap);
            this.groupBox1.Controls.Add(this.radioVadeliHesap);
            this.groupBox1.Controls.Add(this.radioKrediHesap);
            this.groupBox1.Controls.Add(this.radioGenelMusteri);
            this.groupBox1.Font = new System.Drawing.Font("Rockwell", 10F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(973, 90);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri İşlem Özeti";
            // 
            // radioVadesizHesap
            // 
            this.radioVadesizHesap.AutoSize = true;
            this.radioVadesizHesap.Location = new System.Drawing.Point(721, 44);
            this.radioVadesizHesap.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radioVadesizHesap.Name = "radioVadesizHesap";
            this.radioVadesizHesap.Size = new System.Drawing.Size(242, 24);
            this.radioVadesizHesap.TabIndex = 9;
            this.radioVadesizHesap.TabStop = true;
            this.radioVadesizHesap.Text = "Vadesiz Hesap İşlemleriniz";
            this.radioVadesizHesap.UseVisualStyleBackColor = true;
            this.radioVadesizHesap.CheckedChanged += new System.EventHandler(this.radioVadesizHesap_CheckedChanged);
            // 
            // radioVadeliHesap
            // 
            this.radioVadeliHesap.AutoSize = true;
            this.radioVadeliHesap.Location = new System.Drawing.Point(486, 44);
            this.radioVadeliHesap.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radioVadeliHesap.Name = "radioVadeliHesap";
            this.radioVadeliHesap.Size = new System.Drawing.Size(231, 24);
            this.radioVadeliHesap.TabIndex = 8;
            this.radioVadeliHesap.TabStop = true;
            this.radioVadeliHesap.Text = "Vadeli Hesap İşlemleriniz";
            this.radioVadeliHesap.UseVisualStyleBackColor = true;
            this.radioVadeliHesap.CheckedChanged += new System.EventHandler(this.radioVadeliHesap_CheckedChanged);
            // 
            // radioKrediHesap
            // 
            this.radioKrediHesap.AutoSize = true;
            this.radioKrediHesap.Location = new System.Drawing.Point(260, 44);
            this.radioKrediHesap.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radioKrediHesap.Name = "radioKrediHesap";
            this.radioKrediHesap.Size = new System.Drawing.Size(223, 24);
            this.radioKrediHesap.TabIndex = 7;
            this.radioKrediHesap.TabStop = true;
            this.radioKrediHesap.Text = "Kredi Hesap İşlemleriniz";
            this.radioKrediHesap.UseVisualStyleBackColor = true;
            this.radioKrediHesap.CheckedChanged += new System.EventHandler(this.radioKrediHesap_CheckedChanged);
            // 
            // radioGenelMusteri
            // 
            this.radioGenelMusteri.AutoSize = true;
            this.radioGenelMusteri.Location = new System.Drawing.Point(18, 44);
            this.radioGenelMusteri.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radioGenelMusteri.Name = "radioGenelMusteri";
            this.radioGenelMusteri.Size = new System.Drawing.Size(241, 24);
            this.radioGenelMusteri.TabIndex = 6;
            this.radioGenelMusteri.TabStop = true;
            this.radioGenelMusteri.Text = "Genel Müşteri İşlemleriniz";
            this.radioGenelMusteri.UseVisualStyleBackColor = true;
            this.radioGenelMusteri.CheckedChanged += new System.EventHandler(this.radioGenelMusteri_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.radioGenelPersonel);
            this.groupBox2.Controls.Add(this.radioBankaGider);
            this.groupBox2.Controls.Add(this.radioPersonelMaas);
            this.groupBox2.Controls.Add(this.radioBankaGelir);
            this.groupBox2.Controls.Add(this.radioGenelBanka);
            this.groupBox2.Font = new System.Drawing.Font("Rockwell", 9F);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(14, 1);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(969, 95);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personel İşlem Özeti";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(843, 21);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 68);
            this.button1.TabIndex = 6;
            this.button1.Text = "FINANS RAPORU";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioGenelPersonel
            // 
            this.radioGenelPersonel.AutoSize = true;
            this.radioGenelPersonel.Location = new System.Drawing.Point(182, 43);
            this.radioGenelPersonel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radioGenelPersonel.Name = "radioGenelPersonel";
            this.radioGenelPersonel.Size = new System.Drawing.Size(225, 21);
            this.radioGenelPersonel.TabIndex = 5;
            this.radioGenelPersonel.TabStop = true;
            this.radioGenelPersonel.Text = "Genel Personel İşlemleriniz";
            this.radioGenelPersonel.UseVisualStyleBackColor = true;
            this.radioGenelPersonel.CheckedChanged += new System.EventHandler(this.radioGenelPersonel_CheckedChanged);
            // 
            // radioBankaGider
            // 
            this.radioBankaGider.AutoSize = true;
            this.radioBankaGider.Location = new System.Drawing.Point(663, 18);
            this.radioBankaGider.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radioBankaGider.Name = "radioBankaGider";
            this.radioBankaGider.Size = new System.Drawing.Size(179, 21);
            this.radioBankaGider.TabIndex = 4;
            this.radioBankaGider.TabStop = true;
            this.radioBankaGider.Text = "Bankadan Çıkan Para";
            this.radioBankaGider.UseVisualStyleBackColor = true;
            this.radioBankaGider.CheckedChanged += new System.EventHandler(this.radioBankaGider_CheckedChanged);
            // 
            // radioPersonelMaas
            // 
            this.radioPersonelMaas.AutoSize = true;
            this.radioPersonelMaas.Location = new System.Drawing.Point(422, 44);
            this.radioPersonelMaas.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radioPersonelMaas.Name = "radioPersonelMaas";
            this.radioPersonelMaas.Size = new System.Drawing.Size(287, 21);
            this.radioPersonelMaas.TabIndex = 3;
            this.radioPersonelMaas.TabStop = true;
            this.radioPersonelMaas.Text = "Banka Personel Maaş Ödeme Raporu";
            this.radioPersonelMaas.UseVisualStyleBackColor = true;
            this.radioPersonelMaas.CheckedChanged += new System.EventHandler(this.radioPersonelMaas_CheckedChanged);
            // 
            // radioBankaGelir
            // 
            this.radioBankaGelir.AutoSize = true;
            this.radioBankaGelir.Location = new System.Drawing.Point(664, 66);
            this.radioBankaGelir.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radioBankaGelir.Name = "radioBankaGelir";
            this.radioBankaGelir.Size = new System.Drawing.Size(171, 21);
            this.radioBankaGelir.TabIndex = 1;
            this.radioBankaGelir.TabStop = true;
            this.radioBankaGelir.Text = "Bankaya Gelen Para";
            this.radioBankaGelir.UseVisualStyleBackColor = true;
            this.radioBankaGelir.CheckedChanged += new System.EventHandler(this.radioBankaGelir_CheckedChanged);
            // 
            // radioGenelBanka
            // 
            this.radioGenelBanka.AutoSize = true;
            this.radioGenelBanka.Location = new System.Drawing.Point(5, 43);
            this.radioGenelBanka.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radioGenelBanka.Name = "radioGenelBanka";
            this.radioGenelBanka.Size = new System.Drawing.Size(171, 21);
            this.radioGenelBanka.TabIndex = 0;
            this.radioGenelBanka.TabStop = true;
            this.radioGenelBanka.Text = "Tüm Banka İşlemleri";
            this.radioGenelBanka.UseVisualStyleBackColor = true;
            this.radioGenelBanka.CheckedChanged += new System.EventHandler(this.radioGenelBanka_CheckedChanged);
            // 
            // RaporDokumGoruntuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(994, 583);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Rockwell", 8F);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "RaporDokumGoruntuleForm";
            this.Text = "Raporlar";
            this.Load += new System.EventHandler(this.RaporDokumGoruntuleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioBankaGider;
        private System.Windows.Forms.RadioButton radioPersonelMaas;
        private System.Windows.Forms.RadioButton radioBankaGelir;
        private System.Windows.Forms.RadioButton radioGenelBanka;
        private System.Windows.Forms.RadioButton radioVadesizHesap;
        private System.Windows.Forms.RadioButton radioVadeliHesap;
        private System.Windows.Forms.RadioButton radioKrediHesap;
        private System.Windows.Forms.RadioButton radioGenelMusteri;
        private System.Windows.Forms.RadioButton radioGenelPersonel;
        private System.Windows.Forms.Button button1;
    }
}