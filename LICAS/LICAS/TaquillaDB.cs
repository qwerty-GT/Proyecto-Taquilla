using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace LICAS
{
    class TaquillaDB
    {
        public static OdbcConnection getDB()
        {
            OdbcConnection cnx = new OdbcConnection(Properties.Settings.Default.ruta);
            cnx.Open();
            return cnx;
        }
    }
}
