using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBANK
{
   public class VadesizHesap : Hesap
    {
        public decimal HesapBakiye { get; set; }
        public decimal GunlukHarcama { get; set; }

        public VadesizHesap()
        {
            this.HesapBakiye = 0M;
            this.GunlukHarcama = 0m;
        }
    }

}
