namespace EtkinlikTakip
{
    partial class anasayfaFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anasayfaFrm));
            panelLogo = new Panel();
            panelKullaniciBari = new Panel();
            label1 = new Label();
            panelKullanici = new Panel();
            pictureBox1 = new PictureBox();
            panelAcikForm = new Panel();
            lblyetki = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panelKullaniciBari.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelAcikForm.SuspendLayout();
            SuspendLayout();
            // 
            // panelLogo
            // 
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 89);
            panelLogo.Margin = new Padding(3, 4, 3, 4);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(1106, 203);
            panelLogo.TabIndex = 3;
            // 
            // panelKullaniciBari
            // 
            panelKullaniciBari.BackColor = Color.FromArgb(237, 187, 153);
            panelKullaniciBari.Controls.Add(label1);
            panelKullaniciBari.Dock = DockStyle.Top;
            panelKullaniciBari.Location = new Point(0, 0);
            panelKullaniciBari.Margin = new Padding(3, 4, 3, 4);
            panelKullaniciBari.Name = "panelKullaniciBari";
            panelKullaniciBari.Size = new Size(1106, 89);
            panelKullaniciBari.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 36.3130455F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(354, 9);
            label1.Name = "label1";
            label1.Size = new Size(384, 67);
            label1.TabIndex = 0;
            label1.Text = "Etkinlik Takip";
            // 
            // panelKullanici
            // 
            panelKullanici.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelKullanici.BackColor = Color.FromArgb(236, 143, 94);
            panelKullanici.Location = new Point(1801, 0);
            panelKullanici.Margin = new Padding(3, 4, 3, 4);
            panelKullanici.Name = "panelKullanici";
            panelKullanici.Size = new Size(200, 95);
            panelKullanici.TabIndex = 0;
            panelKullanici.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.FromArgb(209, 242, 235);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(656, 312);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(437, 433);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panelAcikForm
            // 
            panelAcikForm.BackColor = Color.LightYellow;
            panelAcikForm.Controls.Add(lblyetki);
            panelAcikForm.Controls.Add(button4);
            panelAcikForm.Controls.Add(button3);
            panelAcikForm.Controls.Add(button2);
            panelAcikForm.Controls.Add(button1);
            panelAcikForm.Controls.Add(pictureBox1);
            panelAcikForm.Controls.Add(panelKullanici);
            panelAcikForm.Dock = DockStyle.Fill;
            panelAcikForm.Location = new Point(0, 0);
            panelAcikForm.Margin = new Padding(3, 4, 3, 4);
            panelAcikForm.Name = "panelAcikForm";
            panelAcikForm.Size = new Size(1106, 760);
            panelAcikForm.TabIndex = 5;
            // 
            // lblyetki
            // 
            lblyetki.AutoSize = true;
            lblyetki.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point);
            lblyetki.Location = new Point(37, 706);
            lblyetki.Name = "lblyetki";
            lblyetki.Size = new Size(67, 20);
            lblyetki.TabIndex = 53;
            lblyetki.Text = "lblyetki";
            lblyetki.Visible = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(236, 112, 99);
            button4.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(37, 604);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(142, 84);
            button4.TabIndex = 51;
            button4.Text = "Çıkış";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(133, 193, 233);
            button3.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(37, 513);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(142, 84);
            button3.TabIndex = 4;
            button3.Text = "Ödeme";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(163, 155, 125);
            button2.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(37, 422);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(142, 84);
            button2.TabIndex = 3;
            button2.Text = "Etkinlik Ekle";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(247, 220, 111);
            button1.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(37, 331);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(142, 84);
            button1.TabIndex = 2;
            button1.Text = "Etkinlik Listele";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // anasayfaFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1106, 760);
            Controls.Add(panelLogo);
            Controls.Add(panelKullaniciBari);
            Controls.Add(panelAcikForm);
            Margin = new Padding(3, 4, 3, 4);
            Name = "anasayfaFrm";
            Text = "Anasayfa";
            Load += anasayfaFrm_Load;
            panelKullaniciBari.ResumeLayout(false);
            panelKullaniciBari.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelAcikForm.ResumeLayout(false);
            panelAcikForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLogo;
        private Panel panelKullaniciBari;
        private Panel panelKullanici;
        private PictureBox pictureBox1;
        private Panel panelAcikForm;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button4;
        private Label lblyetki;
        private Label label1;
    }
}