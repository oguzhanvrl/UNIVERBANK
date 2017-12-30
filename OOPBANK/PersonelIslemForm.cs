using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPBANK
{
    public partial class PersonelIslemForm : Form
    {
        Banka BANKA;
        Random rnd;
        int kod;
        public PersonelIslemForm()
        {
            InitializeComponent();
        }
        public PersonelIslemForm(Banka BANKAM)
        {
            InitializeComponent();
            this.BANKA = BANKAM;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string ID;
            string pass;
            ID = txtID.Text.ToString();
            pass = txtSIFRE.Text.ToString();
            foreach (var personeller in BANKA.PersonelList)
            {
                if (personeller.PID == Convert.ToInt64(ID) && personeller.Sifre == personeller.passSifreleme(pass, Convert.ToInt64(txtID.Text)))
                {
                    rnd = new Random();
                    kod = rnd.Next(1000, 9999);            
                    SmsGonder(personeller.Iletisim.CepTel,kod);
                    GirisDogrulamaForm giris = new GirisDogrulamaForm(BANKA,personeller,kod);
                    this.Close();
                    giris.Show();
                }
            }
        }

        private void PersonelIslemForm_Load(object sender, EventArgs e)
        {
            BANKA.OnlineKisi = 0;
            if (BANKA.OnlineKisi > 0)
            {
                MessageBox.Show(BANKA.OnlineKisi.ToString() + "Zaten Aktifsiniz Önce çıkış yapın!");
                this.Hide();
            }
        }

        public void SmsGonder(string tel,int kod)
        {
            String testXml = "<request>";
            testXml += "<authentication>";
            testXml += "<username>5522209181</username>";
            testXml += "<password>123456789</password>";
            testXml += "</authentication>";
            testXml += "<order>";
            testXml += "<sender>BESTASLI</sender>";
            testXml += "<sendDateTime></sendDateTime>";
            testXml += "<message>";
            testXml += "<text>Deneme Mesaj ! : " +kod.ToString()+"</text>";
            testXml += "<receipents>";
            testXml += "<number>"+tel+"</number>";
            testXml += "</receipents>";
            testXml += "</message>";
            testXml += "</order>";
            testXml += "</request>";

            this.XMLPOST("http://api.iletimerkezi.com/v1/send-sms", testXml);
        }
        public string XMLPOST(string PostAddress, string xmlData)
        {
            try
            {
                var res = "";
                byte[] bytes = Encoding.UTF8.GetBytes(xmlData);
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(PostAddress);

                request.Method = "POST";
                request.ContentLength = bytes.Length;
                request.ContentType = "text/xml";
                request.Timeout = 300000000;
                using (Stream requestStream = request.GetRequestStream())
                {
                    requestStream.Write(bytes, 0, bytes.Length);
                }
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        string message = String.Format(
                        "POST failed. Received HTTP {0}",
                        response.StatusCode);
                        throw new ApplicationException(message);
                    }

                    Stream responseStream = response.GetResponseStream();
                    using (StreamReader rdr = new StreamReader(responseStream))
                    {
                        res = rdr.ReadToEnd();
                    }
                    return res;
                }
            }
            catch
            {
                return "-1";
            }
        }
    }
}
