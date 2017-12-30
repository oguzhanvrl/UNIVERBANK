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
    public partial class GirisDogrulamaForm : Form
    {
        public GirisDogrulamaForm()
        {
            InitializeComponent();
        }
        Banka BANKA;
        Random rnd;
        Personel personel;
        int dkod;
        public GirisDogrulamaForm(Banka BANKAM , Personel p, int kod)
        {
            InitializeComponent();
            this.BANKA = BANKAM;
            this.personel = p;
            this.dkod = kod;
        }

        private void GirisDogrulamaForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            BANKA.OnlineKisi = personel.PID;
            PersonelIslemMenu m = new PersonelIslemMenu(BANKA);
            this.Close();
            if (a.ToString() == dkod.ToString())
                MessageBox.Show("KOD DOĞRU","UNIVER-BANK TEST", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("KOD YANLIŞ","UNIVER-BANK TEST",MessageBoxButtons.OK,MessageBoxIcon.Information);
                m.Show();


            // Giriş Yapıldı ------------- IslemKayit ekleeeeeeeeee
            BANKA.IslemKayit(BANKA.OnlineKisi, BANKA.OnlineKisi, 900, " Personel "+ BANKA.OnlineKisi.ToString() +"--> Girişi Yapıldı !");
        }
    }
}
