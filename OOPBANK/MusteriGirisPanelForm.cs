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
    public partial class MusteriGirisPanelForm : Form
    {
        public MusteriGirisPanelForm()
        {
            InitializeComponent();
        }
        Banka BANKA;
        public MusteriGirisPanelForm(Banka Bankam)
        {
            InitializeComponent();
            this.BANKA = Bankam;
        }

        private void MusteriGirisPanelForm_Load(object sender, EventArgs e)
        {
      
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string ID, pass;
            ID = txtID.Text.ToString();
            pass = txtSIFRE.Text.ToString();
            foreach (var müsteriler in BANKA.MusteriList)
            {
                if (müsteriler.MID == Convert.ToInt64(ID) && müsteriler.Sifre == müsteriler.passSifreleme(pass, Convert.ToInt64(ID)))
                {
                    BANKA.OnlineKisi = müsteriler.MID;
                    BANKA.IslemKayit(BANKA.OnlineKisi, BANKA.OnlineKisi, 900, " Personel " + BANKA.OnlineKisi.ToString() + "--> Girişi Yapıldı !");
                    MusteriMenuForm m = new MusteriMenuForm(BANKA);
                    this.Close();
                    m.Show();
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
