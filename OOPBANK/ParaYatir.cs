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
    public partial class ParaYatir : Form
    {
        Banka Bankam;
        int islem = 1;
        long tutar, mid;
        BireyselMusteri b;
        KurumsalMusteri k;
        VadesizHesap v1,v2,vh;
        KrediHesap kh;
        public ParaYatir(Banka Banka)
        {
            InitializeComponent();
            this.Bankam = Banka;
            if (Bankam.OnlineKisi < 17999)
                b = Bankam.BireyselMusteriList.Find(x => x.MID == Bankam.OnlineKisi);
            else
                k = Bankam.KurumsalMusteriList.Find(x => x.MID == Bankam.OnlineKisi);
        }

        private void rbBH_CheckedChanged(object sender, EventArgs e)
        {
           
        }
        void Doldur()
        {
            if (Bankam.OnlineKisi < 17999&&islem==3)
            {
                foreach (var x in b.VadesizHesapList)
                    cbSH.Items.Add(x.HID);
            }
            else if(Bankam.OnlineKisi > 17999 && islem == 3)
            {
                foreach (var x in k.VadesizHesapList)
                    cbSH.Items.Add(x.HID);
            }
            else if (Bankam.OnlineKisi < 17999&&islem==1)
            {
                foreach (var x in b.VadesizHesapList)
                {
                    cbSH.Items.Add(x.HID);
                    cbHH.Items.Add(x.HID);
                }
            }
            else if(Bankam.OnlineKisi>17999&&islem==1)
            {
                foreach (var x in k.VadesizHesapList)
                {
                    cbSH.Items.Add(x.HID);
                    cbHH.Items.Add(x.HID);
                }
            }
            else if (Bankam.OnlineKisi < 17999&&islem==2)
            {
                foreach (var x in b.VadesizHesapList)

                    cbSH.Items.Add(x.HID);
                foreach (var x in b.KrediHesapList)
                    cbHH.Items.Add(x.HID);
            }
            else if(Bankam.OnlineKisi>17999&&islem==2)
            {
                foreach (var x in k.VadesizHesapList)
                    cbSH.Items.Add(x.HID);
                foreach (var x in k.KrediHesapList)
                    cbHH.Items.Add(x.HID);
            }
        }
        void Sifirla()
        {
            panel1.Visible = false;
            lbBakiye.Text = "";
            cbSH.Items.Clear();
            cbHH.Items.Clear();
            cbHH.Visible = false;
            txtHH.Visible = false;
            Sorgu();
            label3.Visible = false;
        }
        private void ParaYatir_Load(object sender, EventArgs e)
        {
            Sifirla();
            if (Bankam.OnlineKisi < 17999)
                lbID.Text ="ID # "+ b.MID.ToString();
            else
                lbID.Text = "ID # "+k.MID.ToString();
            Doldur();
        }

        private void rbVH_Click(object sender, EventArgs e)
        {
            islem = 2;
            Sifirla();
            panel1.Visible = true;
            cbHH.Visible = true;
            Sorgu();
            label3.Visible = true;
        }

        private void chkboxNakit_CheckedChanged(object sender, EventArgs e)
        {
        }
        void Sorgu()
        {
            if(chkboxNakit.Checked)
            {
                label1.Visible = false;
                cbSH.Visible = false;
                cbHH.Visible = false;
            }
            else
            {
                label1.Visible = true;
                cbSH.Visible = true;
            }
        }
        private void rbBH_Click(object sender, EventArgs e)
        {
            islem = 1;
            Sifirla();
            Sorgu();
            Doldur();
            panel1.Visible = true;
            cbHH.Visible = true;
            label3.Visible = true;
        }

        private void chkboxNakit_Click(object sender, EventArgs e)
        {
            if (chkboxNakit.Checked && islem != 3)
            {
                Sifirla();
                Sorgu();
                panel1.Visible = true;
                label3.Visible = true;
                cbHH.Visible = true;
            }
            else if (chkboxNakit.Checked && islem == 3)
            {
                Sifirla();
                Sorgu();
                panel1.Visible = true;
                txtHH.Visible = true;
                label3.Visible = true;
            }
            else if (!(chkboxNakit.Checked) && islem != 3)
            {
                Sifirla();
                panel1.Visible = true;
                Sorgu();
                label3.Visible = true;
                cbHH.Visible = true;
            }
            else if (!chkboxNakit.Checked && islem == 3)
            {
                Sifirla();
                panel1.Visible = true;
                Sorgu();
                txtHH.Visible = true;
                label3.Visible = true;
            }
            Doldur();
        }

        private void rbHH_Click(object sender, EventArgs e)
        {
            islem = 3;
            Sifirla();
            Doldur();
            panel1.Visible = true;
            cbHH.Visible = false;
            txtHH.Visible = true;
            label3.Visible = true;
            Sorgu();
        }

        private void rbKH_Click(object sender, EventArgs e)
        {
            islem = 2;
            Sifirla();
            Doldur();
            Sorgu();
            panel1.Visible = true;
            cbHH.Visible = true;
            label3.Visible = true;
        }

        private void txtYP_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tutar = Convert.ToInt64(txtYP.Text);
            }
            catch
            {

            }
        }

        private void Yatır_Click(object sender, EventArgs e)
        {
            if (islem == 1 && !chkboxNakit.Checked && (v1.HesapBakiye - tutar) >= 0)
            {
                v1.HesapBakiye -= tutar;
                v2.HesapBakiye += tutar;
                Bankam.IslemKayit(Convert.ToInt64(Bankam.OnlineKisi), v1.HID, 600, Bankam.OnlineKisi.ToString() + " 'Nolu Müşteri "+ v1.HID.ToString() +" 'Nolu VADESİZ HESABINDAN ->  " + v2.HID.ToString() + "'nolu VADESİZ HESABINA "+ tutar.ToString()+" ₺ tutarında PARA AKTARDI!");            
            }
            else if (islem == 2 && !chkboxNakit.Checked && (v1.HesapBakiye - tutar) >= 0)
            {
                v1.HesapBakiye -= tutar;
                if ((kh.Borc - tutar) > 0)
                {
                    kh.Borc -= tutar;
                    Bankam.IslemKayit(Convert.ToInt64(Bankam.OnlineKisi), v1.HID, 600, Bankam.OnlineKisi.ToString() + " 'Nolu Müşteri " + v1.HID.ToString() + " 'Nolu VADESİZ HESABINDAN ->  " + kh.HID.ToString() + "'nolu KREDİ HESABININ " + tutar.ToString() + " ₺ tutarındaki KREDİ BORCUNU ÖDEDİ!");
                    Bankam.IslemKayit(Convert.ToInt64(Bankam.OnlineKisi), v2.HID, 400, Bankam.OnlineKisi.ToString() + " 'Nolu Müşteri " + kh.HID.ToString() + " 'Nolu KRED HESABININ ->  " + tutar.ToString() + " ₺ tutarındaki KREDİ BORCUNU ODEDİ !");
                }
                else
                {
                    MessageBox.Show("Tüm borcunuz ödendi . " + (tutar - kh.Borc) + " TLniz iade ediliyor ...");
                    v1.HesapBakiye += (tutar - kh.Borc);
                    Bankam.IslemKayit(Convert.ToInt64(Bankam.OnlineKisi), v1.HID, 600, Bankam.OnlineKisi.ToString() + " 'Nolu Müşteri " + v1.HID.ToString() + " 'Nolu VADESİZ HESABINDAN ->  " + kh.HID.ToString() + "'nolu KREDİ HESABININ " + kh.Borc.ToString()+" ₺ tutarındaki KREDİ BORCUNU ÖDEDİ!");
                    Bankam.IslemKayit(Convert.ToInt64(Bankam.OnlineKisi), kh.HID, 400, Bankam.OnlineKisi.ToString() + " 'Nolu Müşteri " + kh.HID.ToString() + " 'Nolu KRED HESABININ ->  " + kh.Borc.ToString() + " ₺ tutarındaki KREDİ BORCUNU ODEDİ !");
                    kh.Borc = 0;

                }

               
            }
            else if (islem == 3 && !chkboxNakit.Checked && (v1.HesapBakiye - tutar) >= 0)
            {
                foreach (var y in Bankam.BireyselMusteriList)
                {
                    v2 = y.VadesizHesapList.Find(z => z.HID == Convert.ToInt64(txtHH.Text));
                    try
                    {
                        if (!v2.HID.Equals(null))
                            vh = v2;
                    }
                    catch
                    {

                    }

                }

                try
                {
                    if (vh.Equals(null))
                    { }
                }
                catch
                {
                    try
                    {
                        foreach (var x in Bankam.KurumsalMusteriList)
                        {
                            v2 = x.VadesizHesapList.Find(y => y.HID == Convert.ToInt64(txtHH.Text));
                            if (v2.HID == Convert.ToInt64(txtHH.Text))
                                vh = v2;
                        }
                        if (vh.Equals(null))
                        { }
                    }
                    catch
                    {

                    }

                }
                try
                {
                    vh.HesapBakiye += tutar;
                    v1.HesapBakiye -= tutar;
                    Bankam.IslemKayit(Convert.ToInt64(Bankam.OnlineKisi), vh.HID, 600, mid.ToString() + " 'Nolu Müşteriye " + v1.HID.ToString() + " 'Nolu VADESİZ HESABINIZDAN ->  KİŞİNİN  " + vh.HID.ToString() + "'nolu VADESİZ HESABINA " + tutar.ToString() + " ₺ tutarında PARA GONDERDİNİZ !");
                    Bankam.IslemKayit(mid, v1.HID, 600, Bankam.OnlineKisi.ToString() + " 'Nolu Müşteri " + v1.HID.ToString() + " 'Nolu VADESİZ HESABINDAN ->  SİZİN " + vh.HID.ToString() + "'nolu VADESİZ HESABINIZA " + tutar.ToString() + " ₺ tutarında PARA GONDERDİ !");
                }
                catch
                {
                    MessageBox.Show("Hesap Bulunamadı ");
                }
            }
            else if (islem == 1 && chkboxNakit.Checked)
                v2.HesapBakiye += tutar;
            else if(islem==2&&chkboxNakit.Checked)
            {
                if ((kh.Borc - tutar) > 0)
                {
                    kh.Borc -= tutar;
                    Bankam.BankaHazinesi += Convert.ToDecimal(tutar);
                    Bankam.IslemKayit(Convert.ToInt64(Bankam.OnlineKisi), kh.HID, 400, Bankam.OnlineKisi.ToString() + " 'Nolu Müşteri " + kh.HID.ToString() + " 'Nolu KRED HESABININ ->  " + kh.Borc.ToString() + " ₺ tutarındaki KREDİ BORCUNU ODEDİ !");
                    Bankam.IslemKayit(1, kh.HID, 130, Bankam.OnlineKisi.ToString() + " 'Nolu Müşteri " + kh.HID.ToString() + " 'Nolu KREDİ HESABINNIN -> "  + tutar.ToString() + " ₺ tutarındaki BORCUNU ÖDEDİ -> Bankaya GELEN PARA !");
                }
                else
                {
                    MessageBox.Show("Tüm borcunuz ödendi . " + (tutar - kh.Borc) + " TLniz iade ediliyor ...");
                    kh.Borc = 0;
                }
            }
            else if(islem==3&&chkboxNakit.Checked)
            {
                vh = b.VadesizHesapList.Find(x => x.HID == Convert.ToInt64(txtHH.Text));
                try
                {
                    if (vh.Equals(null))
                    { }
                }
                catch
                {
                    try
                    {
                        foreach (var x in Bankam.KurumsalMusteriList)
                        {
                            v2 = x.VadesizHesapList.Find(y => y.HID == Convert.ToInt64(txtHH.Text));
                            if (v2.HID == Convert.ToInt64(txtHH.Text))
                            {
                                vh = v2;
                                mid = x.MID;
                            }
                        }
                        if (vh.Equals(null))
                        { }
                    }
                    catch
                    {

                    }

                }
                try
                {
                    vh.HesapBakiye += tutar;
                    Bankam.IslemKayit(Convert.ToInt64(Bankam.OnlineKisi), vh.HID, 600, mid.ToString() + " 'Nolu Müşteriye " + v1.HID.ToString() + " 'Nolu VADESİZ HESABINIZDAN ->  KİŞİNİN  " + v2.HID.ToString() + "'nolu VADESİZ HESABINA " + tutar.ToString() + " ₺ tutarında PARA GONDERDİNİZ !");
                    Bankam.IslemKayit(mid, v1.HID, 600, Bankam.OnlineKisi.ToString() + " 'Nolu Müşteri " + v1.HID.ToString() + " 'Nolu VADESİZ HESABINDAN ->  SİZİN " + vh.HID.ToString() + "'nolu VADESİZ HESABINIZA " + tutar.ToString() + " ₺ tutarında PARA GONDERDİ !");
                }
                catch
                {
                    MessageBox.Show("Hesap Bulunamadı ");
                }
            }
            else
            {
                MessageBox.Show("Bakiye Yetersiz .");
            }
        }

        private void cbSH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Bankam.OnlineKisi<17999)
            {
                v1 = b.VadesizHesapList.Find(x => x.HID == Convert.ToInt64(cbSH.SelectedItem));
            }
            else if(Bankam.OnlineKisi > 17999)
            {
                v1 = k.VadesizHesapList.Find(x => x.HID == Convert.ToInt64(cbSH.SelectedItem));
            }
            lb1.Text = v1.HesapBakiye.ToString();
        }

        private void cbHH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Bankam.OnlineKisi < 17999 && islem == 1)
            {
                v2 = b.VadesizHesapList.Find(x => x.HID == Convert.ToInt64(cbHH.SelectedItem));
                lb2.Text = v2.HesapBakiye.ToString();
            }
            else if (Bankam.OnlineKisi > 17999 && islem == 1)
            {
                v2 = k.VadesizHesapList.Find(x => x.HID == Convert.ToInt64(cbHH.SelectedItem));
                lb2.Text = v2.HesapBakiye.ToString();
            }
            else if (Bankam.OnlineKisi < 17999 && islem == 2)
            {
                kh = b.KrediHesapList.Find(x => x.HID == Convert.ToInt64(cbHH.SelectedItem));
                lb2.Text = kh.Borc.ToString();
            }
            else if (Bankam.OnlineKisi > 17999 && islem == 2)
            {
                kh = k.KrediHesapList.Find(x => x.HID == Convert.ToInt64(cbHH.SelectedItem));
                lb2.Text = kh.Borc.ToString();
            }     
        }
    }
}
