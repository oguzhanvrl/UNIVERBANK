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
    public partial class Iletisim : Form
    {
        Banka Bankam;
        BireyselMusteri b;
        KurumsalMusteri k;
        long x;
        int islem;
        public Iletisim(Banka Banka,long id,int islem)
        {
            InitializeComponent();
            this.Bankam = Banka;
            if (id < 17999)
                b = Bankam.BireyselMusteriList.Find(x => x.MID == id);
            else
                k = Bankam.KurumsalMusteriList.Find(x => x.MID == id);
            x = id;
            this.islem = islem;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBilgiGuncelle_Click(object sender, EventArgs e)
        {
            if(islem%2==0)
            {
                b.Iletisim.Adres = txtAdres.Text;
                b.Iletisim.CepTel = txtTel.Text;
                b.Iletisim.Mail = txtMail.Text;
                Bankam.IslemKayit(Convert.ToInt64(Bankam.OnlineKisi), b.MID, 300, Bankam.OnlineKisi.ToString() + " 'Nolu Bireysel -> Müşterinin İLETİŞİM Bilgileri Güncelledi.");
            }
            else if(islem%2==1)
            {
                k.Firma.Adres = txtAdres.Text;
                k.Firma.Mail = txtMail.Text;
                k.Firma.Tel = txtTel.Text;
                Bankam.IslemKayit(Convert.ToInt64(Bankam.OnlineKisi), k.MID, 300, Bankam.OnlineKisi.ToString() + " 'Nolu Kurumsal -> Müşterinin İLETİŞİM Bilgileri Güncelledi.");
            }


        }

        private void Iletisim_Load(object sender, EventArgs e)
        {
            
            if (islem%2==1)
            {
                txtAdres.Text = k.Firma.Adres;
                txtMail.Text = k.Firma.Mail;
                txtTel.Text = k.Firma.Tel;
                lbID.Text = "ID #"+k.MID.ToString();
                lbMusteriAdi.Text = k.Firma.FirmaAd;
            }
            else if(islem%2==0)
            {
                txtAdres.Text = b.Iletisim.Adres;
                txtMail.Text = b.Iletisim.Mail;
                txtTel.Text = b.Iletisim.CepTel;
                lbID.Text = "ID #" + b.MID.ToString();
                lbMusteriAdi.Text = b.Kimlik.Adi+ " "+b.Kimlik.Soyadi ;
            }
            txtAdres.Enabled = false;
            txtMail.Enabled = false;
            txtTel.Enabled = false;
            btnBilgiGuncelle.Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                txtAdres.Enabled = false;
                txtMail.Enabled = false;
                txtTel.Enabled = false;
                btnBilgiGuncelle.Visible = false;
            }
            else
            {
                txtAdres.Enabled = true;
                txtMail.Enabled = true;
                txtTel.Enabled = true;
                btnBilgiGuncelle.Visible = true;
            }
        }
    }
}
