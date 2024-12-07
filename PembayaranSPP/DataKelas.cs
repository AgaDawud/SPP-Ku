using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PembayaranSPP
{
    public partial class DataKelas : Form
    {
        public MySqlCommand cmd;
        public MySqlDataReader dr;
        public DataKelas()
        {
            InitializeComponent();
        }

        public void baru()
        {
            btnBaru.Enabled = false;
            btnExit.Enabled = false;
            btnBersih.Enabled = true;
            btnHapus.Enabled = true;
            btnSimpan.Enabled = true;
            btnUpdate.Enabled = true;
            txtCari.Enabled = true;
            txtID.Enabled = true;
            txtKeahlian.Enabled = true;
            txtKelas.Enabled = true;
            txtclear();
        }

        public void txtclear()
        {
            txtKelas.Text = "";
            txtCari.Text = "";
            txtID.Text = "";
            txtKeahlian.Text = "";
        }

        public void bersih()
        {
            btnBersih.Enabled = false;
            btnHapus.Enabled = false;
            btnSimpan.Enabled = false;
            btnUpdate.Enabled = false;
            btnExit.Enabled = true;
            btnBaru.Enabled = true;
            txtCari.Enabled = false;
            txtID.Enabled = false;
            txtKeahlian.Enabled = false;
            txtKelas.Enabled = false;
            txtclear();
        }

        public void view()
        {
            try
            {
                koneksi.conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("select * from `spp_ku` . `tb_kelas`", koneksi.conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dg_Kelas.DataSource = ds.Tables[0];
                koneksi.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                koneksi.conn.Close();
                Close();
            }
        }

        private void btnBaru_Click(object sender, EventArgs e)
        {
            baru();
        }

        private void DataKelas_Load(object sender, EventArgs e)
        {
            view();
            bersih();
        }

        private void btnBersih_Click(object sender, EventArgs e)
        {
            bersih();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dg_Kelas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = dg_Kelas.CurrentCell.RowIndex;
            txtID.Text = dg_Kelas.Rows[baris].Cells[0].Value.ToString();
            txtKelas.Text = dg_Kelas.Rows[baris].Cells[1].Value.ToString();
            txtKeahlian.Text = dg_Kelas.Rows[baris].Cells[2].Value.ToString();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.conn.Open();
                string query = "insert into tb_kelas values('" + txtID.Text + "','" + txtKelas.Text + "','" + txtKeahlian.Text + "')";
                cmd = new MySqlCommand(query, koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil di simpan");
                koneksi.conn.Close();

                view();
                bersih();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                koneksi.conn.Close();
                Close();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.conn.Open();
                string id = txtID.Text;
                string query = "delete from tb_kelas where id_kelas='"+id+"'";
                cmd = new MySqlCommand(query, koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil di hapus");
                koneksi.conn.Close();

                view();
                bersih();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                koneksi.conn.Close();
                Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.conn.Open();
                string query = "UPDATE `tb_kelas` SET `nama_kelas`='"+txtKelas.Text+"',`kopetensi_keahlian`='"+txtKeahlian.Text+"' WHERE `id_kelas`='"+txtID.Text+"'";
                cmd = new MySqlCommand(query, koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil di edit");
                koneksi.conn.Close();

                view();
                bersih();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                koneksi.conn.Close();
                Close();
            }
        }

        private void txtCari_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if(e.KeyChar == (char)Keys.Enter)
                {
                    koneksi.conn.Open();
                    string cari = txtCari.Text;
                    MySqlDataAdapter da = new MySqlDataAdapter("select * from tb_kelas where id_kelas like '%" + cari + "%' or nama_kelas like '%" + cari + "%' or kopetensi_keahlian like '%" + cari + "%'", koneksi.conn);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dg_Kelas.DataSource = ds.Tables[0];
                    koneksi.conn.Close();
                    txtCari.Text = "";
                    e.Handled = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                koneksi.conn.Close();
                Close();
            }
        }
    }
}
