using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.SqlClient;

namespace SiteOtomasyon
{
    public partial class YöneticiMenüsü : Form
    {
        public YöneticiMenüsü()
        {
            InitializeComponent();
            baglanti baglan= new baglanti();
            baglan.YoneticiBilgiler(lblad,lblsoyad,lblplaka,lbldaireno,lbltel,lblcins,lblmail,lblblok,lblblokyonetici,blokhaneinsaat);
            baglan.ApartmanBilgisi(lblApartmanAdi, lblKatBilgisi);
            if (lblblok.Text == "A")
            {
                blokhaneinsaat.Text = "BLOKHANE İNŞAAT A BLOK";
            }
            else
            {
                blokhaneinsaat.Text = "BLOKHANE İNŞAAT B BLOK";
            }
            baglan.blokbilgileri(datagridBlokbilgisi);
            
            

        }
        #region front
        Animasyonlar animasyon = new Animasyonlar();
        private void richTextBox1_TextChanged(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        private void btnAra_Click(object sender, EventArgs e)
        {
            if(txtAra.Text==""|| comboBox1.Text == "")
            {
                MessageBox.Show("Lütfen Filtreleme Seçimlerinizi Yapınız!");
            }
            else {
                string filtre = comboBox1.SelectedItem.ToString();
                string ArananIsim = txtAra.Text;
                if (filtre == "İsim")
                {
                    filtre = "isim";
                }
                else if (filtre == "Soyisim")
                {
                    filtre = "soyisim";
                }
                else if (filtre == "Araç Plakası")
                {
                    filtre = "aracplakasi";
                }
                else if (filtre == "Daire Numarası")
                {
                    filtre = "daireno";
                }
                else if (filtre == "Telefon Numarası")
                {
                    filtre = "telefon";
                }
                SQLiteConnection baglan1 = new SQLiteConnection("Data source=.\\apartmanyonetimsistemi.db;Versiyon=3");
                baglan1.Open();
                string sql = $"SELECT isim, soyisim, aracplakasi, daireno,telefon,cinsiyet,mail FROM {globaldegisken.blok}blok WHERE {filtre} LIKE '{ArananIsim}'";
                SQLiteCommand command = new SQLiteCommand(sql, baglan1);
                command.Parameters.AddWithValue("@ArananIsim", ArananIsim);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Aradığınız kritere uygun veri bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        datagridBlokbilgisi.DataSource = dt;
                    }

                 
                }
                baglan1.Close();
            }
            
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            baglanti baglanti = new baglanti();
            baglanti.blokbilgileri(datagridBlokbilgisi);
            txtAra.Text = "";
            comboBox1.Text="";
        }

        private void btnfiltre_Click(object sender, EventArgs e)
        {
            timer3.Start();     
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            animasyon.FiltrelemeAnimasyon(timer3,panelFiltre);
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
        }

        private void txtduyuru1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnduyuru_Click(object sender, EventArgs e)
        {
            // txtduyuru1 metin kutusundaki metni al
            string[] duyurular = txtduyuru1.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

            // Her bir duyuru için veritabanına ekleme işlemi yap
            using (SQLiteConnection baglanti = new SQLiteConnection("Data source=.\\apartmanyonetimsistemi.db;Version=3"))
            {
                // Bağlantıyı aç
                baglanti.Open();

                // Her duyuruyu veritabanına ekle
                foreach (string duyuru in duyurular)
                {
                    // Duyurunun boş olmadığından emin ol
                    if (!string.IsNullOrWhiteSpace(duyuru))
                    {
                        // SQLite komutunu oluştur
                        using (SQLiteCommand komut = new SQLiteCommand("INSERT INTO duyurular (duyuru1, duyuru2) VALUES (@duyuru1, @duyuru2)", baglanti))
                        {
                            // Parametreleri ekle
                            komut.Parameters.AddWithValue("@duyuru1", duyuru);  // İhtiyacınıza göre duyuru1 veya duyuru2 olarak ayarlayabilirsiniz
                            komut.Parameters.AddWithValue("@duyuru2", "");  // Eğer duyuru2'yi kullanmıyorsanız boş bırakabilirsiniz

                            // Komutu çalıştır
                            komut.ExecuteNonQuery();
                            
                            MessageBox.Show("Kaydetme işlemi başarılı");
                        }
                    }
                }
            }
        }
    }
}
