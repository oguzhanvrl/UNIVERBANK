using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBANK
{
    public class Islemler
    {
        public long KimID { get; set; }  // online kisi
         
        public long HID { get; set; }    // kime veya kim için veya hesap no

        public int IslemTür { get; set; } // 100 110 efthavele 210yrnimüşter

        public string Aciklama { get; set; }

        public DateTime Tarih { get; set; } 
    }

    

    /*
     * 
        BANKA İŞLEMLERİ = 1-99

        BANKA AÇILDI     10

        BANKA PARA GELDİ 20
        BANKA PARA ÇIKTI 30s
        

    MAAAŞDA --> BANKA ID PER ID

        PERS MAAŞ ÖDENDİ 40

        MÜşteri eklendi  50
        personel eklendi 60

        yeni hesap açıldı70
        hesap kapatıldı  80

        BANKA KAPANDI    90

            BANKA 100  PARA ÇIKAN 120  PARA GİREN 130  maaş yatırma 140
            PERSONEL 200
            MÜŞTERİ 300
            KREDİ  400
            VADELİ 500
            VADESİZ 600

    BİLDİRİMLER 700
    TALEP İŞLEMLERİ 800
    GİRİŞ ÇIKIŞ LOG 900



    // otomatik hesap açılma işlemi   müşteri ve personel ortak
     * 
    PERSONEL İŞLEMLERİ = 100-199        personel no ve kimID
    -hesapaçıldı pers       110
    -personel müş ekledi    120
    -para yatırıldı         130   +
    -para çekti             140   -
    -maaş aldı              180   -
    -statü yükseltme        195   +

        -hesapaçıldı pers oto   200

    MÜŞTERİ İŞLEMLERİ = 200-299            müşteri no ve kimID
    - müşteri sist eklend 200
    - hesapaçtı vadeli/siz210   otomatik açılan ve  kendi açtığı
    - para yatırdı        220   +
    - para çekti          230   -
    - havale gönderdi     240
    - havale geldi        250
    - Kborç ödedi         260   +
    - Kpara çekti         270   -
    - havale geldi        280   
    - vadeliparayatırdı   290   +
    - vadelibozduparaçek  295   -/+
    - hesap kapattı       298   



    KREDİ İŞLEMLERİ = 300-399                hesapID ve kimID
    - hesap açıldı   310
    - krepara çekti  320  -
    - borç ödendi    330  +
    - limit artırıldı340  -
    - hesap kapatıldı350

     
    VADESİZ HESAP İŞLEMLERİ =400-499          hesapID ve kimID
    - hesap açıldı   410  
    - para yatırldı  420  +
    - para çekildi   430  -
    - havale geldi   440  
    - havele gitti   450
    - hesapkapatıldı 460



    VADELİ HESAP İŞLEMLERİ = 500-599            hesapID ve kimID
    - hesap açıldı           510   +
    - para çekildi / bozuldu 520   -/+
    - hesap kapatıldı        530


     */
}
