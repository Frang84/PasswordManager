using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace WinFormsPasswordManager.Repository
{
    
    public class SqliteHelper
    {
        SqliteConnection _connection;
        

        public SqliteHelper(string connectionString)
        {
            _connection = new SqliteConnection(connectionString);
        }
        public bool IsConnection
        {
            get
            {
                if (_connection.State == System.Data.ConnectionState.Closed)
                {
                    _connection.Open();
                }
                return true;
            }
        }
    }
}
