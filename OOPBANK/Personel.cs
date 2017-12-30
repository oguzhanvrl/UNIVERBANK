using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBANK
{
    public enum Dept
    {
        Veznedar=1,
        MüşteriHizmetleri=2,
        Yönetici=3
    }


    public class Personel : Kisi
    {
        public long PID { get; set; }

        public int Statü { get; set; } // 1 / 2 / 3

        public string Departman { get; set; } // Veznedar / MüşteriHizmetleri / Yonetici

        public decimal Maas { get; set; } // 1500 / 2250 / 5000

        //HESAP

        public Banka BANKAM;

        public Personel()
        {
        }

        public void statuGuncelle(int Statü)
        {
            this.Statü = Statü;
            this.Departman = ((Dept)this.Statü).ToString();
            if (Statü == 1)
                this.Maas = 1500;
            else if (Statü == 2)
                this.Maas = 2250;
            else 
                this.Maas = 5000;         
        }

        public Personel(Banka Bankam)
        {
            this.BANKAM = Bankam;
            this.PID = BANKAM.IDVER(10001,14999);

            // otomatik olarak hesap açılıyor
            // vadesizTL ve Ekhesap tanımlandı!
            // BANKAM.EkHesapveVadesizTLHesapAC(this.PID);
        }
    }
}
