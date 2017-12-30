using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPBANK
{
    public partial class Personeller : Form
    {
        Banka Bankam;
        public Personeller(Banka Banka)
        {
            InitializeComponent();
            this.Bankam = Banka;
        }

        private void Personeller_Load(object sender, EventArgs e)
        {
            int s1 = 0, s2 = 0, s3 = 0;
            foreach(Personel p in Bankam.PersonelList)
            {
                if (p.Statü == 1)
                    s1++;
                else if (p.Statü == 2)
                    s2++;
                else
                    s3++;
            }
            lbVSayi.Text = "Veznedar Sayısı :" + s1;
            Personel pp = Bankam.PersonelList.Find(x => x.PID == Bankam.OnlineKisi);
            lbOnline.Text = "ID #" + Bankam.OnlineKisi + " " + pp.Kimlik.Adi+" " + pp.Kimlik.Soyadi;
            lbMHSayi.Text = "Müşteri Hizmetleri Sayısı :" + s2;
            lbYSayi.Text = "Yönetici Sayısı :" + s3;
        }
    }
}
