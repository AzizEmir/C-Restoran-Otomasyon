using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RestorantFikir2
{
    public partial class YemekTuru : Form
    {
        public YemekTuru()
        {
            InitializeComponent();
        }
        DBislemleri bag = new DBislemleri();
        DataTable dTur = new DataTable();
        MySqlCommand kmt = new MySqlCommand();
        int siraNo = 0;

        private void YemekTuru_Load(object sender, EventArgs e)
        {
            DataGridiDoldur();
            ToolTip btn_aciklama = new ToolTip();
            btn_aciklama.SetToolTip(btnSil, "Menu Sil");
            btn_aciklama.SetToolTip(btnEkle, "Menu Ekle");
            btn_aciklama.SetToolTip(btnGuncelle, "Menu Güncelle");
        }
        private void DataGridiDoldur()
        {
            dataGridView1.SelectionChanged -= dataGridView1_SelectionChanged;

            dataGridView1.RowHeadersVisible = true;
            dataGridView1.Font = new Font("Arial", 10);
            dTur.Columns.Clear();
            dTur.Clear();
            MySqlDataAdapter adtr = new MySqlDataAdapter("select * from yemekturu", bag.Baglan());
            adtr.Fill(dTur);
            dataGridView1.DataSource = dTur;

            dataGridView1.Columns["id"].HeaderText = "ID";
            dataGridView1.Columns["id"].Width = 80;
            dataGridView1.Columns["Tur"].HeaderText = "TÜR";
            dataGridView1.Columns["tur"].Width = 165;

            try
            {
                dataGridView1.Rows[siraNo].Selected = true;
            }
            catch (Exception)
            {

                MessageBox.Show("Yemek Türü Tablosu Boş","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            VerileriDoldur();

            bag.BaglantiyiKapat();

            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;

        }
        private void VerileriDoldur()
        {
            if (siraNo >= 0 && siraNo < dTur.Rows.Count)
            {
                txtID.Text = dTur.Rows[siraNo]["id"].ToString();
                txtYemekTuru.Text = dTur.Rows[siraNo]["Tur"].ToString();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                siraNo = dataGridView1.CurrentRow.Index;
                dataGridView1.Rows[siraNo].Selected = true;
                if (siraNo >= 0)
                {
                    VerileriDoldur();
                }
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            dataGridView1.SelectionChanged -= dataGridView1_SelectionChanged;
            try
            {
                string sorgu = "INSERT INTO `yemekturu` ( `Tur` ) VALUES ( @Tur ); ";

                kmt = new MySqlCommand(sorgu, bag.Baglan());

                kmt.Parameters.AddWithValue("@Tur", txtYemekTuru.Text.Trim());

                kmt.ExecuteNonQuery();
                siraNo = dTur.Rows.Count;
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
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            dataGridView1.SelectionChanged -= dataGridView1_SelectionChanged;
            try
            {
                string sorgu = "UPDATE `yemekturu` SET `Tur` = @Tur WHERE `id` = @id; ";

                kmt = new MySqlCommand(sorgu, bag.Baglan());

                kmt.Parameters.AddWithValue("@Tur", txtYemekTuru.Text.Trim());
                kmt.Parameters.AddWithValue("@id", txtID.Text.Trim().ToString());

                kmt.ExecuteNonQuery();
                siraNo = dataGridView1.CurrentRow.Index;
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
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            dataGridView1.SelectionChanged -= dataGridView1_SelectionChanged;
            try
            {
                string sorgu = "DELETE FROM `yemekturu` WHERE `id` = @id; ";

                kmt = new MySqlCommand(sorgu, bag.Baglan());

                kmt.Parameters.AddWithValue("@id", txtID.Text.Trim().ToString());

                kmt.ExecuteNonQuery();
                siraNo = 0;
                DataGridiDoldur();

                MessageBox.Show("Silme Başarılı", "Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }
    }
}
