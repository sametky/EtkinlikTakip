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
    public partial class kullanıcıEkle : Form
    {
        public kullanıcıEkle()
        {
            InitializeComponent();
        }
        sqlBaglanti bgl = new sqlBaglanti();
        public string yetki;
        private void LoadData()
        {

            SqlDataAdapter da = new SqlDataAdapter("select * from kullanici", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();

        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbxYetki.Text) ||
                string.IsNullOrEmpty(tbxTelNo.Text) || string.IsNullOrEmpty(tbxKullaniciAdi.Text) ||
            string.IsNullOrEmpty(tbxEmail.Text) || string.IsNullOrEmpty(tbxŞifre.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                return;
            }

            SqlCommand komut = new SqlCommand("insert into kullanici(kulad,sifre,email,telefon,yetki) values(@kulad,@sifre,@email,@telefon,@yetki)", bgl.baglanti());
            komut.Parameters.AddWithValue("@kulad", tbxKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@sifre", tbxŞifre.Text);
            komut.Parameters.AddWithValue("@email", tbxEmail.Text);
            komut.Parameters.AddWithValue("@telefon", tbxTelNo.Text);
            komut.Parameters.AddWithValue("@yetki", cbxYetki.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Yeni kullanıcı eklenmiştir");
            LoadData();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand checkCommand = new SqlCommand("SELECT COUNT(*) FROM kullanici WHERE id=@p1", bgl.baglanti());
            checkCommand.Parameters.AddWithValue("@p1", tbxKullaniciID.Text);

            int rowCount = (int)checkCommand.ExecuteScalar(); // Sorguyu çalıştır ve etkilenen satır sayısını al

            // Eğer öğrenci numarası mevcut değilse
            if (rowCount == 0)
            {
                MessageBox.Show("id numarası bulunamadı.");
            }
            else
            {
                // Öğrenci numarası mevcut ise silme işlemini gerçekleştir
                SqlCommand deleteCommand = new SqlCommand("DELETE FROM kullanici WHERE id=@p1", bgl.baglanti());
                deleteCommand.Parameters.AddWithValue("@p1", tbxKullaniciID.Text);
                int affectedRows = deleteCommand.ExecuteNonQuery(); // Silme işlemini gerçekleştir ve etkilenen satır sayısını al
                bgl.baglanti().Close();

                // Silme işlemi başarılıysa
                if (affectedRows > 0)
                {
                    MessageBox.Show("Kullanıcı silinmiştir.");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Silme işlemi gerçekleştirilemedi.");
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbxYetki.Text) ||
               string.IsNullOrEmpty(tbxTelNo.Text) || string.IsNullOrEmpty(tbxKullaniciAdi.Text) ||
           string.IsNullOrEmpty(tbxEmail.Text) || string.IsNullOrEmpty(tbxŞifre.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                return;
            }

            SqlCommand checkCommand = new SqlCommand("SELECT COUNT(*) FROM kullanici WHERE id=@p1", bgl.baglanti());
            checkCommand.Parameters.AddWithValue("@p1", tbxKullaniciID.Text);

            int rowCount = (int)checkCommand.ExecuteScalar(); // Sorguyu çalıştır ve etkilenen satır sayısını al

            // Eğer öğrenci numarası mevcut değilse
            if (rowCount == 0)
            {
                MessageBox.Show("Öğrenci numarası bulunamadı.");
            }
            SqlCommand komut = new SqlCommand("update kullanici set kulad=@kulad, sifre=@sifre, email=@email, telefon=@telefon, yetki=@yetki where id=@id", bgl.baglanti());
            komut.Parameters.AddWithValue("@id", tbxKullaniciID.Text);
            komut.Parameters.AddWithValue("@kulad", tbxKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@sifre", tbxŞifre.Text);
            komut.Parameters.AddWithValue("@email", tbxEmail.Text);
            komut.Parameters.AddWithValue("@telefon", tbxTelNo.Text);
            komut.Parameters.AddWithValue("@yetki", cbxYetki.Text);
            komut.ExecuteNonQuery();


            MessageBox.Show("kullanıcı bilgileri güncellenmiştir");
            LoadData();
        }

        private void kullanıcıEkle_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from kullanici", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();
            lblyetki.Text = yetki;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                tbxKullaniciID.Text = row.Cells["id"].Value.ToString();
                tbxKullaniciAdi.Text = row.Cells["kulad"].Value.ToString();
                tbxŞifre.Text = row.Cells["sifre"].Value.ToString();
                tbxEmail.Text = row.Cells["email"].Value.ToString();
                tbxTelNo.Text = row.Cells["telefon"].Value.ToString();
                cbxYetki.Text = row.Cells["yetki"].Value.ToString();
            }
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
    }
}
