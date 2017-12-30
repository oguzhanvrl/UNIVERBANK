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
    public partial class Firma : Form
    {
        Banka Bankam;
        long id;
        KurumsalMusteri k;
        public Firma(Banka Banka,long id)
        {
            InitializeComponent();
            this.Bankam = Banka;
            this.id = id;
            k = Bankam.KurumsalMusteriList.Find(x => x.MID == id);
        }

        private void Firma_Load(object sender, EventArgs e)
        {
            txtFirmaAd.Enabled = false;
            txtFirmaC.Enabled = false;
            txtFirmaMV.Enabled = false;
            txtVergiD.Enabled = false;
            txtVergiNo.Enabled = false;
            lbAd.Text = k.Firma.FirmaAd;
            lbID.Text = "ID #"+k.MID;
            btnGuncelle.Visible = false;
            txtFirmaAd.Text = k.Firma.FirmaAd;
            txtFirmaC.Text = k.FirmaCirosu.ToString();
            txtFirmaMV.Text = k.FirmaMalVarlik.ToString();
            txtVergiD.Text = k.Firma.VergiDaire;
            txtVergiNo.Text = k.Firma.VergiNo.ToString();
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if(!checkBox1.Checked)
            {
                txtFirmaAd.Enabled = false;
                txtFirmaC.Enabled = false;
                txtFirmaMV.Enabled = false;
                txtVergiD.Enabled = false;
                txtVergiNo.Enabled = false;
                btnGuncelle.Visible = false;
            }
            else
            {
                txtFirmaAd.Enabled = true;
                txtFirmaC.Enabled = true;
                txtFirmaMV.Enabled = true;
                txtVergiD.Enabled = true;
                txtVergiNo.Enabled = true;
                btnGuncelle.Visible = true;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            k.FirmaCirosu = Convert.ToDecimal(txtFirmaC.Text);
            k.FirmaMalVarlik = Convert.ToDecimal(txtFirmaMV.Text);
            k.Firma.FirmaAd = txtFirmaAd.Text;
            k.Firma.VergiDaire = txtVergiD.Text;
            k.Firma.VergiNo = Convert.ToInt64(txtVergiNo.Text);
            Bankam.IslemKayit(Convert.ToInt64(Bankam.OnlineKisi), k.MID, 300, Bankam.OnlineKisi.ToString() + " 'Nolu Kurumsal -> Müşterinin FİRMA Bilgileri Güncelledi.");
        }
    }
}
