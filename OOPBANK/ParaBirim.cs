using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBANK
{
    public class ParaBirim
    {
        public int ParaID { get; set; }  // 1 TürkLirası 2 Dolar 3 Euro 4 BTC

        public string Isim { get; set; }

        public decimal Kur { get; private set; } // internetten çekebiliriz...

        public ParaBirim()
        {
            
        }

    }
}
