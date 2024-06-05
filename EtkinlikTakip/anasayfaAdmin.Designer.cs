namespace EtkinlikTakip
{
    partial class anasayfaAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anasayfaAdmin));
            panelAcikForm = new Panel();
            pictureBox1 = new PictureBox();
            lblyetki = new Label();
            button3 = new Button();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            panelKullanici = new Panel();
            panelAcikForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelAcikForm
            // 
            panelAcikForm.BackColor = Color.LightYellow;
            panelAcikForm.BackgroundImage = (Image)resources.GetObject("panelAcikForm.BackgroundImage");
            panelAcikForm.Controls.Add(pictureBox1);
            panelAcikForm.Controls.Add(lblyetki);
            panelAcikForm.Controls.Add(button3);
            panelAcikForm.Controls.Add(button4);
            panelAcikForm.Controls.Add(button2);
            panelAcikForm.Controls.Add(button1);
            panelAcikForm.Controls.Add(panelKullanici);
            panelAcikForm.Dock = DockStyle.Fill;
            panelAcikForm.Location = new Point(0, 0);
            panelAcikForm.Margin = new Padding(3, 4, 3, 4);
            panelAcikForm.Name = "panelAcikForm";
            panelAcikForm.Size = new Size(1106, 760);
            panelAcikForm.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(280, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(814, 736);
            pictureBox1.TabIndex = 53;
            pictureBox1.TabStop = false;
            // 
            // lblyetki
            // 
            lblyetki.AutoSize = true;
            lblyetki.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point);
            lblyetki.Location = new Point(37, 148);
            lblyetki.Name = "lblyetki";
            lblyetki.Size = new Size(67, 20);
            lblyetki.TabIndex = 52;
            lblyetki.Text = "lblyetki";
            lblyetki.Visible = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(241, 148, 138);
            button3.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(37, 513);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(142, 84);
            button3.TabIndex = 51;
            button3.Text = "Çıkış";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(128, 183, 207);
            button4.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(37, 239);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(142, 84);
            button4.TabIndex = 5;
            button4.Text = "Kullanıcı Ekle";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(191, 201, 202);
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
            button1.BackColor = Color.FromArgb(249, 231, 159);
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
            // panelKullanici
            // 
            panelKullanici.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelKullanici.BackColor = Color.FromArgb(236, 143, 94);
            panelKullanici.Location = new Point(2679, 0);
            panelKullanici.Margin = new Padding(3, 4, 3, 4);
            panelKullanici.Name = "panelKullanici";
            panelKullanici.Size = new Size(200, 95);
            panelKullanici.TabIndex = 0;
            panelKullanici.Visible = false;
            // 
            // anasayfaAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1106, 760);
            Controls.Add(panelAcikForm);
            Margin = new Padding(3, 4, 3, 4);
            Name = "anasayfaAdmin";
            Text = "anasayfaAdmin";
            Load += anasayfaAdmin_Load;
            panelAcikForm.ResumeLayout(false);
            panelAcikForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelAcikForm;
        private Button button4;
        private Button button2;
        private Button button1;
        private Panel panelKullanici;
        private Button button3;
        private Label lblyetki;
        private PictureBox pictureBox1;
    }
}