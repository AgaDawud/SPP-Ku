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
    public partial class Data_Pegawai : Form
    {
        public MySqlCommand cmd;
        public MySqlDataReader dr;
        public Data_Pegawai()
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
            txtAlamat.Enabled = true;
            txtCari.Enabled = true;
            txtID.Enabled = true;
            txtPassword.Enabled = true;
            txtUsername.Enabled = true;
            txt_nama.Enabled = true;
            txttelp.Enabled = true;
            cB_level.Enabled = true;
            txtclear();
        }

        public void txtclear()
        {
            txtAlamat.Text = "";
            txtCari.Text = "";
            txtID.Text = "";
            txtPassword.Text = "";
            txtUsername.Text = "";
            txt_nama.Text = "";
            txttelp.Text = "";
            cB_level.Text = "";
        }

        public void bersih()
        {
            btnBersih.Enabled = false;
            btnHapus.Enabled = false;
            btnSimpan.Enabled = false;
            btnUpdate.Enabled = false;
            btnExit.Enabled = true;
            btnBaru.Enabled = true;
            txtAlamat.Enabled = false;
            txtCari.Enabled = false;
            txtID.Enabled = false;
            txtPassword.Enabled = false;
            txtUsername.Enabled = false;
            txt_nama.Enabled = false;
            txttelp.Enabled = false;
            cB_level.Enabled = false;
            txtclear();
        }

        public void view()
        {
            try
            {
                koneksi.conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("select * from `spp_ku` . `tb_pegawai`", koneksi.conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dg_pegawai.DataSource = ds.Tables[0];
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

        private void Data_Pegawai_Load(object sender, EventArgs e)
        {
            view();
            bersih();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBersih_Click(object sender, EventArgs e)
        {
            bersih();
        }

        private void dg_pegawai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = dg_pegawai.CurrentCell.RowIndex;
            txtID.Text = dg_pegawai.Rows[baris].Cells[0].Value.ToString();
            txt_nama.Text = dg_pegawai.Rows[baris].Cells[1].Value.ToString();
            string jk = dg_pegawai.Rows[baris].Cells[2].Value.ToString();
            if(jk == "Laki-laki")
            {
                rbLaki.Checked = true;
            } 
            else if (jk == "Perempuan")
            {
                rb_Perempuan.Checked = true;
            }
            txtAlamat.Text = dg_pegawai.Rows[baris].Cells[3].Value.ToString();
            txttelp.Text = dg_pegawai.Rows[baris].Cells[4].Value.ToString();
            txtUsername.Text = dg_pegawai.Rows[baris].Cells[5].Value.ToString();
            txtPassword.Text = dg_pegawai.Rows[baris].Cells[6].Value.ToString();
            cB_level.Text = dg_pegawai.Rows[baris].Cells[7].Value.ToString();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.conn.Open();
                string jk = "";
                if(rbLaki.Checked == true)
                {
                    jk = "Laki-laki";
                } 
                else if (rb_Perempuan.Checked == true)
                {
                    jk = "Perempuan";
                }
                string query = "insert into tb_pegawai values('"+txtID.Text+"','"+txt_nama.Text+"','"+jk+"','"+txttelp.Text+"','"+txtAlamat.Text+"','"+txtUsername.Text+"','"+txtPassword.Text+"','"+cB_level.Text+"')";
                cmd = new MySqlCommand(query, koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil di simpan");
                koneksi.conn.Close();

                view();
                bersih();
                baru();
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
                string query = "delete from tb_pegawai where id_pegawai='"+txtID.Text+"'";
                cmd = new MySqlCommand(query, koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil di hapus");
                koneksi.conn.Close();

                view();
                bersih();
                baru();
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
                string jk = "";
                if(rbLaki.Checked == true)
                {
                    jk = "Laki-laki";
                }
                else if (rb_Perempuan.Checked == true)
                {
                    jk = "Perempuan";
                }
                string query = "UPDATE `tb_pegawai` SET `nama_pegawai`='"+txt_nama.Text+"',`jenis_kelamin`='"+jk+"',`no_telp`='"+txttelp.Text+"',`alamat`='"+txtAlamat.Text+"',`username`='"+txtUsername.Text+"',`password`='"+txtPassword.Text+"',`level`='"+cB_level.Text+"' WHERE `id_pegawai`='"+txtID.Text+"'";
                cmd = new MySqlCommand(query, koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil di edit");
                koneksi.conn.Close();

                view();
                bersih();
                baru();
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
                    MySqlDataAdapter da = new MySqlDataAdapter("select * from tb_pegawai where id_pegawai like '%" + cari + "%' or nama_pegawai like '%" + cari + "%' or jenis_kelamin like '%" + cari + "%' or no_telp like '%" + cari + "%' or alamat like '%" + cari + "%' or username like '%" + cari + "%' or password like '%" + cari + "%' or level like '%" + cari + "%'", koneksi.conn);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dg_pegawai.DataSource = ds.Tables[0];
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
