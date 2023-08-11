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
    public partial class BiletSatınAl : Form
    {
        public BiletSatınAl()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MusteriAnaTablo frm = new MusteriAnaTablo();
            frm.Show();
            this.Hide(); 
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand eklekomutu = new SqlCommand($"Insert into BiletSat (yolcu_ad,yolcu_soyad,cinsiyet,yas,bulunankonum,hedefkonum,tarih,ucret) values (@yolcuad,@yolcusoyad,@cinsiyet,@yas,@bulunankonum,@hedefkonum,@tarih,@ucret)", SqlOperations.Baglanti);
            SqlOperations.Kontrolbaglanti(SqlOperations.Baglanti);




            eklekomutu.Parameters.AddWithValue("@yolcuad", tboxİsim.Text);
            eklekomutu.Parameters.AddWithValue("@yolcusoyad", tBoxSoyisim.Text);
            eklekomutu.Parameters.AddWithValue("@cinsiyet", comboBox1.Text);
            eklekomutu.Parameters.AddWithValue("@yas", tboxYas.Text);
            eklekomutu.Parameters.AddWithValue("@bulunankonum", tboxKonum.Text);
            eklekomutu.Parameters.AddWithValue("@hedefkonum", tboxVaris.Text);
            eklekomutu.Parameters.AddWithValue("@tarih", datetimepickertarih.Value); 
            eklekomutu.Parameters.AddWithValue("@ucret", Convert.ToInt32(label8.Text));
            
            eklekomutu.ExecuteNonQuery();


            MessageBox.Show("Bilet Bilgisi Başarı ile Eklendi");
            SayfaYenileme();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int yas = Convert.ToInt32(tboxYas.Text);

            if (tboxYas.Text == "" || tboxKonum.Text == "" || tboxVaris.Text == "" || tboxİsim.Text == "" || tBoxSoyisim.Text == "" ||comboBox1.Text == "" )
            {
                MessageBox.Show("Herhangi Bir Bilgi Boş Bırakılamaz");
            }
            
           else if (yas <= 0)
            {
                MessageBox.Show("Yaşınız 0 dan büyük olmalıdır.");
            }
            else if (yas <= 6)
            {
               MessageBox.Show("Yaşınız 6 Yaşından Küçük Olduğu İçin Biletiniz Ücretsizdir.");
                label8.Text = "0";
            }
            else if (yas <= 18)
            {
                MessageBox.Show("Yaşınız 18 Yaşından Küçük Olduğu İçin Biletinizin Fiyatı 500 TL");
                label8.Text = "500";
            }
            else if (yas>18 && yas < 120)
            {
                MessageBox.Show("Yaşınız 18 Yaşından Büyük Olduğu İçin Biletinizin Fiyatı 1500 TL");
                label8.Text = "1500";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Giris frm = new Giris();
            this.Hide();
            frm.Show();
        }

        private void BiletSatınAl_Load(object sender, EventArgs e)
        {
            SayfaYenileme();
        }
        public void SayfaYenileme()
        {

            SqlCommand listelemekomutu = new SqlCommand("select * from BiletSat", SqlOperations.Baglanti);
            SqlOperations.Kontrolbaglanti(SqlOperations.Baglanti);

            SqlDataAdapter da = new SqlDataAdapter(listelemekomutu);

            DataTable dt = new DataTable();

            da.Fill(dt);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = dt;

        }
    }
}
