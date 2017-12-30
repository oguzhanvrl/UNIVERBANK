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
    public partial class MüsteriEkleForm : Form
    {
        public MüsteriEkleForm()
        {
            InitializeComponent();
        }
        Banka BANKA;
        BireyselMusteri bmus;
        KurumsalMusteri kmus;
        string musTip;
        bool onay;
        List<Hesap> hesap = new List<Hesap>();
        public MüsteriEkleForm(string tip, Banka Bankam)
        {
            InitializeComponent();
            this.BANKA = Bankam;
            
            if (BANKA.OnlineKisi < 15000 && BANKA.OnlineKisi >= 10000)
            {
                btnMTALEP.Visible = false; //personelll
                onay = true;
            }
            else
            {
                btnMEKLE.Visible = false; // müşteri talep
                onay = false;
            }

            musTip = tip;

            if (tip == "bireysel")
            {
                grpFIRMA.Visible = false;
                grpKRMSL.Visible = false;
            }
            else
                grpBRYSL.Visible = false;
        }

        private void MüsteriEkleForm_Load(object sender, EventArgs e)
        {

        }

        private void brnMENU_Click(object sender, EventArgs e)
        {
            PersonelIslemMenu menu = new PersonelIslemMenu(BANKA);
            this.Close();
            menu.Show();
        }

        private void btnMEKLE_Click(object sender, EventArgs e)
        {
            // işlem kaydı şu personel açıklamada şu idli yeni müşteri ekledi
            if (musTip == "bireysel")
            {
                bmus = new BireyselMusteri(BANKA);
                BireyselMusteriEkle(bmus);
            }
            else
            {
                kmus = new KurumsalMusteri(BANKA);
                KurumsalMusteriEkle(kmus);
            }
            PersonelIslemMenu menu = new PersonelIslemMenu(BANKA);
            if (onay == true) menu.Show();
            this.Close();
        }

        public void BireyselMusteriEkle(BireyselMusteri bmus)
        {
            long musID = 0;
            bmus.Kimlik.TCNo = Convert.ToInt64(txtTCNO.Text);
            bmus.Kimlik.Adi = txtAD.Text;
            bmus.Iletisim.CepTel = txtCEPTEL.Text;

            /* bmus.Kimlik.AnaAdi = txtANAADI.Text;
             bmus.Kimlik.BabaAdi = txtBABAADI.Text;
             bmus.Kimlik.Cinsiyet = txtCINSIYET.Text;
             bmus.Kimlik.DogumTarihi = Convert.ToDateTime(txtDOGUMTARIH.Text);
             bmus.Kimlik.DogumYeri = txtDOGUM.Text;
             bmus.Kimlik.KanGrubu = txtKAN.Text;
             bmus.Kimlik.MedeniHali = txtMEDENIHAL.Text;
             bmus.Kimlik.Soyadi = txtSOYAD.Text;*/


            /*bmus.Iletisim.Adres = txtEVADRES.Text;
            
            bmus.Iletisim.EvTel = txtEVTEL.Text;
            bmus.Iletisim.Il = txtIL.Text;
            bmus.Iletisim.Ilce = txtILCE.Text;
            bmus.Iletisim.Mail = txtMAILADRES.Text;*/

            bmus.AylikGelir = Convert.ToDecimal(txtBRAYLIK.Text);
            bmus.BireyselMalVarlik = Convert.ToInt64(txtBRMAL.Text);
            bmus.AnneKizlikSoyAdi = txtBRKSOY.Text;

            bmus.Sifre = bmus.passSifreleme(txtSIFRE.Text,bmus.MID);
            
            bmus.Onay = onay;

            bmus.BireyselPuanLimit = bmus.MusteriPuanHesapla();

            BANKA.MusteriList.Add(bmus);
            BANKA.BireyselMusteriList.Add(bmus);
            musID = bmus.MID;
            //hesap = bmus.EkHesapveVadesizTLHesapAC(BANKA, musID);

            VadesizHesap v = bmus.VadesizTLAC(BANKA, musID);
            bmus.VadesizHesapList.Add(v);
            KrediHesap k = bmus.EkHesapAC(BANKA, musID);
            bmus.KrediHesapList.Add(k);

            MessageBox.Show(v.HID.ToString() + " NOLU [VADESİZ TL] HESABINIZ ve "+k.HID.ToString()+" NOLU [EK HESABINIZ] --> " + musID.ToString()+ " NOLU Bireysel MUSTERİ Hesabınıza Otomatik olarak tanımlanmıştır.");
            BANKA.IslemKayit(BANKA.OnlineKisi, musID, 300, "Bireysel "+musID.ToString() + "-> Nolu  Müşteri Eklendi.");
        }

        public void KurumsalMusteriEkle(KurumsalMusteri kmus)
        {
            long musID = 0;
            kmus.Kimlik.TCNo = Convert.ToInt64(txtTCNO.Text);
            kmus.Kimlik.Adi = txtAD.Text;
            kmus.Iletisim.CepTel = txtCEPTEL.Text;

            /* kmus.Kimlik.AnaAdi = txtANAADI.Text;
             kmus.Kimlik.BabaAdi = txtBABAADI.Text;
             kmus.Kimlik.Cinsiyet = txtCINSIYET.Text;
             kmus.Kimlik.DogumTarihi = Convert.ToDateTime(txtDOGUMTARIH.Text);
             kmus.Kimlik.DogumYeri = txtDOGUM.Text;
             kmus.Kimlik.KanGrubu = txtKAN.Text;
             kmus.Kimlik.MedeniHali = txtMEDENIHAL.Text;
             kmus.Kimlik.Soyadi = txtSOYAD.Text;*/


            /*kmus.Iletisim.Adres = txtEVADRES.Text;

            kmus.Iletisim.EvTel = txtEVTEL.Text;
            kmus.Iletisim.Il = txtIL.Text;
            kmus.Iletisim.Ilce = txtILCE.Text;
            kmus.Iletisim.Mail = txtMAILADRES.Text;


            kmus.Firma.Adres = txtFIRMAADRES.Text;
           
            kmus.Firma.Mail = txtFIRMAMAIL.Text;
            kmus.Firma.Tel = txtFIRMATEL.Text;
            kmus.Firma.VergiDaire = txtFIRMAVERGIDAIRE.Text;
            kmus.Firma.VergiNo = Convert.ToInt64(txtFIRMAVERGINO.Text);
            kmus.Firma.WebURL = txtFIRMAWEB.Text;*/

            //kmus.Firma.FirmaAd = txtFIRMAADI.Text.ToString().ToUpper();

            kmus.FirmaCirosu = Convert.ToInt64(txtFIRMACIRO.Text);
            kmus.FirmaMalVarlik = Convert.ToInt64(txtFIRMAMAL.Text);

            kmus.Sifre = kmus.passSifreleme(txtSIFRE.Text, kmus.MID);
            kmus.Onay = onay;

            kmus.FirmaPuanLimit = kmus.MusteriPuanHesapla();
            

            BANKA.MusteriList.Add(kmus);
            BANKA.KurumsalMusteriList.Add(kmus);
            musID = kmus.MID;
            //hesap = kmus.EkHesapveVadesizTLHesapAC(BANKA, musID);
            VadesizHesap v = kmus.VadesizTLAC(BANKA, musID);
            kmus.VadesizHesapList.Add(v);
            /*KrediHesap k = kmus.EkHesapAC(BANKA, musID);
            kmus.KrediHesapList.Add(k);*/

            MessageBox.Show(v.HID.ToString() + " NOLU [VADESİZ TL] HESABINIZ --> " + musID.ToString() + " NOLU Kurumsal MUSTERİ Hesabınıza Otomatik olarak tanımlanmıştır.");
            BANKA.IslemKayit(BANKA.OnlineKisi, musID,300, "Kurumsal "+musID.ToString() + " -> Nolu Müşteri Eklendi.");
        }

        private void btnMTALEP_Click(object sender, EventArgs e)
        {
            if(musTip == "bireysel" && BANKA.OnlineKisi == -1)
            {
                bmus = new BireyselMusteri(BANKA);
                BireyselMusteriEkle(bmus);
            }
            else if (musTip == "kurumsal" && BANKA.OnlineKisi == -1)
            {
                kmus = new KurumsalMusteri(BANKA);
                KurumsalMusteriEkle(kmus);
            }
            else
                MessageBox.Show("HATA!!!");

            this.Close();

        }
    }
}