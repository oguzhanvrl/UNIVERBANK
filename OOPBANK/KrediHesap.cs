using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBANK
{
    public class KrediHesap : Hesap , IKrediLimitBelirlenebilen , IKrediPuaniDegistirilebilen
    {
        public decimal Limit { get; set; } // enumdan ne seçerse ona göre üst limit hesaplanması

        public double FaizOrani { get; set; }

        public int Vade { get; set; } //12/24/36/48/60/72/84/96/108/120     //%1/2/3/4/5/6/7/8/9/10

        public decimal Borc { get; set; }

        public decimal FaizliHacizLimiti { get; set; } //%80 ->  %100

        public string KrediHesapTürü { get; set; } 
        
        //public Para para { get; set; }

        public KrediHesap()
        {
            //EK HESAP ORANLARI 

            this.KrediHesapTürü = EnumKrediTur.ekhesapKredi.ToString("G");
            this.FaizOrani = Convert.ToDouble(EnumKrediTur.ekhesapKredi.ToString("D"));
            this.Limit = 750M;
            this.Vade = 1; //AYLIK
            this.Borc = 0;
            this.FaizliHacizLimiti = 0;            
        }


        public decimal KrediLimitHesapla(double puanLimit, double krediFaizDeger)
        {
            // 100 - 1000
            // tutar geldi

           /* decimal a;
            a = (Convert.ToDecimal(puanLimit * 0.2) * Convert.ToDecimal(krediTür.ToString("D")));*/  


            //puandan düşür 100  puanLimitse
            //               x de KrediLimit diyip 100den x i çıkarcaz
            return (Convert.ToDecimal(puanLimit * 0.1) * Convert.ToDecimal(krediFaizDeger));
        }

        public double MusteriKrediPuaniIslemleri(decimal deger, double puanLimit)
        {
            // para gelirse puan artır o oranla
            // birde ilk kredi tanımlanınca para oranı kadar puan düşür

            //((a*100) / puanLimit) müsteripuanından düşür

            // double döndür müşteripuandan çıkart abi
            return (Convert.ToDouble(deger * 100) / puanLimit);
        }


    }
    public enum EnumKrediTur
    {
        ekhesapKredi = 1,
        // Bireysel Kredi faiz oranları
        evKredisi = 5,       //kişi malvarlığının %90 nı + 5 yıllık aylık geliri toplamı ev kredinsi limitini belirler 
        ihtiyacKredisi = 3,  // herkes çekebilir ihtiyaç kredinde tüm oranlar sabittir ve 10bin TL ye kadar herkese verilir.
        tarimKredisi = 2,   //tarım kredisine başvururken tarımvehayvancılık bakanlığından tarımIDnizi sisteme girmelisiniz üst limit30bin

        // Kurumsal Kredi faiz oranları
        megaKredi = 2,     //AYLIK CIROSU 30bin TL ve altındaki tüm kurumsal müşterilerimiz faydalanabilir SABIT KREDİ LİMİTi = 50bin TL dir
        gigaKredi = 4, // AYLIK CIROSU 75bin TL ve üstündeki krumsal müşterilerimiz faydalanabilir üst Limit Sabittir 150bin TLdir.
        teraKredi = 7   // AYLIK CIROSU +100bin TL ve üstendeki kurumsal müşterilerimiz faydanalabilir üst Limit hesaplanırken 
                        //firma mal varlıklarının %80 ini ne kadar kredi çekebilirler 
    }
}
