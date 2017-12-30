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
    public partial class PersonelIslemMenu : Form
    {
        Banka Bankam;
        RaporDokumGoruntuleForm rapor;
        public PersonelIslemMenu()
        {
            InitializeComponent();
        }

        public PersonelIslemMenu(Banka BANKA)
        {
            InitializeComponent();
            this.Bankam = BANKA;
        }

        private void müşteriListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void PersonelIslemMenu_Load(object sender, EventArgs e)
        {

        }

        private void yeniPersonelEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelEkleForm p = new PersonelEkleForm(Bankam);
            //p.MdiParent = this;
            p.Show();
        }

        private void personelListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelListForm p = new PersonelListForm(Bankam,0);
            p.Show();
        }

        private void çıkışYAPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Bankam.OnlineKisi.ToString()+" --> Çıkış Yapıldı !");
            Bankam.OnlineKisi = 0;
            this.Close();

        }

        private void bireyselMüşteriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string mustipi = "bireysel";
            MüsteriEkleForm mb = new MüsteriEkleForm(mustipi,Bankam);
            this.Close();
            mb.Show();

        }

        private void kurumsalMüşteriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string mustipi = "kurumsal";
            MüsteriEkleForm mk = new MüsteriEkleForm(mustipi, Bankam);
            this.Close();
            mk.Show();
        }

        private void müşterilerinListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusteriLisForm mus = new MusteriLisForm(Bankam,0);
            mus.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Personeller p = new Personeller(Bankam);
            p.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PersonelListForm p = new PersonelListForm(Bankam,2);
            p.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PersonelListForm p = new PersonelListForm(Bankam, 1);
            p.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MusteriLisForm m1 = new MusteriLisForm(Bankam, 1);
            m1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MusteriLisForm m1 = new MusteriLisForm(Bankam, 2);
            m1.Show();
        }

        private void raporİşlermÖzetleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RaporDokumGoruntuleForm r = new RaporDokumGoruntuleForm(Bankam);
            r.Show();
        }
    }
}
