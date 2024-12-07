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
    public partial class Data_Siswa : Form
    {
        public MySqlCommand cmd;
        public MySqlDataReader dr;
        public Data_Siswa()
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
            txtIDKelas.Enabled = true;
            txtAlamat.Enabled = true;
            txt_Telp.Enabled = true;
            txtID_SPP.Enabled = true;
            txtNama.Enabled = true;
            txtNIS.Enabled = true;
            txtclear();
        }

        public void txtclear()
        {
            txtCari.Text = "";
            txtIDKelas.Text = "";
            txtAlamat.Text = "";
            txt_Telp.Text = "";
            txtID_SPP.Text = "";
            txtNama.Text = "";
            txtNIS.Text = "";
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
            txtIDKelas.Enabled = false;
            txtAlamat.Enabled = false;
            txt_Telp.Enabled = false;
            txtID_SPP.Enabled = false;
            txtNama.Enabled = false;
            txtNIS.Enabled = false;
            txtclear();
        }

        private void view()
        {
            try
            {
                koneksi.conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("select * from `spp_ku` . `tb_siswa`", koneksi.conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dg_siswa.DataSource = ds.Tables[0];
                koneksi.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                koneksi.conn.Close();
                Close();
            }
        }

        private void Data_Siswa_Load(object sender, EventArgs e)
        {
            view();
            bersih();
        }

        private void btnBaru_Click(object sender, EventArgs e)
        {
            baru();
        }

        private void btnBersih_Click(object sender, EventArgs e)
        {
            bersih();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dg_siswa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = dg_siswa.CurrentCell.RowIndex;
            txtNIS.Text = dg_siswa.Rows[baris].Cells[0].Value.ToString();
            txtNama.Text = dg_siswa.Rows[baris].Cells[1].Value.ToString();
            string jk = dg_siswa.Rows[baris].Cells[2].Value.ToString();
            if(jk == "Laki-laki")
            {
                rbLaki.Checked = true;
            }
            else if(jk == "Perempuan")
            {
                rb_Perempuan.Checked = true;
            }
            txtIDKelas.Text = dg_siswa.Rows[baris].Cells[3].Value.ToString();
            txtAlamat.Text = dg_siswa.Rows[baris].Cells[4].Value.ToString();
            txt_Telp.Text = dg_siswa.Rows[baris].Cells[5].Value.ToString();
            txtID_SPP.Text = dg_siswa.Rows[baris].Cells[6].Value.ToString();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.conn.Open();
                string jk = "";
                if (rbLaki.Checked == true)
                {
                    jk = "Laki-laki";
                }
                else if (rb_Perempuan.Checked == true)
                {
                    jk = "Perempuan";
                }
                string query = "insert into tb_siswa values('" + txtNIS.Text + "','" + txtNama.Text + "','" + jk + "','" + txtIDKelas.Text + "','" + txtAlamat.Text + "','" + txt_Telp.Text + "','" + txtID_SPP.Text + "')";
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.conn.Open();
                string jk = "";
                if (rbLaki.Checked == true)
                {
                    jk = "Laki-laki";
                }
                else if (rb_Perempuan.Checked == true)
                {
                    jk = "Perempuan";
                }
                string query = "UPDATE `tb_siswa` SET `nama_siswa`='" + txtNama.Text + "',`jenis_kelamin`='" + jk + "',`id_kelas`='" + txtIDKelas.Text + "',`alamat`='"+txtAlamat.Text+"',`no_telp`='"+txt_Telp.Text+"',`id_spp`='"+txtID_SPP.Text+"' WHERE `nis`='"+txtNIS.Text+"'";
                cmd = new MySqlCommand(query, koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil di update");
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
                string nis = txtNIS.Text;
                string query = "delete from tb_siswa where nis='" + nis + "'";
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

        private void txtCari_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if(e.KeyChar == (char)Keys.Enter)
                {
                    koneksi.conn.Open();
                    string cari = txtCari.Text;
                    MySqlDataAdapter da = new MySqlDataAdapter("select * from tb_siswa where nis like '%" + cari + "%' or nama_siswa like '%" + cari + "%' or jenis_kelamin like '%" + cari + "%' or id_kelas like '%" + cari + "%' or alamat like '%" + cari + "%' or no_telp like '%" + cari + "%' or id_spp like '%" + cari + "%'", koneksi.conn);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dg_siswa.DataSource = ds.Tables[0];
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
