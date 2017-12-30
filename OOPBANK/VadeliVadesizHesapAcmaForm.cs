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
    public partial class VadeliVadesizHesapAcmaForm : Form
    {
        public VadeliVadesizHesapAcmaForm()
        {
            InitializeComponent();
        }
        Banka BANKA;
        KurumsalMusteri kmus;
        BireyselMusteri bmus;
        VadesizHesap vadesizHesapYeni;
        VadeliHesap vadeliHesapYeni;
        string mesaj;
        double yatirilanPara = 0;
        decimal ceza = 0;

        private void btnVADELIHESAPAC_Click(object sender, EventArgs e)
        {
            vadeliHesapYeni = new VadeliHesap();
            vadeliHesapYeni.HesapParaBirimi = comboPARABIRIM.SelectedItem.ToString();
            vadeliHesapYeni.ParaBirimiKuru = (Convert.ToDecimal(BANKA.KurBulEnum(vadeliHesapYeni.HesapParaBirimi))/100);
            vadeliHesapYeni.FaizSuresi = Convert.ToInt16(comboAylikFaizSure.SelectedItem.ToString());
            vadeliHesapYeni.FaizOrani = (vadeliHesapYeni.FaizSuresi / 12)+2;
            vadeliHesapYeni.CezaOrani = (vadeliHesapYeni.FaizOrani)-2;
            yatirilanPara = Convert.ToDouble((Convert.ToDecimal(txtYatirilanPara.Text) * (Convert.ToDecimal(BANKA.KurBulEnum(comboBIRIMP.SelectedItem.ToString())) / 100)));
            vadeliHesapYeni.YatirilanPara = (Convert.ToDecimal(yatirilanPara) / (vadeliHesapYeni.ParaBirimiKuru));
            vadeliHesapYeni.CekilenPara = ((Convert.ToDecimal(vadeliHesapYeni.FaizOrani / 100) * vadeliHesapYeni.YatirilanPara) + vadeliHesapYeni.YatirilanPara);

            BANKA.BankaHazinesi += Convert.ToDecimal(yatirilanPara);
            
            ceza = (vadeliHesapYeni.YatirilanPara - (Convert.ToDecimal(vadeliHesapYeni.CezaOrani/100) * vadeliHesapYeni.YatirilanPara));
            lblYillikVadeOran.Text = vadeliHesapYeni.FaizOrani.ToString();
            lblCezaOran.Text = vadeliHesapYeni.CezaOrani.ToString();
            lblCezaliAnaPARA.Text = Math.Round(ceza, 2).ToString();
            lblFaizliAnaPARA.Text = Math.Round(vadeliHesapYeni.CekilenPara, 2).ToString();
            lblKUR.Text = (vadeliHesapYeni.ParaBirimiKuru).ToString();
            label15.Text = "Para Birimi ->" + vadeliHesapYeni.HesapParaBirimi.ToString();
            label17.Text = label15.Text.ToString();

            vadeliHesapYeni.VadeBaslangicTarih = DateTime.Now;
            vadeliHesapYeni.VadeBitisTarih = vadeliHesapYeni.VadeBaslangicTarih.AddMonths(vadeliHesapYeni.FaizSuresi);

            // VADE başlangıç tarihinden  itibaren FAIZ SURESI işelemye başlar !!!
            // VADE BAŞLANGIÇ + FAIZ = BADE BİTİŞE DENK olduğu zaman para çekilebilir.

            if (vadeliHesapYeni.VadeBaslangicTarih == vadeliHesapYeni.VadeBitisTarih)            
                vadeliHesapYeni.CezaOrani = 0;
                //BANKA.BildirimList.Add();
                //VADE DOLDU

            if (BANKA.OnlineKisi > 17999 && BANKA.OnlineKisi < 20000)
            {
                vadeliHesapYeni = kmus.VadeliHesapAC(BANKA, kmus.MID, vadeliHesapYeni);
                kmus.VadeliHesapList.Add(vadeliHesapYeni);           
            }
            else
            {
                vadeliHesapYeni = bmus.VadeliHesapAC(BANKA, bmus.MID, vadeliHesapYeni);
                bmus.VadeliHesapList.Add(vadeliHesapYeni);
            }

            mesaj = "VADELİ Hesabınız başarıyla oluşturulmuştur !";
            BANKA.IslemKayit(Convert.ToInt64(BANKA.OnlineKisi), vadeliHesapYeni.HID, 500, BANKA.OnlineKisi.ToString() + " 'Nolu Müşteri -> " + vadeliHesapYeni.HID.ToString() + " 'Nolu VADELİ Hesaba " + yatirilanPara.ToString() + " ₺ tutarında PARA YATIRILMIŞTIR !");
            BANKA.IslemKayit(1, Convert.ToInt64(BANKA.OnlineKisi), 130, BANKA.OnlineKisi.ToString() + " 'Nolu Müşteri -> " + vadeliHesapYeni.HID.ToString() + " 'Nolu VADELİ Hesabına PARA YATIRILMIŞTIR !");
            BANKA.IslemKayit(Convert.ToInt64(BANKA.OnlineKisi), vadeliHesapYeni.HID, 500, BANKA.OnlineKisi.ToString() + " 'Nolu Müşteri -> " + vadeliHesapYeni.HID.ToString() + " 'Nolu VADELİ Hesap Başarıyla tanımlanmıştır.");
            txtIslemMesaj.Text = mesaj.ToString();
            MessageBox.Show(mesaj.ToString(),"UNIVER BANK HESAP İŞLEMLERİ");
            ListeleriGoster();
        }

        private void btnVADESIZHESAPAC_Click(object sender, EventArgs e)
        {
            vadesizHesapYeni = new VadesizHesap();
            vadesizHesapYeni.HesapParaBirimi = comboPARABIRIM.SelectedItem.ToString();
            vadesizHesapYeni.ParaBirimiKuru = (Convert.ToDecimal(BANKA.KurBulEnum(vadesizHesapYeni.HesapParaBirimi))/100);
            lblKUR.Text = vadesizHesapYeni.ParaBirimiKuru.ToString();
       
            if (txtVADESIZPARA.Text != null)
            {
                yatirilanPara = (Convert.ToDouble(txtVADESIZPARA.Text) * (Convert.ToDouble(BANKA.KurBulEnum(comboKURVADESIZ.SelectedItem.ToString()))/100));
                vadesizHesapYeni.HesapBakiye += (Convert.ToDecimal(yatirilanPara) / (vadesizHesapYeni.ParaBirimiKuru/100));
                BANKA.BankaHazinesi += Convert.ToDecimal(yatirilanPara);

            }

            if (BANKA.OnlineKisi > 17999 && BANKA.OnlineKisi < 20000)
            {
                vadesizHesapYeni = kmus.VadesizHesapAC(BANKA, kmus.MID, vadesizHesapYeni);
                kmus.VadesizHesapList.Add(vadesizHesapYeni);                
            }
            else
            {
                vadesizHesapYeni = bmus.VadesizHesapAC(BANKA, bmus.MID, vadesizHesapYeni);
                bmus.VadesizHesapList.Add(vadesizHesapYeni);
            }
            BANKA.IslemKayit(Convert.ToInt64(BANKA.OnlineKisi), vadesizHesapYeni.HID, 600, BANKA.OnlineKisi.ToString() + " 'Nolu Müşteri -> " + vadesizHesapYeni.HID.ToString() + " 'Nolu VADESIZ Hesaba " + yatirilanPara.ToString() + " ₺ tutarında PARA YATIRILMIŞTIR !");
            BANKA.IslemKayit(1, Convert.ToInt64(BANKA.OnlineKisi), 130, BANKA.OnlineKisi.ToString() + " 'Nolu Müşteri -> " + vadesizHesapYeni.HID.ToString() + " 'Nolu VADESIZ Hesaba " + yatirilanPara.ToString() + " ₺ tutarında PARA YATIRILMIŞTIR !");
            BANKA.IslemKayit(Convert.ToInt64(BANKA.OnlineKisi), vadesizHesapYeni.HID, 600, BANKA.OnlineKisi.ToString() + " 'Nolu Müşteri Hesaplı Kullanıcıya -> " + vadesizHesapYeni.HID.ToString() + " 'Nolu VADESİZ Hesap Başarıyla tanımlanmıştır.");
            BANKA.VadesizHesapList.Add(vadesizHesapYeni);
            mesaj = "Vadesiz Hesabınız başarıyla oluşturulmuştur !";
            txtIslemMesaj.Text = mesaj.ToString();
            MessageBox.Show(mesaj.ToString(), "UNIVER BANK HESAP İŞLEMLERİ");
            ListeleriGoster();
        }

        public void ListeleriGoster()
        {
            if (BANKA.OnlineKisi < 20000 && BANKA.OnlineKisi > 18000)
            {
                var listVadeli = new BindingList<VadeliHesap>(kmus.VadeliHesapList);
                dataGridView2.DataSource = listVadeli;

                var listVadesiz = new BindingList<VadesizHesap>(kmus.VadesizHesapList);
                dataGridView1.DataSource = listVadesiz;
            }
            else
            {
                var listVadeli = new BindingList<VadeliHesap>(bmus.VadeliHesapList);
                dataGridView2.DataSource = listVadeli;

                var listVadesiz = new BindingList<VadesizHesap>(bmus.VadesizHesapList);
                dataGridView1.DataSource = listVadesiz;
            }
        }

        public void NesneleriGosterme()
        {
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            rdbtnVadesiz.Checked = true;
            rdbtnVadeli.Checked = false;
        }

        private void btnKREDIHESAPAC_Click(object sender, EventArgs e)
        {
            KrediHesabıBasvuruForm kredi;
            if (BANKA.OnlineKisi > 17999 && BANKA.OnlineKisi < 20000)
                kredi = new KrediHesabıBasvuruForm(BANKA, kmus);
            else
                kredi = new KrediHesabıBasvuruForm(BANKA, bmus);
            this.Close();
            kredi.Show();
        }

        private void rdbtnVadesiz_CheckedChanged(object sender, EventArgs e)
        {
            groupBox6.Visible = true;
            groupBox5.Visible = true;
            groupBox4.Visible = false;
        }

        private void rdbtnVadeli_CheckedChanged(object sender, EventArgs e)
        {
            groupBox4.Visible = true;
            groupBox5.Visible = true;
            groupBox6.Visible = false;
        }

        public VadeliVadesizHesapAcmaForm(Banka BANKAM,BireyselMusteri bmus)
        {
            InitializeComponent();
            this.BANKA = BANKAM;
            this.bmus = bmus;
        }

        public VadeliVadesizHesapAcmaForm(Banka BANKAM, KurumsalMusteri kmus)
        {
            InitializeComponent();
            this.BANKA = BANKAM;
            this.kmus = kmus;
        }


        private void VadeliVadesizHesapAcmaForm_Load(object sender, EventArgs e)
        {
            ListeleriGoster();
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;

            listKREDI.Items.Add(" Sistemden 3 Çeşit Kredi alabilirsiniz \n Eğer Bireysel Müşteriyseniz; \n *Ev *Ihtiyaç *Tarım \n \n ... \n \n Eğer Kurumsal Müşteriyseniz; \n *Mega *Giga *Tera \n kredi türlerinden LİMİT puanınıza göre kredi hesabı oluşturabilirsiniz");
            listVADELI.Items.Add(" ");
            listVADESIZ.Items.Add(" ");
        }
    }
}
