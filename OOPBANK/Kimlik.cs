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
    public partial class Kimlik : Form
    {
        Banka Bankam;
        long id;
        BireyselMusteri b;
        public Kimlik(Banka Banka,long id)
        {
            InitializeComponent();
            this.Bankam = Banka;
            this.id = id;
            b = Bankam.BireyselMusteriList.Find(x => x.MID == id);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            b.Kimlik.Adi = txtAd.Text;
            b.Kimlik.AnaAdi = txtAna.Text;
            b.Kimlik.BabaAdi = txtBaba.Text;
            b.Kimlik.Cinsiyet = txtC.Text;
            b.Kimlik.DogumTarihi =Convert.ToDateTime (txtDT.Text);
            b.Kimlik.DogumYeri = txtDY.Text;
            b.Kimlik.KanGrubu = txtKan.Text;
            b.Kimlik.MedeniHali = txtMedeni.Text;
            b.Kimlik.Soyadi = txtSoyad.Text;
            b.Kimlik.TCNo = Convert.ToInt64(txtTC.Text);
            Bankam.IslemKayit(Convert.ToInt64(Bankam.OnlineKisi), b.MID, 300, Bankam.OnlineKisi.ToString() + " 'Nolu Bireysel -> Müşterinin KİMLİK Bilgileri Güncelledi.");
        }

        private void Kimlik_Load(object sender, EventArgs e)
        {
            txtAd.Enabled = false;
            txtAna.Enabled = false;
            txtBaba.Enabled = false;
            txtC.Enabled = false;
            txtDT.Enabled = false;
            txtDY.Enabled = false;
            txtKan.Enabled = false;
            txtMedeni.Enabled = false;
            txtSoyad.Enabled = false;
            txtTC.Enabled = false;
            btnGuncelle.Visible = false;
            txtAd.Text = b.Kimlik.Adi;
            txtAna.Text = b.Kimlik.AnaAdi;
            txtBaba.Text = b.Kimlik.BabaAdi;
            txtC.Text = b.Kimlik.Cinsiyet;
            txtDT.Text = b.Kimlik.DogumTarihi.ToShortDateString();
            txtDY.Text = b.Kimlik.DogumYeri;
            txtKan.Text = b.Kimlik.KanGrubu;
            txtMedeni.Text = b.Kimlik.MedeniHali;
            txtSoyad.Text = b.Kimlik.Soyadi;
            txtTC.Text = b.Kimlik.TCNo.ToString();
            lbID.Text="ID #"+b.MID;
            lbMusteriAd.Text = b.Kimlik.Adi + " " + b.Kimlik.Soyadi;
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                txtAd.Enabled = true;
                txtAna.Enabled = true;
                txtBaba.Enabled = true;
                txtC.Enabled = true;
                txtDT.Enabled = true;
                txtDY.Enabled = true;
                txtKan.Enabled = true;
                txtMedeni.Enabled = true;
                txtSoyad.Enabled = true;
                txtTC.Enabled = true;
                btnGuncelle.Visible = true;
            }
            else
            {
                txtAd.Enabled = false;
                txtAna.Enabled = false;
                txtBaba.Enabled = false;
                txtC.Enabled = false;
                txtDT.Enabled = false;
                txtDY.Enabled = false;
                txtKan.Enabled = false;
                txtMedeni.Enabled = false;
                txtSoyad.Enabled = false;
                txtTC.Enabled = false;
                btnGuncelle.Visible = false;
            }
        }
    }
}
