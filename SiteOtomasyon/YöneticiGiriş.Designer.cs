namespace SiteOtomasyon
{
    partial class YöneticiGiriş
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YöneticiGiriş));
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menubutton = new System.Windows.Forms.PictureBox();
            this.homecontainer = new System.Windows.Forms.Panel();
            this.btnGüvenlik = new System.Windows.Forms.Button();
            this.btnSiteSakin = new System.Windows.Forms.Button();
            this.btnGiris = new System.Windows.Forms.Button();
            this.btnYonetici = new System.Windows.Forms.Button();
            this.BtnAyarlar = new System.Windows.Forms.Button();
            this.BtnHakkında = new System.Windows.Forms.Button();
            this.btnCikisYap = new System.Windows.Forms.Button();
            this.BtnGirisYap = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.radioAblok = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.radioBblok = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menubutton)).BeginInit();
            this.homecontainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.Crimson;
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.homecontainer);
            this.sidebar.Controls.Add(this.BtnAyarlar);
            this.sidebar.Controls.Add(this.BtnHakkında);
            this.sidebar.Controls.Add(this.btnCikisYap);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(230, 662);
            this.sidebar.MinimumSize = new System.Drawing.Size(53, 577);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(53, 662);
            this.sidebar.TabIndex = 36;
            this.sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebar_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menubutton);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(49, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menü";
            // 
            // menubutton
            // 
            this.menubutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menubutton.Image = ((System.Drawing.Image)(resources.GetObject("menubutton.Image")));
            this.menubutton.Location = new System.Drawing.Point(9, 33);
            this.menubutton.Name = "menubutton";
            this.menubutton.Size = new System.Drawing.Size(34, 28);
            this.menubutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menubutton.TabIndex = 0;
            this.menubutton.TabStop = false;
            this.menubutton.Click += new System.EventHandler(this.menubutton_Click);
            // 
            // homecontainer
            // 
            this.homecontainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.homecontainer.Controls.Add(this.btnGüvenlik);
            this.homecontainer.Controls.Add(this.btnSiteSakin);
            this.homecontainer.Controls.Add(this.btnGiris);
            this.homecontainer.Controls.Add(this.btnYonetici);
            this.homecontainer.Location = new System.Drawing.Point(3, 109);
            this.homecontainer.MaximumSize = new System.Drawing.Size(225, 200);
            this.homecontainer.MinimumSize = new System.Drawing.Size(225, 58);
            this.homecontainer.Name = "homecontainer";
            this.homecontainer.Size = new System.Drawing.Size(225, 58);
            this.homecontainer.TabIndex = 3;
            // 
            // btnGüvenlik
            // 
            this.btnGüvenlik.AutoSize = true;
            this.btnGüvenlik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.btnGüvenlik.FlatAppearance.BorderSize = 0;
            this.btnGüvenlik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGüvenlik.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGüvenlik.ForeColor = System.Drawing.Color.White;
            this.btnGüvenlik.Image = ((System.Drawing.Image)(resources.GetObject("btnGüvenlik.Image")));
            this.btnGüvenlik.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGüvenlik.Location = new System.Drawing.Point(-3, 155);
            this.btnGüvenlik.Name = "btnGüvenlik";
            this.btnGüvenlik.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnGüvenlik.Size = new System.Drawing.Size(252, 41);
            this.btnGüvenlik.TabIndex = 9;
            this.btnGüvenlik.Text = "    Güvenlik Giriş";
            this.btnGüvenlik.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGüvenlik.UseVisualStyleBackColor = false;
            // 
            // btnSiteSakin
            // 
            this.btnSiteSakin.AutoSize = true;
            this.btnSiteSakin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.btnSiteSakin.FlatAppearance.BorderSize = 0;
            this.btnSiteSakin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiteSakin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiteSakin.ForeColor = System.Drawing.Color.White;
            this.btnSiteSakin.Image = ((System.Drawing.Image)(resources.GetObject("btnSiteSakin.Image")));
            this.btnSiteSakin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSiteSakin.Location = new System.Drawing.Point(-3, 108);
            this.btnSiteSakin.Name = "btnSiteSakin";
            this.btnSiteSakin.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnSiteSakin.Size = new System.Drawing.Size(252, 41);
            this.btnSiteSakin.TabIndex = 8;
            this.btnSiteSakin.Text = "    Site Sakini";
            this.btnSiteSakin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSiteSakin.UseVisualStyleBackColor = false;
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.Crimson;
            this.btnGiris.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGiris.FlatAppearance.BorderSize = 0;
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiris.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.ForeColor = System.Drawing.Color.White;
            this.btnGiris.Image = ((System.Drawing.Image)(resources.GetObject("btnGiris.Image")));
            this.btnGiris.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGiris.Location = new System.Drawing.Point(0, 0);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnGiris.Size = new System.Drawing.Size(225, 59);
            this.btnGiris.TabIndex = 2;
            this.btnGiris.Text = "          Giriş Yap";
            this.btnGiris.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // btnYonetici
            // 
            this.btnYonetici.AutoSize = true;
            this.btnYonetici.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.btnYonetici.FlatAppearance.BorderSize = 0;
            this.btnYonetici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYonetici.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYonetici.ForeColor = System.Drawing.Color.White;
            this.btnYonetici.Image = ((System.Drawing.Image)(resources.GetObject("btnYonetici.Image")));
            this.btnYonetici.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYonetici.Location = new System.Drawing.Point(0, 65);
            this.btnYonetici.Name = "btnYonetici";
            this.btnYonetici.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnYonetici.Size = new System.Drawing.Size(225, 38);
            this.btnYonetici.TabIndex = 4;
            this.btnYonetici.Text = "    Yönetici Giriş";
            this.btnYonetici.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYonetici.UseVisualStyleBackColor = false;
            // 
            // BtnAyarlar
            // 
            this.BtnAyarlar.FlatAppearance.BorderSize = 0;
            this.BtnAyarlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAyarlar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAyarlar.ForeColor = System.Drawing.Color.White;
            this.BtnAyarlar.Image = ((System.Drawing.Image)(resources.GetObject("BtnAyarlar.Image")));
            this.BtnAyarlar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAyarlar.Location = new System.Drawing.Point(3, 173);
            this.BtnAyarlar.Name = "BtnAyarlar";
            this.BtnAyarlar.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BtnAyarlar.Size = new System.Drawing.Size(225, 58);
            this.BtnAyarlar.TabIndex = 2;
            this.BtnAyarlar.Text = "          Ayarlar";
            this.BtnAyarlar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAyarlar.UseVisualStyleBackColor = true;
            // 
            // BtnHakkında
            // 
            this.BtnHakkında.FlatAppearance.BorderSize = 0;
            this.BtnHakkında.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHakkında.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnHakkında.ForeColor = System.Drawing.Color.White;
            this.BtnHakkında.Image = ((System.Drawing.Image)(resources.GetObject("BtnHakkında.Image")));
            this.BtnHakkında.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHakkında.Location = new System.Drawing.Point(3, 237);
            this.BtnHakkında.Name = "BtnHakkında";
            this.BtnHakkında.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BtnHakkında.Size = new System.Drawing.Size(225, 58);
            this.BtnHakkında.TabIndex = 2;
            this.BtnHakkında.Text = "          Hakkında";
            this.BtnHakkında.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHakkında.UseVisualStyleBackColor = true;
            // 
            // btnCikisYap
            // 
            this.btnCikisYap.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCikisYap.FlatAppearance.BorderSize = 0;
            this.btnCikisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikisYap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikisYap.ForeColor = System.Drawing.Color.White;
            this.btnCikisYap.Image = ((System.Drawing.Image)(resources.GetObject("btnCikisYap.Image")));
            this.btnCikisYap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCikisYap.Location = new System.Drawing.Point(3, 301);
            this.btnCikisYap.Name = "btnCikisYap";
            this.btnCikisYap.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnCikisYap.Size = new System.Drawing.Size(240, 51);
            this.btnCikisYap.TabIndex = 4;
            this.btnCikisYap.Text = "          Çıkış Yap";
            this.btnCikisYap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCikisYap.UseVisualStyleBackColor = true;
            // 
            // BtnGirisYap
            // 
            this.BtnGirisYap.BackColor = System.Drawing.Color.Crimson;
            this.BtnGirisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGirisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGirisYap.ForeColor = System.Drawing.Color.White;
            this.BtnGirisYap.Location = new System.Drawing.Point(550, 453);
            this.BtnGirisYap.Name = "BtnGirisYap";
            this.BtnGirisYap.Size = new System.Drawing.Size(149, 47);
            this.BtnGirisYap.TabIndex = 41;
            this.BtnGirisYap.Text = "Giriş Yap";
            this.BtnGirisYap.UseVisualStyleBackColor = false;
            this.BtnGirisYap.Click += new System.EventHandler(this.BtnGirisYap_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1013, 467);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(251, 227);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 46;
            this.pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Crimson;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnCikis);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(53, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1170, 64);
            this.panel3.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(363, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(368, 50);
            this.label2.TabIndex = 71;
            this.label2.Text = "Yönetici Giriş Ekranı";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Crimson;
            this.btnCikis.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.Color.White;
            this.btnCikis.Location = new System.Drawing.Point(1116, 0);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(54, 64);
            this.btnCikis.TabIndex = 26;
            this.btnCikis.Text = "X";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // radioAblok
            // 
            this.radioAblok.AutoSize = true;
            this.radioAblok.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioAblok.ForeColor = System.Drawing.Color.Crimson;
            this.radioAblok.Location = new System.Drawing.Point(521, 217);
            this.radioAblok.Name = "radioAblok";
            this.radioAblok.Size = new System.Drawing.Size(109, 33);
            this.radioAblok.TabIndex = 48;
            this.radioAblok.TabStop = true;
            this.radioAblok.Text = "A Blok";
            this.radioAblok.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(420, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 32);
            this.label5.TabIndex = 58;
            this.label5.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(455, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 32);
            this.label3.TabIndex = 59;
            this.label3.Text = "Ad:";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(432, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 32);
            this.label4.TabIndex = 60;
            this.label4.Text = "Şifre:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.BackColor = System.Drawing.Color.White;
            this.txtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(521, 349);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(198, 34);
            this.txtSoyad.TabIndex = 56;
            // 
            // TxtAd
            // 
            this.TxtAd.BackColor = System.Drawing.Color.White;
            this.TxtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAd.Location = new System.Drawing.Point(521, 308);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(198, 34);
            this.TxtAd.TabIndex = 55;
            // 
            // TxtSifre
            // 
            this.TxtSifre.BackColor = System.Drawing.Color.White;
            this.TxtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSifre.Location = new System.Drawing.Point(521, 390);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(198, 34);
            this.TxtSifre.TabIndex = 57;
            this.TxtSifre.UseSystemPasswordChar = true;
            // 
            // radioBblok
            // 
            this.radioBblok.AutoSize = true;
            this.radioBblok.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioBblok.ForeColor = System.Drawing.Color.Crimson;
            this.radioBblok.Location = new System.Drawing.Point(520, 256);
            this.radioBblok.Name = "radioBblok";
            this.radioBblok.Size = new System.Drawing.Size(110, 33);
            this.radioBblok.TabIndex = 48;
            this.radioBblok.TabStop = true;
            this.radioBblok.Text = "B Blok";
            this.radioBblok.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(841, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(313, 32);
            this.label6.TabIndex = 59;
            this.label6.Text = "ablok: keremaydın kayd";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Crimson;
            this.label7.Location = new System.Drawing.Point(841, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(344, 32);
            this.label7.TabIndex = 59;
            this.label7.Text = "bblok: baran demirci bdem";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(189, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 61;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // YöneticiGiriş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1223, 662);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.radioBblok);
            this.Controls.Add(this.radioAblok);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.BtnGirisYap);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "YöneticiGiriş";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YöneticiGiriş";
            this.Load += new System.EventHandler(this.YöneticiGiriş_Load);
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menubutton)).EndInit();
            this.homecontainer.ResumeLayout(false);
            this.homecontainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox menubutton;
        private System.Windows.Forms.Panel homecontainer;
        private System.Windows.Forms.Button btnGüvenlik;
        private System.Windows.Forms.Button btnSiteSakin;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Button btnYonetici;
        private System.Windows.Forms.Button BtnAyarlar;
        private System.Windows.Forms.Button BtnHakkında;
        private System.Windows.Forms.Button btnCikisYap;
        private System.Windows.Forms.Button BtnGirisYap;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.RadioButton radioAblok;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.RadioButton radioBblok;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}