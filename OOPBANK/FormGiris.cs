using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPBANK
{
    public partial class FormGiris : Form
    {
        public Banka BANKAM = new Banka();
        public FormGiris()
        {
            
            InitializeComponent();
        }

        private void FormGiris_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BireyselMusteri b = new BireyselMusteri() { MID = 12345, Sifre = "123" };
            KurumsalMusteri k = new KurumsalMusteri() { MID = 18888, Sifre = "123" };
            VadesizHesap v1 = new VadesizHesap() { HID = 22222, HesapBakiye = 2500 };
            VadesizHesap v2 = new VadesizHesap() { HID = 33333, HesapBakiye = 5000 };
            b.VadesizHesapList.Add(v1);
            k.VadesizHesapList.Add(v2);
            KrediHesap k1 = new KrediHesap() { HID = 44444, Borc = 300 };
            KrediHesap k2 = new KrediHesap() { HID = 55555, Borc = 500 };
            b.KrediHesapList.Add(k1);
            k.KrediHesapList.Add(k2);
            BANKAM.BireyselMusteriList.Add(b);
            BANKAM.KurumsalMusteriList.Add(k);
            VadeliHesap v = new VadeliHesap() { YatirilanPara = 5000 };
            b.VadeliHesapList.Add(v);
            Color c = btnMUSGiris.BackColor;
            btnMUSGiris.BackColor = Color.FromArgb(0, c.R, c.G, c.B);
        } 

        private void btnPersonel_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMUSTalep_Click(object sender, EventArgs e)
        {
            // Müşteriler liste ekle  ONAY : 0
            // İşlemler liste ekle
            BANKAM.OnlineKisi = -1;
            DialogResult sec=  MessageBox.Show("Müşteri Talep Tipinizi Seçiniz ? \n \n * Bireysel Müşteri İçin [EVET] | Kurumsal Müşteri için [HAYIR] \n","Müşteri Talep",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
            if (sec == DialogResult.Yes)
            {  
                MüsteriEkleForm m = new MüsteriEkleForm("bireysel", BANKAM);
                m.Show();
            }
            else if (sec == DialogResult.No)
            {
                MüsteriEkleForm m = new MüsteriEkleForm("kurumsal", BANKAM);
                m.Show();
            }
            else
            {

            }
        }

        private void btnMUSGiris_Click(object sender, EventArgs e)
        {
              
        }

        private void btnATM_Click(object sender, EventArgs e)
        {
            // ATM Sayfasını aç 
            AtmForm atm = new AtmForm();
            atm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RaporDokumGoruntuleForm m = new RaporDokumGoruntuleForm(BANKAM);
            m.Show();
        }

        private void btnPersonel_Click_1(object sender, EventArgs e)
        {
            if (BANKAM.OnlineKisi > 0)
                MessageBox.Show(BANKAM.OnlineKisi.ToString() + "Zaten Aktifsiniz Önce çıkış yapın!");
            else if (BANKAM.OnlineKisi == -1)
                BANKAM.OnlineKisi = 0;
            else
            {
                PersonelIslemForm p = new PersonelIslemForm(BANKAM);
                p.Show();
            }
        }

        private void btnMUSGiris_Click_1(object sender, EventArgs e)
        {
            MusteriGirisPanelForm m = new MusteriGirisPanelForm(BANKAM);
            m.Show();
        }

        private void btnMUSTalep_Click_1(object sender, EventArgs e)
        {
            BANKAM.OnlineKisi = -1;
            DialogResult sec = MessageBox.Show("Müşteri Talep Tipinizi Seçiniz ? \n \n * Bireysel Müşteri İçin [EVET] | Kurumsal Müşteri için [HAYIR] \n", "Müşteri Talep", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (sec == DialogResult.Yes)
            {
                MüsteriEkleForm m = new MüsteriEkleForm("bireysel", BANKAM);
                m.Show();
            }
            else if (sec == DialogResult.No)
            {
                MüsteriEkleForm m = new MüsteriEkleForm("kurumsal", BANKAM);
                m.Show();
            }
            else
            {

            }
        }

        private void btnATM_Click_1(object sender, EventArgs e)
        {
            AtmForm form = new AtmForm();
            form.Show();
        }
    }
}
