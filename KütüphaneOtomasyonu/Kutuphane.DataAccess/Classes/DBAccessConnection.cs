using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.DataAccess.Classes
{
    public class DBAccessConnection
    {
        OleDbConnection connection;

        // Veritabanına bağlanmak için OleDb bağlantısı oluşturdum
        public OleDbConnection connect()
        {
            connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_kutuphane.mdb");
            connection.Open();

            return connection;
        }
        // Veritabanı bağlantısını yapılan her işlemden sonra kapattım.
        public void close()
        {
            connection.Close();
        }
    }
}
