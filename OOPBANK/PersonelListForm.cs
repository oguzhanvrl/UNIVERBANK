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
    public partial class PersonelListForm : Form
    {
        Banka Bankam;
        Personel p;
        int satir = 0, sutun = 0, islem;
        public PersonelListForm()
        {
            InitializeComponent();
        }

        public PersonelListForm(Banka BANKA,int islem)
        {
            InitializeComponent();
            this.Bankam = BANKA;
            this.islem = islem;
            dataGridView1.ReadOnly = true;
        }

        private void PersonelListForm_Load(object sender, EventArgs e)
        {
            guncelle();           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var personel = from y in Bankam.PersonelList where y.PID.ToString().StartsWith(textBox1.Text) select y;
            var list = new BindingList<Personel>(personel.ToList());
            dataGridView1.DataSource = list;
        }

        private void veznedarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.statuGuncelle(1);
            Bankam.IslemKayit(Convert.ToInt64(Bankam.OnlineKisi), p.PID, 200, p.PID.ToString() + " 'Nolu Personelin -> STATÜ Bilgileri Güncellenerek " + p.Departman + "oldu.");
            guncelle();
        }

        private void personelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.statuGuncelle(2);
            Bankam.IslemKayit(Convert.ToInt64(Bankam.OnlineKisi), p.PID, 200, p.PID.ToString() + " 'Nolu Personelin -> STATÜ Bilgileri Güncellenerek " + p.Departman + "oldu.");
            guncelle();
        }

        private void yöneticiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.statuGuncelle(3);
            Bankam.IslemKayit(Convert.ToInt64(Bankam.OnlineKisi), p.PID, 200, p.PID.ToString() + " 'Nolu Personelin -> STATÜ Bilgileri Güncellenerek " + p.Departman + "oldu.");
            guncelle();
        }

        private void maaşYatırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p = Bankam.PersonelList.Find(x => x.PID == Convert.ToInt64(dataGridView1.Rows[satir].Cells[0].Value));
            foreach(var x in p.VadesizHesapList)
            {
                x.HesapBakiye += p.Maas;
                MessageBox.Show("" + x.HesapBakiye);
                Bankam.BankaHazinesi -= p.Maas;
                Bankam.IslemKayit(Bankam.OnlineKisi,p.PID,200, Bankam.OnlineKisi.ToString()+" ID NOLU Yönetici --> " +p.PID.ToString()+" Nolu Personelin "+p.Maas.ToString()+" ₺ tutarındaki MAAŞINI ÖDEDİ !");
                Bankam.IslemKayit(1, p.PID, 140, Bankam.OnlineKisi.ToString() + " ID NOLU Yönetici --> " + p.PID.ToString() + " Nolu Personelin " + p.Maas.ToString() + " ₺ tutarındaki MAAŞINI ÖDEDİ !");
            }
            
        }

        void guncelle()
        {
            var list = new BindingList<Personel>(Bankam.PersonelList);
            dataGridView1.DataSource = list;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridView1.MultiSelect = false;
            if (e.Button == MouseButtons.Left && e.RowIndex != -1)
            {
                satir = e.RowIndex;
                sutun = e.ColumnIndex;
            }
            else if (e.Button == MouseButtons.Right && islem == 1)
                contextMenuStrip1.Show(Cursor.Position);
            else if (e.Button == MouseButtons.Right && islem == 2)
                contextMenuStrip2.Show(Cursor.Position);
            p = Bankam.PersonelList.Find(x => x.PID == Convert.ToInt64(dataGridView1.Rows[satir].Cells[0].Value));
        }
    }
}
