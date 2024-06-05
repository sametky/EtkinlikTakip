namespace EtkinlikTakip
{
    partial class etkinlikEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(etkinlikEkle));
            btnGetir = new Button();
            label20 = new Label();
            mtbxToplamUcret = new MaskedTextBox();
            label18 = new Label();
            mtbxDavetliSayisi = new MaskedTextBox();
            tbxDetay = new TextBox();
            tbxAdres = new TextBox();
            mtbxTelNo = new MaskedTextBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label10 = new Label();
            label8 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label17 = new Label();
            tbxAciklama = new TextBox();
            label5 = new Label();
            button1 = new Button();
            lblyetki = new Label();
            tbxKategori = new TextBox();
            tbxEtkinlikTarihi = new TextBox();
            cbxBaslangicSaati = new MaskedTextBox();
            cbxBitisSaati = new MaskedTextBox();
            SuspendLayout();
            // 
            // btnGetir
            // 
            btnGetir.BackColor = Color.FromArgb(229, 152, 102);
            btnGetir.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point);
            btnGetir.Location = new Point(254, 823);
            btnGetir.Margin = new Padding(3, 4, 3, 4);
            btnGetir.Name = "btnGetir";
            btnGetir.Size = new Size(77, 36);
            btnGetir.TabIndex = 80;
            btnGetir.Text = "Ekle";
            btnGetir.UseVisualStyleBackColor = false;
            btnGetir.Click += btnGetir_Click;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point);
            label20.Location = new Point(299, 594);
            label20.Name = "label20";
            label20.Size = new Size(35, 22);
            label20.TabIndex = 79;
            label20.Text = "TL";
            // 
            // mtbxToplamUcret
            // 
            mtbxToplamUcret.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            mtbxToplamUcret.Location = new Point(179, 589);
            mtbxToplamUcret.Margin = new Padding(3, 4, 3, 4);
            mtbxToplamUcret.Mask = "0000000";
            mtbxToplamUcret.Name = "mtbxToplamUcret";
            mtbxToplamUcret.Size = new Size(115, 27);
            mtbxToplamUcret.TabIndex = 75;
            mtbxToplamUcret.TextAlign = HorizontalAlignment.Right;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point);
            label18.Location = new Point(285, 551);
            label18.Name = "label18";
            label18.Size = new Size(42, 22);
            label18.TabIndex = 73;
            label18.Text = "Kişi";
            // 
            // mtbxDavetliSayisi
            // 
            mtbxDavetliSayisi.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            mtbxDavetliSayisi.Location = new Point(179, 541);
            mtbxDavetliSayisi.Margin = new Padding(3, 4, 3, 4);
            mtbxDavetliSayisi.Mask = "00000";
            mtbxDavetliSayisi.Name = "mtbxDavetliSayisi";
            mtbxDavetliSayisi.Size = new Size(100, 27);
            mtbxDavetliSayisi.TabIndex = 72;
            // 
            // tbxDetay
            // 
            tbxDetay.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tbxDetay.Location = new Point(183, 496);
            tbxDetay.Margin = new Padding(3, 4, 3, 4);
            tbxDetay.Name = "tbxDetay";
            tbxDetay.Size = new Size(249, 27);
            tbxDetay.TabIndex = 71;
            // 
            // tbxAdres
            // 
            tbxAdres.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbxAdres.Location = new Point(183, 276);
            tbxAdres.Margin = new Padding(3, 4, 3, 4);
            tbxAdres.Multiline = true;
            tbxAdres.Name = "tbxAdres";
            tbxAdres.ScrollBars = ScrollBars.Vertical;
            tbxAdres.Size = new Size(249, 163);
            tbxAdres.TabIndex = 69;
            // 
            // mtbxTelNo
            // 
            mtbxTelNo.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            mtbxTelNo.Location = new Point(183, 231);
            mtbxTelNo.Margin = new Padding(3, 4, 3, 4);
            mtbxTelNo.Mask = "09990000000";
            mtbxTelNo.Name = "mtbxTelNo";
            mtbxTelNo.Size = new Size(165, 27);
            mtbxTelNo.TabIndex = 68;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(63, 589);
            label14.Name = "label14";
            label14.Size = new Size(121, 22);
            label14.TabIndex = 63;
            label14.Text = "Toplam Ücret";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(62, 545);
            label13.Name = "label13";
            label13.Size = new Size(121, 22);
            label13.TabIndex = 62;
            label13.Text = "Davetli Sayısı";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(123, 501);
            label12.Name = "label12";
            label12.Size = new Size(58, 22);
            label12.TabIndex = 61;
            label12.Text = "Detay";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(120, 280);
            label10.Name = "label10";
            label10.Size = new Size(63, 22);
            label10.TabIndex = 59;
            label10.Text = "Adresi";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(112, 236);
            label8.Name = "label8";
            label8.Size = new Size(70, 22);
            label8.TabIndex = 57;
            label8.Text = "Telefon";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(94, 186);
            label4.Name = "label4";
            label4.Size = new Size(94, 22);
            label4.TabIndex = 51;
            label4.Text = "Bitiş Saati";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(62, 143);
            label3.Name = "label3";
            label3.Size = new Size(128, 22);
            label3.TabIndex = 50;
            label3.Text = "Başlama Saati";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(55, 99);
            label2.Name = "label2";
            label2.Size = new Size(130, 22);
            label2.TabIndex = 49;
            label2.Text = "Etkinlik Tarihi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(237, 187, 153);
            label1.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(10, 14);
            label1.Name = "label1";
            label1.Size = new Size(184, 22);
            label1.TabIndex = 48;
            label1.Text = "Rezervasyon Bilgileri";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(96, 636);
            label17.Name = "label17";
            label17.Size = new Size(88, 22);
            label17.TabIndex = 64;
            label17.Text = "Açıklama";
            // 
            // tbxAciklama
            // 
            tbxAciklama.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbxAciklama.Location = new Point(179, 636);
            tbxAciklama.Margin = new Padding(3, 4, 3, 4);
            tbxAciklama.Multiline = true;
            tbxAciklama.Name = "tbxAciklama";
            tbxAciklama.Size = new Size(249, 163);
            tbxAciklama.TabIndex = 76;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(96, 64);
            label5.Name = "label5";
            label5.Size = new Size(82, 22);
            label5.TabIndex = 81;
            label5.Text = "Kategori";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(209, 83, 69);
            button1.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(459, 9);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 83;
            button1.Text = "Geri";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lblyetki
            // 
            lblyetki.AutoSize = true;
            lblyetki.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point);
            lblyetki.Location = new Point(478, 60);
            lblyetki.Name = "lblyetki";
            lblyetki.Size = new Size(70, 22);
            lblyetki.TabIndex = 84;
            lblyetki.Text = "lblyetki";
            lblyetki.Visible = false;
            lblyetki.Click += lblyetki_Click;
            // 
            // tbxKategori
            // 
            tbxKategori.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tbxKategori.Location = new Point(184, 61);
            tbxKategori.Margin = new Padding(3, 4, 3, 4);
            tbxKategori.Name = "tbxKategori";
            tbxKategori.Size = new Size(164, 27);
            tbxKategori.TabIndex = 85;
            // 
            // tbxEtkinlikTarihi
            // 
            tbxEtkinlikTarihi.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tbxEtkinlikTarihi.Location = new Point(183, 99);
            tbxEtkinlikTarihi.Margin = new Padding(3, 4, 3, 4);
            tbxEtkinlikTarihi.Name = "tbxEtkinlikTarihi";
            tbxEtkinlikTarihi.Size = new Size(164, 27);
            tbxEtkinlikTarihi.TabIndex = 86;
            // 
            // cbxBaslangicSaati
            // 
            cbxBaslangicSaati.Location = new Point(196, 143);
            cbxBaslangicSaati.Mask = "00:00";
            cbxBaslangicSaati.Name = "cbxBaslangicSaati";
            cbxBaslangicSaati.Size = new Size(151, 27);
            cbxBaslangicSaati.TabIndex = 87;
            cbxBaslangicSaati.ValidatingType = typeof(DateTime);
            // 
            // cbxBitisSaati
            // 
            cbxBitisSaati.Location = new Point(194, 186);
            cbxBitisSaati.Mask = "00:00";
            cbxBitisSaati.Name = "cbxBitisSaati";
            cbxBitisSaati.Size = new Size(153, 27);
            cbxBitisSaati.TabIndex = 88;
            cbxBitisSaati.ValidatingType = typeof(DateTime);
            // 
            // etkinlikEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(583, 873);
            Controls.Add(cbxBitisSaati);
            Controls.Add(cbxBaslangicSaati);
            Controls.Add(tbxEtkinlikTarihi);
            Controls.Add(tbxKategori);
            Controls.Add(lblyetki);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(btnGetir);
            Controls.Add(label20);
            Controls.Add(tbxAciklama);
            Controls.Add(mtbxToplamUcret);
            Controls.Add(label18);
            Controls.Add(mtbxDavetliSayisi);
            Controls.Add(tbxDetay);
            Controls.Add(tbxAdres);
            Controls.Add(mtbxTelNo);
            Controls.Add(label17);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "etkinlikEkle";
            Text = "Etkinlik Ekle";
            Load += etkinlikEkle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGetir;
        private Label label20;
        private MaskedTextBox mtbxToplamUcret;
        private Label label18;
        private MaskedTextBox mtbxDavetliSayisi;
        private TextBox tbxDetay;
        private TextBox tbxAdres;
        private MaskedTextBox mtbxTelNo;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label10;
        private Label label8;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label17;
        private TextBox tbxAciklama;
        private Label label5;
        private Button button1;
        private Label lblyetki;
        private TextBox tbxKategori;
        private TextBox tbxEtkinlikTarihi;
        private MaskedTextBox cbxBaslangicSaati;
        private MaskedTextBox cbxBitisSaati;
    }
}