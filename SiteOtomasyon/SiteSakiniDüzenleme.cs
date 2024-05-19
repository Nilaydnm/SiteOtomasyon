using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiteOtomasyon
{
    public partial class SiteSakiniDüzenleme : Form
    {
        public SiteSakiniDüzenleme()
        {
            InitializeComponent();
        }
        Animasyonlar animasyon = new Animasyonlar();

        private void timer1_Tick(object sender, EventArgs e)
        {
            animasyon.YanBarAnimasyon(sidebar, timer1);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            animasyon.HomeAnimasyon(homecontainer, timer2);
        }

        private void menubutton_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void btnGiris_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void SiteSakiniDüzenleme_Load(object sender, EventArgs e)
        {

        }
        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiteSakiniDüzenleme));
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menubutton = new System.Windows.Forms.PictureBox();
            this.homecontainer = new System.Windows.Forms.Panel();
            this.btnGüvenlik = new System.Windows.Forms.Button();
            this.btnSiteSakin = new System.Windows.Forms.Button();
            this.btnGiris = new System.Windows.Forms.Button();
            this.btnYonetici = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnCikisYap = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtSKullanıcıAdı = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.TxtSBlok = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.TxtSDaireNo = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.TxtSAd = new System.Windows.Forms.TextBox();
            this.TxtSSifre = new System.Windows.Forms.TextBox();
            this.txtKulaniciAd = new System.Windows.Forms.TextBox();
            this.TxtSKat = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.TxtSPlaka = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TxtSTelNo = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.dataGridViewSiteSakini = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menubutton)).BeginInit();
            this.homecontainer.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSiteSakini)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.Crimson;
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.homecontainer);
            this.sidebar.Controls.Add(this.button2);
            this.sidebar.Controls.Add(this.button3);
            this.sidebar.Controls.Add(this.btnCikisYap);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(230, 577);
            this.sidebar.MinimumSize = new System.Drawing.Size(53, 650);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(53, 650);
            this.sidebar.TabIndex = 96;
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
            this.btnGüvenlik.Location = new System.Drawing.Point(-3, 150);
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
            this.btnSiteSakin.Location = new System.Drawing.Point(-3, 107);
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
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(3, 173);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(225, 58);
            this.button2.TabIndex = 2;
            this.button2.Text = "          Ayarlar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(3, 237);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(225, 58);
            this.button3.TabIndex = 2;
            this.button3.Text = "          Hakkında";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Crimson;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnCikis);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(53, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(973, 64);
            this.panel3.TabIndex = 97;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(217, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(527, 50);
            this.label2.TabIndex = 71;
            this.label2.Text = "Site Sakini Düzenleme Ekranı";
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
            this.btnCikis.Location = new System.Drawing.Point(919, 0);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.TxtSKullanıcıAdı);
            this.panel2.Controls.Add(this.textBox6);
            this.panel2.Controls.Add(this.TxtSBlok);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.TxtSDaireNo);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.TxtSAd);
            this.panel2.Controls.Add(this.TxtSSifre);
            this.panel2.Controls.Add(this.txtKulaniciAd);
            this.panel2.Controls.Add(this.TxtSKat);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.TxtSPlaka);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.TxtSTelNo);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.txtSifre);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.btnGirisYap);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.dataGridViewSiteSakini);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(53, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(973, 512);
            this.panel2.TabIndex = 98;
            // 
            // TxtSKullanıcıAdı
            // 
            this.TxtSKullanıcıAdı.BackColor = System.Drawing.Color.White;
            this.TxtSKullanıcıAdı.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSKullanıcıAdı.Location = new System.Drawing.Point(190, 301);
            this.TxtSKullanıcıAdı.Name = "TxtSKullanıcıAdı";
            this.TxtSKullanıcıAdı.Size = new System.Drawing.Size(198, 30);
            this.TxtSKullanıcıAdı.TabIndex = 128;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.White;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox6.Location = new System.Drawing.Point(187, 301);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(198, 30);
            this.textBox6.TabIndex = 129;
            // 
            // TxtSBlok
            // 
            this.TxtSBlok.BackColor = System.Drawing.Color.White;
            this.TxtSBlok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSBlok.Location = new System.Drawing.Point(190, 115);
            this.TxtSBlok.Name = "TxtSBlok";
            this.TxtSBlok.Size = new System.Drawing.Size(198, 30);
            this.TxtSBlok.TabIndex = 131;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(187, 115);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(198, 30);
            this.textBox2.TabIndex = 130;
            // 
            // TxtSDaireNo
            // 
            this.TxtSDaireNo.BackColor = System.Drawing.Color.White;
            this.TxtSDaireNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSDaireNo.Location = new System.Drawing.Point(190, 207);
            this.TxtSDaireNo.Name = "TxtSDaireNo";
            this.TxtSDaireNo.Size = new System.Drawing.Size(198, 30);
            this.TxtSDaireNo.TabIndex = 133;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.White;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox5.Location = new System.Drawing.Point(187, 207);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(198, 30);
            this.textBox5.TabIndex = 132;
            // 
            // TxtSAd
            // 
            this.TxtSAd.BackColor = System.Drawing.Color.White;
            this.TxtSAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSAd.Location = new System.Drawing.Point(190, 24);
            this.TxtSAd.Name = "TxtSAd";
            this.TxtSAd.Size = new System.Drawing.Size(198, 30);
            this.TxtSAd.TabIndex = 135;
            // 
            // TxtSSifre
            // 
            this.TxtSSifre.BackColor = System.Drawing.Color.White;
            this.TxtSSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSSifre.Location = new System.Drawing.Point(190, 347);
            this.TxtSSifre.Name = "TxtSSifre";
            this.TxtSSifre.Size = new System.Drawing.Size(198, 30);
            this.TxtSSifre.TabIndex = 137;
            this.TxtSSifre.UseSystemPasswordChar = true;
            // 
            // txtKulaniciAd
            // 
            this.txtKulaniciAd.BackColor = System.Drawing.Color.White;
            this.txtKulaniciAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKulaniciAd.Location = new System.Drawing.Point(187, 24);
            this.txtKulaniciAd.Name = "txtKulaniciAd";
            this.txtKulaniciAd.Size = new System.Drawing.Size(198, 30);
            this.txtKulaniciAd.TabIndex = 134;
            // 
            // TxtSKat
            // 
            this.TxtSKat.BackColor = System.Drawing.Color.White;
            this.TxtSKat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSKat.Location = new System.Drawing.Point(190, 163);
            this.TxtSKat.Name = "TxtSKat";
            this.TxtSKat.Size = new System.Drawing.Size(198, 30);
            this.TxtSKat.TabIndex = 139;
            this.TxtSKat.UseSystemPasswordChar = true;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox4.Location = new System.Drawing.Point(187, 347);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(198, 30);
            this.textBox4.TabIndex = 136;
            this.textBox4.UseSystemPasswordChar = true;
            // 
            // TxtSPlaka
            // 
            this.TxtSPlaka.BackColor = System.Drawing.Color.White;
            this.TxtSPlaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSPlaka.Location = new System.Drawing.Point(190, 255);
            this.TxtSPlaka.Name = "TxtSPlaka";
            this.TxtSPlaka.Size = new System.Drawing.Size(198, 30);
            this.TxtSPlaka.TabIndex = 140;
            this.TxtSPlaka.UseSystemPasswordChar = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(187, 163);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 30);
            this.textBox1.TabIndex = 138;
            this.textBox1.UseSystemPasswordChar = true;
            // 
            // TxtSTelNo
            // 
            this.TxtSTelNo.BackColor = System.Drawing.Color.White;
            this.TxtSTelNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSTelNo.Location = new System.Drawing.Point(190, 72);
            this.TxtSTelNo.Name = "TxtSTelNo";
            this.TxtSTelNo.Size = new System.Drawing.Size(198, 30);
            this.TxtSTelNo.TabIndex = 142;
            this.TxtSTelNo.UseSystemPasswordChar = true;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox3.Location = new System.Drawing.Point(187, 255);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(198, 30);
            this.textBox3.TabIndex = 141;
            this.textBox3.UseSystemPasswordChar = true;
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.White;
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(187, 72);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(198, 30);
            this.txtSifre.TabIndex = 143;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Crimson;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(504, 462);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(208, 41);
            this.button7.TabIndex = 119;
            this.button7.Text = "Çıkış Yap";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Crimson;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(279, 462);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(208, 41);
            this.button6.TabIndex = 120;
            this.button6.Text = "Bilgi Güncelle";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Crimson;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(504, 413);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(208, 41);
            this.button4.TabIndex = 121;
            this.button4.Text = "Geri Dön";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(279, 413);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 41);
            this.button1.TabIndex = 122;
            this.button1.Text = "Listele";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Crimson;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(51, 462);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(220, 41);
            this.button5.TabIndex = 124;
            this.button5.Text = "Site Sakini Sil";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.BackColor = System.Drawing.Color.Crimson;
            this.btnGirisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGirisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGirisYap.ForeColor = System.Drawing.Color.White;
            this.btnGirisYap.Location = new System.Drawing.Point(51, 413);
            this.btnGirisYap.Margin = new System.Windows.Forms.Padding(4);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(220, 41);
            this.btnGirisYap.TabIndex = 123;
            this.btnGirisYap.Text = "Site Sakini Ekle";
            this.btnGirisYap.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(848, 413);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(125, 99);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 118;
            this.pictureBox3.TabStop = false;
            // 
            // dataGridViewSiteSakini
            // 
            this.dataGridViewSiteSakini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSiteSakini.Location = new System.Drawing.Point(433, 19);
            this.dataGridViewSiteSakini.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewSiteSakini.Name = "dataGridViewSiteSakini";
            this.dataGridViewSiteSakini.RowHeadersWidth = 51;
            this.dataGridViewSiteSakini.Size = new System.Drawing.Size(497, 366);
            this.dataGridViewSiteSakini.TabIndex = 112;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(99, 348);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 29);
            this.label3.TabIndex = 127;
            this.label3.Text = "Şifre:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.Crimson;
            this.label10.Location = new System.Drawing.Point(22, 302);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(165, 29);
            this.label10.TabIndex = 126;
            this.label10.Text = "Kullanıcı Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(104, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 29);
            this.label4.TabIndex = 125;
            this.label4.Text = "Blok:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Crimson;
            this.label9.Location = new System.Drawing.Point(56, 207);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 29);
            this.label9.TabIndex = 117;
            this.label9.Text = "Daire No:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Crimson;
            this.label8.Location = new System.Drawing.Point(24, 256);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 29);
            this.label8.TabIndex = 116;
            this.label8.Text = "Araç Plakası:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Crimson;
            this.label7.Location = new System.Drawing.Point(114, 158);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 29);
            this.label7.TabIndex = 115;
            this.label7.Text = "Kat:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(69, 68);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 29);
            this.label5.TabIndex = 114;
            this.label5.Text = "Telefon:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(52, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 29);
            this.label6.TabIndex = 113;
            this.label6.Text = "Ad Soyad:";
            // 
            // SiteSakiniDüzenleme
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1026, 576);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SiteSakiniDüzenleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.SiteSakiniDüzenleme_Load);
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menubutton)).EndInit();
            this.homecontainer.ResumeLayout(false);
            this.homecontainer.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSiteSakini)).EndInit();
            this.ResumeLayout(false);

        }
        private FlowLayoutPanel sidebar;
        private Panel panel1;
        private Label label1;
        private PictureBox menubutton;
        private Panel homecontainer;
        private Button btnGüvenlik;
        private Button btnSiteSakin;
        private Button btnGiris;
        private Button btnYonetici;
        private Button button2;
        private Button button3;
        private Button btnCikisYap;
        private Panel panel3;
        private Label label2;
        private Button btnCikis;
        private Timer timer1;
        private IContainer components;
        private Timer timer2;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private Panel panel2;
        private TextBox TxtSKullanıcıAdı;
        private TextBox textBox6;
        private TextBox TxtSBlok;
        private TextBox textBox2;
        private TextBox TxtSDaireNo;
        private TextBox textBox5;
        private TextBox TxtSAd;
        private TextBox TxtSSifre;
        private TextBox txtKulaniciAd;
        private TextBox TxtSKat;
        private TextBox textBox4;
        private TextBox TxtSPlaka;
        private TextBox textBox1;
        private TextBox TxtSTelNo;
        private TextBox textBox3;
        private TextBox txtSifre;
        private Button button7;
        private Button button6;
        private Button button4;
        private Button button1;
        private Button button5;
        private Button btnGirisYap;
        private PictureBox pictureBox3;
        private DataGridView dataGridViewSiteSakini;
        private Label label3;
        private Label label10;
        private Label label4;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label5;
        private Label label6;
    }
}
