namespace SiteOtomasyon
{
    partial class AidatKontrol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AidatKontrol));
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBoxA = new System.Windows.Forms.GroupBox();
            this.dataGridViewA = new System.Windows.Forms.DataGridView();
            this.groupBoxB = new System.Windows.Forms.GroupBox();
            this.dataGridViewB = new System.Windows.Forms.DataGridView();
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menubutton)).BeginInit();
            this.homecontainer.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBoxA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewA)).BeginInit();
            this.groupBoxB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewB)).BeginInit();
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
            this.sidebar.MaximumSize = new System.Drawing.Size(230, 577);
            this.sidebar.MinimumSize = new System.Drawing.Size(53, 577);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(53, 577);
            this.sidebar.TabIndex = 39;
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
            this.btnGüvenlik.Location = new System.Drawing.Point(-3, 156);
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
            this.btnSiteSakin.Location = new System.Drawing.Point(-3, 109);
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Crimson;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnCikis);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(53, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(973, 64);
            this.panel3.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(255, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(377, 50);
            this.label2.TabIndex = 71;
            this.label2.Text = "Aidat Kontrol Ekranı";
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
            this.panel2.Controls.Add(this.groupBoxA);
            this.panel2.Controls.Add(this.groupBoxB);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(53, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(973, 512);
            this.panel2.TabIndex = 44;
            // 
            // groupBoxA
            // 
            this.groupBoxA.Controls.Add(this.dataGridViewA);
            this.groupBoxA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.groupBoxA.Location = new System.Drawing.Point(70, 34);
            this.groupBoxA.Name = "groupBoxA";
            this.groupBoxA.Size = new System.Drawing.Size(373, 445);
            this.groupBoxA.TabIndex = 45;
            this.groupBoxA.TabStop = false;
            this.groupBoxA.Text = "A Blok";
            // 
            // dataGridViewA
            // 
            this.dataGridViewA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewA.Location = new System.Drawing.Point(6, 27);
            this.dataGridViewA.Name = "dataGridViewA";
            this.dataGridViewA.RowHeadersWidth = 51;
            this.dataGridViewA.RowTemplate.Height = 24;
            this.dataGridViewA.Size = new System.Drawing.Size(361, 412);
            this.dataGridViewA.TabIndex = 41;
            // 
            // groupBoxB
            // 
            this.groupBoxB.Controls.Add(this.dataGridViewB);
            this.groupBoxB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.groupBoxB.Location = new System.Drawing.Point(508, 34);
            this.groupBoxB.Name = "groupBoxB";
            this.groupBoxB.Size = new System.Drawing.Size(395, 445);
            this.groupBoxB.TabIndex = 44;
            this.groupBoxB.TabStop = false;
            this.groupBoxB.Text = "B Blok";
            // 
            // dataGridViewB
            // 
            this.dataGridViewB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewB.Location = new System.Drawing.Point(6, 33);
            this.dataGridViewB.Name = "dataGridViewB";
            this.dataGridViewB.RowHeadersWidth = 51;
            this.dataGridViewB.RowTemplate.Height = 24;
            this.dataGridViewB.Size = new System.Drawing.Size(383, 406);
            this.dataGridViewB.TabIndex = 41;
            // 
            // AidatKontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1026, 576);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AidatKontrol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AidatKontrol";
            this.Load += new System.EventHandler(this.AidatKontrol_Load);
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menubutton)).EndInit();
            this.homecontainer.ResumeLayout(false);
            this.homecontainer.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBoxA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewA)).EndInit();
            this.groupBoxB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewB)).EndInit();
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
        private System.Windows.Forms.Button BtnAyarlar;
        private System.Windows.Forms.Button BtnHakkında;
        private System.Windows.Forms.Button btnCikisYap;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBoxA;
        private System.Windows.Forms.DataGridView dataGridViewA;
        private System.Windows.Forms.GroupBox groupBoxB;
        private System.Windows.Forms.DataGridView dataGridViewB;
    }
}