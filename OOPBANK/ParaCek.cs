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
    public partial class ParaCek : Form
    {
        Banka Bankam;
        BireyselMusteri b;
        KurumsalMusteri k;
        VadesizHesap v;
        KrediHesap kh;
        public ParaCek(Banka Banka)
        {
            InitializeComponent();
            this.Bankam = Banka;
            if (Bankam.OnlineKisi < 18000)
            {
                b = Bankam.BireyselMusteriList.Find(x => x.MID == Bankam.OnlineKisi);
                VadesizHesap v1 = new VadesizHesap() { HesapBakiye = 3000m, HID = 33333 };
                b.VadesizHesapList.Add(v1);
                KrediHesap k1 = new KrediHesap() { Limit = 750m, Borc = 0m, HID = 33334, KrediHesapTürü = "ekhesap" };
                b.KrediHesapList.Add(k1);
                lbID.Text = b.MID.ToString();
                lbMusteriAdi.Text = b.Kimlik.Adi;
            }
               
            else
            {
                k = Bankam.KurumsalMusteriList.Find(x => x.MID == Bankam.OnlineKisi);
                VadesizHesap v2 = new VadesizHesap() { HesapBakiye = 50000m, HID = 22222 };
                k.VadesizHesapList.Add(v2);
                KrediHesap k2 = new KrediHesap() { Limit = 750m, Borc = 0m, HID = 22223, KrediHesapTürü = "ekhesap" };
                k.KrediHesapList.Add(k2);
                lbID.Text = k.MID.ToString();
                lbMusteriAdi.Text = k.Firma.FirmaAd;
            }        
        }

        private void ParaCek_Load(object sender, EventArgs e)
        {
            if (Bankam.OnlineKisi < 18000)
                foreach (var x in b.VadesizHesapList)
                    cbHesapNo.Items.Add(x.HID);
            else
                foreach (var x in k.VadesizHesapList)
                    cbHesapNo.Items.Add(x.HID);
        }

        private void btnParaCek_Click(object sender, EventArgs e)
        {
            if (Bankam.OnlineKisi < 18000)
            {
                if ((v.GunlukHarcama + Convert.ToDecimal(txtMiktar.Text)) < 750)
                {
                    if (Convert.ToInt64(txtMiktar.Text) > v.HesapBakiye)
                    {
                        if ((750 - kh.Borc) + v.HesapBakiye < Convert.ToInt64(txtMiktar.Text))
                            MessageBox.Show("Bakiyeniz Yetersiz .");
                        else
                        {
                            kh.Borc += (Convert.ToInt64(txtMiktar.Text) - v.HesapBakiye);
                            v.GunlukHarcama += Convert.ToDecimal(txtMiktar.Text);
                            v.HesapBakiye = 0m;
                        }
                    }
                    else
                    {
                        v.GunlukHarcama += Convert.ToDecimal(txtMiktar.Text);
                        v.HesapBakiye -= Convert.ToInt64(txtMiktar.Text);
                    }
                    Bankam.IslemKayit(Convert.ToInt64(Bankam.OnlineKisi), v.HID, 600, Bankam.OnlineKisi.ToString() + " 'Nolu BİREYESEL Müşteri HESABINDAN ->  " + (Convert.ToInt64(txtMiktar.Text)).ToString() + " PARA ÇEKTİ.");
                    Bankam.IslemKayit(1, v.HID, 120, Bankam.OnlineKisi.ToString() + " 'Nolu BİREYSEL Müşteri HESABINDAN ->  " + (Convert.ToInt64(txtMiktar.Text) - v.HesapBakiye).ToString() + " PARA ÇEKTİ.");
                    Bankam.BankaHazinesi -= Convert.ToDecimal(txtMiktar.Text);
                }
                else
                {
                    MessageBox.Show("Günlük Limitiniz Yetersiz .");
                }
            }
            else
            {
                VadesizHesap v = k.VadesizHesapList.Find(x => x.HID == Convert.ToInt64(cbHesapNo.SelectedItem));
                KrediHesap kh = k.KrediHesapList.Find(x => x.KrediHesapTürü == "ekhesap");
                if ((v.GunlukHarcama + Convert.ToDecimal(txtMiktar.Text))<750)
                {
                    if (Convert.ToInt64(txtMiktar.Text) > v.HesapBakiye)
                    {
                        if ((750 - kh.Borc) + v.HesapBakiye < Convert.ToInt64(txtMiktar.Text))
                            MessageBox.Show("Bakiyeniz Yetersiz .");
                        else
                        {
                            kh.Borc += (Convert.ToInt64(txtMiktar.Text) - v.HesapBakiye);
                            v.GunlukHarcama += Convert.ToDecimal(txtMiktar.Text);
                            v.HesapBakiye = 0m;
                        }
                    }
                    else
                    {
                        v.GunlukHarcama += Convert.ToDecimal(txtMiktar.Text);
                        v.HesapBakiye -= Convert.ToInt64(txtMiktar.Text);
                    }
                    Bankam.IslemKayit(Convert.ToInt64(Bankam.OnlineKisi), v.HID, 600, Bankam.OnlineKisi.ToString() + " 'Nolu BİREYESEL Müşteri HESABINDAN ->  " + (Convert.ToInt64(txtMiktar.Text)).ToString() + " PARA ÇEKTİ.");
                    Bankam.IslemKayit(1, v.HID, 120, Bankam.OnlineKisi.ToString() + " 'Nolu BİREYSEL Müşteri HESABINDAN ->  " + (Convert.ToInt64(txtMiktar.Text) - v.HesapBakiye).ToString() + " PARA ÇEKTİ.");
                    Bankam.BankaHazinesi -= Convert.ToDecimal(txtMiktar.Text);
                }
                else 
                {
                    MessageBox.Show("Günlük Limitiniz Yetersiz .");
                }
                Bankam.IslemKayit(Convert.ToInt64(Bankam.OnlineKisi), v.HID, 600, Bankam.OnlineKisi.ToString() + " 'Nolu KURUMSAL Müşteri HESABINDAN ->  " + (Convert.ToInt64(txtMiktar.Text)).ToString() + " PARA ÇEKTİ.");
                Bankam.IslemKayit(1, v.HID, 120, Bankam.OnlineKisi.ToString() + " 'Nolu KURUMSAL Müşteri HESABINDAN ->  " + (Convert.ToInt64(txtMiktar.Text) - v.HesapBakiye).ToString() + " PARA ÇEKTİ.");
                Bankam.BankaHazinesi -= Convert.ToDecimal(txtMiktar.Text);
            }    
            }
               
        

        private void cbHesapNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Bankam.OnlineKisi<18000)
            {
                 v = b.VadesizHesapList.Find(x => x.HID == Convert.ToInt64(cbHesapNo.SelectedItem));
                 kh = b.KrediHesapList.Find(x => x.KrediHesapTürü == "ekhesap");
                lbBakiye.Text = v.HesapBakiye.ToString();
                lbEkHesap.Text = kh.Borc.ToString();
            }
            else
            {
                v = k.VadesizHesapList.Find(x => x.HID == Convert.ToInt64(cbHesapNo.SelectedItem));
                kh = k.KrediHesapList.Find(x => x.KrediHesapTürü == "ekhesap");
                lbBakiye.Text = v.HesapBakiye.ToString();
                lbEkHesap.Text = kh.Borc.ToString();
            }
            
        }

        private void ParaCek_FormClosed(object sender, FormClosedEventArgs e)
        {
            cbHesapNo.Items.Clear();
        }
    }
}
