using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EtkinlikTakip
{
    public partial class odemeAl : Form
    {
        public odemeAl()
        {
            InitializeComponent();
        }
        sqlBaglanti bgl = new sqlBaglanti();
        public string yetki;
        private void btnTahsilatEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxTCNo.Text) ||
               string.IsNullOrEmpty(tbxAdSoyad.Text) || string.IsNullOrEmpty(mtbxTutar.Text) ||
           string.IsNullOrEmpty(tbxTarih.Text) || string.IsNullOrEmpty(tbxAciklama.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                return;
            }

            SqlCommand komut = new SqlCommand("insert into sepet(tc,adsoyad,tutar,tarih,aciklama) values(@tc,@adsoyad,@tutar,@tarih,@aciklama)", bgl.baglanti());
            komut.Parameters.AddWithValue("@tc", tbxTCNo.Text);
            komut.Parameters.AddWithValue("@adsoyad", tbxAdSoyad.Text);
            komut.Parameters.AddWithValue("@tutar", mtbxTutar.Text);
            komut.Parameters.AddWithValue("@tarih", tbxTarih.Text);
            komut.Parameters.AddWithValue("@aciklama", tbxAciklama.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Sepete Eklenmiştir.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            odemeFrm odeme = new odemeFrm();
            odeme.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("select * from kullanici where yetki=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", lblyetki.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                if (lblyetki.Text == "1")
                {
                    anasayfaFrm frm3 = new anasayfaFrm();
                    frm3.yetki = lblyetki.Text;
                    frm3.Show();
                }
                else if (lblyetki.Text == "0")
                {
                    anasayfaAdmin frm2 = new anasayfaAdmin();
                    frm2.yetki = lblyetki.Text;
                    frm2.Show();
                }
                break;
            }
            bgl.baglanti().Close();

            this.Close();
        }

        private void odemeAl_Load(object sender, EventArgs e)
        {
            lblyetki.Text = yetki;

        }
    }
}
