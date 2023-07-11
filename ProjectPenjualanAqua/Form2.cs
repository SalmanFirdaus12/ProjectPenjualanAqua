using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjectPenjualanAqua
{
    public partial class Form2 : Form
    {
        private string stringConnection = "data source=LAPTOP-BVFI5R8I\\MUHAMMADSALMAN;" +
        "database=PenjualanAqua;User ID=sa; Password=S4lm4nrar1";
        private SqlConnection koneksi;
        private void refreshform()
        {
            
            nmp.Text = "";
            idp.Text = "";
            nmp.Enabled = false;
            btnSave.Enabled = false;
            btnClear.Enabled = false;

        }
        public Form2()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }
      
      
        
       
        private void dataGridView()
        {
            koneksi.Open();
            string str = "select * from dbo.Pelanggan";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DGview.DataSource = ds.Tables[0];
            koneksi.Close();
        }

       
       
        private void Form2_Load(object sender, EventArgs e)
        {
            Form1 hu = new Form1();
            hu.Show();
            this.Hide();
        }

        private void menuUtamaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form1 fo = new Form1();
            fo.Show();
            this.Hide();
        }

        private void penjualanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 fo = new Form3();
            fo.Show();
            this.Hide();
        }

        private void gudangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 fo = new Form4();
            fo.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            nmp.Enabled = true;
            idp.Enabled = true; 
            btnSave.Enabled = true;
            btnClear.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string nmPelanggan = nmp.Text;
            string idPelanggan = idp.Text;

            if (nmPelanggan == "")
            {
                MessageBox.Show("Masukkan Nama Pelanggan", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                string str = "insert into dbo.Pelanggan (ID_pelanggan,nama_pelanggan)" + "values(@idp,@namap)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("idp", idPelanggan));
                cmd.Parameters.Add(new SqlParameter("namap", nmPelanggan));
                cmd.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView();
                refreshform();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            dataGridView();
            btnOpen.Enabled = false;
        }
    }
}
