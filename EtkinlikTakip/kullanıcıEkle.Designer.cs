namespace EtkinlikTakip
{
    partial class kullanıcıEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kullanıcıEkle));
            panel1 = new Panel();
            lblyetki = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            tbxTelNo = new MaskedTextBox();
            pictureBox1 = new PictureBox();
            btnDuzenle = new Button();
            label9 = new Label();
            tbxKullaniciID = new TextBox();
            label7 = new Label();
            btnSil = new Button();
            btnGuncelle = new Button();
            btnGetir = new Button();
            btnEkle = new Button();
            label6 = new Label();
            tbxŞifre = new TextBox();
            tbxEmail = new TextBox();
            tbxKullaniciAdi = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            cbxYetki = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.LightYellow;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(lblyetki);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(tbxTelNo);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnDuzenle);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(tbxKullaniciID);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(btnSil);
            panel1.Controls.Add(btnGuncelle);
            panel1.Controls.Add(btnGetir);
            panel1.Controls.Add(btnEkle);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(tbxŞifre);
            panel1.Controls.Add(tbxEmail);
            panel1.Controls.Add(tbxKullaniciAdi);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cbxYetki);
            panel1.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(14, 15);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1147, 699);
            panel1.TabIndex = 1;
            // 
            // lblyetki
            // 
            lblyetki.AutoSize = true;
            lblyetki.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point);
            lblyetki.Location = new Point(1067, 57);
            lblyetki.Name = "lblyetki";
            lblyetki.Size = new Size(67, 20);
            lblyetki.TabIndex = 53;
            lblyetki.Text = "lblyetki";
            lblyetki.Visible = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(174, 182, 191);
            button1.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(1048, 14);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 29);
            button1.TabIndex = 50;
            button1.Text = "Geri";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(450, 151);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 49;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(694, 498);
            dataGridView1.TabIndex = 49;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // tbxTelNo
            // 
            tbxTelNo.BorderStyle = BorderStyle.None;
            tbxTelNo.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tbxTelNo.Location = new Point(154, 260);
            tbxTelNo.Margin = new Padding(3, 4, 3, 4);
            tbxTelNo.Mask = "09990000000";
            tbxTelNo.Name = "tbxTelNo";
            tbxTelNo.Size = new Size(250, 19);
            tbxTelNo.TabIndex = 47;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(150, 252);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(285, 41);
            pictureBox1.TabIndex = 48;
            pictureBox1.TabStop = false;
            // 
            // btnDuzenle
            // 
            btnDuzenle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDuzenle.Location = new Point(1870, 96);
            btnDuzenle.Margin = new Padding(3, 4, 3, 4);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(126, 42);
            btnDuzenle.TabIndex = 23;
            btnDuzenle.Text = "DÜZENLE";
            btnDuzenle.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(93, 109, 126);
            label9.Font = new Font("Times New Roman", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(193, 99);
            label9.Name = "label9";
            label9.Size = new Size(180, 25);
            label9.TabIndex = 22;
            label9.Text = "Kullanıcı Bilgileri";
            // 
            // tbxKullaniciID
            // 
            tbxKullaniciID.Enabled = false;
            tbxKullaniciID.Location = new Point(149, 153);
            tbxKullaniciID.Margin = new Padding(3, 4, 3, 4);
            tbxKullaniciID.Name = "tbxKullaniciID";
            tbxKullaniciID.Size = new Size(285, 24);
            tbxKullaniciID.TabIndex = 21;
            tbxKullaniciID.Visible = false;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(1369, 43);
            label7.Name = "label7";
            label7.Size = new Size(130, 23);
            label7.TabIndex = 18;
            label7.Text = "Kullanıcı Listesi";
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.FromArgb(241, 148, 138);
            btnSil.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point);
            btnSil.Location = new Point(147, 547);
            btnSil.Margin = new Padding(3, 4, 3, 4);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(285, 42);
            btnSil.TabIndex = 17;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.FromArgb(245, 203, 167);
            btnGuncelle.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuncelle.Location = new Point(303, 497);
            btnGuncelle.Margin = new Padding(3, 4, 3, 4);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(131, 42);
            btnGuncelle.TabIndex = 16;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnGetir
            // 
            btnGetir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGetir.Location = new Point(1704, 96);
            btnGetir.Margin = new Padding(3, 4, 3, 4);
            btnGetir.Name = "btnGetir";
            btnGetir.Size = new Size(160, 42);
            btnGetir.TabIndex = 15;
            btnGetir.Text = "GETİR";
            btnGetir.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.FromArgb(133, 193, 233);
            btnEkle.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point);
            btnEkle.Location = new Point(147, 497);
            btnEkle.Margin = new Padding(3, 4, 3, 4);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(149, 42);
            btnEkle.TabIndex = 13;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(69, 201);
            label6.Name = "label6";
            label6.Size = new Size(48, 20);
            label6.TabIndex = 12;
            label6.Text = "Yetki";
            // 
            // tbxŞifre
            // 
            tbxŞifre.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            tbxŞifre.Location = new Point(150, 426);
            tbxŞifre.Margin = new Padding(3, 4, 3, 4);
            tbxŞifre.Multiline = true;
            tbxŞifre.Name = "tbxŞifre";
            tbxŞifre.Size = new Size(285, 41);
            tbxŞifre.TabIndex = 11;
            // 
            // tbxEmail
            // 
            tbxEmail.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            tbxEmail.Location = new Point(150, 367);
            tbxEmail.Margin = new Padding(3, 4, 3, 4);
            tbxEmail.Multiline = true;
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(285, 41);
            tbxEmail.TabIndex = 10;
            // 
            // tbxKullaniciAdi
            // 
            tbxKullaniciAdi.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            tbxKullaniciAdi.Location = new Point(150, 309);
            tbxKullaniciAdi.Margin = new Padding(3, 4, 3, 4);
            tbxKullaniciAdi.Multiline = true;
            tbxKullaniciAdi.Name = "tbxKullaniciAdi";
            tbxKullaniciAdi.Size = new Size(285, 41);
            tbxKullaniciAdi.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(62, 372);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 7;
            label5.Text = "E-Mail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(73, 431);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 6;
            label4.Text = "Şifre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(15, 314);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 5;
            label3.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(26, 256);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 3;
            label2.Text = "Telefon No";
            // 
            // cbxYetki
            // 
            cbxYetki.AutoCompleteCustomSource.AddRange(new string[] { "Yönetici", "Personel", "Kullanıcı" });
            cbxYetki.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxYetki.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cbxYetki.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cbxYetki.Items.AddRange(new object[] { "0", "1" });
            cbxYetki.Location = new Point(149, 201);
            cbxYetki.Margin = new Padding(3, 4, 3, 4);
            cbxYetki.Name = "cbxYetki";
            cbxYetki.Size = new Size(285, 30);
            cbxYetki.TabIndex = 0;
            cbxYetki.Text = "Seçim Yapınız.";
            // 
            // kullanıcıEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1175, 754);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "kullanıcıEkle";
            Text = "Kullanıcı Ekle";
            Load += kullanıcıEkle_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private MaskedTextBox tbxTelNo;
        private PictureBox pictureBox1;
        private Button btnDuzenle;
        private Label label9;
        private TextBox tbxKullaniciID;
        private Label label7;
        private Button btnSil;
        private Button btnGuncelle;
        private Button btnGetir;
        private Button btnEkle;
        private Label label6;
        private TextBox tbxŞifre;
        private TextBox tbxEmail;
        private TextBox tbxKullaniciAdi;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cbxYetki;
        private DataGridView dataGridView1;
        private Button button1;
        private Label lblyetki;
    }
}