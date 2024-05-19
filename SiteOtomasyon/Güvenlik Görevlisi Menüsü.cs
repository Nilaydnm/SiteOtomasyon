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
    public partial class GüvenlikGörevlisiMenüsü : Form
    {
        public GüvenlikGörevlisiMenüsü()
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

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
