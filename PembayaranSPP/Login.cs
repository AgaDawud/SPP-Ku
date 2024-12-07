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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.conn.Open();
                string username = txtUsername.Text;
                string password = txtPassword.Text;

                string query = "select * from tb_pegawai where username='"+username+"' and password='"+password+"'";
                var cmd = new MySqlCommand(query, koneksi.conn);
                var rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    string level = rd["level"].ToString();
                    if(level == "admin")
                    {
                        DashboardAdmin da = new DashboardAdmin();
                        da.Show();
                        Hide();
                    }
                    else if(level == "pegawai")
                    {
                        DashboardPegawai dp = new DashboardPegawai();
                        dp.Show();
                        Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Username dan Password Salah !!");
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                }
                koneksi.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                koneksi.conn.Close();
                Close();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
