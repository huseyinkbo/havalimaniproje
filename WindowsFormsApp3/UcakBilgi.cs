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
    public partial class UcakBilgi : Form
    {
        public UcakBilgi()
        {
            InitializeComponent();
        }

        private void UcakBilgi_Load(object sender, EventArgs e)
        {
            SqlCommand ucakbilgilistesi = new SqlCommand("select * from Ucak",SqlOperations.Baglanti);
            SqlOperations.Kontrolbaglanti(SqlOperations.Baglanti);

            SqlDataAdapter da = new SqlDataAdapter(ucakbilgilistesi);

            DataTable dt = new DataTable();
            
            da.Fill(dt);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MusteriAnaTablo frm = new MusteriAnaTablo();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Giris frm = new Giris();
            frm.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
