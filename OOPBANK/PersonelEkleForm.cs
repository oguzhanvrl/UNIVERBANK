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
    public partial class PersonelEkleForm : Form
    {
        Banka Bankam;
        public PersonelEkleForm()
        {
            InitializeComponent();
        }

        public PersonelEkleForm(Banka BANKA)
        {
            InitializeComponent();
            this.Bankam = BANKA;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Personel PerYeni = new Personel(Bankam);
                PerYeni.Kimlik.TCNo = Convert.ToInt64(textBox1.Text);
                PerYeni.Kimlik.Adi = textBox2.Text.ToUpper().ToString();
                PerYeni.Iletisim.CepTel = textBox4.Text.ToString();
                PerYeni.Sifre = PerYeni.passSifreleme(textBox3.Text.ToString(),PerYeni.PID);
                string combo = comboBox1.SelectedItem.ToString();
                if (combo == "Veznedar")
                {
                    PerYeni.Statü = 1;
                    PerYeni.Maas = 1500M;
                }
                else if (combo == "MüşteriHizmetleri")
                {
                    PerYeni.Statü = 2;
                    PerYeni.Maas = 2250M;
                }
                else if (combo == "Yonetici")
                {
                    PerYeni.Statü = 3;
                    PerYeni.Maas = 5000M;
                }
                else
                {
                    PerYeni.Statü = 1;
                    PerYeni.Maas = 1500M;
                }

                Bankam.PersonelList.Add(PerYeni);
                VadesizHesap v = PerYeni.VadesizTLAC(Bankam, PerYeni.PID);
                PerYeni.VadesizHesapList.Add(v);
                KrediHesap k = PerYeni.EkHesapAC(Bankam, PerYeni.PID);
                PerYeni.KrediHesapList.Add(k);

                MessageBox.Show(v.HID.ToString() + " NOLU [VADESİZ TL] HESABINIZ  ve  " + k.HID.ToString() + " NOLU [EK HESABINIZ] --> " + PerYeni.PID.ToString() + " NOLU Personele Hesabına Otomatik olarak tanımlanmıştır.");
                Bankam.IslemKayit(Bankam.OnlineKisi, PerYeni.PID,200,"Yeni "+ PerYeni.Statü.ToString() + combo.ToString()+ "Statülü "+ PerYeni.PID.ToString()+ " Nolu --> Personel Eklendi.");
                this.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("HATA!!!");
            }
 
        }

        private void PersonelEkleForm_Load(object sender, EventArgs e)
        {

        }
    }
}
