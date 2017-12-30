using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBANK
{
    public class KurumsalMusteri : Musteri,IMusteriPuanAlabilen
    {
        public FirmaBilgi Firma = new FirmaBilgi();

        public string FirmaBilgi { get; set; }

        public decimal FirmaMalVarlik { get; set; }

        public decimal FirmaCirosu { get; set; }

        public double FirmaPuanLimit { get; set; }

        //public int FirmaKrediLEVEL { get; set; } // Kredi ÜSTLimitini belirler. 12345

        Banka Bankam;
        public KurumsalMusteri()
        {
            FirmaBilgi = "...";
        }
        public KurumsalMusteri(Banka BANKAM)
        {
            this.Bankam = BANKAM;
            this.BankaMusteriPuani = 100;
            this.MID = BANKAM.IDVER(18000, 19999);
        }

        public double MusteriPuanHesapla()
        {
            FirmaPuanLimit = ((( Convert.ToUInt64(FirmaCirosu) * 12) + Convert.ToUInt64(FirmaMalVarlik)) * 0.8);
            return FirmaPuanLimit;
        }
    }
}
