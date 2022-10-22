using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace RestorantFikir2
{
    class DBislemleri
    {
        MySqlConnection baglanti;
        public MySqlConnection Baglan() // class içinde baglan adında fonksiyon oluşturuldu.
        {
            baglanti = new MySqlConnection("Server = localhost; Database = dbrestorant; Uid = root; Pwd = ;");
            // Bağlantı yolu verildi.
            baglanti.Open();// Bağlantı açıldı.
            MySqlConnection.ClearPool(baglanti);// Bundan önceki bağlantılar temizlendi.
            return baglanti;// Çağrıldığı yere bağlantı gönderildi.
        }
        
        public void BaglantiyiKapat()
        {
            baglanti.Close();
        }
    }
}
