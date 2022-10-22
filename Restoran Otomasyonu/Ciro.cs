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
    public partial class Ciro : Form
    {
        public Ciro()
        {
            InitializeComponent();
        }
        DBislemleri bag = new DBislemleri();// Bağlantı için oluşturulan class’tan türetilen bir nesne
        DataTable dtCiro = new DataTable();//Tablolara yüklemek için bir adet dtBirinci değişkeni tanımlandı.
        int siraNo = 0;
        private void DataGridiDoldur()
        {
            dataGridView1.RowHeadersVisible = true;//Satır başlıkları görünmez yapılır.
            dataGridView1.Font = new Font("Arial", 10);// Datagridview için font ayarlaması yapılır.
            dtCiro.Columns.Clear();//Tablonun önceki kullanımından kalan sütunlar temizlenir.
            dtCiro.Clear(); // Tablo temizlenir.
            MySqlDataAdapter adtr = new MySqlDataAdapter("select * from satislar", bag.Baglan());//Komut ve bağlantı yüklenen DataAdapter nesnesi
            adtr.Fill(dtCiro);//DataAdapter nesnesine yüklenen bilgiler tabloya aktarılır.
            dataGridView1.DataSource = dtCiro; //Datagridview bileşeni data kaynağı olarak dtBirinci seçilir.

            dataGridView1.Columns.Remove("id");
            dataGridView1.Columns["menuAdı=Fiyati"].HeaderText = "Menü Adı ve Fiyatı";
            dataGridView1.Columns["menuAdı=Fiyati"].Width = 365;
            dataGridView1.Columns["tarih"].HeaderText = "Tarih";
            dataGridView1.Columns["tarih"].Width = 375;

            try
            {
                dataGridView1.Rows[siraNo].Selected = true;
            }
            catch (Exception)
            {
                MessageBox.Show("       Tablo Boş","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            bag.BaglantiyiKapat();
        }
        private void Ciro_Load(object sender, EventArgs e)
        {
            DataGridiDoldur();
        }
    }
}
