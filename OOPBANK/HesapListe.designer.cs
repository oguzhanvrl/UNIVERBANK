namespace OOPBANK
{
    partial class HesapListe
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HesapListe));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hesabıSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabHesaplar = new System.Windows.Forms.TabControl();
            this.tabVadeli = new System.Windows.Forms.TabPage();
            this.dgVadeli = new System.Windows.Forms.DataGridView();
            this.tabVadesiz = new System.Windows.Forms.TabPage();
            this.dgVadesiz = new System.Windows.Forms.DataGridView();
            this.tabKredi = new System.Windows.Forms.TabPage();
            this.dgKredi = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hesabıBozToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hesabıSilToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.tabHesaplar.SuspendLayout();
            this.tabVadeli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVadeli)).BeginInit();
            this.tabVadesiz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVadesiz)).BeginInit();
            this.tabKredi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgKredi)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hesabıSilToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(145, 28);
            // 
            // hesabıSilToolStripMenuItem
            // 
            this.hesabıSilToolStripMenuItem.Name = "hesabıSilToolStripMenuItem";
            this.hesabıSilToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.hesabıSilToolStripMenuItem.Text = "Hesabı Sil";
            this.hesabıSilToolStripMenuItem.Click += new System.EventHandler(this.hesabıSilToolStripMenuItem_Click);
            // 
            // tabHesaplar
            // 
            this.tabHesaplar.Controls.Add(this.tabVadeli);
            this.tabHesaplar.Controls.Add(this.tabVadesiz);
            this.tabHesaplar.Controls.Add(this.tabKredi);
            this.tabHesaplar.Location = new System.Drawing.Point(22, 16);
            this.tabHesaplar.Margin = new System.Windows.Forms.Padding(4);
            this.tabHesaplar.Name = "tabHesaplar";
            this.tabHesaplar.SelectedIndex = 0;
            this.tabHesaplar.Size = new System.Drawing.Size(1612, 710);
            this.tabHesaplar.TabIndex = 5;
            this.tabHesaplar.SelectedIndexChanged += new System.EventHandler(this.tabHesaplar_SelectedIndexChanged);
            this.tabHesaplar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabHesaplar_MouseClick);
            // 
            // tabVadeli
            // 
            this.tabVadeli.Controls.Add(this.dgVadeli);
            this.tabVadeli.Location = new System.Drawing.Point(4, 31);
            this.tabVadeli.Margin = new System.Windows.Forms.Padding(4);
            this.tabVadeli.Name = "tabVadeli";
            this.tabVadeli.Padding = new System.Windows.Forms.Padding(4);
            this.tabVadeli.Size = new System.Drawing.Size(1604, 675);
            this.tabVadeli.TabIndex = 0;
            this.tabVadeli.Text = "Vadeli";
            this.tabVadeli.UseVisualStyleBackColor = true;
            // 
            // dgVadeli
            // 
            this.dgVadeli.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgVadeli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVadeli.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dgVadeli.Location = new System.Drawing.Point(9, 8);
            this.dgVadeli.Margin = new System.Windows.Forms.Padding(4);
            this.dgVadeli.Name = "dgVadeli";
            this.dgVadeli.RowTemplate.Height = 24;
            this.dgVadeli.Size = new System.Drawing.Size(1582, 653);
            this.dgVadeli.TabIndex = 0;
            this.dgVadeli.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVadeli_CellClick);
            this.dgVadeli.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgVadeli_CellMouseClick);
            this.dgVadeli.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgVadeli_MouseClick);
            // 
            // tabVadesiz
            // 
            this.tabVadesiz.Controls.Add(this.dgVadesiz);
            this.tabVadesiz.Location = new System.Drawing.Point(4, 31);
            this.tabVadesiz.Margin = new System.Windows.Forms.Padding(4);
            this.tabVadesiz.Name = "tabVadesiz";
            this.tabVadesiz.Padding = new System.Windows.Forms.Padding(4);
            this.tabVadesiz.Size = new System.Drawing.Size(1604, 675);
            this.tabVadesiz.TabIndex = 1;
            this.tabVadesiz.Text = "Vadesiz";
            this.tabVadesiz.UseVisualStyleBackColor = true;
            // 
            // dgVadesiz
            // 
            this.dgVadesiz.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgVadesiz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVadesiz.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dgVadesiz.Location = new System.Drawing.Point(9, 8);
            this.dgVadesiz.Margin = new System.Windows.Forms.Padding(4);
            this.dgVadesiz.Name = "dgVadesiz";
            this.dgVadesiz.RowTemplate.Height = 24;
            this.dgVadesiz.Size = new System.Drawing.Size(1582, 653);
            this.dgVadesiz.TabIndex = 0;
            this.dgVadesiz.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVadesiz_CellClick);
            this.dgVadesiz.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgVadesiz_CellMouseClick);
            this.dgVadesiz.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgVadesiz_MouseClick);
            // 
            // tabKredi
            // 
            this.tabKredi.Controls.Add(this.dgKredi);
            this.tabKredi.Location = new System.Drawing.Point(4, 31);
            this.tabKredi.Margin = new System.Windows.Forms.Padding(4);
            this.tabKredi.Name = "tabKredi";
            this.tabKredi.Padding = new System.Windows.Forms.Padding(4);
            this.tabKredi.Size = new System.Drawing.Size(1604, 675);
            this.tabKredi.TabIndex = 2;
            this.tabKredi.Text = "Kredi";
            this.tabKredi.UseVisualStyleBackColor = true;
            // 
            // dgKredi
            // 
            this.dgKredi.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgKredi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKredi.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dgKredi.Location = new System.Drawing.Point(9, 8);
            this.dgKredi.Margin = new System.Windows.Forms.Padding(4);
            this.dgKredi.Name = "dgKredi";
            this.dgKredi.RowTemplate.Height = 24;
            this.dgKredi.Size = new System.Drawing.Size(1582, 653);
            this.dgKredi.TabIndex = 0;
            this.dgKredi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgKredi_CellClick);
            this.dgKredi.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgKredi_CellMouseClick);
            this.dgKredi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgKredi_MouseClick);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hesabıBozToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(154, 28);
            // 
            // hesabıBozToolStripMenuItem
            // 
            this.hesabıBozToolStripMenuItem.Name = "hesabıBozToolStripMenuItem";
            this.hesabıBozToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.hesabıBozToolStripMenuItem.Text = "Hesabı Boz";
            this.hesabıBozToolStripMenuItem.Click += new System.EventHandler(this.hesabıBozToolStripMenuItem_Click);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hesabıSilToolStripMenuItem1});
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(176, 56);
            // 
            // hesabıSilToolStripMenuItem1
            // 
            this.hesabıSilToolStripMenuItem1.Name = "hesabıSilToolStripMenuItem1";
            this.hesabıSilToolStripMenuItem1.Size = new System.Drawing.Size(175, 24);
            this.hesabıSilToolStripMenuItem1.Text = "Hesabı Sil";
            this.hesabıSilToolStripMenuItem1.Click += new System.EventHandler(this.hesabıSilToolStripMenuItem1_Click);
            // 
            // HesapListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1653, 742);
            this.Controls.Add(this.tabHesaplar);
            this.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HesapListe";
            this.Text = "HesapListe";
            this.Load += new System.EventHandler(this.HesapListe_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabHesaplar.ResumeLayout(false);
            this.tabVadeli.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgVadeli)).EndInit();
            this.tabVadesiz.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgVadesiz)).EndInit();
            this.tabKredi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgKredi)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hesabıSilToolStripMenuItem;
        private System.Windows.Forms.TabControl tabHesaplar;
        private System.Windows.Forms.TabPage tabVadeli;
        private System.Windows.Forms.DataGridView dgVadeli;
        private System.Windows.Forms.TabPage tabVadesiz;
        private System.Windows.Forms.DataGridView dgVadesiz;
        private System.Windows.Forms.TabPage tabKredi;
        private System.Windows.Forms.DataGridView dgKredi;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem hesabıBozToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem hesabıSilToolStripMenuItem1;
    }
}