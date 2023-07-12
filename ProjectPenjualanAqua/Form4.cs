using System;
using System.Windows.Forms;

namespace ProjectPenjualanAqua
{
    public partial class Form4 : Form
    {
        private string stringConnection = "data source=LAPTOP-BVFI5R8I\\MUHAMMADSALMAN;" +
        "database=PenjualanAqua;User ID=sa; Password=S4lm4nrar1";
        private SqlConnection koneksi;
        private string ID_produk, nama_produk, jumlah;
        private DateTime tgl_masuk;
        BindingSource costumersBindingSource = new BindingSource();
        public Form4()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cbxProduk.Text = "";
            cbxJumlah.Text = "";
            cbxMasuk.Text = "";
            cbxProduk.Enabled = true;
            cbxJumlah.Enabled = true;
            cbxMasuk.Enabled = true;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
            btnAdd.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
        }
    }
}
