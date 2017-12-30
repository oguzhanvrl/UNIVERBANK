using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBANK
{
    public class BireyselMusteri : Musteri,IMusteriPuanAlabilen
    {
        public decimal AylikGelir { get; set; }

        public decimal BireyselMalVarlik { get; set; }

        public string AnneKizlikSoyAdi { get; set; }

        public double BireyselPuanLimit { get; set; }

        Banka Bankam;
        public BireyselMusteri()
        {

        }
        public BireyselMusteri(Banka BANKAM)
        {
            this.Bankam = BANKAM;
            this.BankaMusteriPuani = 100;
            this.MID = BANKAM.IDVER(15000, 17999);

        }

        public double MusteriPuanHesapla()
        {           
            this.BireyselPuanLimit = (((Convert.ToUInt64(this.AylikGelir) * 12) + Convert.ToUInt64(this.BireyselMalVarlik)) * 0.8);
            return BireyselPuanLimit;
        }

    }
    
}
