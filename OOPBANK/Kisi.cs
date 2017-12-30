using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OOPBANK
{
    public abstract class Kisi : IlkHesapAlabilen,ISıfreKriptolanabilen
    {
        public IletisimBilgi Iletisim = new IletisimBilgi();

        public KimlikBilgi Kimlik = new KimlikBilgi();

        public string IletisimBilgi { get; set; }

        public string KimlikBilgi { get; set; }

        public string Sifre { get; set; }

        //public List<Hesap> Hesaplar { get; set; }

        public List<VadeliHesap> VadeliHesapList { get; set; }

        public List<VadesizHesap> VadesizHesapList { get; set; }

        public List<KrediHesap> KrediHesapList { get; set; }

        public List<Bildirim> BildirimList { get; set; }

        //public List<Islemler> IslemlerList { get; set; }

        EnumKrediTur tur;
        Banka BANKA;
        public Kisi()
        {
            Iletisim = new IletisimBilgi();
            Kimlik = new KimlikBilgi();
            tur = new EnumKrediTur();
            BildirimList = new List<Bildirim>();
            VadeliHesapList = new List<VadeliHesap>();
            VadesizHesapList = new List<VadesizHesap>();
            KrediHesapList = new List<KrediHesap>();

            IletisimBilgi = "...";
            KimlikBilgi = "...";

            //IslemlerList = new List<Islemler>();
        }

        public KrediHesap EkHesapAC(Banka BANKAM, long id)
        {
            this.BANKA = BANKAM;
            tur = EnumKrediTur.ekhesapKredi;
            KrediHesap ekHesap = new KrediHesap();
            ekHesap.KrediHesapTürü = tur.ToString("G").ToUpper();
            ekHesap.FaizOrani = Convert.ToDouble(tur.ToString("D"));
            ekHesap.HID = BANKA.IDVER(20000, 29999);
            //ekHesap.FaizliHacizLimiti
            ekHesap.MüsteriTürü = false;           //  normal müşteri ise false
      
            if (id >= 18000 && id < 20000)
                ekHesap.MüsteriTürü = true; // ticari müşteri ise true

            BANKA.IslemKayit(BANKA.OnlineKisi, id, 400, ekHesap.HID.ToString() + " NUMARALI [EKHESAP] -> " + id.ToString() + " Kullaniciya otomatik olarak tanimlandi.");
            BANKA.KrediHesapList.Add(ekHesap);

            return ekHesap;
        }
        public VadesizHesap VadesizTLAC(Banka BANKAM, long id)
        {
            this.BANKA = BANKAM;
            VadesizHesap vadesiztl = new VadesizHesap();
            vadesiztl.HID = BANKAM.IDVER(30000, 39999);
            vadesiztl.MüsteriTürü = false;

            if (id >= 18000 && id < 20000)
            vadesiztl.MüsteriTürü = true; // ticari müşteri ise true

            BANKA.IslemKayit(BANKA.OnlineKisi, id, 600, vadesiztl.HID.ToString() + " NUMARALI [VADESİZ TL HESAP] -> " + id.ToString() + " Kullaniciya otomatik olarak tanimlandi.");
            BANKA.VadesizHesapList.Add(vadesiztl);

            return vadesiztl;
        }

        public string passSifreleme(string Sifre, long MusteriID)
        {
                var kripto = Encoding.UTF8.GetBytes(Sifre);
                var anahtar = Encoding.UTF8.GetBytes(MusteriID.ToString());

                var HMACileSifrele = new HMACMD5(anahtar);
                var hashBytes = HMACileSifrele.ComputeHash(kripto);

                return System.BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
        }
    }

}
