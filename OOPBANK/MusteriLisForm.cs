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
    public partial class MusteriLisForm : Form
    {
        public MusteriLisForm()
        {
            InitializeComponent();
        }
        Banka Bankam;
        int islem,satirb=0,sutunb=0,satirk=0,sutunk=0;
        public MusteriLisForm(Banka BANKA,int islem)
        {
            InitializeComponent();
            this.Bankam = BANKA;
            this.islem = islem;
        }

        private void detaylarıGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sutunb == 8)
            {
                Iletisim i = new Iletisim(Bankam, Convert.ToInt64(dgMUSLIS.Rows[satirb].Cells[4].Value), 0);
                i.Show();
            }
            else if (sutunb == 9)
            {
                Kimlik k = new Kimlik(Bankam, Convert.ToInt64(dgMUSLIS.Rows[satirb].Cells[4].Value));
                k.Show();
            }
        }

        private void detaylarıGörüntüleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (sutunk == 8)
            {
                Iletisim i = new Iletisim(Bankam, Convert.ToInt64(dgMULIS2.Rows[satirk].Cells[4].Value), 1);
                i.Show();
            }
            else if (sutunk == 9)
            {
                Firma f = new Firma(Bankam, Convert.ToInt64(dgMULIS2.Rows[satirk].Cells[4].Value));
                f.Show();
            }
        }

        private void MusteriLisForm_Load(object sender, EventArgs e)
        {
            if(islem==0)
            {
                var listBireysel = new BindingList<BireyselMusteri>(Bankam.BireyselMusteriList);
                var listKurumsal = new BindingList<KurumsalMusteri>(Bankam.KurumsalMusteriList);
                dgMUSLIS.DataSource = listBireysel;
                dgMULIS2.DataSource = listKurumsal;
            }
            
            else if(islem==1)
            {
                var listb = from p in Bankam.BireyselMusteriList where p.Onay == false select p;
                var listBireysel = new BindingList<BireyselMusteri>(listb.ToList());
                var listk = from p in Bankam.KurumsalMusteriList where p.Onay == false select p;
                var listKurumsal = new BindingList<KurumsalMusteri>(listk.ToList());
                dgMUSLIS.DataSource = listBireysel;
                dgMULIS2.DataSource = listKurumsal;
            }
            else if(islem==2)
            {
                var listb = from p in Bankam.BireyselMusteriList where p.Onay == true select p;
                var listBireysel = new BindingList<BireyselMusteri>(listb.ToList());
                var listk = from p in Bankam.KurumsalMusteriList where p.Onay == true select p;
                var listKurumsal = new BindingList<KurumsalMusteri>(listk.ToList());
                dgMUSLIS.DataSource = listBireysel;
                dgMULIS2.DataSource = listKurumsal;
            }
            dgMULIS2.Columns[9].HeaderText = "ŞirketBilgileri";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        { 
            if(islem==0)
            {
                var Sonuc = from p in Bankam.BireyselMusteriList
                            where p.MID.ToString().StartsWith(txtARA.Text.ToString())
                            select p;

                var Sonuc2 = from p in Bankam.KurumsalMusteriList
                             where p.MID.ToString().StartsWith(txtARA.Text.ToString())
                             select p;

                var listBireysel = new BindingList<BireyselMusteri>(Sonuc.ToList());
                dgMUSLIS.DataSource = listBireysel;

                var listKurumsal = new BindingList<KurumsalMusteri>(Sonuc2.ToList());
                dgMULIS2.DataSource = listKurumsal;
            }
            else if(islem==1)
            {
                var Sonuc = from p in Bankam.BireyselMusteriList
                            where p.Onay==false&& p.MID.ToString().StartsWith(txtARA.Text.ToString())
                            select p;

                var Sonuc2 = from p in Bankam.KurumsalMusteriList
                             where p.Onay==false&& p.MID.ToString().StartsWith(txtARA.Text.ToString())
                             select p;

                var listBireysel = new BindingList<BireyselMusteri>(Sonuc.ToList());
                dgMUSLIS.DataSource = listBireysel;

                var listKurumsal = new BindingList<KurumsalMusteri>(Sonuc2.ToList());
                dgMULIS2.DataSource = listKurumsal;
            }
            else if(islem==2)
            {
                var Sonuc = from p in Bankam.BireyselMusteriList
                            where p.Onay == true && p.MID.ToString().StartsWith(txtARA.Text.ToString())
                            select p;

                var Sonuc2 = from p in Bankam.KurumsalMusteriList
                             where p.Onay == true && p.MID.ToString().StartsWith(txtARA.Text.ToString())
                             select p;

                var listBireysel = new BindingList<BireyselMusteri>(Sonuc.ToList());
                dgMUSLIS.DataSource = listBireysel;

                var listKurumsal = new BindingList<KurumsalMusteri>(Sonuc2.ToList());
                dgMULIS2.DataSource = listKurumsal;
            }
            dgMULIS2.Columns[9].HeaderText = "ŞirketBilgileri";
        }

        private void dgMUSLIS_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgMUSLIS.MultiSelect = false;
            if (e.Button == MouseButtons.Left && e.RowIndex != -1)
            {
                satirb = e.RowIndex;
                sutunb = e.ColumnIndex;
            }
            else if (e.Button == MouseButtons.Right)
                contextMenuStrip1.Show(Cursor.Position);
        }

        private void dgMULIS2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgMULIS2.MultiSelect = false;
            if (e.Button == MouseButtons.Left && e.RowIndex != -1)
            {
                satirk = e.RowIndex;
                sutunk = e.ColumnIndex;
            }
            else if (e.Button == MouseButtons.Right)
                contextMenuStrip2.Show(Cursor.Position);
        }
    }
}
