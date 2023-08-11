using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp3
{
    public partial class UcakEkle : Form
    {
        public UcakEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tboxUcakID.Text == "" || tBoxUcakAd.Text == "" || tBoxHavayoluID.Text == "" || tboxKoltukSayisi.Text == "" || cboxUcakTuru.Text == "")
            {
                MessageBox.Show("Herhangi bir bilgi boş bırakılamaz.");
            }
            else
            {


                SqlCommand eklekomutu = new SqlCommand($"Insert into Ucak (ucak_id,ucak_adi,havayolu_id,koltuk_sayisi,ucak_turu) values (@ucakid,@ucakadi,@havayoluid,@koltuksayısı,@ucakturu)", SqlOperations.Baglanti);
                SqlOperations.Kontrolbaglanti(SqlOperations.Baglanti);




                eklekomutu.Parameters.AddWithValue("@ucakid", tboxUcakID.Text);
                eklekomutu.Parameters.AddWithValue("@ucakadi", tBoxUcakAd.Text);
                eklekomutu.Parameters.AddWithValue("@havayoluid", tBoxHavayoluID.Text);
                eklekomutu.Parameters.AddWithValue("@koltuksayısı", tboxKoltukSayisi.Text);
                eklekomutu.Parameters.AddWithValue("@ucakturu", cboxUcakTuru.Text);
              
                eklekomutu.ExecuteNonQuery();


                MessageBox.Show("Uçak Bilgisi Başarı ile Eklendi");
                SayfaYenileme();
                
            }
        }
        public void SayfaYenileme()
        {

            SqlCommand listelemekomutu = new SqlCommand("select * from Ucak", SqlOperations.Baglanti);
            SqlOperations.Kontrolbaglanti(SqlOperations.Baglanti);

            SqlDataAdapter da = new SqlDataAdapter(listelemekomutu);

            DataTable dt = new DataTable();

            da.Fill(dt);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = dt;

        }
        int secilmisID;
        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand silmekomutu = new SqlCommand($"Delete from Ucak where ucak_id = @ucakid", SqlOperations.Baglanti);
            SqlOperations.Kontrolbaglanti(SqlOperations.Baglanti);

            silmekomutu.Parameters.AddWithValue("@ucakid", secilmisID);
            silmekomutu.ExecuteNonQuery();

            MessageBox.Show(secilmisID + " Numaralı Kayıt Silinmiştir.");
            SayfaYenileme();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Giris frm = new Giris();
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PersonelAnaTablo frm = new PersonelAnaTablo();
            frm.Show();
            this.Hide();
        }

        private void UcakEkle_Load(object sender, EventArgs e)
        {
            SayfaYenileme();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                secilmisID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ucak_id"].Value);
                labelsecim.Text = secilmisID.ToString();
                labelID.Text = "Boş Yere Tıklandı.";
            }
            catch (Exception)
            {

                MessageBox.Show("Boş yere tıkladınız ID numarası boş olamaz. Lütfen tekrar deneyiniz.");
                labelsecim.Text = "Boş Yere Tıklandı.";
                labelID.Text = "Boş Yere Tıklandı.";
            }
            labelID.Text = secilmisID.ToString();
          
            tboxGuncelleUcakAdi.Text = (dataGridView1.CurrentRow.Cells["ucak_adi"].Value).ToString();
            tboxGuncelleHavayoluID.Text = (dataGridView1.CurrentRow.Cells["havayolu_id"].Value).ToString();
            tboxGuncelleKoltukSayisi.Text = (dataGridView1.CurrentRow.Cells["koltuk_sayisi"].Value).ToString();
            tboxGuncelleUcakTuru.Text = (dataGridView1.CurrentRow.Cells["ucak_turu"].Value).ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {

            SqlCommand guncellemekomutu = new SqlCommand("Update Ucak set ucak_adi = @ucakadi, havayolu_id = @havayoluid, koltuk_sayisi = @koltuksayisi, ucak_turu = @ucakturu where ucak_id = @ucakidsi", SqlOperations.Baglanti);
            SqlOperations.Kontrolbaglanti(SqlOperations.Baglanti);

            
            guncellemekomutu.Parameters.AddWithValue("@ucakadi", tboxGuncelleUcakAdi.Text);
            guncellemekomutu.Parameters.AddWithValue("@havayoluid", tboxGuncelleHavayoluID.Text);
            guncellemekomutu.Parameters.AddWithValue("@koltuksayisi", tboxGuncelleKoltukSayisi.Text);
            guncellemekomutu.Parameters.AddWithValue("@ucakturu", tboxGuncelleUcakTuru.Text);
            guncellemekomutu.Parameters.AddWithValue("@ucakidsi", secilmisID);
            guncellemekomutu.ExecuteNonQuery();
            SayfaYenileme();
        }
    }
}
