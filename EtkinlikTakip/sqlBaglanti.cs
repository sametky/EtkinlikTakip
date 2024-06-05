using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace EtkinlikTakip
{
    internal class sqlBaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source = LAPTOP-R3D59GR9\SQLEXPRESS;Initial Catalog=etkinliktakip;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
