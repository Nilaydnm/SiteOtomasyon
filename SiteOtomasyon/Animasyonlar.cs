using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiteOtomasyon
{
    internal class Animasyonlar
    {
        bool sidebarExpend;
        bool login;
        bool filtre1;
        public void YanBarAnimasyon(Panel sidebar, Timer timer1)
        {
            if (sidebarExpend)
            {

                sidebar.Width -= 20;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpend = false;
                    timer1.Stop();
                }
            }
            else
            {
                sidebar.Width += 20;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpend = true;
                    timer1.Stop();
                }
            }

        }
        public void HomeAnimasyon(Panel homecontainer, Timer timer2)
        {
            if (login)
            {
                homecontainer.Height += 20;
                if (homecontainer.Height == homecontainer.MaximumSize.Height)
                {
                    login = false;
                    timer2.Stop();
                }
            }
            else
            {
                homecontainer.Height -= 20;
                if (homecontainer.Height == homecontainer.MinimumSize.Height)
                {
                    login = true;
                    timer2.Stop();
                }
            }
        }

        public void FiltrelemeAnimasyon(Timer timer3,Panel filtrepanel)
        {
            if (filtre1)
            {
                filtrepanel.Height += 20;
                if (filtrepanel.Height == filtrepanel.MaximumSize.Height)
                {
                    filtre1 = false;
                    timer3.Stop();
                }
            }
            else
            {
                filtrepanel.Height -= 20;
                if (filtrepanel.Height == filtrepanel.MinimumSize.Height)
                {
                    filtre1 = true;
                    timer3.Stop();
                }
            }
        }
        }
}
