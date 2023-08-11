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
    public partial class Giris : Form
    {
        
        public int hak = 3;
        public string kullaniciadi ="";
        public string sifrev = "";
     
        public Giris()
        {
           
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kayıtol frm = new Kayıtol();
            frm.Show();
            this.Hide();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand giriskomutu = new SqlCommand("Select * from KullaniciTablosu where K_adi=@pkadi and K_sifre = @psifre", SqlOperations.Baglanti);
            SqlOperations.Kontrolbaglanti(SqlOperations.Baglanti);
            string hashedPassword = SHA256Donusturucu.ComputeSha256Hash(textBox2.Text);

            giriskomutu.Parameters.AddWithValue("@pkadi", textBox1.Text);
            giriskomutu.Parameters.AddWithValue("@psifre", hashedPassword);

            SqlDataAdapter da = new SqlDataAdapter(giriskomutu);

            DataTable dt = new DataTable();

            da.Fill(dt);

            if (dt.Rows.Count > 0 && textBox3.Text == "205121")
            {
                MessageBox.Show("Personel Girişi Başarılı");
                PersonelAnaTablo frm = new PersonelAnaTablo();
                frm.Show();
                this.Hide();
            }
            else if (dt.Rows.Count > 0 && textBox3.Text != "205121" && checkBox2.Checked == true)
            {
                MessageBox.Show("Personel Kodu Yanlış");
            }
            else if (dt.Rows.Count > 0 && checkBox2.Checked == false)
            {
                MessageBox.Show("Müşteri Girişi Başarılı");
                MusteriAnaTablo frm = new MusteriAnaTablo();
                frm.Show();
                this.Hide();
            }
            else if (textBox1.Text == "" && textBox2.Text == "")
            { MessageBox.Show("Herhangi Bir Bilgi Boş Geçilemez"); }
                
                    
                
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış");
            }

        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                
                textBox2.PasswordChar = '\0';
            }
           
            else
            {
                textBox2.PasswordChar = '*';
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox3.Visible = true;
                label3.Visible = true;
            }
            else
            {
                textBox3.Visible = false;
                label3.Visible = false;
            }
        }
    }
    }

