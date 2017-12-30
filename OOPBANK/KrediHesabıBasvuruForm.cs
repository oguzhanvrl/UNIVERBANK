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
    public partial class KrediHesabıBasvuruForm : Form
    {
        public KrediHesabıBasvuruForm()
        {
            InitializeComponent();
        }

        Banka BANKA;
        KrediHesap krediHesapYeni;
        KurumsalMusteri kmus;
        BireyselMusteri bmus;
        int tip = 0, hid;
        long musID;
        string krediBilgi, hesaptür, paraBirim;
        double faizoran = 0, musPuan = 1, maxTL = 0, harcananPuan = 0;
        public KrediHesabıBasvuruForm(Banka Bankam, KurumsalMusteri MUS)
        {
            InitializeComponent();
            this.BANKA = Bankam;
            this.kmus = MUS;
        }
        public KrediHesabıBasvuruForm(Banka Bankam, BireyselMusteri MUS)
        {
            InitializeComponent();
            this.BANKA = Bankam;
            this.bmus = MUS;
        }

        private void KrediHesabıBasvuruForm_Load(object sender, EventArgs e)
        {
            krediBilgi = "";
            comboBox2.SelectedItem = "TL";
            radioButton1.Checked = false;
            comboBox1.Visible = false;
            label10.Visible = false;
            button1.Visible = false;
            comboBox1.Visible = false;
            button1.Visible = false;
            label10.Visible = false;
            btnKrediOnayla.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            var sorgu = from s in BANKA.MusteriList
                        where s.MID == BANKA.OnlineKisi
                        select s;

            foreach (var item in sorgu)
            {
                label9.Text = "ID : " + item.MID.ToString() + " | " + item.Kimlik.Adi.ToString() +"Bey";
            }

            if (BANKA.OnlineKisi > 17999 && BANKA.OnlineKisi < 20000)
            {
                radioButton1.Text = EnumKrediTur.megaKredi.ToString("G");
                radioButton2.Text = EnumKrediTur.gigaKredi.ToString("G");
                radioButton3.Text = EnumKrediTur.teraKredi.ToString("G");
                label4.Text = kmus.FirmaMalVarlik.ToString();
                label5.Text = kmus.FirmaCirosu.ToString();
                label6.Text = kmus.BankaMusteriPuani.ToString();
                musID = kmus.MID;
            }
            else
            {
                radioButton1.Text = EnumKrediTur.evKredisi.ToString("G");
                radioButton2.Text = EnumKrediTur.ihtiyacKredisi.ToString("G");
                radioButton3.Text = EnumKrediTur.tarimKredisi.ToString("G");
                label4.Text = bmus.BireyselMalVarlik.ToString();
                label5.Text = bmus.AylikGelir.ToString();
                label6.Text = bmus.BankaMusteriPuani.ToString();
                musID = bmus.MID;
            }
        }

        /*else if (hesapTürü == "vadelitlhesap") rnd = hid.Next(55000, 59999);ev
              else if (hesapTürü == "vadelitlhesap") rnd = hid.Next(60000, 64999);ihtiyac
                 else if (hesapTürü == "vadelitlhesap") rnd = hid.Next(65000, 69999);tarım
                    else if (hesapTürü == "vadelitlhesap") rnd = hid.Next(70000, 74999);mega
                       else if (hesapTürü == "vadelitlhesap") rnd = hid.Next(75000, 79999);giga
                          else if (hesapTürü == "vadelitlhesap") rnd = hid.Next(80000, 84999);tera*/

        //Tür : 1 ise Kurumsal 0 ise Bireysel Müşteri
        DialogResult mb = new DialogResult();
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            krediBilgi = " ";
            faizoran = Convert.ToDouble(EnumKrediTur.evKredisi.ToString("D"));
            hesaptür = EnumKrediTur.evKredisi.ToString("G");
            hid = 55000;
            if (BANKA.OnlineKisi > 17999 && BANKA.OnlineKisi < 20000)
            {
                faizoran = Convert.ToDouble(EnumKrediTur.megaKredi.ToString("D"));
                hesaptür = EnumKrediTur.megaKredi.ToString("G");
                hid = 70000;
            }
            krediBilgi = hesaptür + " %" + faizoran.ToString() + " Sabit Faizli Kredi";
            mb = MessageBox.Show(krediBilgi.ToString() + "yi Hesabınıza Tanımlama İşlemindesiniz, devam etmek istiyor musunuz ?", "UNIVER BANK Kredi İşlem Bilgisi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (mb == DialogResult.OK) NesneleriGöster();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            krediBilgi = " ";
            faizoran = Convert.ToDouble(EnumKrediTur.ihtiyacKredisi.ToString("D"));
            hesaptür = EnumKrediTur.ihtiyacKredisi.ToString("G");
            hid = 60000;
            if (BANKA.OnlineKisi > 17999 && BANKA.OnlineKisi < 20000)
            {
                faizoran = Convert.ToDouble(EnumKrediTur.gigaKredi.ToString("D"));
                hesaptür = EnumKrediTur.gigaKredi.ToString("G");
                hid = 75000;
            }
            krediBilgi = hesaptür + " %" + faizoran.ToString() + " Sabit Faizli Kredi";
            mb = MessageBox.Show(krediBilgi.ToString() + "yi Hesabınıza Tanımlama İşlemindesiniz, devam etmek istiyor musunuz ?", "UNIVER BANK Kredi İşlem Bilgisi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (mb == DialogResult.OK) NesneleriGöster();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            krediBilgi = " ";
            faizoran = Convert.ToDouble(EnumKrediTur.tarimKredisi.ToString("D"));
            hesaptür = EnumKrediTur.tarimKredisi.ToString("G");
            hid = 65000;
            if (BANKA.OnlineKisi > 17999 && BANKA.OnlineKisi < 20000)
            {
                faizoran = Convert.ToDouble(EnumKrediTur.teraKredi.ToString("D"));
                hesaptür = EnumKrediTur.teraKredi.ToString("G");
                hid = 80000;
            }
            krediBilgi = hesaptür + " %" + faizoran.ToString() + " Sabit Faizli Kredi";
            mb = MessageBox.Show(krediBilgi.ToString()+ "yi Hesabınıza Tanımlama İşlemindesiniz, devam etmek istiyor musunuz ?", "UNIVER BANK Kredi İşlem Bilgisi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (mb == DialogResult.OK) NesneleriGöster();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            label14.Text = dataGridView1.SelectedRows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            // sağ tıkla bilgi göster !!!
            //para çek
            // borç öde
        }

        private void btnKrediOnayla_Click(object sender, EventArgs e)
        {
            KrediHesapTanimla(faizoran, hesaptür, hid);
            KrediHesaplariListele();          
            LabellaraVeriYaz(krediHesapYeni);
            MusteriPuanGuncelle();

            // Kredi BAŞLAT
            krediHesapYeni.Borc= KrediFaizBaslat(krediHesapYeni);
            MessageBox.Show("Krediniz Hesabınıza Başarıyla Tanımalanmıştır.", "UNIVER BANK Kredi İşlem Bilgisi");
        }

        public void KrediHesapTanimla(double faizoran, string hesaptür, int hid)
        {
            if (musPuan > 0 && musPuan <= 100)
            {
                krediHesapYeni = new KrediHesap();
                krediHesapYeni.HID = Convert.ToInt64(BANKA.IDVER(hid, (hid + 4999)));
                krediHesapYeni.MüsteriTürü = false;
                krediHesapYeni.Borc = 0;
                krediHesapYeni.FaizliHacizLimiti = 0; // LİMİT HESAPLA fonksiyon yaz !
                                                      // ------
                krediHesapYeni.Vade = Convert.ToInt16(comboBox1.SelectedItem);

                krediHesapYeni.FaizOrani = faizoran + (krediHesapYeni.Vade / 12) - 1;
                krediHesapYeni.KrediHesapTürü = hesaptür.ToUpper();

                if (BANKA.OnlineKisi > 17999 && BANKA.OnlineKisi < 20000)
                {
                    krediHesapYeni.MüsteriTürü = true;
                    krediHesapYeni.Limit = krediHesapYeni.KrediLimitHesapla(kmus.FirmaPuanLimit, krediHesapYeni.FaizOrani);
                    krediHesapYeni.FaizliHacizLimiti = (Convert.ToDecimal(kmus.FirmaPuanLimit) * 10) / 8;
                    kmus.BankaMusteriPuani -= krediHesapYeni.MusteriKrediPuaniIslemleri(krediHesapYeni.Limit, kmus.FirmaPuanLimit);
                    musPuan = kmus.BankaMusteriPuani;    
                    MessageBox.Show("* Hesabınıza Tanımlanan Kredi Limitiniz : " + krediHesapYeni.Limit.ToString() + " ₺ \n \n * [haciz] Müşteri Genel Limitiniz : " + krediHesapYeni.FaizliHacizLimiti.ToString() + " ₺ \n \n * Kredi için Harcanan Müşteri Puanı : " + harcananPuan.ToString(), "UNIVER BANK Kredi İşlem Bilgisi", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    kmus.KrediHesapList.Add(krediHesapYeni);
                }
                else
                {
                    krediHesapYeni.MüsteriTürü = false;
                    krediHesapYeni.Limit = krediHesapYeni.KrediLimitHesapla(bmus.BireyselPuanLimit, krediHesapYeni.FaizOrani);
                    krediHesapYeni.FaizliHacizLimiti = (Convert.ToDecimal(bmus.BireyselPuanLimit) * 10) / 8;
                    harcananPuan = krediHesapYeni.MusteriKrediPuaniIslemleri(krediHesapYeni.Limit, bmus.BireyselPuanLimit);
                    bmus.BankaMusteriPuani -= harcananPuan;
                    musPuan = bmus.BankaMusteriPuani;
                    MessageBox.Show("* Hesabınıza Tanımlanan Kredi Limitiniz : " + krediHesapYeni.Limit.ToString() + " ₺ \n \n * [haciz] Müşteri Genel Limitiniz : " + krediHesapYeni.FaizliHacizLimiti.ToString() + " ₺ \n \n * Kredi için Harcanan Müşteri Puanı : " + harcananPuan.ToString(), "UNIVER BANK Kredi İşlem Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bmus.KrediHesapList.Add(krediHesapYeni);
                }

                maxTL = ((musPuan * Convert.ToDouble(krediHesapYeni.Limit)) / harcananPuan);

                LabellaraVeriYaz(krediHesapYeni);
                // banka GELİR/GİDER TÜR NUMARSI İLE KREDİ GİDER OLARAK KAYDET ::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
                BANKA.KrediHesapList.Add(krediHesapYeni);
                BANKA.IslemKayit(Convert.ToInt64(BANKA.OnlineKisi), krediHesapYeni.HID, 400, musID.ToString() + " 'Nolu Müşteri Hesabına -> " + krediBilgi.ToString() + " tanımlanmıştır.");
                BANKA.IslemKayit(Convert.ToInt64(BANKA.OnlineKisi), krediHesapYeni.HID, 400, musID.ToString() + " 'Nolu Müşteri -> " + krediHesapYeni.HID.ToString() + " 'Nolu Kredi Hesabına " + krediHesapYeni.Limit.ToString() + " ₺ otomatik limit tanımlandı. ");
            }
            else
            {
                MessageBox.Show("Müşteri Puanınız Yetersiz - Puanınızın Artışını Sağlamak için Borçlarınızı Ödeyiniz !!!", "UNIVER BANK Kredi İşlem Bilgisi",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnParaCEK_Click(object sender, EventArgs e)
        {
            kredidenParaCek(((BANKA.KurBulEnum(comboBox2.SelectedItem.ToString()) * Convert.ToDecimal(txtParaCEK.Text)))/100);
            LabellaraVeriYaz(krediHesapYeni);
            MusteriPuanGuncelle();
            KrediHesaplariListele();
        }

        public void kredidenParaCek(decimal tutar)
        {
            if (krediHesapYeni.Limit >= tutar && tutar > 0 && ((krediHesapYeni.Borc) + tutar) <= (krediHesapYeni.Limit))
            {
                BANKA.BankaHazinesi -= tutar;
                krediHesapYeni.Borc += tutar;
                BANKA.IslemKayit(Convert.ToInt64(BANKA.OnlineKisi), krediHesapYeni.HID, 400, musID.ToString() + " 'Nolu Müşteri "+ krediHesapYeni.HID.ToString()+" 'Nolu Kredi Hesabından BAŞARIYLA "+ tutar.ToString()+" ₺ Para Çekti !");
                BANKA.IslemKayit(1,Convert.ToInt64(BANKA.OnlineKisi), 120, musID.ToString() + " 'Nolu Müşteri " + krediHesapYeni.HID.ToString() + " 'Nolu Kredi Hesabından BAŞARIYLA " + tutar.ToString() + " ₺ PARA ÇEKTİ !");
                MessageBox.Show(" Başarıyla "+krediHesapYeni.HID.ToString()+"'Nolu Kredi Hesabınızdan --> "+tutar.ToString()+" ₺ tutarında para çektiniz.", "UNIVER BANK Kredi Para Çekme İşlem Bilgisi");
            }
            else if (((krediHesapYeni.Borc * (-1)) + tutar) == (krediHesapYeni.Limit))
                MessageBox.Show("Bu hesapdan daha fazla para çekemezsiniz !!! LİMİT AŞIMI ", "UNIVER BANK Kredi Para Çekme İşlem Bilgisi");
            else
                MessageBox.Show("Hesabınızın limitinin kontrol ederek yeniden deneyiniz !!!", "UNIVER BANK Kredi Para Çekme İşlem Bilgisi");
        }

        private void btnTalepBaslat_Click(object sender, EventArgs e)
        {
            double artir = Convert.ToDouble(txtLimitARTIR.Text);
            if (maxTL >= artir && artir > 0)
            {
                harcananPuan = (artir * musPuan) / maxTL;
                musPuan -= harcananPuan;
                krediHesapYeni.Limit += Convert.ToDecimal(artir);
                // banka GELİR/GİDER TÜR NUMARSI İLE KREDİ GİDER OLARAK KAYDET :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
                BANKA.IslemKayit(Convert.ToInt64(BANKA.OnlineKisi), krediHesapYeni.HID, 400, musID.ToString() + " 'Nolu Müşteri -> " + krediHesapYeni.HID.ToString() + " 'Nolu Kredi Hesabı Limitini " + artir.ToString() + " ₺ artırarak güncel limiti"+ krediHesapYeni.Limit.ToString() + " ₺ oldu.");
                LabellaraVeriYaz(krediHesapYeni);
                KrediHesaplariListele();
                MusteriPuanGuncelle();
                MessageBox.Show(" * Müşteri Puanınızı kullanarak Kredi Limit artış işlemini Başarıyla gerçekleştirdiniz ...", "UNIVER BANK Talep İşlem Bilgisi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Talep İşleminizin TUTARINI kontrol ederek yeniden deneyiniz !!!", "UNIVER BANK Kredi Para Çekme İşlem Bilgisi",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        public decimal KrediFaizBaslat(KrediHesap kredi)
        {
            if(kredi.Borc >= kredi.FaizliHacizLimiti)
                MessageBox.Show("Haciz İşlmei Başlatılıyor !.. " +  kredi.FaizliHacizLimiti.ToString() +" ₺ civarındaki Tüm Malvarlığınıza el konulanacaktır.","UNIVER BANK Haci İşlem Bilgisi",MessageBoxButtons.OK,MessageBoxIcon.Warning);           
            
            // Gün geldiği zaman EKSTRE VER

            if (DateTime.Now == kredi.HesapAcilisTarihi.AddDays(Convert.ToDouble(kredi.Vade)))
                kredi.Borc += kredi.Borc * Convert.ToDecimal(kredi.FaizOrani);

            return kredi.Borc;            
        }

        private void btnTalep_Click(object sender, EventArgs e)
        {
            groupBox4.Visible = true;
            KrediHesaplariListele();
            LabellaraVeriYaz(krediHesapYeni);
            MusteriPuanGuncelle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("* 12 AY : +%0 \n * 24 AY : +%1\n 36 AY : +%2\n * 48 AY : +%3\n * 60 AY : +%4\n * 72 AY : +%5\n * 84 AY : +%6\n * 96 AY : +%7\n * 108 AY : +%8\n * 120 AY : +%9\n", "Kredi Vade sürelerine göre ekstra Faiz oran tablosu");
        }

        public void LabellaraVeriYaz(KrediHesap yeniKrediBilgi)
        {
            label6.Text = musPuan.ToString();
            label22.Text = musPuan.ToString();
            label29.Text = musPuan.ToString();
            label14.Text = yeniKrediBilgi.HID.ToString();
            label15.Text = yeniKrediBilgi.Limit.ToString();
            label16.Text = yeniKrediBilgi.Borc.ToString();
            label24.Text = yeniKrediBilgi.Vade.ToString();
            label25.Text = yeniKrediBilgi.FaizliHacizLimiti.ToString();
            label27.Text = yeniKrediBilgi.FaizOrani.ToString();
            label30.Text = yeniKrediBilgi.Limit.ToString();
            label32.Text = maxTL.ToString();
        }
        public void NesneleriGöster()
        {
            comboBox1.Visible = true;
            button1.Visible = true;
            label10.Visible = true;
            btnKrediOnayla.Visible = true;
            groupBox2.Visible = true;
            groupBox3.Visible = true;
            groupBox4.Visible = false;
        }

        public void KrediHesaplariListele()
        {
            if (BANKA.OnlineKisi < 20000 && BANKA.OnlineKisi > 18000)
            {
                var krediListKurumsal = new BindingList<KrediHesap>(kmus.KrediHesapList);
                dataGridView1.DataSource = krediListKurumsal;
            }
            else
            {
                var krediListBireysel = new BindingList<KrediHesap>(bmus.KrediHesapList);
                dataGridView1.DataSource = krediListBireysel;
            }
        }


        public void MusteriPuanGuncelle()
        {
            if (BANKA.OnlineKisi > 17999 && BANKA.OnlineKisi < 20000)
                kmus.BankaMusteriPuani = musPuan;
            else
                bmus.BankaMusteriPuani = musPuan;
        }
    }
}
