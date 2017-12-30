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
    public partial class HesapListe : Form
    {
        Banka Bankam;
        BireyselMusteri b;
        KurumsalMusteri k;
        VadeliHesap v;
        KrediHesap kh;
        VadesizHesap vh;

        int musTip,tab=0,satira=0,sutuna=0,satirb=0,sutunb=0,satirc=0,sutunc=0;

        private void dgKredi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            satirc = e.RowIndex;
            sutunc = e.ColumnIndex;
        }

        private void dgKredi_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                contextMenuStrip1.Show(Cursor.Position);
        }

        private void tabHesaplar_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void dgVadeli_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgVadeli.MultiSelect = false;
            if (e.Button == MouseButtons.Left && e.RowIndex != -1)
            {
                satira = e.RowIndex;
                sutuna = e.ColumnIndex;
            }
        }

        private void dgVadesiz_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgVadesiz.MultiSelect = false;
            if (e.Button == MouseButtons.Left && e.RowIndex != -1)
            {
                satirb = e.RowIndex;
                sutunb = e.ColumnIndex;
            }
        }

        private void dgKredi_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgKredi.MultiSelect = false;
            if (e.Button == MouseButtons.Left && e.RowIndex != -1)
            {
                satirc = e.RowIndex;
                sutunc = e.ColumnIndex;
            }
        }

        private void dgVadesiz_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                contextMenuStrip3.Show(Cursor.Position);
        }

        private void hesabıSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(musTip==1)
            {
                kh = b.KrediHesapList.Find(x => x.HID == Convert.ToInt64(dgKredi.Rows[satirc].Cells[6].Value));
                if (kh.Borc == 0)
                {
                    b.KrediHesapList.Remove(kh);
                    Bankam.IslemKayit(Bankam.OnlineKisi, kh.HID, 400, Bankam.OnlineKisi.ToString() + " Nolu Müşteri  --> " + kh.HID.ToString() + " Nolu KREDİ HESABINI KAPATTI !");
                }

                else
                {
                    MessageBox.Show("Borcunu öde");
                }
            }
            else
            {
                kh = k.KrediHesapList.Find(x => x.HID == Convert.ToInt64(dgKredi.Rows[satirc].Cells[6].Value));
                if (vh.HesapBakiye == 0)
                {
                    k.KrediHesapList.Remove(kh);
                    Bankam.IslemKayit(Bankam.OnlineKisi, vh.HID, 600, Bankam.OnlineKisi.ToString() + " Nolu Müşteri  --> " + vh.HID.ToString() + " Nolu VADESİZ HESABINI KAPATTI !");
                }

                else
                {
                    MessageBox.Show("Borcunu öde");
                }
            }

        }

        private void hesabıSilToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (musTip == 1)
            {
                vh = b.VadesizHesapList.Find(x => x.HID == Convert.ToInt64(dgVadesiz.Rows[satirb].Cells[1].Value));
                if (vh.HesapBakiye == 0)
                    b.VadesizHesapList.Remove(vh);
                else
                {
                    MessageBox.Show("Paranı Çek");
                }
            }
            else
            {
                vh = k.VadesizHesapList.Find(x => x.HID == Convert.ToInt64(dgVadesiz.Rows[satirb].Cells[1].Value));
                if (vh.HesapBakiye == 0)
                    k.VadesizHesapList.Remove(vh);
                else
                {
                    MessageBox.Show("Paranı Çek");
                }
            }
        }

        private void hesabıBozToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v = b.VadeliHesapList.Find(x => x.HID == Convert.ToInt64(dgVadeli.Rows[satira].Cells[7].Value));
            b.VadeliHesapList.Remove(v);
            Bankam.IslemKayit(Bankam.OnlineKisi, v.HID, 500, Bankam.OnlineKisi.ToString() + " Nolu Müşteri  --> " + v.HID.ToString() + " Nolu VADELİ HESABINI KAPATTI !");
        }

        private void dgVadesiz_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
                
        }


        private void HesapListe_Load(object sender, EventArgs e)
        {
        }

        public HesapListe(Banka Banka)
        {
            InitializeComponent();
            this.Bankam = Banka;
                hesapBul(Bankam.OnlineKisi);
                tabHesaplar.Visible = true;
            
        }
        void hesapBul(long id)
        {
            b = Bankam.BireyselMusteriList.Find(x => x.MID == id);
            try
            {
                if (b.Equals(null))
                { }
                musTip = 1;
                tabHesaplar.Visible = true;
            }
            catch
            {
                k = Bankam.KurumsalMusteriList.Find(x => x.MID == id);
                try
                {
                    if (k.Equals(null))
                    { }
                    musTip = 2;
                    tabVadeli.Hide();
                    tabHesaplar.Visible = true;
                }
                catch
                {
                    MessageBox.Show("Hesap Bulunamadı !");
                }
            }
            if (musTip == 1)
            {
                BindingList<VadeliHesap> bv = new BindingList<VadeliHesap>(b.VadeliHesapList.ToList());
                dgVadeli.DataSource = bv;
                BindingList<VadesizHesap> bv2 = new BindingList<VadesizHesap>(b.VadesizHesapList.ToList());
                dgVadesiz.DataSource = bv2;
                BindingList<KrediHesap> bk = new BindingList<KrediHesap>(b.KrediHesapList.ToList());
                dgKredi.DataSource = bk;
            }
            if (musTip == 2)
            {

                BindingList<VadeliHesap> bv = new BindingList<VadeliHesap>(k.VadeliHesapList.ToList());
                dgVadeli.DataSource = bv;
                BindingList<VadesizHesap> bv2 = new BindingList<VadesizHesap>(k.VadesizHesapList.ToList());
                dgVadesiz.DataSource = bv2;
                BindingList<KrediHesap> bk = new BindingList<KrediHesap>(k.KrediHesapList.ToList());
                dgKredi.DataSource = bk;
            }
        }
        private void btnHesapBul_Click(object sender, EventArgs e)
        {          
           
            }

        private void dgVadeli_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                contextMenuStrip2.Show(Cursor.Position);
        }

        private void dgVadeli_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void tabHesaplar_SelectedIndexChanged(object sender, EventArgs e)
        {
            tab = tabHesaplar.SelectedIndex;
        }
    }
}
