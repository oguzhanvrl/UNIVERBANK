using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPBANK
{
    public partial class FinansRaporuForm : Form
    {
        public FinansRaporuForm()
        {
            InitializeComponent();
        }
        Banka BANKA;
        public FinansRaporuForm(Banka BANKAM)
        {
            InitializeComponent();
            this.BANKA = BANKAM;
        }

        private void FinansRaporuForm_Load(object sender, EventArgs e)
        {
      
            

            List<Islemler> islemsorgu = BANKA.IslemList.Where(s => s.KimID == 1).ToList();
            dataGridView1.DataSource = islemsorgu;

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 50;
            dataGridView1.Columns[2].Width = 60;
            dataGridView1.Columns[3].Width = 520;
            dataGridView1.Columns[4].Width = 110;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                Application.DoEvents();
                // Math.DivRem(i, 2, out sayi);
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value) == 120)
                {
                    renk.BackColor = Color.Red;
                    renk.ForeColor = Color.White;
                }
                else if (Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value) == 130)
                {
                    renk.BackColor = Color.Green;
                    renk.ForeColor = Color.White;
                }
              else
                {
                    renk.BackColor = Color.White;
                    renk.ForeColor = Color.Purple;
                }
                dataGridView1.Rows[i].DefaultCellStyle = renk;
            }

        }
    }
}
