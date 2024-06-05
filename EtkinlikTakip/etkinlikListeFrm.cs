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
    public partial class etkinlikListeFrm : Form
    {
        public etkinlikListeFrm()
        {
            InitializeComponent();
        }
        sqlBaglanti bgl = new sqlBaglanti();
        public string yetki;
        private void etkinlikListeFrm_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select kategori, tarih, baslangic,bitis,telefon,adres,detay,ucret,aciklama from etkinlikbilgiler", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();
            lblyetki.Text = yetki;

        }

        private void btnTumunuSec_Click(object sender, EventArgs e)
        {
            cbxDugun.Checked = true;
            cbxKina.Checked = true;
            cbxMezuniyet.Checked = true;
            cbxNisan.Checked = true;
            cbxSunnetDugunu.Checked = true;
            cbxToplanti.Checked = true;
            cbxKokteyl.Checked = true;
            cbxKonferans.Checked = true;
            cbxDiger.Checked = true;
            cbxNikah.Checked = true;
            cbxIftar.Checked = true;
        }

        private void btnHepsiniBirak_Click(object sender, EventArgs e)
        {
            cbxDugun.Checked = false;
            cbxKina.Checked = false;
            cbxMezuniyet.Checked = false;
            cbxNisan.Checked = false;
            cbxSunnetDugunu.Checked = false;
            cbxToplanti.Checked = false;
            cbxKokteyl.Checked = false;
            cbxKonferans.Checked = false;
            cbxDiger.Checked = false;
            cbxNikah.Checked = false;
            cbxIftar.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Seçili kategorileri belirle
            List<string> selectedCategories = new List<string>();

            if (cbxDugun.Checked) selectedCategories.Add("Düğün");
            if (cbxKina.Checked) selectedCategories.Add("Kına");
            if (cbxMezuniyet.Checked) selectedCategories.Add("Mezuniyet");
            if (cbxNisan.Checked) selectedCategories.Add("Nişan");
            if (cbxSunnetDugunu.Checked) selectedCategories.Add("Sünnet Düğünü");
            if (cbxToplanti.Checked) selectedCategories.Add("Toplantı");
            if (cbxKokteyl.Checked) selectedCategories.Add("Kokteyl");
            if (cbxKonferans.Checked) selectedCategories.Add("Konferans");
            if (cbxDiger.Checked) selectedCategories.Add("Diğer");
            if (cbxNikah.Checked) selectedCategories.Add("Nikah");
            if (cbxIftar.Checked) selectedCategories.Add("İftar");

            // Seçili tarihi al
            DateTime selectedDate = mcalGunSecici.SelectionRange.Start;
            
            // SQL sorgusu oluştur
            string query = "SELECT kategori, tarih, baslangic, bitis, telefon, adres, detay, ucret, aciklama FROM etkinlikbilgiler WHERE tarih = @selectedDate";

            if (selectedCategories.Count > 0)
            {
                string categories = string.Join("','", selectedCategories);
                query += $" AND kategori IN ('{categories}')";
            }

            // SQL sorgusunu çalıştır ve sonuçları DataGridView'e yükle
            SqlDataAdapter da = new SqlDataAdapter(query, bgl.baglanti());
            da.SelectCommand.Parameters.AddWithValue("@selectedDate", selectedDate);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();
        }

        private void btnHaftalik_Click(object sender, EventArgs e)
        {
            List<string> selectedCategories = new List<string>();

            if (cbxDugun.Checked) selectedCategories.Add("Düğün");
            if (cbxKina.Checked) selectedCategories.Add("Kına");
            if (cbxMezuniyet.Checked) selectedCategories.Add("Mezuniyet");
            if (cbxNisan.Checked) selectedCategories.Add("Nişan");
            if (cbxSunnetDugunu.Checked) selectedCategories.Add("Sünnet Düğünü");
            if (cbxToplanti.Checked) selectedCategories.Add("Toplantı");
            if (cbxKokteyl.Checked) selectedCategories.Add("Kokteyl");
            if (cbxKonferans.Checked) selectedCategories.Add("Konferans");
            if (cbxDiger.Checked) selectedCategories.Add("Diğer");
            if (cbxNikah.Checked) selectedCategories.Add("Nikah");
            if (cbxIftar.Checked) selectedCategories.Add("İftar");

            // Seçili tarihi al
            DateTime selectedDate = mcalGunSecici.SelectionRange.Start;

            // SQL sorgusu oluştur
            string query = "SELECT kategori, tarih, baslangic, bitis, telefon, adres, detay, ucret, aciklama FROM etkinlikbilgiler WHERE tarih = @selectedDate";

            if (selectedCategories.Count > 0)
            {
                string categories = string.Join("','", selectedCategories);
                query += $" AND kategori IN ('{categories}')";
            }

            query += " ORDER BY ucret ASC";

            // SQL sorgusunu çalıştır ve sonuçları DataGridView'e yükle
            SqlDataAdapter da = new SqlDataAdapter(query, bgl.baglanti());
            da.SelectCommand.Parameters.AddWithValue("@selectedDate", selectedDate);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();
        }

        private void btnAylik_Click(object sender, EventArgs e)
        {
            List<string> selectedCategories = new List<string>();

            if (cbxDugun.Checked) selectedCategories.Add("Düğün");
            if (cbxKina.Checked) selectedCategories.Add("Kına");
            if (cbxMezuniyet.Checked) selectedCategories.Add("Mezuniyet");
            if (cbxNisan.Checked) selectedCategories.Add("Nişan");
            if (cbxSunnetDugunu.Checked) selectedCategories.Add("Sünnet Düğünü");
            if (cbxToplanti.Checked) selectedCategories.Add("Toplantı");
            if (cbxKokteyl.Checked) selectedCategories.Add("Kokteyl");
            if (cbxKonferans.Checked) selectedCategories.Add("Konferans");
            if (cbxDiger.Checked) selectedCategories.Add("Diğer");
            if (cbxNikah.Checked) selectedCategories.Add("Nikah");
            if (cbxIftar.Checked) selectedCategories.Add("İftar");

            // Seçili tarihi al
            DateTime selectedDate = mcalGunSecici.SelectionRange.Start;

            // SQL sorgusu oluştur
            string query = "SELECT kategori, tarih, baslangic, bitis, telefon, adres, detay, ucret, aciklama FROM etkinlikbilgiler WHERE tarih = @selectedDate";

            if (selectedCategories.Count > 0)
            {
                string categories = string.Join("','", selectedCategories);
                query += $" AND kategori IN ('{categories}')";
            }

            query += " ORDER BY ucret DESC";

            // SQL sorgusunu çalıştır ve sonuçları DataGridView'e yükle
            SqlDataAdapter da = new SqlDataAdapter(query, bgl.baglanti());
           da.SelectCommand.Parameters.AddWithValue("@selectedDate", selectedDate);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("select * from kullanici where yetki=@yetki", bgl.baglanti());
            komut1.Parameters.AddWithValue("@yetki", lblyetki.Text);
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
    }
}
