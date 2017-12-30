using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBANK
{
    public abstract class Hesap
    {
        public long HID { get; set; }

        public DateTime HesapAcilisTarihi { get; set; }

        public bool MüsteriTürü { get; set; } // Tür : 1 TRUE ise Kurumsal 0 ise Bireysel Müşteri

        public string HesapParaBirimi { get; set; }

        public decimal ParaBirimiKuru { get; set; }

        public Hesap()
        {
            this.HesapAcilisTarihi = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            this.HesapParaBirimi = ParaBirimEnum.TL.ToString("G");
            this.ParaBirimiKuru = Convert.ToInt16(ParaBirimEnum.TL.ToString("D"))/100;
        }

        public enum ParaBirimEnum
        {
            TL = 100,    //  1.00 ₺
            DOLAR = 380,  //  3.80 ₺
            EURO = 450,   //  4.50 ₺
            BTC = 6500000 // 65.000 ₺
        }
    }

}
