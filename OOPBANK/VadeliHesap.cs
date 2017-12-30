using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBANK
{
    public class VadeliHesap : Hesap
    {
        public DateTime VadeBaslangicTarih { get; set; }

        public DateTime VadeBitisTarih { get; set; }

        public double FaizOrani { get; set; }

        public int FaizSuresi { get; set; }
        //5AY %4 10AY %8 faiz

        public decimal YatirilanPara { get; set; }

        public double CezaOrani { get; set; } 
        
        // VADEYİ BOZ ve cezalı parayı al - Beklersende Yıllık olarak %2 artışla vade sonun fazili al

        public decimal CekilenPara { get; set; }

        public VadeliHesap()
        {
            this.VadeBaslangicTarih = DateTime.Now;
        }

    }


}
