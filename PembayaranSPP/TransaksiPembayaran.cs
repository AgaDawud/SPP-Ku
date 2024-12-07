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
    public partial class TransaksiPembayaran : Form
    {
        public MySqlCommand cmd;
        public MySqlDataReader dr;
        public TransaksiPembayaran()
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
            txtID_Pegawai.Enabled = true;
            txtJB.Enabled = true;
            txtID_SPP.Enabled = true;
            txtTHN.Enabled = true;
            txtNIS.Enabled = true;
            comboBulan.Enabled = true;
            tgl_bayar.Enabled = true;
            txtID_Pembayaran.Enabled = true;
            txtclear();
        }

        public void txtclear()
        {
            txtCari.Text = "";
            txtID_SPP.Text = "";
            txtNIS.Text = "";
            txtTHN.Text = "";
            txtID_Pegawai.Text = "";
            comboBulan.Text = "";
            txtJB.Text = "";
            txtID_Pembayaran.Text = "";
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
            txtID_Pegawai.Enabled = false;
            txtJB.Enabled = false;
            txtID_SPP.Enabled = false;
            txtTHN.Enabled = false;
            txtNIS.Enabled = false;
            comboBulan.Enabled = false;
            tgl_bayar.Enabled = false;
            txtID_Pembayaran.Enabled = false;
            txtclear();
        }

        public void view()
        {
            try
            {
                koneksi.conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("select * from `spp_ku` . `tb_pembayaran`", koneksi.conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dg_tp.DataSource = ds.Tables[0];
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

        private void btnBersih_Click(object sender, EventArgs e)
        {
            bersih();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TransaksiPembayaran_Load(object sender, EventArgs e)
        {
            view();
            bersih();
        }

        private void dg_tp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = dg_tp.CurrentCell.RowIndex;
            txtID_Pembayaran.Text = dg_tp.Rows[baris].Cells[0].Value.ToString();
            txtID_Pegawai.Text = dg_tp.Rows[baris].Cells[1].Value.ToString();
            txtNIS.Text = dg_tp.Rows[baris].Cells[2].Value.ToString();
            string tgl = tgl_bayar.Value.ToString("yyyy-MM-dd");
            tgl = dg_tp.Rows[baris].Cells[3].Value.ToString();
            comboBulan.Text = dg_tp.Rows[baris].Cells[4].Value.ToString();
            txtTHN.Text = dg_tp.Rows[baris].Cells[5].Value.ToString();
            txtID_SPP.Text = dg_tp.Rows[baris].Cells[6].Value.ToString();
            txtJB.Text = dg_tp.Rows[baris].Cells[7].Value.ToString(); 
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.conn.Open();
                string tgl = tgl_bayar.Value.ToString("yyyy-MM-dd");
                string query = "insert into tb_pembayaran values('" + txtID_Pembayaran.Text + "','" + txtID_Pegawai.Text + "','" + txtNIS.Text + "','" + tgl + "','" + comboBulan.Text + "','" + txtTHN.Text + "','" + txtID_SPP.Text + "','" + txtJB.Text + "')";
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
                string id = txtID_Pembayaran.Text;
                string query = "delete from tb_pembayaran where id_pembayaran='" + id + "'";
                cmd = new MySqlCommand(query, koneksi.conn);
                cmd.ExecuteNonQuery();
                koneksi.conn.Close();
                MessageBox.Show("Data berhasil di hapus");

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
                string tgl = tgl_bayar.Value.ToString("yyyy-MM-dd");
                string query = "UPDATE `tb_pembayaran` SET `id_pembayaran`='" + txtID_Pembayaran.Text + "', `id_pegawai`='" + txtID_Pegawai.Text + "',`nis`='" + txtNIS.Text + "',`tgl_bayar`='" + tgl + "',`bulan_dibayar`='" + comboBulan.Text + "',`tahun_dibayar`='" + txtTHN.Text + "',`id_spp`='" + txtID_SPP.Text + "',`jumlah_bayar`='" + txtJB.Text + "' WHERE `tb_pembayaran`.`id_pembayaran`='" + txtID_Pembayaran.Text + "'";
                cmd = new MySqlCommand(query, koneksi.conn);
                cmd.ExecuteNonQuery();
                koneksi.conn.Close();
                MessageBox.Show("Data Berhasil di update");

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
                    MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM `tb_pembayaran` WHERE `id_pembayaran` LIKE '%"+cari+"%' OR `id_pegawai` LIKE '%"+cari+ "%' OR `nis` LIKE '%" + cari + "%' OR `tgl_bayar` LIKE '%" + cari + "%' OR `bulan_dibayar` LIKE '%" + cari + "%' OR `tahun_dibayar` LIKE '%" + cari + "%' OR `id_spp` LIKE '%" + cari + "%' OR `jumlah_bayar` LIKE '%" + cari + "%'", koneksi.conn);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dg_tp.DataSource = ds.Tables[0];
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
