namespace OOPBANK
{
    partial class MusteriLisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriLisForm));
            this.dgMUSLIS = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtARA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgMULIS2 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detaylarıGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.detaylarıGörüntüleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgMUSLIS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMULIS2)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgMUSLIS
            // 
            this.dgMUSLIS.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgMUSLIS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMUSLIS.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dgMUSLIS.Location = new System.Drawing.Point(18, 126);
            this.dgMUSLIS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgMUSLIS.Name = "dgMUSLIS";
            this.dgMUSLIS.RowTemplate.Height = 24;
            this.dgMUSLIS.Size = new System.Drawing.Size(1503, 426);
            this.dgMUSLIS.TabIndex = 0;
            this.dgMUSLIS.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgMUSLIS_CellMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(118, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "MÜŞTERİ ID :";
            // 
            // txtARA
            // 
            this.txtARA.Location = new System.Drawing.Point(286, 43);
            this.txtARA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtARA.Name = "txtARA";
            this.txtARA.Size = new System.Drawing.Size(148, 31);
            this.txtARA.TabIndex = 2;
            this.txtARA.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(543, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "TextChange Özelliği vardır!";
            // 
            // dgMULIS2
            // 
            this.dgMULIS2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgMULIS2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMULIS2.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dgMULIS2.Location = new System.Drawing.Point(18, 583);
            this.dgMULIS2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgMULIS2.Name = "dgMULIS2";
            this.dgMULIS2.RowTemplate.Height = 24;
            this.dgMULIS2.Size = new System.Drawing.Size(1503, 426);
            this.dgMULIS2.TabIndex = 4;
            this.dgMULIS2.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgMULIS2_CellMouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem,
            this.detaylarıGörüntüleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(208, 52);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.silToolStripMenuItem.Text = "Sil";
            // 
            // detaylarıGörüntüleToolStripMenuItem
            // 
            this.detaylarıGörüntüleToolStripMenuItem.Name = "detaylarıGörüntüleToolStripMenuItem";
            this.detaylarıGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.detaylarıGörüntüleToolStripMenuItem.Text = "Detayları Görüntüle";
            this.detaylarıGörüntüleToolStripMenuItem.Click += new System.EventHandler(this.detaylarıGörüntüleToolStripMenuItem_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem1,
            this.detaylarıGörüntüleToolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(208, 52);
            // 
            // silToolStripMenuItem1
            // 
            this.silToolStripMenuItem1.Name = "silToolStripMenuItem1";
            this.silToolStripMenuItem1.Size = new System.Drawing.Size(207, 24);
            this.silToolStripMenuItem1.Text = "Sil";
            // 
            // detaylarıGörüntüleToolStripMenuItem1
            // 
            this.detaylarıGörüntüleToolStripMenuItem1.Name = "detaylarıGörüntüleToolStripMenuItem1";
            this.detaylarıGörüntüleToolStripMenuItem1.Size = new System.Drawing.Size(207, 24);
            this.detaylarıGörüntüleToolStripMenuItem1.Text = "Detayları Görüntüle";
            this.detaylarıGörüntüleToolStripMenuItem1.Click += new System.EventHandler(this.detaylarıGörüntüleToolStripMenuItem1_Click);
            // 
            // MusteriLisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1566, 1030);
            this.Controls.Add(this.dgMULIS2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtARA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgMUSLIS);
            this.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MusteriLisForm";
            this.Text = "Müşteri Listesi";
            this.Load += new System.EventHandler(this.MusteriLisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMUSLIS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMULIS2)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgMUSLIS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtARA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgMULIS2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detaylarıGörüntüleToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem detaylarıGörüntüleToolStripMenuItem1;
    }
}