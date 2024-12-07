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
    public partial class DataSPP : Form
    {
        public MySqlCommand cmd;
        public MySqlDataReader dr;
        public DataSPP()
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
            txtNominal.Enabled = true;
            txtTahun.Enabled = true;
            txtclear();
        }

        public void txtclear()
        {
            txtTahun.Text = "";
            txtCari.Text = "";
            txtID.Text = "";
            txtNominal.Text = "";
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
            txtNominal.Enabled = false;
            txtTahun.Enabled = false;
            txtclear();
        }

        private void view()
        {
            try
            {
                koneksi.conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("select * from `spp_ku` . `tb_spp`", koneksi.conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dg_spp.DataSource = ds.Tables[0];
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

        private void DataSPP_Load(object sender, EventArgs e)
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

        private void dg_spp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = dg_spp.CurrentCell.RowIndex;
            txtID.Text = dg_spp.Rows[baris].Cells[0].Value.ToString();
            txtTahun.Text = dg_spp.Rows[baris].Cells[1].Value.ToString();
            txtNominal.Text = dg_spp.Rows[baris].Cells[2].Value.ToString();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.conn.Open();
                string query = "insert into tb_spp values('" + txtID.Text + "','" + txtTahun.Text + "','" + txtNominal.Text + "')";
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
                string query = "delete from tb_spp where id_spp='" + id + "'";
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
                string query = "UPDATE `tb_spp` SET `tahun`='" + txtTahun.Text + "',`nominal`='" + txtNominal.Text + "' WHERE `id_spp`='" + txtID.Text + "'";
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
                    MySqlDataAdapter da = new MySqlDataAdapter("select * from tb_spp where id_spp like '%" + cari + "%' or tahun like '%" + cari + "%' or nominal like '%" + cari + "%'", koneksi.conn);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dg_spp.DataSource = ds.Tables[0];
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