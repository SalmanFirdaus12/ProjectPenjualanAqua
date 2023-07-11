using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjectPenjualanAqua
{
    public partial class Form3 : Form
    {
        private string stringConnection = "data source=LAPTOP-BVFI5R8I\\MUHAMMADSALMAN;" +
        "database=PenjualanAqua;User ID=sa; Password=S4lm4nrar1";
        private SqlConnection koneksi;
        private string ID_transaksi, metode_pembayaran,  total_harga;
        private DateTime tgl_transaksi;
        BindingSource costumersBindingSource = new BindingSource();
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtTransaksi.Text = "";
            txtHarga.Text = "";
            dtTransaksi.Value = DateTime.Today;
            txtTransaksi.Enabled = true;
            cbxPembayaran.Enabled = true;
            dtTransaksi.Enabled = true;
            txtHarga.Enabled = true;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
            btnAdd.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ID_transaksi = txtTransaksi.Text;
            metode_pembayaran = cbxPembayaran.Text;
            tgl_transaksi = dtTransaksi.Value;
            total_harga = txtHarga.Text;
            int hs = 0;
            koneksi.Open();
            string strs = "select ID_transaksi from dbo.Transaksi where ID_pelanggan = @dd";
            SqlCommand cm = new SqlCommand(strs, koneksi);
            cm.CommandType = CommandType.Text;
            cm.Parameters.Add(new SqlParameter("@dd", ID_transaksi));
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                hs = int.Parse(dr["ID_transaksi"].ToString());

            }
            dr.Close();
            string str = "insert into dbo.Transaksi (ID_transaksi,ID_pelanggan, tgl_transaksi, total_harga, metode_pembayaran)" +
                          "values(@nim, @nm, @jk, @al, @tgll, @idp) ";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("nim", ID_transaksi));
            cmd.Parameters.Add(new SqlParameter("nm", metode_pembayaran));
            cmd.Parameters.Add(new SqlParameter("jk", total_harga));
            cmd.Parameters.Add(new SqlParameter("tgll", tgl_transaksi));
            cmd.Parameters.Add(new SqlParameter("idp", hs));
            cmd.ExecuteNonQuery();

            koneksi.Close();

            MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

            refreshform();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshform();
        }
        private void clearBinding()
        {
            this.txtTransaksi.DataBindings.Clear();
            this.cbxPembayaran.DataBindings.Clear();
            this.dtTransaksi.DataBindings.Clear();
            this.txtHarga.DataBindings.Clear();

        }

        private void FormDataMahasiswa()
        {
            koneksi.Open();
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(new SqlCommand("Select m.nim, m.nama_mahasiswa, m.alamat, m.jenis_kelamin, m.tgl_lahir, p.nama_prodi\r\nFrom dbo.mahasiswa m \r\njoin dbo.prodi p \r\non m.id_prodi = p.id_prodi", koneksi));
            DataSet ds = new DataSet();
            dataAdapter1.Fill(ds);

            this.costumersBindingSource.DataSource = ds.Tables[0];
            this.txtTransaksi.DataBindings.Add(
                new Binding("Text", this.costumersBindingSource, "nim", true));
            this.cbxPembayaran.DataBindings.Add(new Binding("Text", this.costumersBindingSource, "jenis_kelamin", true));
            this.dtTransaksi.DataBindings.Add(new Binding("Text", this.costumersBindingSource, "tgl_lahir", true));
            this.txtHarga.DataBindings.Add(new Binding("Text", this.costumersBindingSource, "nama_prodi", true));
            koneksi.Close();
        }
        private void refreshform()
        {

            txtTransaksi.Enabled = false;
            cbxPembayaran.Enabled = false;
            txtHarga.Enabled = false;
            dtTransaksi.Enabled = false;
            btnAdd.Enabled = true;
            btnClear.Enabled = false;
            btnSave.Enabled = false;
            clearBinding();
            FormDataMahasiswa();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load_1(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        public Form3()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
