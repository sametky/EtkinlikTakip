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
    public partial class anasayfaAdmin : Form
    {
        public anasayfaAdmin()
        {
            InitializeComponent();
        }
        public string yetki;

        private void button1_Click(object sender, EventArgs e)
        {
            etkinlikListeFrm lst = new etkinlikListeFrm();
            lst.yetki = lblyetki.Text;
            lst.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kullanıcıEkle ekle = new kullanıcıEkle();
            ekle.yetki = lblyetki.Text;
            ekle.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            etkinlikEkle ekle = new etkinlikEkle();
            ekle.yetki = lblyetki.Text;
            ekle.Show();
            this.Hide();
        }

        private void anasayfaAdmin_Load(object sender, EventArgs e)
        {
            lblyetki.Text = yetki;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loginPage login = new loginPage();
            login.Show();
            this.Close();
        }
    }
}
