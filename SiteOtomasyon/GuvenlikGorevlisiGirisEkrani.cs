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
    public partial class GuvenlikGorevlisiGirisEkrani : Form
    {
        public GuvenlikGorevlisiGirisEkrani()
        {
            InitializeComponent();
        }
        #region front
        Animasyonlar animasyon = new Animasyonlar();
        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            animasyon.YanBarAnimasyon(sidebar, timer1);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            animasyon.HomeAnimasyon(homecontainer, timer2);
        }
        private void btnGiris_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void menubutton_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        #endregion

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            TxtAd.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TxtAd.Text);
            txtSoyad.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtSoyad.Text);
            baglanti baglan = new baglanti();
            baglan.GuvenlikGorevlisiGirisEkrani(TxtAd, txtSoyad, TxtSifre);

        }
    }
}
