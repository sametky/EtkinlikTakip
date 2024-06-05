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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EtkinlikTakip
{
    public partial class etkinlikEkle : Form
    {
        public etkinlikEkle()
        {
            InitializeComponent();
        }
        sqlBaglanti bgl = new sqlBaglanti();
        public string yetki;
        private void btnGetir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxKategori.Text) || string.IsNullOrEmpty(tbxEtkinlikTarihi.Text) || string.IsNullOrEmpty(cbxBaslangicSaati.Text) ||
               string.IsNullOrEmpty(cbxBitisSaati.Text) || string.IsNullOrEmpty(mtbxTelNo.Text) ||
            string.IsNullOrEmpty(tbxAdres.Text) || string.IsNullOrEmpty(tbxDetay.Text) ||
            string.IsNullOrEmpty(mtbxDavetliSayisi.Text) || string.IsNullOrEmpty(mtbxToplamUcret.Text) ||
               string.IsNullOrEmpty(tbxAciklama.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                return;
            }

            SqlCommand komut = new SqlCommand("insert into etkinlikbilgilerii(kategori,tarih,baslangic,bitis,telefon,adres,detay,kisi_sayisi,ucret,aciklama) values(@kategori,@tarih,@baslangic,@bitis,@telefon,@adres,@detay,@kisi_sayisi,@ucret,@aciklama)", bgl.baglanti());
            komut.Parameters.AddWithValue("@kategori", tbxKategori.Text);
            komut.Parameters.AddWithValue("@tarih", tbxEtkinlikTarihi.Text);
            komut.Parameters.AddWithValue("@baslangic", cbxBaslangicSaati.Text);
            komut.Parameters.AddWithValue("@bitis", cbxBitisSaati.Text);
            komut.Parameters.AddWithValue("@telefon", mtbxTelNo.Text);
            komut.Parameters.AddWithValue("@adres", tbxAdres.Text);
            komut.Parameters.AddWithValue("@detay", tbxDetay.Text);
            komut.Parameters.AddWithValue("@kisi_sayisi", mtbxDavetliSayisi.Text);
            komut.Parameters.AddWithValue("@ucret", mtbxToplamUcret.Text);
            komut.Parameters.AddWithValue("@aciklama", tbxAciklama.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Yeni etkinlik eklenmiştir");
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void etkinlikEkle_Load(object sender, EventArgs e)
        {
            lblyetki.Text = yetki;

        }

        private void lblyetki_Click(object sender, EventArgs e)
        {

        }
    }
}
