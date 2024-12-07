using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PembayaranSPP
{
    class koneksi
    {
        public static MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd=;database=spp_ku");
    }
}
