using System.Data.SqlClient;
using System.Data;

namespace EtkinlikTakip
{
    public partial class odemeFrm : Form
    {
        public odemeFrm()
        {
            InitializeComponent();
        }
        sqlBaglanti bgl = new sqlBaglanti();
        public string yetki;
        private void LoadData()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from sepet", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            bgl.baglanti().Close();

            listView1.Items.Clear();
            decimal toplamTutar = 0;

            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row["id"].ToString());
                item.SubItems.Add(row["tc"].ToString());
                item.SubItems.Add(row["adsoyad"].ToString());
                item.SubItems.Add(row["tutar"].ToString());
                item.SubItems.Add(row["tarih"].ToString());
                item.SubItems.Add(row["aciklama"].ToString());

                listView1.Items.Add(item);

                decimal tutar = 0;
                decimal.TryParse(row["tutar"].ToString(), out tutar);
                toplamTutar += tutar;
            }

            label13.Text = "Toplam: " + toplamTutar.ToString("C");
        }
        private void LoadPayments()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from odeme", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            bgl.baglanti().Close();

            listKasaGecmisi.Items.Clear();

            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row["id"].ToString());
                item.SubItems.Add(row["tc"].ToString());
                item.SubItems.Add(row["adsoyad"].ToString());
                item.SubItems.Add(row["tutar"].ToString());
                item.SubItems.Add(row["tarih"].ToString());
                item.SubItems.Add(row["aciklama"].ToString());

                listKasaGecmisi.Items.Add(item);
            }
        }
        private void odemeFrm_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadPayments();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string toplamTutarStr = label13.Text.Replace("Toplam: ", "").Replace("?", "").Trim();
            decimal toplamTutar;

            // Toplam tutarý decimal'e dönüþtür
            if (decimal.TryParse(toplamTutarStr, System.Globalization.NumberStyles.Currency, System.Globalization.CultureInfo.CurrentCulture, out toplamTutar))
            {
                // Kullanýcýya onay mesajý göster
                DialogResult result = MessageBox.Show($"Toplam {toplamTutar.ToString("C")} kadar ödemenizi gerçekleþtirmek istediðinize emin misiniz?", "Ödeme Onayý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Eðer kullanýcý "Evet" derse
                if (result == DialogResult.Yes)
                {
                    SqlConnection connection = bgl.baglanti();
                    SqlCommand command = new SqlCommand("INSERT INTO odeme (tc, adsoyad, tutar, tarih, aciklama) SELECT tc, adsoyad, tutar, tarih, aciklama FROM sepet", connection);
                    command.ExecuteNonQuery();

                    SqlCommand clearCommand = new SqlCommand("DELETE FROM sepet", connection);
                    clearCommand.ExecuteNonQuery();

                    connection.Close();

                    LoadData();
                    LoadPayments();

                    MessageBox.Show("Ödemeniz gerçekleþtirildi.");
                }
                else
                {
                    MessageBox.Show("Ödeme iþlemi iptal edildi.");
                }
            }
            else
            {
                MessageBox.Show("Toplam tutar geçersiz.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM odeme";

            if (comboBox1.SelectedItem != null)
            {
                string selectedOption = comboBox1.SelectedItem.ToString();

                switch (selectedOption)
                {
                    case "YENÝ TARÝHE GÖRE LÝSTELE":
                        query += " ORDER BY tarih DESC";
                        break;
                    case "ESKÝ TARÝHE GÖRE LÝSTELE":
                        query += " ORDER BY tarih ASC";
                        break;
                    case "TUMU":
                    default:
                        // Default case is already handled with the base query
                        break;
                }
            }

            SqlDataAdapter da = new SqlDataAdapter(query, bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            bgl.baglanti().Close();

            listKasaGecmisi.Items.Clear();

            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row["id"].ToString());
                item.SubItems.Add(row["tc"].ToString());
                item.SubItems.Add(row["adsoyad"].ToString());
                item.SubItems.Add(row["tutar"].ToString());
                item.SubItems.Add(row["tarih"].ToString());
                item.SubItems.Add(row["aciklama"].ToString());

                listKasaGecmisi.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
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
