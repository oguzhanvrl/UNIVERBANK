using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBANK
{
    public class Bildirim
    {
        public long Kim { get; set; }

        public int Tür { get; set; }

        public string Aciklama { get; set; }

        public DateTime Tarih { get; set; }

        public string IconURL { get; set; }

        public bool PersoneleIletilme { get; set; }  // 1 ise Personel görsün - 0 ise Görmesin 

        public Bildirim()
        {

        }

        public virtual string TureGoreBildirimRenkGonder(int Tür)
        {
            //this.Tür = Tür;
            return "siyah";
        }
    }
}
