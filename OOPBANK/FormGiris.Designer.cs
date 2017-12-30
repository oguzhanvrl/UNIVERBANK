namespace OOPBANK
{
    partial class FormGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGiris));
            this.btnMUSTalep = new System.Windows.Forms.Button();
            this.btnPersonel = new System.Windows.Forms.Button();
            this.btnATM = new System.Windows.Forms.Button();
            this.btnMUSGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMUSTalep
            // 
            this.btnMUSTalep.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMUSTalep.Location = new System.Drawing.Point(1112, 826);
            this.btnMUSTalep.Name = "btnMUSTalep";
            this.btnMUSTalep.Size = new System.Drawing.Size(160, 126);
            this.btnMUSTalep.TabIndex = 22;
            this.btnMUSTalep.Text = "Müşteri Talep";
            this.btnMUSTalep.UseVisualStyleBackColor = false;
            this.btnMUSTalep.Click += new System.EventHandler(this.btnMUSTalep_Click_1);
            // 
            // btnPersonel
            // 
            this.btnPersonel.BackColor = System.Drawing.Color.Transparent;
            this.btnPersonel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPersonel.BackgroundImage")));
            this.btnPersonel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPersonel.Location = new System.Drawing.Point(1357, 564);
            this.btnPersonel.Name = "btnPersonel";
            this.btnPersonel.Size = new System.Drawing.Size(160, 126);
            this.btnPersonel.TabIndex = 19;
            this.btnPersonel.UseVisualStyleBackColor = false;
            this.btnPersonel.Click += new System.EventHandler(this.btnPersonel_Click_1);
            // 
            // btnATM
            // 
            this.btnATM.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnATM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnATM.Location = new System.Drawing.Point(122, 696);
            this.btnATM.Name = "btnATM";
            this.btnATM.Size = new System.Drawing.Size(130, 93);
            this.btnATM.TabIndex = 20;
            this.btnATM.Text = "ATM Kullan";
            this.btnATM.UseVisualStyleBackColor = false;
            this.btnATM.Click += new System.EventHandler(this.btnATM_Click_1);
            // 
            // btnMUSGiris
            // 
            this.btnMUSGiris.BackColor = System.Drawing.Color.Transparent;
            this.btnMUSGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMUSGiris.BackgroundImage")));
            this.btnMUSGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMUSGiris.Location = new System.Drawing.Point(873, 564);
            this.btnMUSGiris.Name = "btnMUSGiris";
            this.btnMUSGiris.Size = new System.Drawing.Size(160, 126);
            this.btnMUSGiris.TabIndex = 21;
            this.btnMUSGiris.UseVisualStyleBackColor = false;
            this.btnMUSGiris.Click += new System.EventHandler(this.btnMUSGiris_Click_1);
            // 
            // FormGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1469, 905);
            this.Controls.Add(this.btnMUSTalep);
            this.Controls.Add(this.btnMUSGiris);
            this.Controls.Add(this.btnATM);
            this.Controls.Add(this.btnPersonel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FormGiris";
            this.Text = "FormGiris";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.FormGiris_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMUSTalep;
        private System.Windows.Forms.Button btnPersonel;
        private System.Windows.Forms.Button btnATM;
        private System.Windows.Forms.Button btnMUSGiris;
    }
}