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
    public partial class PersonelEkle : Form
    {
        public PersonelEkle()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tboxPersonelAdi.Text == "" || tboxPersonelSoyadı.Text == "" || cboxcinsiyet.Text == "" || tboxSehir.Text == "" || tboxTelno.Text == "" || tboxMaas.Text == "")
            {
                MessageBox.Show("Herhangi bir bilgi boş bırakılamaz.");
            }
            else
            {


                SqlCommand eklekomutu = new SqlCommand($"Insert into Personel (personel_ad,personel_soyad,personel_gorev,cinsiyet,sehir,telefon_no,maas) values (@personeladi,@personelsoyadi,@personelgorev,@cinsiyet,@sehir,@telno,@maas)", SqlOperations.Baglanti);
                SqlOperations.Kontrolbaglanti(SqlOperations.Baglanti);




                eklekomutu.Parameters.AddWithValue("@personeladi", tboxPersonelAdi.Text);
                eklekomutu.Parameters.AddWithValue("@personelsoyadi", tboxPersonelSoyadı.Text);
                eklekomutu.Parameters.AddWithValue("@personelgorev", tboxPersonelGorevi.Text);
                eklekomutu.Parameters.AddWithValue("@cinsiyet", cboxcinsiyet.Text);
                eklekomutu.Parameters.AddWithValue("@sehir", tboxSehir.Text);
                eklekomutu.Parameters.AddWithValue("@telno", tboxTelno.Text);
                eklekomutu.Parameters.AddWithValue("@maas", tboxMaas.Text);
                eklekomutu.ExecuteNonQuery();


                MessageBox.Show("Personel Başarı ile Eklendi");
                SayfaYenileme();

            }
        }
        public void SayfaYenileme()
        {

            SqlCommand listelemekomutu = new SqlCommand("select * from Personel", SqlOperations.Baglanti);
            SqlOperations.Kontrolbaglanti(SqlOperations.Baglanti);

            SqlDataAdapter da = new SqlDataAdapter(listelemekomutu);

            DataTable dt = new DataTable();

            da.Fill(dt);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = dt;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UcusEkleme frm = new UcusEkleme();
            this.Hide();
            frm.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        int secilmisID; // burda publicte atama yapıyoruz sonra bunu dataviewgried 'da selectionchange icin kullanacağız.
        private void button2_Click_1(object sender, EventArgs e)
        {
    
                SqlCommand silmekomutu = new SqlCommand($"Delete from Personel where personel_id = @personelid", SqlOperations.Baglanti);
                SqlOperations.Kontrolbaglanti(SqlOperations.Baglanti);

                silmekomutu.Parameters.AddWithValue("@personelid", secilmisID);
                silmekomutu.ExecuteNonQuery();

                MessageBox.Show(secilmisID+" Numaralı Kayıt Silinmiştir.");
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

        private void PersonelEkle_Load(object sender, EventArgs e)
        {
            SayfaYenileme();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //TRY CATCH BOŞ BİR YERE TIKLANDIĞINDA NULL HATASI ALINMAMASI İÇİN KULLANILMIŞTIR.

            try
            {
                secilmisID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["personel_id"].Value);
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
            tboxGuncelleAd.Text = (dataGridView1.CurrentRow.Cells["personel_ad"].Value).ToString();
            tboxGuncelleSoyad.Text = (dataGridView1.CurrentRow.Cells["personel_soyad"].Value).ToString();
            tboxGuncelleGorev.Text = (dataGridView1.CurrentRow.Cells["personel_gorev"].Value).ToString();
            tboxGuncelleCinsiyet.Text = (dataGridView1.CurrentRow.Cells["cinsiyet"].Value).ToString();
            tboxGuncelleSehir.Text = (dataGridView1.CurrentRow.Cells["sehir"].Value).ToString();
            tboxGuncelleTelno.Text = (dataGridView1.CurrentRow.Cells["telefon_no"].Value).ToString();
            tboxGuncelleMaas.Text = (dataGridView1.CurrentRow.Cells["maas"].Value).ToString();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlCommand guncellemekomutu = new SqlCommand("Update Personel set personel_ad = @personeladi ," +
                "personel_soyad = @personelsoyadi, personel_gorev = @personelgorev, cinsiyet = @cinsiyet," +
                "sehir = @sehir, telefon_no = @telno, maas = @maas where personel_id = @personelid ",SqlOperations.Baglanti);
            SqlOperations.Kontrolbaglanti(SqlOperations.Baglanti);

            guncellemekomutu.Parameters.AddWithValue("@personeladi", tboxGuncelleAd.Text);
            guncellemekomutu.Parameters.AddWithValue("@personelsoyadi", tboxGuncelleSoyad.Text);
            guncellemekomutu.Parameters.AddWithValue("@personelgorev", tboxGuncelleGorev.Text);
            guncellemekomutu.Parameters.AddWithValue("@cinsiyet", tboxGuncelleCinsiyet.Text);
            guncellemekomutu.Parameters.AddWithValue("@sehir", tboxGuncelleSehir.Text);
            guncellemekomutu.Parameters.AddWithValue("@telno", tboxGuncelleTelno.Text);
            guncellemekomutu.Parameters.AddWithValue("@maas", tboxGuncelleMaas.Text);
            guncellemekomutu.Parameters.AddWithValue("@personelid", secilmisID);
            guncellemekomutu.ExecuteNonQuery();
            SayfaYenileme();

        }
    }
}
