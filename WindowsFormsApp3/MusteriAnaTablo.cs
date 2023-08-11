using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class MusteriAnaTablo : Form
    {
        public MusteriAnaTablo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BiletSatınAl form5 = new BiletSatınAl();
            form5.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UcusSaatleri frm = new UcusSaatleri();
            this.Hide();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UcakBilgi frm = new UcakBilgi();
            this.Hide();
            frm.Show();
        }
    }
}
