namespace SiteOtomasyon
{
    partial class YöneticiMenüsü
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YöneticiMenüsü));
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menubutton = new System.Windows.Forms.PictureBox();
            this.homecontainer = new System.Windows.Forms.Panel();
            this.btnGüvenlik = new System.Windows.Forms.Button();
            this.btnSiteSakin = new System.Windows.Forms.Button();
            this.btnGiris = new System.Windows.Forms.Button();
            this.btnYonetici = new System.Windows.Forms.Button();
            this.BtnDuyuruYapma = new System.Windows.Forms.Button();
            this.BtnSiteSakiniBilgileri = new System.Windows.Forms.Button();
            this.BtnAidatKontrol = new System.Windows.Forms.Button();
            this.btnCikisYap = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.KisiselBilgiler = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblblokyonetici = new System.Windows.Forms.Label();
            this.lblApartmanAdi = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.lbldaireno = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.lblblok = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblKatBilgisi = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblmail = new System.Windows.Forms.Label();
            this.lblcins = new System.Windows.Forms.Label();
            this.lbltel = new System.Windows.Forms.Label();
            this.lblplaka = new System.Windows.Forms.Label();
            this.lblsoyad = new System.Windows.Forms.Label();
            this.lblad = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelFiltre = new System.Windows.Forms.Panel();
            this.btnfiltre = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.datagridBlokbilgisi = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.blokhaneinsaat = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.txtduyuru1 = new System.Windows.Forms.TextBox();
            this.duyuru1 = new System.Windows.Forms.Label();
            this.btnduyuru = new System.Windows.Forms.Button();
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menubutton)).BeginInit();
            this.homecontainer.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.KisiselBilgiler.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panelFiltre.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridBlokbilgisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.Crimson;
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.homecontainer);
            this.sidebar.Controls.Add(this.BtnDuyuruYapma);
            this.sidebar.Controls.Add(this.BtnSiteSakiniBilgileri);
            this.sidebar.Controls.Add(this.BtnAidatKontrol);
            this.sidebar.Controls.Add(this.btnCikisYap);
            resources.ApplyResources(this.sidebar, "sidebar");
            this.sidebar.Name = "sidebar";
            this.sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebar_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menubutton);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // menubutton
            // 
            this.menubutton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.menubutton, "menubutton");
            this.menubutton.Name = "menubutton";
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
            resources.ApplyResources(this.homecontainer, "homecontainer");
            this.homecontainer.Name = "homecontainer";
            // 
            // btnGüvenlik
            // 
            resources.ApplyResources(this.btnGüvenlik, "btnGüvenlik");
            this.btnGüvenlik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.btnGüvenlik.FlatAppearance.BorderSize = 0;
            this.btnGüvenlik.ForeColor = System.Drawing.Color.White;
            this.btnGüvenlik.Name = "btnGüvenlik";
            this.btnGüvenlik.UseVisualStyleBackColor = false;
            // 
            // btnSiteSakin
            // 
            resources.ApplyResources(this.btnSiteSakin, "btnSiteSakin");
            this.btnSiteSakin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.btnSiteSakin.FlatAppearance.BorderSize = 0;
            this.btnSiteSakin.ForeColor = System.Drawing.Color.White;
            this.btnSiteSakin.Name = "btnSiteSakin";
            this.btnSiteSakin.UseVisualStyleBackColor = false;
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.Crimson;
            resources.ApplyResources(this.btnGiris, "btnGiris");
            this.btnGiris.FlatAppearance.BorderSize = 0;
            this.btnGiris.ForeColor = System.Drawing.Color.White;
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // btnYonetici
            // 
            resources.ApplyResources(this.btnYonetici, "btnYonetici");
            this.btnYonetici.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.btnYonetici.FlatAppearance.BorderSize = 0;
            this.btnYonetici.ForeColor = System.Drawing.Color.White;
            this.btnYonetici.Name = "btnYonetici";
            this.btnYonetici.UseVisualStyleBackColor = false;
            // 
            // BtnDuyuruYapma
            // 
            this.BtnDuyuruYapma.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.BtnDuyuruYapma, "BtnDuyuruYapma");
            this.BtnDuyuruYapma.ForeColor = System.Drawing.Color.White;
            this.BtnDuyuruYapma.Name = "BtnDuyuruYapma";
            this.BtnDuyuruYapma.UseVisualStyleBackColor = true;
            this.BtnDuyuruYapma.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnSiteSakiniBilgileri
            // 
            this.BtnSiteSakiniBilgileri.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.BtnSiteSakiniBilgileri, "BtnSiteSakiniBilgileri");
            this.BtnSiteSakiniBilgileri.ForeColor = System.Drawing.Color.White;
            this.BtnSiteSakiniBilgileri.Name = "BtnSiteSakiniBilgileri";
            this.BtnSiteSakiniBilgileri.UseVisualStyleBackColor = true;
            // 
            // BtnAidatKontrol
            // 
            this.BtnAidatKontrol.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.BtnAidatKontrol, "BtnAidatKontrol");
            this.BtnAidatKontrol.ForeColor = System.Drawing.Color.White;
            this.BtnAidatKontrol.Name = "BtnAidatKontrol";
            this.BtnAidatKontrol.UseVisualStyleBackColor = true;
            // 
            // btnCikisYap
            // 
            this.btnCikisYap.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnCikisYap, "btnCikisYap");
            this.btnCikisYap.ForeColor = System.Drawing.Color.White;
            this.btnCikisYap.Name = "btnCikisYap";
            this.btnCikisYap.UseVisualStyleBackColor = true;
            this.btnCikisYap.Click += new System.EventHandler(this.btnCikisYap_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Crimson;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnCikis);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Crimson;
            resources.ApplyResources(this.btnCikis, "btnCikis");
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.ForeColor = System.Drawing.Color.White;
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.KisiselBilgiler);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // KisiselBilgiler
            // 
            this.KisiselBilgiler.Controls.Add(this.tabPage1);
            this.KisiselBilgiler.Controls.Add(this.tabPage2);
            this.KisiselBilgiler.Controls.Add(this.tabPage3);
            this.KisiselBilgiler.Controls.Add(this.tabPage4);
            resources.ApplyResources(this.KisiselBilgiler, "KisiselBilgiler");
            this.KisiselBilgiler.Name = "KisiselBilgiler";
            this.KisiselBilgiler.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label29);
            this.tabPage1.Controls.Add(this.label28);
            this.tabPage1.Controls.Add(this.panel6);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.panel5);
            this.tabPage1.Controls.Add(this.pictureBox3);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label29
            // 
            resources.ApplyResources(this.label29, "label29");
            this.label29.Name = "label29";
            // 
            // label28
            // 
            resources.ApplyResources(this.label28, "label28");
            this.label28.Name = "label28";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.lblblokyonetici);
            this.panel6.Controls.Add(this.lblApartmanAdi);
            this.panel6.Controls.Add(this.label26);
            this.panel6.Controls.Add(this.lbldaireno);
            this.panel6.Controls.Add(this.label27);
            this.panel6.Controls.Add(this.lblblok);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.lblKatBilgisi);
            this.panel6.Controls.Add(this.label8);
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.Name = "panel6";
            // 
            // lblblokyonetici
            // 
            resources.ApplyResources(this.lblblokyonetici, "lblblokyonetici");
            this.lblblokyonetici.ForeColor = System.Drawing.Color.Crimson;
            this.lblblokyonetici.Name = "lblblokyonetici";
            // 
            // lblApartmanAdi
            // 
            resources.ApplyResources(this.lblApartmanAdi, "lblApartmanAdi");
            this.lblApartmanAdi.ForeColor = System.Drawing.Color.Crimson;
            this.lblApartmanAdi.Name = "lblApartmanAdi";
            // 
            // label26
            // 
            resources.ApplyResources(this.label26, "label26");
            this.label26.Name = "label26";
            // 
            // lbldaireno
            // 
            resources.ApplyResources(this.lbldaireno, "lbldaireno");
            this.lbldaireno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbldaireno.ForeColor = System.Drawing.Color.Crimson;
            this.lbldaireno.Name = "lbldaireno";
            // 
            // label27
            // 
            resources.ApplyResources(this.label27, "label27");
            this.label27.Name = "label27";
            // 
            // lblblok
            // 
            resources.ApplyResources(this.lblblok, "lblblok");
            this.lblblok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblblok.ForeColor = System.Drawing.Color.Crimson;
            this.lblblok.Name = "lblblok";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // lblKatBilgisi
            // 
            resources.ApplyResources(this.lblKatBilgisi, "lblKatBilgisi");
            this.lblKatBilgisi.ForeColor = System.Drawing.Color.Crimson;
            this.lblKatBilgisi.Name = "lblKatBilgisi";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.lblmail);
            this.panel5.Controls.Add(this.lblcins);
            this.panel5.Controls.Add(this.lbltel);
            this.panel5.Controls.Add(this.lblplaka);
            this.panel5.Controls.Add(this.lblsoyad);
            this.panel5.Controls.Add(this.lblad);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label4);
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // lblmail
            // 
            resources.ApplyResources(this.lblmail, "lblmail");
            this.lblmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblmail.ForeColor = System.Drawing.Color.Crimson;
            this.lblmail.Name = "lblmail";
            // 
            // lblcins
            // 
            resources.ApplyResources(this.lblcins, "lblcins");
            this.lblcins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblcins.ForeColor = System.Drawing.Color.Crimson;
            this.lblcins.Name = "lblcins";
            // 
            // lbltel
            // 
            resources.ApplyResources(this.lbltel, "lbltel");
            this.lbltel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbltel.ForeColor = System.Drawing.Color.Crimson;
            this.lbltel.Name = "lbltel";
            // 
            // lblplaka
            // 
            resources.ApplyResources(this.lblplaka, "lblplaka");
            this.lblplaka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblplaka.ForeColor = System.Drawing.Color.Crimson;
            this.lblplaka.Name = "lblplaka";
            // 
            // lblsoyad
            // 
            resources.ApplyResources(this.lblsoyad, "lblsoyad");
            this.lblsoyad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblsoyad.ForeColor = System.Drawing.Color.Crimson;
            this.lblsoyad.Name = "lblsoyad";
            // 
            // lblad
            // 
            resources.ApplyResources(this.lblad, "lblad");
            this.lblad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblad.ForeColor = System.Drawing.Color.Crimson;
            this.lblad.Name = "lblad";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // pictureBox3
            // 
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panelFiltre);
            this.tabPage2.Controls.Add(this.panel7);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.blokhaneinsaat);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panelFiltre
            // 
            this.panelFiltre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelFiltre.Controls.Add(this.btnfiltre);
            this.panelFiltre.Controls.Add(this.txtAra);
            this.panelFiltre.Controls.Add(this.comboBox1);
            this.panelFiltre.Controls.Add(this.btnAra);
            this.panelFiltre.Controls.Add(this.btnTemizle);
            resources.ApplyResources(this.panelFiltre, "panelFiltre");
            this.panelFiltre.Name = "panelFiltre";
            // 
            // btnfiltre
            // 
            this.btnfiltre.BackColor = System.Drawing.Color.Crimson;
            resources.ApplyResources(this.btnfiltre, "btnfiltre");
            this.btnfiltre.FlatAppearance.BorderSize = 0;
            this.btnfiltre.ForeColor = System.Drawing.Color.White;
            this.btnfiltre.Name = "btnfiltre";
            this.btnfiltre.UseVisualStyleBackColor = false;
            this.btnfiltre.Click += new System.EventHandler(this.btnfiltre_Click);
            // 
            // txtAra
            // 
            this.txtAra.BackColor = System.Drawing.Color.White;
            this.txtAra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtAra, "txtAra");
            this.txtAra.ForeColor = System.Drawing.Color.Crimson;
            this.txtAra.Name = "txtAra";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.ForeColor = System.Drawing.Color.Crimson;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1"),
            resources.GetString("comboBox1.Items2"),
            resources.GetString("comboBox1.Items3"),
            resources.GetString("comboBox1.Items4")});
            this.comboBox1.Name = "comboBox1";
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.Crimson;
            resources.ApplyResources(this.btnAra, "btnAra");
            this.btnAra.ForeColor = System.Drawing.Color.White;
            this.btnAra.Name = "btnAra";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.Crimson;
            resources.ApplyResources(this.btnTemizle, "btnTemizle");
            this.btnTemizle.ForeColor = System.Drawing.Color.White;
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.datagridBlokbilgisi);
            resources.ApplyResources(this.panel7, "panel7");
            this.panel7.Name = "panel7";
            // 
            // datagridBlokbilgisi
            // 
            this.datagridBlokbilgisi.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.datagridBlokbilgisi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.datagridBlokbilgisi, "datagridBlokbilgisi");
            this.datagridBlokbilgisi.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.datagridBlokbilgisi.Name = "datagridBlokbilgisi";
            this.datagridBlokbilgisi.RowTemplate.Height = 24;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // blokhaneinsaat
            // 
            resources.ApplyResources(this.blokhaneinsaat, "blokhaneinsaat");
            this.blokhaneinsaat.Name = "blokhaneinsaat";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnduyuru);
            this.tabPage3.Controls.Add(this.duyuru1);
            this.tabPage3.Controls.Add(this.txtduyuru1);
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            resources.ApplyResources(this.tabPage4, "tabPage4");
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
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
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // timer3
            // 
            this.timer3.Interval = 10;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // txtduyuru1
            // 
            resources.ApplyResources(this.txtduyuru1, "txtduyuru1");
            this.txtduyuru1.Name = "txtduyuru1";
            this.txtduyuru1.TextChanged += new System.EventHandler(this.txtduyuru1_TextChanged);
            // 
            // duyuru1
            // 
            resources.ApplyResources(this.duyuru1, "duyuru1");
            this.duyuru1.Name = "duyuru1";
            // 
            // btnduyuru
            // 
            resources.ApplyResources(this.btnduyuru, "btnduyuru");
            this.btnduyuru.Name = "btnduyuru";
            this.btnduyuru.UseVisualStyleBackColor = true;
            this.btnduyuru.Click += new System.EventHandler(this.btnduyuru_Click);
            // 
            // YöneticiMenüsü
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "YöneticiMenüsü";
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menubutton)).EndInit();
            this.homecontainer.ResumeLayout(false);
            this.homecontainer.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.KisiselBilgiler.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panelFiltre.ResumeLayout(false);
            this.panelFiltre.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridBlokbilgisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button BtnDuyuruYapma;
        private System.Windows.Forms.Button BtnSiteSakiniBilgileri;
        private System.Windows.Forms.Button BtnAidatKontrol;
        private System.Windows.Forms.Button btnCikisYap;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TabControl KisiselBilgiler;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblmail;
        private System.Windows.Forms.Label lblcins;
        private System.Windows.Forms.Label lbltel;
        private System.Windows.Forms.Label lblplaka;
        private System.Windows.Forms.Label lblsoyad;
        private System.Windows.Forms.Label lblad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblApartmanAdi;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.Label lbldaireno;
        private System.Windows.Forms.Label lblblok;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblblokyonetici;
        private System.Windows.Forms.Label lblKatBilgisi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label blokhaneinsaat;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView datagridBlokbilgisi;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panelFiltre;
        private System.Windows.Forms.Button btnfiltre;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label duyuru1;
        private System.Windows.Forms.TextBox txtduyuru1;
        private System.Windows.Forms.Button btnduyuru;
    }
}