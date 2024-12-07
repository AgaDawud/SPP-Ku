using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PembayaranSPP
{
    public partial class DashboardAdmin : Form
    {
        public DashboardAdmin()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Data_Siswa ds = new Data_Siswa();
            ds.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Data_Pegawai dp = new Data_Pegawai();
            dp.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DataKelas dk = new DataKelas();
            dk.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DataSPP dsp = new DataSPP();
            dsp.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            TransaksiPembayaran tp = new TransaksiPembayaran();
            tp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HistoryPembayaran hp = new HistoryPembayaran();
            hp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
