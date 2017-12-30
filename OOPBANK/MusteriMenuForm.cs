using System;
using System.Collections;
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
    public partial class MusteriMenuForm : Form
    {

        public MusteriMenuForm()
        {
            InitializeComponent();
        }
        Banka BANKA;
        KrediHesabıBasvuruForm krediForm;
        VadeliVadesizHesapAcmaForm hesap;
        RaporDokumGoruntuleForm rapor;
        KurumsalMusteri kmus;
        BireyselMusteri bmus;
        ParaCek paraCek;
        public MusteriMenuForm(Banka Bankam)
        {
            InitializeComponent();
            this.BANKA = Bankam;
             bmus = BANKA.BireyselMusteriList.FirstOrDefault(s => s.MID == BANKA.OnlineKisi);
             kmus = BANKA.KurumsalMusteriList.FirstOrDefault(s => s.MID == BANKA.OnlineKisi);
        }
        private void krediBaşvurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BANKA.OnlineKisi > 18000 && BANKA.OnlineKisi <20000)
                krediForm = new KrediHesabıBasvuruForm(BANKA,kmus);
            else
                krediForm = new KrediHesabıBasvuruForm(BANKA,bmus);
            krediForm.Show();
        }

        private void MusteriMenuForm_Load(object sender, EventArgs e)
        {          
                
        }

        private void vadeliVadesizHesapAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BANKA.OnlineKisi > 18000 && BANKA.OnlineKisi < 20000)
                hesap = new VadeliVadesizHesapAcmaForm(BANKA, kmus);
            else
                hesap = new VadeliVadesizHesapAcmaForm(BANKA, bmus);
            hesap.Show();
        }

        private void çıkışYAPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            BANKA.OnlineKisi = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            paraCek = new ParaCek(BANKA);
            paraCek.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ParaYatir p = new ParaYatir(BANKA);
            p.Show();
        }

        private void raporİşlemÖzetleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BANKA.OnlineKisi > 18000 && BANKA.OnlineKisi < 20000)
                rapor = new RaporDokumGoruntuleForm(BANKA, kmus);
            else
                rapor = new RaporDokumGoruntuleForm(BANKA, bmus);
            rapor.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // taleplist 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HesapListe h = new HesapListe(BANKA);
            h.Show();
        }

        private void hesaplarınıGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            HesapListe h = new HesapListe(BANKA);
            h.Show();
        }
    }
}
