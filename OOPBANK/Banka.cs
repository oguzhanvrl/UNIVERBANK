using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBANK
{
    public class Banka
    {
        // Müşteri Hizmetleri TALEP

        public string BankaIsmi { get; set; }

        public DateTime KurulusTarih { get; set; }

        private long VergiNo { get; set; }

        private string VergiDairesi { get; set; }

        public string WebURL { get; private set; }

        private string ImtiyazSahibi { get; set; }

        public decimal BankaHazinesi { get; set; }

        public long OnlineKisi { get; set; }

        //borsa no vs...


        public List<Musteri> MusteriList { get; set; }

        public List<BireyselMusteri> BireyselMusteriList { get; set; }

        public List<KurumsalMusteri> KurumsalMusteriList { get; set; }

        public List<Personel> PersonelList { get; set; }


        //public List<Hesap> HesapList { get; set; }
        public List<KrediHesap> KrediHesapList { get; set; }

        public List<VadeliHesap> VadeliHesapList { get; set; }

        public List<VadesizHesap> VadesizHesapList { get; set; }


        public List<Islemler> IslemList { get; set; }

        //public List<Talep> TalepList { get; set; }

        public List<Bildirim> BildirimList { get; set; }

        public Islemler islems { get; set; }

        public Banka()
        {
            MusteriList = new List<Musteri>();
            PersonelList = new List<Personel>();
            BireyselMusteriList = new List<BireyselMusteri>();
            KurumsalMusteriList = new List<KurumsalMusteri>();
            KrediHesapList = new List<KrediHesap>();
            VadeliHesapList = new List<VadeliHesap>();
            VadesizHesapList = new List<VadesizHesap>();
            IslemList = new List<Islemler>();
            BildirimList = new List<Bildirim>();
            //TalepList = new List<Talep>();
            //HesapList = new List<Hesap>();

         

            this.BankaIsmi = "UNIVERBANK";
            this.KurulusTarih = DateTime.Now;
            this.VergiNo = 11111111111;
            this.VergiDairesi = "Turgutlu";
            this.WebURL = "www.google.com.tr";
            this.ImtiyazSahibi = "BEN";
            this.BankaHazinesi = 5000000M; // 5.000.000,00 ₺
            //BANKAMIZ OLUŞTURULDU ::::::::::::::::::::::::::::::::::::::::::::::::::::::


            //Bankaya bir yönetici statüsünde yetkili tanımlanıyor:::::::::::::::::::::::
            Personel Admin = new Personel();
            Admin.Statü = 3;
            Admin.PID = 10000;
            Admin.Sifre = Admin.passSifreleme("1",Admin.PID);
            Admin.Iletisim.CepTel = "05522209181";
            Admin.Maas = 5000M;
            Admin.Departman = "Üst Düzey Yetkili Yönetici";

            long KimID = Admin.PID;
            int IslemTür = 200; // Personel Ekleme
            string Aciklama = Admin.PID.ToString() + " -Statü : " + Admin.Statü.ToString() + " -Departman : " + Admin.Departman.ToString();

            IslemKayit(KimID,Admin.PID,IslemTür,Aciklama);
            PersonelList.Add(Admin);
        }


        public int IDVER(int x,int y) // personel - müşteri(bireysel / kurumsal)
        {
            Random id = new Random();
            int rand = id.Next(x, y); //persnoel (10001, 14999); --(15000, 17999bireysel / kurumsal 18000, 19999); // müşteri
            return rand;
        }

        public void IslemKayit(long kimid,long hid,int tür,string aciklama)
        {
            islems = new Islemler();
            islems.KimID = kimid;
            islems.HID = hid;
            islems.IslemTür = tür;
            islems.Aciklama = aciklama;
            islems.Tarih = DateTime.Now;

            IslemList.Add(islems);
        }
        public enum ParaBirimEnum
        {
            TL = 100,    //  1.00 ₺
            DOLAR = 380,  //  3.80 ₺
            EURO = 450,   //  4.50 ₺
            BTC = 6500000 // 65.000 ₺
        }
        public decimal KurBulEnum(string paraBirim)
        {
            string birim;
            if (ParaBirimEnum.TL.ToString("G") == paraBirim)
                birim = ParaBirimEnum.TL.ToString("D");
            else if (ParaBirimEnum.DOLAR.ToString("G") == paraBirim)
                birim = ParaBirimEnum.DOLAR.ToString("D");
            else if (ParaBirimEnum.EURO.ToString("G") == paraBirim)
                birim = ParaBirimEnum.EURO.ToString("D");
            else if (ParaBirimEnum.BTC.ToString("G") == paraBirim)
                birim = ParaBirimEnum.BTC.ToString("D");
            else
                birim = ParaBirimEnum.TL.ToString("D");
            return Convert.ToDecimal(birim);
        }
    }

}
