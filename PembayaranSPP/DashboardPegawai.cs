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
    public partial class DashboardPegawai : Form
    {
        public DashboardPegawai()
        {
            InitializeComponent();
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
