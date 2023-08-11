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
    public partial class UcusEkleme : Form
    {
        public UcusEkleme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tboxUcusID.Text == "" || tboxUcakID.Text == "" || tboxHavaalaniID.Text == "" || tboxHavaalaniAdi.Text == "" || tboxVKonum.Text == "" || tboxHKonum.Text == "" || tboxHavaOnayiID.Text == "")
            {
                MessageBox.Show("Herhangi bir bilgi boş bırakılamaz.");
            }
            else
            {


                SqlCommand eklekomutu = new SqlCommand($"Insert into Ucus (ucus_id,ucak_id,havaalani_id,havaalani_ad,bulunan_konum,hedef_konum,havaonay_id) values (@ucusid,@ucakid,@havaalaniid,@havaalaniad,@vkonum,@hkonum,@havaonayid)", SqlOperations.Baglanti);
                SqlOperations.Kontrolbaglanti(SqlOperations.Baglanti);




                eklekomutu.Parameters.AddWithValue("@ucusid", tboxUcusID.Text);
                eklekomutu.Parameters.AddWithValue("@ucakid", tboxUcakID.Text);
                eklekomutu.Parameters.AddWithValue("@havaalaniid", tboxHavaalaniID.Text);
                eklekomutu.Parameters.AddWithValue("@havaalaniad", tboxHavaalaniAdi.Text);
                eklekomutu.Parameters.AddWithValue("@vkonum", tboxVKonum.Text);
                eklekomutu.Parameters.AddWithValue("@hkonum", tboxHKonum.Text);
                eklekomutu.Parameters.AddWithValue("@havaonayid", tboxHavaOnayiID.Text);
                eklekomutu.ExecuteNonQuery();


                MessageBox.Show("Ucuş Bilgisi Başarı ile Eklendi");
                SayfaYenileme();
                
            }
        }
        public void SayfaYenileme()
        {

            SqlCommand listelemekomutu = new SqlCommand("select * from Ucus", SqlOperations.Baglanti);
            SqlOperations.Kontrolbaglanti(SqlOperations.Baglanti);

            SqlDataAdapter da = new SqlDataAdapter(listelemekomutu);

            DataTable dt = new DataTable();

            da.Fill(dt);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = dt;

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
        int secilmisID;
        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand silmekomutu = new SqlCommand($"Delete from Ucus where ucus_id = @ucusid", SqlOperations.Baglanti);
            SqlOperations.Kontrolbaglanti(SqlOperations.Baglanti);

            silmekomutu.Parameters.AddWithValue("@ucusid", secilmisID);
            silmekomutu.ExecuteNonQuery();

            MessageBox.Show(secilmisID + " Numaralı Kayıt Silinmiştir.");
            SayfaYenileme();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            PersonelAnaTablo frm = new PersonelAnaTablo();
            frm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Giris frm = new Giris();
            frm.Show();
            this.Hide();
        }

        private void UcusEkleme_Load(object sender, EventArgs e)
        {
            SayfaYenileme();
        }     

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
            secilmisID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ucus_id"].Value);
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
            
            tboxGuncelleUcakID.Text = (dataGridView1.CurrentRow.Cells["ucak_id"].Value).ToString();
            tboxGuncelleHavaalaniID.Text = (dataGridView1.CurrentRow.Cells["havaalani_id"].Value).ToString();
            tboxGuncelleHavaalaniAdı.Text = (dataGridView1.CurrentRow.Cells["havaalani_ad"].Value).ToString();
            tboxGuncelleKonum.Text = (dataGridView1.CurrentRow.Cells["bulunan_konum"].Value).ToString();
            tboxGuncelleVKonum.Text = (dataGridView1.CurrentRow.Cells["hedef_konum"].Value).ToString();
            tboxGuncelleHavaOnayID.Text = (dataGridView1.CurrentRow.Cells["havaonay_id"].Value).ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlCommand guncellemekomutu = new SqlCommand("Update Ucus set ucak_id = @ucakid, havaalani_id = @havaalaniid, havaalani_ad = @havaalaniadi," +
               "bulunan_konum = @bulunankonum, hedef_konum = @hkonum, havaonay_id = @havaonayid where ucus_id = @ucusidsi ", SqlOperations.Baglanti);
            SqlOperations.Kontrolbaglanti(SqlOperations.Baglanti);

            
            guncellemekomutu.Parameters.AddWithValue("@ucakid", tboxGuncelleUcakID.Text);
            guncellemekomutu.Parameters.AddWithValue("@havaalaniid", tboxGuncelleHavaalaniID.Text);
            guncellemekomutu.Parameters.AddWithValue("@havaalaniadi", tboxGuncelleHavaalaniAdı.Text);
            guncellemekomutu.Parameters.AddWithValue("@bulunankonum", tboxGuncelleKonum.Text);
            guncellemekomutu.Parameters.AddWithValue("@hkonum", tboxGuncelleVKonum.Text);
            guncellemekomutu.Parameters.AddWithValue("@havaonayid", tboxGuncelleHavaOnayID.Text);
            guncellemekomutu.Parameters.AddWithValue("@ucusidsi", secilmisID);
            guncellemekomutu.ExecuteNonQuery();
            SayfaYenileme();
        }
    }
}
