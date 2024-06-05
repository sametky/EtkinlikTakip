using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EtkinlikTakip
{
    public partial class loginPage : Form
    {
        public loginPage()
        {
            InitializeComponent();
        }
        sqlBaglanti bgl = new sqlBaglanti();
        public static string kulid, kulad, kulsifre;
        bool durumkontrol = false;

        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT * FROM kullanici", bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (oku["kulad"].ToString() == txtKullaniciAdi.Text && oku["sifre"].ToString() == txtSifre.Text)
                {
                    durumkontrol = true;
                    kulid = oku.GetValue(0).ToString();
                    kulad = oku.GetValue(1).ToString();
                    kulsifre = oku.GetValue(2).ToString();
                    bool yetki = Convert.ToBoolean(oku["yetki"]);

                    if (yetki)
                    {
                        anasayfaFrm anasayfa = new anasayfaFrm();
                        anasayfa.yetki = "1"; // Yetki bilgisini atayalım
                        anasayfa.Show();
                    }
                    else
                    {
                        anasayfaAdmin adminSayfa = new anasayfaAdmin();
                        adminSayfa.yetki = "0"; // Yetki bilgisini atayalım
                        adminSayfa.Show();
                    }

                    this.Hide();
                    break;
                }
            }
            if (txtKullaniciAdi.Text == "" || txtSifre.Text == "")
            {
                MessageBox.Show("Kullanıcı adı veya şifre boş olamaz");
            }
            else if (durumkontrol == false)
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış");
            }
            bgl.baglanti().Close();
        }
    }
}
