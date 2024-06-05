using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EtkinlikTakip
{
    public partial class anasayfaFrm : Form
    {
        public anasayfaFrm()
        {
            InitializeComponent();
        }
        public string yetki;

        private void button1_Click(object sender, EventArgs e)
        {
            etkinlikListeFrm listele = new etkinlikListeFrm();
            listele.yetki = lblyetki.Text;
            listele.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            etkinlikEkle ekle = new etkinlikEkle();
            ekle.yetki = lblyetki.Text;

            ekle.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            odemeAl odemefrm = new odemeAl();
            odemefrm.yetki = lblyetki.Text;

            odemefrm.Show();
            this.Hide();
        }

        private void anasayfaFrm_Load(object sender, EventArgs e)
        {
            lblyetki.Text = yetki;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            loginPage login = new loginPage();
            login.Show();
            this.Close();
        }
    }
}
