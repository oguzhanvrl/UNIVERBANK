using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBANK
{
    public abstract class Musteri : Kisi, IVadeliVadesizHesapAcabilen
    {
        public long MID { get; set; }

        public bool Onay { get; set; }

        public DateTime KayitTarih { get; set; }

        public double BankaMusteriPuani { get; set; }

        //ParaBirimEnum para;

        Banka BANKA;
        /*VadeliHesap vadeliHesapYeni;
        VadesizHesap vadesizHesapYeni;*/
        public Musteri()
        {
            this.Onay = false;
            this.KayitTarih = DateTime.Now;
        }
       /* public VadesizHesap VadesizTLAC(Banka BANKAM, long id)
        {
            this.BANKA = BANKAM;
            VadesizHesap vadesiztl = new VadesizHesap();
            vadesiztl.HID = BANKAM.IDVER(30000, 39999);
            vadesiztl.MüsteriTürü = false;

            if (id >= 18000 && id < 20000)
                vadesiztl.MüsteriTürü = true; // ticari müşteri ise true

            BANKA.IslemKayit(BANKA.OnlineKisi, 2, vadesiztl.HID.ToString() + " NUMARALI [VADESİZ TL HESAP] -> " + id.ToString() + " Kullaniciya tanimlandi");
            VadesizHesapList.Add(vadesiztl);
            BANKA.VadesizHesapList.Add(vadesiztl);

            return vadesiztl;
        }*/
        public VadesizHesap VadesizHesapAC(Banka BANKAM, long id, VadesizHesap vadesizHesapYeni)
        {
            this.BANKA = BANKAM;
            vadesizHesapYeni.HID = BANKA.IDVER(40000, 44999);
            vadesizHesapYeni.MüsteriTürü = false;
            
            if (id >= 18000 && id < 20000)
                vadesizHesapYeni.MüsteriTürü = true; // ticari müşteri ise true
            return vadesizHesapYeni;
        }

        public VadeliHesap VadeliHesapAC(Banka BANKAM, long id, VadeliHesap vadeliHesapYeni)
        {
            this.BANKA = BANKAM;
            vadeliHesapYeni.HID = BANKA.IDVER(40000, 44999);
            vadeliHesapYeni.MüsteriTürü = false;      

            if (id >= 18000 && id < 20000)
                vadeliHesapYeni.MüsteriTürü = true; // ticari müşteri ise true
            return vadeliHesapYeni;
        }
    }
}
