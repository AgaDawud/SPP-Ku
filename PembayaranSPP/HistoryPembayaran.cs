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
    public partial class HistoryPembayaran : Form
    {
        public HistoryPembayaran()
        {
            InitializeComponent();
        }

        private void HistoryPembayaran_Load(object sender, EventArgs e)
        {
            try
            {
                koneksi.conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("select * from vpembayaran", koneksi.conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                v_pembayaran.DataSource = ds.Tables[0];
                koneksi.conn.Close();
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
                if (e.KeyChar == (char)Keys.Enter)
                {
                    koneksi.conn.Open();
                    string cari = txtCari.Text;
                    MySqlDataAdapter da = new MySqlDataAdapter("select * from vpembayaran where id_pegawai like '%" + cari + "%' or nama_pegawai like '%" + cari + "%' or nis like '%" + cari + "%' or nama_siswa like '%" + cari + "%' or id_kelas like '%" + cari + "%' or nama_kelas like '%" + cari + "%' or kopetensi_keahlian like '%" + cari + "%' or id_pembayaran like '%" + cari + "%' or tgl_bayar like '%" + cari + "%' or bulan_dibayar like '%" + cari + "%' or tahun_dibayar like '%" + cari + "%' or jumlah_bayar like '%" + cari + "%'", koneksi.conn);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    v_pembayaran.DataSource = ds.Tables[0];
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