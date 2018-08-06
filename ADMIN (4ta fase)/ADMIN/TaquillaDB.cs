using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.Odbc;

namespace ADMIN
{
    class TaquillaDB
    {
        public static OdbcConnection getDB()
        {
            //MySqlConnection conectar = new MySqlConnection("server=127.0.0.1;database=Taquilla;Uid=root;pwd=1243;");
            OdbcConnection cnx = new OdbcConnection(Properties.Settings.Default.ruta1);
            cnx.Open();
            return cnx;
        }
    }
}
