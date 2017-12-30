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
    public partial class RaporDokumGoruntuleForm : Form
    {
        public RaporDokumGoruntuleForm()
        {
            InitializeComponent();
        }
        Banka BANKA;
        KurumsalMusteri kmus;
        BireyselMusteri bmus;

        public RaporDokumGoruntuleForm(Banka BANKAM)
        {
            InitializeComponent();
            this.BANKA = BANKAM;
        }

        public RaporDokumGoruntuleForm(Banka BANKAM, BireyselMusteri mus)
        {
            InitializeComponent();
            this.BANKA = BANKAM;
            this.bmus = mus;
        }

        public RaporDokumGoruntuleForm(Banka BANKAM, KurumsalMusteri mus)
        {
            InitializeComponent();
            this.BANKA = BANKAM;
            this.kmus = mus;
        }

        private void RaporDokumGoruntuleForm_Load(object sender, EventArgs e)
        {
          
            if (kmus != null || bmus != null)
            {
                groupBox1.Visible = true;
                groupBox2.Visible = false;
                radioGenelMusteri.Checked = true;
                radioGenelBanka.Checked = false;

                List<Islemler> islemsorgu = BANKA.IslemList.Where(s => s.KimID == BANKA.OnlineKisi || s.HID == BANKA.OnlineKisi).ToList();
                dataGridView1.DataSource = islemsorgu;
            }
            else
            {
                groupBox1.Visible = false;
                groupBox2.Visible = true;
                radioGenelMusteri.Checked = false;
                radioGenelBanka.Checked = true;

                var listIslemler = new BindingList<Islemler>(BANKA.IslemList);
               dataGridView1.DataSource = listIslemler;

            }

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 50;
            dataGridView1.Columns[2].Width = 60;
            dataGridView1.Columns[3].Width = 520;
            dataGridView1.Columns[4].Width = 110;

            DataGridRenklendir();

        }

        private void radioKrediHesap_CheckedChanged(object sender, EventArgs e)
        {
            List<Islemler> islemsorgu = BANKA.IslemList.Where(s => s.KimID == BANKA.OnlineKisi && s.IslemTür == 400).ToList();
            List<Islemler> islemsorgu2 = BANKA.IslemList.Where(s => s.HID == BANKA.OnlineKisi && s.IslemTür == 400).ToList();
            List<Islemler> sorguList = new List<Islemler>();
            foreach (var item in islemsorgu)
            {
                sorguList.Add(item);
            }
            foreach (var item in islemsorgu2)
            {
                sorguList.Add(item);
            }
            dataGridView1.DataSource = sorguList;
            DataGridRenklendir();
        }

        private void radioVadeliHesap_CheckedChanged(object sender, EventArgs e)
        {
            List<Islemler> islemsorgu = BANKA.IslemList.Where(s => s.KimID == BANKA.OnlineKisi && s.IslemTür == 500).ToList();
            List<Islemler> islemsorgu2 = BANKA.IslemList.Where(s => s.HID == BANKA.OnlineKisi && s.IslemTür == 500).ToList();
            List<Islemler> sorguList = new List<Islemler>();
            foreach (var item in islemsorgu)
            {
                sorguList.Add(item);
            }
            foreach (var item in islemsorgu2)
            {
                sorguList.Add(item);
            }
            dataGridView1.DataSource = sorguList;
            DataGridRenklendir();
        }

        private void radioVadesizHesap_CheckedChanged(object sender, EventArgs e)
        {
            List<Islemler> islemsorgu = BANKA.IslemList.Where(s => s.KimID == BANKA.OnlineKisi && s.IslemTür == 600).ToList();
            List<Islemler> islemsorgu2 = BANKA.IslemList.Where(s => s.HID == BANKA.OnlineKisi && s.IslemTür == 600).ToList();
            List<Islemler> sorguList = new List<Islemler>();
            foreach (var item in islemsorgu)
            {
                sorguList.Add(item);
            }
            foreach (var item in islemsorgu2)
            {
                sorguList.Add(item);
            }
            dataGridView1.DataSource = sorguList;
            DataGridRenklendir();
        }

        private void radioGenelBanka_CheckedChanged(object sender, EventArgs e)
        {
            var listIslemler = new BindingList<Islemler>(BANKA.IslemList);
            dataGridView1.DataSource = listIslemler;
            DataGridRenklendir();
        }

        private void radioGenelMusteri_CheckedChanged(object sender, EventArgs e)
        {
            List<Islemler> islemsorgu = BANKA.IslemList.Where(s => s.KimID == BANKA.OnlineKisi || s.HID == BANKA.OnlineKisi).ToList();
            dataGridView1.DataSource = islemsorgu;
            DataGridRenklendir();
        }

        private void radioGenelPersonel_CheckedChanged(object sender, EventArgs e)
        {
            List<Islemler> islemsorgu = BANKA.IslemList.Where(s => s.KimID == BANKA.OnlineKisi || s.HID == BANKA.OnlineKisi).ToList();
            dataGridView1.DataSource = islemsorgu;
            DataGridRenklendir();
        }

        private void radioBankaGelir_CheckedChanged(object sender, EventArgs e)
        {
            List<Islemler> islemsorgu = BANKA.IslemList.Where(s => s.KimID == 1 && s.IslemTür == 130).ToList();
            dataGridView1.DataSource = islemsorgu;
            DataGridRenklendir();
        }

        private void radioBankaGider_CheckedChanged(object sender, EventArgs e)
        {
            List<Islemler> islemsorgu = BANKA.IslemList.Where(s => s.KimID == 1 && s.IslemTür == 120).ToList();
            dataGridView1.DataSource = islemsorgu;
            DataGridRenklendir();
        }

        private void radioPersonelMaas_CheckedChanged(object sender, EventArgs e)
        {
            List<Islemler> islemsorgu = BANKA.IslemList.Where(s => s.KimID == 1 && s.IslemTür == 140).ToList();
            dataGridView1.DataSource = islemsorgu;
            DataGridRenklendir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FinansRaporuForm raporfinans = new FinansRaporuForm(BANKA);
            MessageBox.Show("> Banka Açılış Tarihi :" + BANKA.KurulusTarih.ToString() + "\n> Banka Başlangıç Hazinesi : 5.000.000 ₺ \n \n --> Güncel Banka Hazinesi : " + BANKA.BankaHazinesi.ToString() + " ₺ ", "UNIVER-BANK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            raporfinans.Show();
        }

        public void DataGridRenklendir()
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                Application.DoEvents();
                // Math.DivRem(i, 2, out sayi);
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value) == 1)
                {
                    renk.BackColor = Color.White;
                    renk.ForeColor = Color.White;
                }
                else if (Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value) == 200)
                {
                    renk.BackColor = Color.Orange;
                    renk.ForeColor = Color.White;
                }
                else if (Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value) == 300)
                {
                    renk.BackColor = Color.Blue;
                    renk.ForeColor = Color.White;
                }
                else if (Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value) == 400)
                {
                    renk.BackColor = Color.Pink;
                    renk.ForeColor = Color.White;
                }
                else if (Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value) == 500)
                {
                    renk.BackColor = Color.Purple;
                    renk.ForeColor = Color.White;
                }
                else if (Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value) == 600)
                {
                    renk.BackColor = Color.Silver;
                    renk.ForeColor = Color.White;
                }
                else
                {
                    renk.BackColor = Color.White;
                    renk.ForeColor = Color.YellowGreen;
                }
                dataGridView1.Rows[i].DefaultCellStyle = renk;
            }
        }

    }


}
