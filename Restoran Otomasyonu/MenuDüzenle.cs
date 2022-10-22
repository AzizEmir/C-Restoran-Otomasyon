using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.IO;

namespace RestorantFikir2
{
    public partial class MenuDüzenle : Form
    {
        public MenuDüzenle()
        {
            InitializeComponent();
        }
        DBislemleri bag = new DBislemleri();// Bağlantı için oluşturulan class’tan türetilen bir nesne
        DataTable dtYemekler = new DataTable();//Tablolara yüklemek için bir adet dtBirinci değişkeni tanımlandı.
        DataTable dtMenu = new DataTable();//Tablolara yüklemek için bir adet dtBirinci değişkeni tanımlandı.
        MySqlCommand kmt = new MySqlCommand();//İşlemler için bir MySqlCommand nesnesi tanımlandı.
        int siraNo = 0;
        private void DataGridiDoldur()
        {
            dgw1.RowHeadersVisible = true;//Satır başlıkları görünmez yapılır.
            dgw1.Font = new Font("Arial", 10);// Datagridview için font ayarlaması yapılır.
            dtYemekler.Columns.Clear();//Tablonun önceki kullanımından kalan sütunlar temizlenir.
            dtYemekler.Clear(); // Tablo temizlenir.
            MySqlDataAdapter adtr = new MySqlDataAdapter("select * from yemekler", bag.Baglan());//Komut ve bağlantı yüklenen DataAdapter nesnesi
            adtr.Fill(dtYemekler);//DataAdapter nesnesine yüklenen bilgiler tabloya aktarılır.
            dgw1.DataSource = dtYemekler; //Datagridview bileşeni data kaynağı olarak dtBirinci seçilir.

            dgw1.Columns["id"].HeaderText = "ID";
            dgw1.Columns["id"].Width = 75;
            dgw1.Columns["ad"].HeaderText = "AD";
            dgw1.Columns["ad"].Width = 220;
            dgw1.Columns["fiyat"].HeaderText = "FİYAT";
            dgw1.Columns["fiyat"].Width = 100;
            dgw1.Columns["tur"].HeaderText = "TÜR";
            dgw1.Columns["tur"].Width = 234;
            dgw1.Columns["resim"].HeaderText = "RESİM";
            dgw1.Columns["resim"].Width = 125;

            try
            {
                dgw1.Rows[siraNo].Selected = true;
            }
            catch (Exception)
            {

                MessageBox.Show("Menü Boş", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            VerileriDoldur();
            bag.BaglantiyiKapat();
        }
        private void ComboboxDoldur()
        {
            dtMenu.Clear(); // Tablo temizlenir.
            MySqlDataAdapter adtr2 = new MySqlDataAdapter("select * from yemekturu", bag.Baglan());//Komut ve bağlantı yüklenen DataAdapter nesnesi
            adtr2.Fill(dtMenu);
            cbYemekTuru.Items.Clear();


            for (int i = 0; i < dtMenu.Rows.Count; i++)
            {
                cbYemekTuru.Items.Add(dtMenu.Rows[i]["Tur"].ToString());
            }

        }
        private void VerileriDoldur()
        {
            if (siraNo >= 0 && siraNo < dtYemekler.Rows.Count)
            {
                txtYemekAdı.Text = dtYemekler.Rows[siraNo]["ad"].ToString();
                nYemekFiyatı.Text = dtYemekler.Rows[siraNo]["fiyat"].ToString();
                txtid.Text = dtYemekler.Rows[siraNo]["id"].ToString();
                cbYemekTuru.Text = dtYemekler.Rows[siraNo]["tur"].ToString();

                string resim = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\Resimler\\";
                if (dtYemekler.Rows[siraNo]["resim"].ToString() == "")
                {
                    resim += "no-image.jpg";
                    pictureBox1.Image = Image.FromFile(resim);
                }
                else
                {
                    resim += dtYemekler.Rows[siraNo]["resim"].ToString();
                    pictureBox1.Image = Image.FromFile(resim);
                }
            }
        }

        private void MenuDüzenle_Load(object sender, EventArgs e)
        {
            dgw1.SelectionChanged -= dataGridView1_SelectionChanged;

            DataGridiDoldur();
            ComboboxDoldur();
            nYemekFiyatı.Maximum = 10000;
            ToolTip btn_aciklama = new ToolTip();
            btn_aciklama.SetToolTip(btnSil, "Menu Sil");
            btn_aciklama.SetToolTip(btnEkle, "Menu Ekle");
            btn_aciklama.SetToolTip(btnGuncelle, "Menu Güncelle");
            btn_aciklama.SetToolTip(btnResimGuncelle, "Resimi Güncelle");
            btn_aciklama.SetToolTip(btnResimSil, "Resimi Sil");

            dgw1.SelectionChanged += dataGridView1_SelectionChanged;

        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            dgw1.SelectionChanged -= dataGridView1_SelectionChanged;
            try
            {
                string sorgu = "INSERT INTO `yemekler` ( `ad`, `tur`, `fiyat`) VALUES ( @ad, @tur, @fiyat)";

                kmt = new MySqlCommand(sorgu, bag.Baglan());

                kmt.Parameters.AddWithValue("@ad", txtYemekAdı.Text.Trim());
                kmt.Parameters.AddWithValue("@tur", cbYemekTuru.Text.Trim());
                kmt.Parameters.AddWithValue("@fiyat", nYemekFiyatı.Text.Trim().ToString());

                kmt.ExecuteNonQuery();
                siraNo = dtYemekler.Rows.Count;
                DataGridiDoldur();

                MessageBox.Show("Kayıt Başarılı", "Kayıt İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception hata)
            {
                MessageBox.Show("HATA : " + hata.Message);
            }
            finally
            {
                kmt.Connection.Close();
                bag.BaglantiyiKapat();
            }
            dgw1.SelectionChanged += dataGridView1_SelectionChanged;
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            


            dgw1.SelectionChanged -= dataGridView1_SelectionChanged;
            try
            {
                string sorgu = "UPDATE `yemekler` SET `ad`=@ad,`tur`=@tur,`fiyat`=@fiyat WHERE `yemekler`.`id`=@id";

                kmt = new MySqlCommand(sorgu, bag.Baglan());

                kmt.Parameters.AddWithValue("@ad", txtYemekAdı.Text.Trim());
                kmt.Parameters.AddWithValue("@tur", cbYemekTuru.Text.Trim());
                kmt.Parameters.AddWithValue("@fiyat", nYemekFiyatı.Text.Trim().ToString());
                kmt.Parameters.AddWithValue("@id", txtid.Text.Trim().ToString());

                kmt.ExecuteNonQuery();
                siraNo = dgw1.CurrentRow.Index;

                DataGridiDoldur();

                MessageBox.Show("Güncelleme Başarılı", "Güncelleme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception hata)
            {
                MessageBox.Show("HATA : " + hata.Message);
            }
            finally
            {
                kmt.Connection.Close();
                bag.BaglantiyiKapat();
            }
            dgw1.SelectionChanged += dataGridView1_SelectionChanged;
        }
        

        private void btnSil_Click(object sender, EventArgs e)
        {
            dgw1.SelectionChanged -= dataGridView1_SelectionChanged;
            try
            {
                string sorgu = "DELETE FROM `yemekler` WHERE `yemekler`.`id` = @id; ";

                kmt = new MySqlCommand(sorgu, bag.Baglan());

                kmt.Parameters.AddWithValue("@id", txtid.Text.Trim().ToString());
                DialogResult cevap = MessageBox.Show("Kayıt Silinecek !", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (cevap == DialogResult.OK)
                {
                    kmt.ExecuteNonQuery();
                    siraNo = 0;
                    DataGridiDoldur();
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("HATA : " + hata.Message);
            }
            finally
            {
                kmt.Connection.Close();
                bag.BaglantiyiKapat();
            }
            dgw1.SelectionChanged += dataGridView1_SelectionChanged;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dgw1.CurrentRow != null)
            {
                siraNo = dgw1.CurrentRow.Index;
                dgw1.Rows[siraNo].Selected = true;
                if (siraNo >= 0)
                {
                    VerileriDoldur();
                }
            }
        }

        private void btnResimGuncelle_Click(object sender, EventArgs e)
        {
            dgw1.SelectionChanged -= dataGridView1_SelectionChanged;

            OpenFileDialog op = new OpenFileDialog();
            string yol = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\Resimler\\";
            op.Title = "Resim Seç"; // filedialog penceresinin başlığında gösterilecek yazı atanır
            op.Filter = "Dosya Türleri|*.jpg;*.jpeg;*.png|" +
                        "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
                        "Portable Network Graphic (*.png)|*.png";

            DialogResult? kontrol = op.ShowDialog();
            if (kontrol != null && kontrol == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(op.FileName);
                if (!Directory.Exists(yol))
                {
                    Directory.CreateDirectory(yol);
                }

                int rSayi = new Random().Next(10000);
                string resimYolu = yol + rSayi + Path.GetFileName(op.FileName);
                File.Copy(op.FileName, resimYolu, true);

                string[] diziResim = resimYolu.Split('\\');
                //MessageBox.Show(diziResim[diziResim.Length - 1].ToString());

                try
                {
                    string sorgu = "UPDATE `yemekler` SET `resim` = @resim WHERE `yemekler`.`id` = @id; ";

                    kmt = new MySqlCommand(sorgu, bag.Baglan());

                    kmt.Parameters.AddWithValue("@id", txtid.Text.Trim().ToString());
                    kmt.Parameters.AddWithValue("@resim", diziResim[diziResim.Length - 1].ToString());

                    kmt.ExecuteNonQuery();

                    DataGridiDoldur();

                    MessageBox.Show("Resim Güncelleme Başarılı", "Resim Güncelleme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception hata)
                {
                    MessageBox.Show("HATA : " + hata.Message);
                }
                finally
                {
                    kmt.Connection.Close();
                    bag.BaglantiyiKapat();
                }
            }
            else
            {
                MessageBox.Show("Resim seçilmedi!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            dgw1.SelectionChanged += dataGridView1_SelectionChanged;
        }

        private void btnResimSil_Click(object sender, EventArgs e)
        {
            dgw1.SelectionChanged -= dataGridView1_SelectionChanged;

            if (dtYemekler.Rows[siraNo]["resim"].ToString().Trim() != "")
            {
                try
                {
                    string sorgu = "UPDATE `yemekler` SET `resim` = @resim WHERE `yemekler`.`id` = @id; ";

                    kmt = new MySqlCommand(sorgu, bag.Baglan());

                    kmt.Parameters.AddWithValue("@id", txtid.Text.Trim().ToString());
                    kmt.Parameters.AddWithValue("@resim", "");

                    kmt.ExecuteNonQuery();

                    string resim = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\Resimler\\" + dtYemekler.Rows[siraNo]["resim"].ToString();
                    if (File.Exists(resim))
                    {
                        string resimNoImage = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\Resimler\\no-image.jpg";
                        pictureBox1.Image = Image.FromFile(resimNoImage);
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                        File.Delete(resim);
                    }


                    MessageBox.Show("Resim Silme Başarılı", "Resim Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception hata)
                {
                    MessageBox.Show("HATA : " + hata.Message);
                }
                finally
                {
                    kmt.Connection.Close();
                    bag.BaglantiyiKapat();
                    DataGridiDoldur();

                }
            }
            else
            {
                MessageBox.Show("Henüz bir resim tanımlanmadı !", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dgw1.SelectionChanged += dataGridView1_SelectionChanged;
        }

       
        private void btnYemekTuruEkle_Click(object sender, EventArgs e)
        {
            YemekTuru form3 = new YemekTuru();
            form3.ShowDialog();
            ComboboxDoldur();
        }
    }
}
