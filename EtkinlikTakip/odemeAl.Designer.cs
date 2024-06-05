namespace EtkinlikTakip
{
    partial class odemeAl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(odemeAl));
            label5 = new Label();
            label20 = new Label();
            mtbxTutar = new MaskedTextBox();
            btnTahsilatEkle = new Button();
            tbxTCNo = new TextBox();
            label7 = new Label();
            label3 = new Label();
            tbxAciklama = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            lblyetki = new Label();
            tbxAdSoyad = new TextBox();
            tbxTarih = new TextBox();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(219, 298);
            label5.Name = "label5";
            label5.Size = new Size(54, 22);
            label5.TabIndex = 106;
            label5.Text = "Tarih";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point);
            label20.Location = new Point(401, 253);
            label20.Name = "label20";
            label20.Size = new Size(35, 22);
            label20.TabIndex = 105;
            label20.Text = "TL";
            // 
            // mtbxTutar
            // 
            mtbxTutar.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            mtbxTutar.Location = new Point(283, 246);
            mtbxTutar.Margin = new Padding(3, 4, 3, 4);
            mtbxTutar.Mask = "0000000";
            mtbxTutar.Name = "mtbxTutar";
            mtbxTutar.Size = new Size(115, 28);
            mtbxTutar.TabIndex = 104;
            mtbxTutar.TextAlign = HorizontalAlignment.Right;
            // 
            // btnTahsilatEkle
            // 
            btnTahsilatEkle.BackColor = Color.FromArgb(241, 148, 138);
            btnTahsilatEkle.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point);
            btnTahsilatEkle.Location = new Point(253, 493);
            btnTahsilatEkle.Margin = new Padding(3, 4, 3, 4);
            btnTahsilatEkle.Name = "btnTahsilatEkle";
            btnTahsilatEkle.Size = new Size(160, 46);
            btnTahsilatEkle.TabIndex = 103;
            btnTahsilatEkle.Text = "TAHSİLAT EKLE";
            btnTahsilatEkle.UseVisualStyleBackColor = false;
            btnTahsilatEkle.Click += btnTahsilatEkle_Click;
            // 
            // tbxTCNo
            // 
            tbxTCNo.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            tbxTCNo.Location = new Point(281, 138);
            tbxTCNo.Margin = new Padding(3, 4, 3, 4);
            tbxTCNo.Multiline = true;
            tbxTCNo.Name = "tbxTCNo";
            tbxTCNo.Size = new Size(285, 43);
            tbxTCNo.TabIndex = 101;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(209, 143);
            label7.Name = "label7";
            label7.Size = new Size(66, 22);
            label7.TabIndex = 100;
            label7.Text = "TC No";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.MintCream;
            label3.Font = new Font("Times New Roman", 18.1565228F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(358, 64);
            label3.Name = "label3";
            label3.Size = new Size(144, 36);
            label3.TabIndex = 99;
            label3.Text = "Ödeme Al";
            // 
            // tbxAciklama
            // 
            tbxAciklama.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            tbxAciklama.Location = new Point(281, 348);
            tbxAciklama.Margin = new Padding(3, 4, 3, 4);
            tbxAciklama.Multiline = true;
            tbxAciklama.Name = "tbxAciklama";
            tbxAciklama.Size = new Size(285, 124);
            tbxAciklama.TabIndex = 98;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(187, 348);
            label4.Name = "label4";
            label4.Size = new Size(88, 22);
            label4.TabIndex = 97;
            label4.Text = "Açıklama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(216, 246);
            label2.Name = "label2";
            label2.Size = new Size(55, 22);
            label2.TabIndex = 96;
            label2.Text = "Tutar";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(188, 196);
            label6.Name = "label6";
            label6.Size = new Size(88, 22);
            label6.TabIndex = 95;
            label6.Text = "Ad Soyad";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(240, 178, 122);
            button1.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(436, 493);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(161, 46);
            button1.TabIndex = 108;
            button1.Text = "SEPETE GİT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(128, 128, 255);
            button2.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(713, 14);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 109;
            button2.Text = "Geri";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // lblyetki
            // 
            lblyetki.AutoSize = true;
            lblyetki.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point);
            lblyetki.Location = new Point(713, 48);
            lblyetki.Name = "lblyetki";
            lblyetki.Size = new Size(70, 22);
            lblyetki.TabIndex = 110;
            lblyetki.Text = "lblyetki";
            lblyetki.Visible = false;
            // 
            // tbxAdSoyad
            // 
            tbxAdSoyad.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            tbxAdSoyad.Location = new Point(283, 189);
            tbxAdSoyad.Margin = new Padding(3, 4, 3, 4);
            tbxAdSoyad.Multiline = true;
            tbxAdSoyad.Name = "tbxAdSoyad";
            tbxAdSoyad.Size = new Size(285, 43);
            tbxAdSoyad.TabIndex = 111;
            // 
            // tbxTarih
            // 
            tbxTarih.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            tbxTarih.Location = new Point(279, 282);
            tbxTarih.Margin = new Padding(3, 4, 3, 4);
            tbxTarih.Multiline = true;
            tbxTarih.Name = "tbxTarih";
            tbxTarih.Size = new Size(285, 43);
            tbxTarih.TabIndex = 112;
            // 
            // odemeAl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(820, 587);
            Controls.Add(tbxTarih);
            Controls.Add(tbxAdSoyad);
            Controls.Add(lblyetki);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label20);
            Controls.Add(mtbxTutar);
            Controls.Add(btnTahsilatEkle);
            Controls.Add(tbxTCNo);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(tbxAciklama);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label6);
            Margin = new Padding(3, 4, 3, 4);
            Name = "odemeAl";
            Text = "Ödeme Al";
            Load += odemeAl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private Label label20;
        private MaskedTextBox mtbxTutar;
        private Button btnTahsilatEkle;
        private TextBox tbxTCNo;
        private Label label7;
        private Label label3;
        private TextBox tbxAciklama;
        private Label label4;
        private Label label2;
        private Label label6;
        private Button button1;
        private Button button2;
        private Label lblyetki;
        private TextBox tbxAdSoyad;
        private TextBox tbxTarih;
    }
}