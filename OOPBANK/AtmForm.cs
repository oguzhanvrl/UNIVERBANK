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
    public partial class AtmForm : Form
    {
        public AtmForm()
        {
            InitializeComponent();
        }

        private void AtmForm_Load(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            btnMUSGiris.Visible = false;
            txtMUSNO.Visible = false;
            txtMUSSIFRE.Visible = false;
            lblMUSAD.Visible = false;
            pictureBox4.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox3.Visible = true;
            btnMUSGiris.Visible = true;
            txtMUSNO.Visible = true;
            txtMUSSIFRE.Visible = true;
        }

        private void btnMUSGiris_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            btnMUSGiris.Visible = false;
            txtMUSNO.Visible = false;
            txtMUSSIFRE.Visible = false;

            lblMUSAD.Visible = true;
            pictureBox4.Visible = true;


        }
    }
}
