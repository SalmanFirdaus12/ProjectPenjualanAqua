using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
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
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }
        private void refreshform()
        {
            cbxProduk.Enabled = false;
            cbxJumlah.Enabled = false;
            cbxMasuk.Enabled = false;
            cbxProduk.SelectedIndex = -1;
            cbxJumlah.SelectedIndex = -1;
            cbxMasuk.SelectedIndex = -1;
            txtID.Visible = false;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
            btnAdd.Enabled = true;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView()
        {
            koneksi.Open();
            string str = "select * from dbo.gudang";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            dataGridView();
            btnOpen.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string produk = txtID.Text;
            string jumlah = cbxJumlah.Text;
            string tglmasuk = cbxMasuk.Text;
            int count = 0;
            string tempKodeStatus = "";
            string kodeStatus = "";
            koneksi.Open();

            string str = "select count (*) from dbo.Gudang";
            SqlCommand cm = new SqlCommand(str, koneksi);
            count = (int)cm.ExecuteScalar();

            if (count == 0)
            {
                kodeStatus = "1";
            }
            else
            {
                string querryString = "select Max(id_status) from dbo.Gudang";
                SqlCommand cmStatusMahasiswaSum = new SqlCommand(str, koneksi);
                int totalStatusMahasiswa = (int)cmStatusMahasiswaSum.ExecuteScalar();
                int finalKodeStatus = totalStatusMahasiswa + 1;
                kodeStatus = Convert.ToString(finalKodeStatus);

            }

            string queryString = "insert into dbo.Gudang (id_produk,nama_produk, " +
                "jumlah, tgl_masuk)" + "values(@idp, @nmp, @jm, @tm)";
            SqlCommand cmd = new SqlCommand(queryString, koneksi);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("idp", kodeStatus));
            cmd.Parameters.Add(new SqlParameter("nm", nama_produk));
            cmd.Parameters.Add(new SqlParameter("jm", jumlah));
            cmd.Parameters.Add(new SqlParameter("tm", tgl_masuk));
            cmd.ExecuteNonQuery();
            koneksi.Close();

            MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            refreshform();
            dataGridView();
        }

        private void cbProduk()
        {
            koneksi.Open();
            string str = "select nama_mahasiswa from dbo.mahasiswa where\r\nnot EXISTS(select id_status from dbo.status_mahasiswa where\r\nstatus_mahasiswa.nim = mahasiswa.nim)";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteReader();
            koneksi.Close();

            cbxProduk.DisplayMember = "nama_produk";
            cbxProduk.ValueMember = "iD";
            cbxProduk.DataSource = ds.Tables[0];
        }

        private void cbxProduk_SelectedIndexChanged(object sender, EventArgs e)
        {
            koneksi.Open();
            string nama = "";
            string strs = "select nim from dbo.produk where nama_produk = @pr";
            SqlCommand cm = new SqlCommand(strs, koneksi);
            cm.CommandType = CommandType.Text;
            cm.Parameters.Add(new SqlParameter("@nm", cbxProduk.Text));
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                nama = dr["nama"].ToString();
            }
            dr.Close();
            koneksi.Close();

            txtID.Text = nama;
        }

        private void cbMasuk()
        {
            int y = DateTime.Now.Year - 2023;
            string[] type = new string[y];
            int i = 0;
            for (i = 0; i < type.Length; i++)
            {
                if (i == 0)
                {
                    cbxMasuk.Items.Add("2023");
                }
                else
                {
                    int l = 2023 + i;
                    cbxMasuk.Items.Add(l.ToString());
                }
            }
        }
        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form4 fm = new Form4();
            fm.Show();
            this.Hide();
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
            refreshform();
        }
    }
}
