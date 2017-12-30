using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBANK
{
    public class KimlikBilgi
    {
        public long TCNo { get; set; }

        public string Adi { get; set; }

        public string Soyadi { get; set; }

        public string DogumYeri { get; set; }

        public DateTime DogumTarihi { get; set; }

        public string Cinsiyet { get; set; }

        public string AnaAdi { get; set; }

        public string BabaAdi { get; set; }

        public string KanGrubu { get; set; }

        public string MedeniHali { get; set; }


        public KimlikBilgi()
        {

        }

    }
}
