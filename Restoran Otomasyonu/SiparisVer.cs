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
using System.Collections;

namespace RestorantFikir2
{
    public partial class SiparisFormu : Form
    {
        public SiparisFormu()
        {
            InitializeComponent();
        }
        //Global Değişkenler
        DBislemleri bag = new DBislemleri();// Bağlantı için oluşturulan class’tan türetilen bir nesne
        DataTable dtYemekler = new DataTable();//Tablolara yüklemek için bir adet dtBirinci değişkeni tanımlandı.
        DataTable dtMenu = new DataTable();//Tablolara yüklemek için bir adet dtBirinci değişkeni tanımlandı.
        int siraNo = 0;
        ArrayList yemekler = new ArrayList();
        ArrayList fiyatlar = new ArrayList();
        MySqlCommand kmt = new MySqlCommand();//İşlemler için bir MySqlCommand nesnesi tanımlandı.

        private void SiparisFormu_Load(object sender, EventArgs e)
        {
            dgw1.SelectionChanged -= dataGridView1_SelectionChanged;
            dtpTarih.Value = DateTime.Now;
            dtpTarih.Enabled = false;
            txtFiyat.Enabled = false;
            txtYemek.Enabled = false;
            DataGridiDoldur();
            ToolTip btn_aciklama = new ToolTip();
            btn_aciklama.SetToolTip(btnSil, "Menu Sil");
            btn_aciklama.SetToolTip(btnMenuEkle, "Menu Ekle");
            dgw1.Columns.Remove("resim");
            dgw1.SelectionChanged += dataGridView1_SelectionChanged;

        }
        private void DataGridiDoldur()
        {
            dgw1.RowHeadersVisible = true;//Satır başlıkları görünmez yapılır.
            dgw1.Font = new Font("Arial", 10);// Datagridview için font ayarlaması yapılır.
            //dtBirinci.Columns.Clear();//Tablonun önceki kullanımından kalan sütunlar temizlenir.
            dtYemekler.Clear(); // Tablo temizlenir.
            MySqlDataAdapter adtr = new MySqlDataAdapter("select * from yemekler", bag.Baglan());//Komut ve bağlantı yüklenen DataAdapter nesnesi
            adtr.Fill(dtYemekler);//DataAdapter nesnesine yüklenen bilgiler tabloya aktarılır.
            dgw1.DataSource = dtYemekler; //Datagridview bileşeni data kaynağı olarak dtBirinci seçilir.
            dgw1.Columns["id"].HeaderText = "ID";
            dgw1.Columns["ad"].HeaderText = "AD";
            dgw1.Columns["ad"].Width = 350;
            dgw1.Columns["fiyat"].HeaderText = "FİYAT";
            dgw1.Columns["fiyat"].Width = 305;
            dgw1.Columns["tur"].HeaderText = "TÜR";
            dgw1.Columns["tur"].Width = 350;
            adtr.Dispose();
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
        private void VerileriDoldur()
        {
            if (siraNo >= 0 && siraNo < dtYemekler.Rows.Count)
            {
                txtYemek.Text = dtYemekler.Rows[siraNo]["ad"].ToString();
                txtFiyat.Text = dtYemekler.Rows[siraNo]["fiyat"].ToString();
                dtMenu.Columns.Clear();//Tablonun önceki kullanımından kalan sütunlar temizlenir.
                dtMenu.Clear(); // Tablo temizlenir.
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
                MySqlDataAdapter adtr = new MySqlDataAdapter("select * from yemekler", bag.Baglan());//Komut ve bağlantı yüklenen DataAdapter nesnesi
                adtr.Fill(dtMenu);
                bag.BaglantiyiKapat();
            }
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
        private void btnMenuDuzenle_Click(object sender, EventArgs e)
        {
            MenuDüzenle menudüzenle = new MenuDüzenle();
            menudüzenle.ShowDialog();
            DataGridiDoldur();
        }
        decimal hesap = 0;
        int index = 0;
        private void btnMenuEkle_Click(object sender, EventArgs e)
        {
            yemekler.Add(txtYemek.Text);
            fiyatlar.Add(txtFiyat.Text);
            Menulistele();
            index = fiyatlar.Count;
            hesap += Convert.ToDecimal(fiyatlar[index - 1]);
            lblHesap.Text = hesap.ToString();
        }
        private void Menulistele()
        {
            lbxMenu.Items.Clear();
            for (int i = 0; i < yemekler.Count; i++)
            {
                lbxMenu.Items.Add(yemekler[i] + "=" + fiyatlar[i]);
            }
            lblSiparisSayisi.Text = lbxMenu.Items.Count.ToString();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            int index = lbxMenu.SelectedIndex;
            if (index < 0)
            {
                MessageBox.Show("Silinecek Menü'yü Seçiniz", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                hesap -= Convert.ToDecimal(fiyatlar[index]);
                yemekler.RemoveAt(index);
                fiyatlar.RemoveAt(index);
                Menulistele();
                lblHesap.Text = hesap.ToString();
            }
        }

        private void btnHesabıTamamla_Click(object sender, EventArgs e)
        {
            dgw1.SelectionChanged -= dataGridView1_SelectionChanged;
            try
            {
                if (lbxMenu.Items.Count != 0)
                {
                    string sql = "INSERT INTO `satislar`(`menuAdı=Fiyati`, `tarih`) VALUES (@menuAdıFiyati,@tarih)";
                    kmt = new MySqlCommand(sql, bag.Baglan());

                    foreach (var kategori in lbxMenu.Items)
                    {
                        kmt = new MySqlCommand(sql, bag.Baglan());
                        kmt.Parameters.AddWithValue("@menuAdıFiyati", kategori.ToString());
                        kmt.Parameters.AddWithValue("@tarih", dtpTarih.Value.ToString("yy-MM-dd"));
                        kmt.ExecuteNonQuery();
                        //siraNo = dtBirinci.Rows.Count;
                        DataGridiDoldur();
                    }
                    DialogResult seçenek = MessageBox.Show("Hesabı Tamamlamak İstiyor musunuz ?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (seçenek == DialogResult.Yes)
                    {
                        MessageBox.Show("Hesap : " + hesap.ToString() + " TL", "Hesap Tutarı");
                        //Görüntüyü Sıfırlamak için
                        lbxMenu.Items.Clear();
                        lblSiparisSayisi.Text = "";
                        lblHesap.Text = "";
                        //Kodda üstüne eklenmemesi için
                        yemekler.Clear();
                        fiyatlar.Clear();
                        hesap = 0;
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Kayıt Edilmiş Menu Yok", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("HATA : " + hata.Message);
            }
            finally
            {
                bag.BaglantiyiKapat();
            }
            dgw1.SelectionChanged += dataGridView1_SelectionChanged;
        }

        private void btnCiroGoruntule_Click(object sender, EventArgs e)
        {
            Ciro form3 = new Ciro();
            form3.ShowDialog();
        }

        private void dgw1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            siraNo = dgw1.CurrentRow.Index;
            dgw1.Rows[siraNo].Selected = true;
            VerileriDoldur();
        }
    }
}
