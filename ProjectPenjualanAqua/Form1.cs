using System;
using System.Windows.Forms;

namespace ProjectPenjualanAqua
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDataPegawai_Click(object sender, EventArgs e)
        {
            Form2 fo = new Form2();
            fo.Show();
            this.Hide();

        }

        private void btnPenjualan_Click(object sender, EventArgs e)
        {
            Form3 fo = new Form3();
            fo.Show();
            this.Hide();
        }

        private void btnGudang_Click(object sender, EventArgs e)
        {
            Form4 fo = new Form4();
            fo.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

