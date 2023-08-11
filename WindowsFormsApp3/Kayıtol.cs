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
    public partial class Kayıtol : Form
    {
        public Kayıtol()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Giris frm = new Giris();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Herhangi bir bilgi boş geçilemez", "Uyarı");
            }
            else if (textBox4.Text.Length<6)
            {
                MessageBox.Show("Şifreniz 6 karakterden küçük olamaz." ,"Uyarı");
            }
            
            
            else { 


            SqlCommand kayitolkomutu = new SqlCommand($"Insert into KullaniciTablosu (K_adi,K_sifre,K_isim,K_soyisim) values (@kullaniciadi,@sifre,@K_isim,@K_soyisim)", SqlOperations.Baglanti);
            SqlOperations.Kontrolbaglanti(SqlOperations.Baglanti);

                string hashedPassword = SHA256Donusturucu.ComputeSha256Hash(textBox4.Text);

                kayitolkomutu.Parameters.AddWithValue("@kullaniciadi", textBox3.Text);
                kayitolkomutu.Parameters.AddWithValue("@sifre", hashedPassword);
                kayitolkomutu.Parameters.AddWithValue("@K_isim", textBox1.Text);
                kayitolkomutu.Parameters.AddWithValue("@K_soyisim", textBox2.Text);

                kayitolkomutu.ExecuteNonQuery();

            MessageBox.Show("Başarıyla kayıt olundu kullanici adiniz = " + textBox3.Text + " Şifreniz = " + textBox4.Text + " Adınız = " + textBox1.Text + " Soyadınız = " + textBox2.Text, "Kayıt Olundu");
            Giris frm = new Giris();
            frm.Show();
            this.Hide();
        }









        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {

                textBox4.PasswordChar = '\0';
            }

            else
            {
                textBox4.PasswordChar = '*';
            }
        }
    }
    }
