using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Data;

namespace SiteOtomasyon
{
    internal class baglanti

    {




        public void SiteSakiniGiris(Control isimtxt, Control soyisimtxt, Control sifretxt)
        {
            string query = "SELECT * FROM password where isim=@p1 and soyisim=@p2 and password=@p3";
            SQLiteConnection baglan = new SQLiteConnection("Data source=.\\apartmanyonetimsistemi.db;Versiyon=3");
            baglan.Open();
            SQLiteCommand cmd = new SQLiteCommand(query, baglan);
            cmd.Parameters.AddWithValue("@p1", isimtxt.Text);
            cmd.Parameters.AddWithValue("@p2", soyisimtxt.Text);
            cmd.Parameters.AddWithValue("@p3", sifretxt.Text);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                string ad = dt.Rows[0]["isim"].ToString();
                string soyad = dt.Rows[0]["Soyisim"].ToString();

                MessageBox.Show($"Hoş geldiniz Sayın {ad} {soyad}!", "Giriş Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.None);
                SiteSakiniMenü site = new SiteSakiniMenü();
                Form aktifForm = Form.ActiveForm;
                site.Show();
                aktifForm.Hide();
            }
            else
            {
                MessageBox.Show("Giriş Başarısız!", "Tekrar Dene!", MessageBoxButtons.OK);

            }
            baglan.Close();

        }

        public void GuvenlikGorevlisiGirisEkrani(Control isimtxt, Control soyisimtxt, Control sifretxt)
        {
            string query = "SELECT * FROM guvenlik where ad=@p1 and soyad=@p2 and password=@p3";
            SQLiteConnection baglan = new SQLiteConnection("Data source=.\\apartmanyonetimsistemi.db;Versiyon=3");
            baglan.Open();
            SQLiteCommand cmd = new SQLiteCommand(query, baglan);
            cmd.Parameters.AddWithValue("@p1", isimtxt.Text);
            cmd.Parameters.AddWithValue("@p2", soyisimtxt.Text);
            cmd.Parameters.AddWithValue("@p3", sifretxt.Text);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                string ad = dt.Rows[0]["ad"].ToString();
                string soyad = dt.Rows[0]["soyad"].ToString();
                MessageBox.Show($"Hoş geldiniz Sayın Güvenlik Görevlisi, {ad} {soyad}!", "Giriş Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.None);
                GüvenlikGörevlisiMenüsü site = new GüvenlikGörevlisiMenüsü();
                Form aktifForm = Form.ActiveForm;
                site.Show();
                aktifForm.Hide();
            }
            else
            {
                MessageBox.Show("Giriş Başarısız!", "Tekrar Dene!", MessageBoxButtons.OK);

            }
            baglan.Close();
        }

        public void YoneticiGiris(Control isimtxt, Control soyisimtxt, Control sifretxt, RadioButton Ablok, RadioButton Bblok)
        {
            if (Ablok.Checked)
            {


                globaldegisken.blok = "A";
                string query = "SELECT * FROM AblokYoneticisi where isim=@p1 and soyisim=@p2 and password=@p3";
                SQLiteConnection baglan = new SQLiteConnection("Data source=.\\apartmanyonetimsistemi.db;Versiyon=3");
                baglan.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, baglan);
                cmd.Parameters.AddWithValue("@p1", isimtxt.Text);
                cmd.Parameters.AddWithValue("@p2", soyisimtxt.Text);
                cmd.Parameters.AddWithValue("@p3", sifretxt.Text);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    string ad = dt.Rows[0]["İsim"].ToString();
                    string soyad = dt.Rows[0]["Soyisim"].ToString();
                    MessageBox.Show($"Hoş geldiniz Sayın {ad} {soyad} !", "Giriş Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.None);
                    YöneticiMenüsü site = new YöneticiMenüsü();
                    Form aktifForm = Form.ActiveForm;
                    site.Show();
                    aktifForm.Hide();

                }

                else
                {
                    MessageBox.Show("Giriş Başarısız!", "Tekrar Dene!", MessageBoxButtons.OK);

                }
                baglan.Close();
            }
            else if (Bblok.Checked)
            {

                globaldegisken.blok = "B";

                string query = "SELECT * FROM BblokYoneticisi where İsim=@p1 and Soyisim=@p2 and password=@p3";
                SQLiteConnection baglan = new SQLiteConnection("Data source=.\\apartmanyonetimsistemi.db;Versiyon=3");
                baglan.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, baglan);
                cmd.Parameters.AddWithValue("@p1", isimtxt.Text);
                cmd.Parameters.AddWithValue("@p2", soyisimtxt.Text);
                cmd.Parameters.AddWithValue("@p3", sifretxt.Text);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    string ad = dt.Rows[0]["İsim"].ToString();
                    string soyad = dt.Rows[0]["Soyisim"].ToString();
                    MessageBox.Show($"Hoş geldiniz Sayın {ad} {soyad}!", "Giriş Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.None);
                    YöneticiMenüsü site = new YöneticiMenüsü();
                    Form aktifForm = Form.ActiveForm;
                    site.Show();
                    aktifForm.Hide();
                }
                else
                {
                    MessageBox.Show("Giriş Başarısız!", "Tekrar Dene!", MessageBoxButtons.OK);

                }
                baglan.Close();
            }
            else
            {
                MessageBox.Show("Lütfen Blok Seçimi Yapınız!");
            }

        }

        public void YoneticiBilgiler(Label ad, Label soyad, Label aracplaka, Label daire, Label telefon, Label cins, Label mail, Label lblblok, Label yonetici,Label blokhaneinsaat)
        {
            lblblok.Text = globaldegisken.blok;
            
            string sql = $"SELECT isim, soyisim, aracplakasi, daireno, telefon, cinsiyet, mail FROM {globaldegisken.blok}Blok WHERE yonetici_id = 1";
            SQLiteConnection baglan = new SQLiteConnection("Data source=.\\apartmanyonetimsistemi.db;Versiyon=3");
            baglan.Open();
            {
                using (SQLiteCommand command = new SQLiteCommand(sql, baglan))
                {
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);

                        if (ds.Tables.Count > 0)
                        {
                            // Tabloda veri var
                            int rowCount = ds.Tables[0].Rows.Count;
                            for (int i = 0; i < rowCount; i++)
                            {
                                // Her satır için labellara veri yazdırın
                                ad.Text = ds.Tables[0].Rows[i]["isim"].ToString();
                                soyad.Text = ds.Tables[0].Rows[i]["soyisim"].ToString();
                                aracplaka.Text = ds.Tables[0].Rows[i]["aracplakasi"].ToString();
                                daire.Text = ds.Tables[0].Rows[i]["daireno"].ToString();
                                telefon.Text = ds.Tables[0].Rows[i]["telefon"].ToString();
                                cins.Text = ds.Tables[0].Rows[i]["cinsiyet"].ToString();
                                mail.Text = ds.Tables[0].Rows[i]["mail"].ToString();
                                yonetici.Text = ds.Tables[0].Rows[i]["isim"].ToString() + " " + ds.Tables[0].Rows[i]["soyisim"].ToString();




                                // Diğer labellar için de kod ekleyin
                            }

                        }
                    }
                }
            }
        }

        public void ApartmanBilgisi(Label ApartmanAdi, Label Kat)
        {
            string sql = $"SELECT apartmanadi,kat from sitebilgileri";
            SQLiteConnection baglan = new SQLiteConnection("Data source=.\\apartmanyonetimsistemi.db;Versiyon=3");
            baglan.Open();
            {
                using (SQLiteCommand command = new SQLiteCommand(sql, baglan))
                {
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);

                        if (ds.Tables.Count > 0)
                        {
                            // Tabloda veri var
                            int rowCount = ds.Tables[0].Rows.Count;
                            for (int i = 0; i < rowCount; i++)
                            {
                                // Her satır için labellara veri yazdırın
                                ApartmanAdi.Text = ds.Tables[0].Rows[i]["apartmanadi"].ToString();
                                Kat.Text = ds.Tables[0].Rows[i]["kat"].ToString();





                                // Diğer labellar için de kod ekleyin
                            }

                        }
                    }
                }




            }

        }

        public void blokbilgileri(DataGridView ad)
        {
            string sql = $"SELECT isim ,soyisim, aracplakasi, daireno, telefon, cinsiyet, mail FROM {globaldegisken.blok}Blok";
            SQLiteConnection baglan = new SQLiteConnection("Data source=.\\apartmanyonetimsistemi.db;Versiyon=3");
            baglan.Open();
            using (SQLiteCommand command = new SQLiteCommand(sql, baglan))
            {
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);

                    if (ds.Tables.Count > 0)
                    {
                        // Tabloda veri var
                        ad.DataSource = ds.Tables[0];
                        ad.AutoGenerateColumns = true;
                    }
                    else
                    {
                        MessageBox.Show("Tabloda veri bulunamadı!");
                    }
                }
            }


        }

        public void sitesakiniara(TextBox sitesakiniara,DataGridView ara)
        {
            string ad=sitesakiniara.Text;
            string sql = $"SELECT isim FROM {globaldegisken.blok}Blok WHERE isim = {ad}";

            SQLiteConnection baglan = new SQLiteConnection("Data source=.\\apartmanyonetimsistemi.db;Versiyon=3");
            baglan.Open();
            using (SQLiteCommand command = new SQLiteCommand(sql, baglan))
            {
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        ara.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Aradığınız kriterlere uyan kullanıcı bulunamadı!");
                    }
                }
            }
            baglan.Close();
        }
    }
}
