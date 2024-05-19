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
    public partial class OtoparkKontrol : Form
    {
        public OtoparkKontrol()
        {
            InitializeComponent();
        }
        Animasyonlar animasyon = new Animasyonlar();

        private void OtoparkKontrol_Load(object sender, EventArgs e)
        {

        }

        private void menubutton_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnGiris_Click_1(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void sidebar_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            animasyon.YanBarAnimasyon(sidebar, timer1);
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            animasyon.YanBarAnimasyon(sidebar, timer1);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
