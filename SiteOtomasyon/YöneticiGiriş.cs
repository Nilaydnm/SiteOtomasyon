using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiteOtomasyon
{
    public partial class YöneticiGiriş : Form
    {
        public YöneticiGiriş()
        {
            InitializeComponent();
        }
        #region front
        Animasyonlar animasyon = new Animasyonlar();
        private void YöneticiGiriş_Load(object sender, EventArgs e)
        {

        }

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

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            TxtAd.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TxtAd.Text);
            txtSoyad.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtSoyad.Text);
            baglanti baglan = new baglanti();
            baglan.YoneticiGiris(TxtAd,txtSoyad,TxtSifre,radioAblok,radioBblok);
           


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            TxtAd.Text = "Kerem";
            txtSoyad.Text = "Aydın";
            TxtSifre.Text = "kayd";
        }
    }
}
