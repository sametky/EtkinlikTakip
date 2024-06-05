namespace EtkinlikTakip
{
    partial class etkinlikListeFrm
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
            mcalGunSecici = new MonthCalendar();
            panel1 = new Panel();
            button1 = new Button();
            btnListele = new Button();
            cbxKonferans = new CheckBox();
            cbxNikah = new CheckBox();
            cbxToplanti = new CheckBox();
            cbxKokteyl = new CheckBox();
            label7 = new Label();
            btnHepsiniBirak = new Button();
            btnTumunuSec = new Button();
            cbxDiger = new CheckBox();
            cbxSunnetDugunu = new CheckBox();
            cbxNisan = new CheckBox();
            cbxKina = new CheckBox();
            cbxIftar = new CheckBox();
            cbxMezuniyet = new CheckBox();
            cbxDugun = new CheckBox();
            panelTakvimArkaplan = new Panel();
            lblyetki = new Label();
            button2 = new Button();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            btnAylik = new Button();
            btnHaftalik = new Button();
            panel1.SuspendLayout();
            panelTakvimArkaplan.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // mcalGunSecici
            // 
            mcalGunSecici.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            mcalGunSecici.BackColor = Color.LightYellow;
            mcalGunSecici.Location = new Point(806, 8);
            mcalGunSecici.Margin = new Padding(9, 10, 9, 10);
            mcalGunSecici.Name = "mcalGunSecici";
            mcalGunSecici.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.BackColor = Color.LightYellow;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnListele);
            panel1.Controls.Add(cbxKonferans);
            panel1.Controls.Add(cbxNikah);
            panel1.Controls.Add(cbxToplanti);
            panel1.Controls.Add(cbxKokteyl);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(btnHepsiniBirak);
            panel1.Controls.Add(btnTumunuSec);
            panel1.Controls.Add(cbxDiger);
            panel1.Controls.Add(cbxSunnetDugunu);
            panel1.Controls.Add(cbxNisan);
            panel1.Controls.Add(cbxKina);
            panel1.Controls.Add(cbxIftar);
            panel1.Controls.Add(cbxMezuniyet);
            panel1.Controls.Add(cbxDugun);
            panel1.Location = new Point(806, 270);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(267, 474);
            panel1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(169, 204, 227);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(152, 419);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(101, 39);
            button1.TabIndex = 25;
            button1.Text = "Listele";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnListele
            // 
            btnListele.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnListele.BackColor = Color.Gainsboro;
            btnListele.FlatAppearance.BorderSize = 0;
            btnListele.FlatStyle = FlatStyle.Flat;
            btnListele.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnListele.Location = new Point(187, 811);
            btnListele.Margin = new Padding(3, 4, 3, 4);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(101, 39);
            btnListele.TabIndex = 24;
            btnListele.Text = "Listele";
            btnListele.UseVisualStyleBackColor = false;
            // 
            // cbxKonferans
            // 
            cbxKonferans.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbxKonferans.AutoSize = true;
            cbxKonferans.Checked = true;
            cbxKonferans.CheckState = CheckState.Checked;
            cbxKonferans.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point);
            cbxKonferans.Location = new Point(59, 384);
            cbxKonferans.Margin = new Padding(3, 4, 3, 4);
            cbxKonferans.Name = "cbxKonferans";
            cbxKonferans.Size = new Size(109, 24);
            cbxKonferans.TabIndex = 23;
            cbxKonferans.Text = "Konferans";
            cbxKonferans.UseVisualStyleBackColor = true;
            // 
            // cbxNikah
            // 
            cbxNikah.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbxNikah.AutoSize = true;
            cbxNikah.Checked = true;
            cbxNikah.CheckState = CheckState.Checked;
            cbxNikah.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point);
            cbxNikah.Location = new Point(59, 256);
            cbxNikah.Margin = new Padding(3, 4, 3, 4);
            cbxNikah.Name = "cbxNikah";
            cbxNikah.Size = new Size(75, 24);
            cbxNikah.TabIndex = 22;
            cbxNikah.Text = "Nikâh";
            cbxNikah.UseVisualStyleBackColor = true;
            // 
            // cbxToplanti
            // 
            cbxToplanti.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbxToplanti.AutoSize = true;
            cbxToplanti.Checked = true;
            cbxToplanti.CheckState = CheckState.Checked;
            cbxToplanti.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point);
            cbxToplanti.Location = new Point(59, 159);
            cbxToplanti.Margin = new Padding(3, 4, 3, 4);
            cbxToplanti.Name = "cbxToplanti";
            cbxToplanti.Size = new Size(92, 24);
            cbxToplanti.TabIndex = 21;
            cbxToplanti.Text = "Toplantı";
            cbxToplanti.UseVisualStyleBackColor = true;
            // 
            // cbxKokteyl
            // 
            cbxKokteyl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbxKokteyl.AutoSize = true;
            cbxKokteyl.Checked = true;
            cbxKokteyl.CheckState = CheckState.Checked;
            cbxKokteyl.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point);
            cbxKokteyl.Location = new Point(59, 320);
            cbxKokteyl.Margin = new Padding(3, 4, 3, 4);
            cbxKokteyl.Name = "cbxKokteyl";
            cbxKokteyl.Size = new Size(90, 24);
            cbxKokteyl.TabIndex = 20;
            cbxKokteyl.Text = "Kokteyl";
            cbxKokteyl.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(56, 22);
            label7.Name = "label7";
            label7.Size = new Size(97, 20);
            label7.TabIndex = 19;
            label7.Text = "Kategoriler";
            // 
            // btnHepsiniBirak
            // 
            btnHepsiniBirak.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnHepsiniBirak.BackColor = Color.FromArgb(217, 136, 128);
            btnHepsiniBirak.FlatAppearance.BorderSize = 0;
            btnHepsiniBirak.FlatStyle = FlatStyle.Flat;
            btnHepsiniBirak.Font = new Font("Times New Roman", 10.0173912F, FontStyle.Bold, GraphicsUnit.Point);
            btnHepsiniBirak.Location = new Point(131, 48);
            btnHepsiniBirak.Margin = new Padding(3, 4, 3, 4);
            btnHepsiniBirak.Name = "btnHepsiniBirak";
            btnHepsiniBirak.Size = new Size(121, 39);
            btnHepsiniBirak.TabIndex = 7;
            btnHepsiniBirak.Text = "Hepsini Bırak";
            btnHepsiniBirak.UseVisualStyleBackColor = false;
            btnHepsiniBirak.Click += btnHepsiniBirak_Click;
            // 
            // btnTumunuSec
            // 
            btnTumunuSec.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTumunuSec.BackColor = Color.FromArgb(127, 179, 213);
            btnTumunuSec.FlatAppearance.BorderSize = 0;
            btnTumunuSec.FlatStyle = FlatStyle.Flat;
            btnTumunuSec.Font = new Font("Times New Roman", 10.0173912F, FontStyle.Bold, GraphicsUnit.Point);
            btnTumunuSec.Location = new Point(24, 48);
            btnTumunuSec.Margin = new Padding(3, 4, 3, 4);
            btnTumunuSec.Name = "btnTumunuSec";
            btnTumunuSec.Size = new Size(101, 39);
            btnTumunuSec.TabIndex = 5;
            btnTumunuSec.Text = "Tümünü Seç";
            btnTumunuSec.UseVisualStyleBackColor = false;
            btnTumunuSec.Click += btnTumunuSec_Click;
            // 
            // cbxDiger
            // 
            cbxDiger.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbxDiger.AutoSize = true;
            cbxDiger.Checked = true;
            cbxDiger.CheckState = CheckState.Checked;
            cbxDiger.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point);
            cbxDiger.Location = new Point(59, 416);
            cbxDiger.Margin = new Padding(3, 4, 3, 4);
            cbxDiger.Name = "cbxDiger";
            cbxDiger.Size = new Size(70, 24);
            cbxDiger.TabIndex = 6;
            cbxDiger.Text = "Diğer";
            cbxDiger.UseVisualStyleBackColor = true;
            // 
            // cbxSunnetDugunu
            // 
            cbxSunnetDugunu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbxSunnetDugunu.AutoSize = true;
            cbxSunnetDugunu.Checked = true;
            cbxSunnetDugunu.CheckState = CheckState.Checked;
            cbxSunnetDugunu.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point);
            cbxSunnetDugunu.Location = new Point(59, 127);
            cbxSunnetDugunu.Margin = new Padding(3, 4, 3, 4);
            cbxSunnetDugunu.Name = "cbxSunnetDugunu";
            cbxSunnetDugunu.Size = new Size(149, 24);
            cbxSunnetDugunu.TabIndex = 5;
            cbxSunnetDugunu.Text = "Sünnet Düğünü";
            cbxSunnetDugunu.UseVisualStyleBackColor = true;
            // 
            // cbxNisan
            // 
            cbxNisan.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbxNisan.AutoSize = true;
            cbxNisan.Checked = true;
            cbxNisan.CheckState = CheckState.Checked;
            cbxNisan.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point);
            cbxNisan.Location = new Point(59, 223);
            cbxNisan.Margin = new Padding(3, 4, 3, 4);
            cbxNisan.Name = "cbxNisan";
            cbxNisan.Size = new Size(72, 24);
            cbxNisan.TabIndex = 4;
            cbxNisan.Text = "Nişan";
            cbxNisan.UseVisualStyleBackColor = true;
            // 
            // cbxKina
            // 
            cbxKina.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbxKina.AutoSize = true;
            cbxKina.Checked = true;
            cbxKina.CheckState = CheckState.Checked;
            cbxKina.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point);
            cbxKina.Location = new Point(59, 191);
            cbxKina.Margin = new Padding(3, 4, 3, 4);
            cbxKina.Name = "cbxKina";
            cbxKina.Size = new Size(66, 24);
            cbxKina.TabIndex = 3;
            cbxKina.Text = "Kına";
            cbxKina.UseVisualStyleBackColor = true;
            // 
            // cbxIftar
            // 
            cbxIftar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbxIftar.AutoSize = true;
            cbxIftar.Checked = true;
            cbxIftar.CheckState = CheckState.Checked;
            cbxIftar.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point);
            cbxIftar.Location = new Point(59, 288);
            cbxIftar.Margin = new Padding(3, 4, 3, 4);
            cbxIftar.Name = "cbxIftar";
            cbxIftar.Size = new Size(63, 24);
            cbxIftar.TabIndex = 2;
            cbxIftar.Text = "İftar";
            cbxIftar.UseVisualStyleBackColor = true;
            // 
            // cbxMezuniyet
            // 
            cbxMezuniyet.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbxMezuniyet.AutoSize = true;
            cbxMezuniyet.Checked = true;
            cbxMezuniyet.CheckState = CheckState.Checked;
            cbxMezuniyet.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point);
            cbxMezuniyet.Location = new Point(59, 352);
            cbxMezuniyet.Margin = new Padding(3, 4, 3, 4);
            cbxMezuniyet.Name = "cbxMezuniyet";
            cbxMezuniyet.Size = new Size(109, 24);
            cbxMezuniyet.TabIndex = 1;
            cbxMezuniyet.Text = "Mezuniyet";
            cbxMezuniyet.UseVisualStyleBackColor = true;
            // 
            // cbxDugun
            // 
            cbxDugun.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbxDugun.AutoSize = true;
            cbxDugun.Checked = true;
            cbxDugun.CheckState = CheckState.Checked;
            cbxDugun.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point);
            cbxDugun.Location = new Point(59, 95);
            cbxDugun.Margin = new Padding(3, 4, 3, 4);
            cbxDugun.Name = "cbxDugun";
            cbxDugun.Size = new Size(80, 24);
            cbxDugun.TabIndex = 0;
            cbxDugun.Text = "Düğün";
            cbxDugun.UseVisualStyleBackColor = true;
            // 
            // panelTakvimArkaplan
            // 
            panelTakvimArkaplan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelTakvimArkaplan.BackColor = Color.LightYellow;
            panelTakvimArkaplan.Controls.Add(lblyetki);
            panelTakvimArkaplan.Controls.Add(button2);
            panelTakvimArkaplan.Controls.Add(panel2);
            panelTakvimArkaplan.Controls.Add(btnAylik);
            panelTakvimArkaplan.Controls.Add(btnHaftalik);
            panelTakvimArkaplan.Location = new Point(14, 8);
            panelTakvimArkaplan.Margin = new Padding(3, 4, 3, 4);
            panelTakvimArkaplan.Name = "panelTakvimArkaplan";
            panelTakvimArkaplan.Size = new Size(779, 736);
            panelTakvimArkaplan.TabIndex = 7;
            // 
            // lblyetki
            // 
            lblyetki.AutoSize = true;
            lblyetki.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point);
            lblyetki.Location = new Point(617, 13);
            lblyetki.Name = "lblyetki";
            lblyetki.Size = new Size(67, 20);
            lblyetki.TabIndex = 53;
            lblyetki.Text = "lblyetki";
            lblyetki.Visible = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(162, 217, 206);
            button2.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(690, 8);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 35);
            button2.TabIndex = 51;
            button2.Text = "Geri";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(3, 48);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(773, 684);
            panel2.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 49;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(773, 684);
            dataGridView1.TabIndex = 0;
            // 
            // btnAylik
            // 
            btnAylik.BackColor = Color.FromArgb(241, 148, 138);
            btnAylik.FlatAppearance.BorderSize = 0;
            btnAylik.FlatStyle = FlatStyle.Flat;
            btnAylik.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point);
            btnAylik.Location = new Point(176, 4);
            btnAylik.Margin = new Padding(3, 4, 3, 4);
            btnAylik.Name = "btnAylik";
            btnAylik.Size = new Size(162, 39);
            btnAylik.TabIndex = 2;
            btnAylik.Text = "Fiyata göre azalan";
            btnAylik.UseVisualStyleBackColor = false;
            btnAylik.Click += btnAylik_Click;
            // 
            // btnHaftalik
            // 
            btnHaftalik.BackColor = Color.FromArgb(169, 204, 227);
            btnHaftalik.FlatAppearance.BorderSize = 0;
            btnHaftalik.FlatStyle = FlatStyle.Flat;
            btnHaftalik.Font = new Font("Times New Roman", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point);
            btnHaftalik.Location = new Point(3, 4);
            btnHaftalik.Margin = new Padding(3, 4, 3, 4);
            btnHaftalik.Name = "btnHaftalik";
            btnHaftalik.Size = new Size(166, 39);
            btnHaftalik.TabIndex = 1;
            btnHaftalik.Text = "Fiyata göre artan";
            btnHaftalik.UseVisualStyleBackColor = false;
            btnHaftalik.Click += btnHaftalik_Click;
            // 
            // etkinlikListeFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1106, 759);
            Controls.Add(panelTakvimArkaplan);
            Controls.Add(mcalGunSecici);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "etkinlikListeFrm";
            Text = "Etkinlik Listele";
            Load += etkinlikListeFrm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelTakvimArkaplan.ResumeLayout(false);
            panelTakvimArkaplan.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MonthCalendar mcalGunSecici;
        private Panel panel1;
        private Button button1;
        private Button btnListele;
        private CheckBox cbxKonferans;
        private CheckBox cbxNikah;
        private CheckBox cbxToplanti;
        private CheckBox cbxKokteyl;
        private Label label7;
        private Button btnHepsiniBirak;
        private Button btnTumunuSec;
        private CheckBox cbxDiger;
        private CheckBox cbxSunnetDugunu;
        private CheckBox cbxNisan;
        private CheckBox cbxKina;
        private CheckBox cbxIftar;
        private CheckBox cbxMezuniyet;
        private CheckBox cbxDugun;
        private Panel panelTakvimArkaplan;
        private Panel panel2;
        private Button btnAylik;
        private Button btnHaftalik;
        private DataGridView dataGridView1;
        private Button button2;
        private Label lblyetki;
    }
}