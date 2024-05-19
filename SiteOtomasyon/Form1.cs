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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BtnBlokYoneticiGiris.BackColor = Color.Transparent;
            BtnBlokYoneticiGiris.Parent= pictureBox1;
            BtnApartmanSakiniGiris.Parent = pictureBox1;
            BtnApartmanSakiniGiris.BackColor= Color.Transparent;
            BtnGuvenlikGorevlisiGiris.Parent = pictureBox1;
            BtnGuvenlikGorevlisiGiris.BackColor = Color.Transparent;
        }
        Animasyonlar animasyon= new Animasyonlar();
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

        private void BtnApartmanSakiniGiris_Click(object sender, EventArgs e)
        {
            SiteSakiniGiris site = new SiteSakiniGiris();
            site.Show();
            this.Hide();
        }

        private void BtnBlokYoneticiGiris_Click(object sender, EventArgs e)
        {
            YöneticiGiriş site = new YöneticiGiriş();
            site.Show();
            this.Hide();
        }

        private void BtnGuvenlikGorevlisiGiris_Click(object sender, EventArgs e)
        {
            GuvenlikGorevlisiGirisEkrani site = new GuvenlikGorevlisiGirisEkrani();
            site.Show();
            this.Hide();
        }
    }
}
