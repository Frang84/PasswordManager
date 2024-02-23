using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsPasswordManager.Repository;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.Common;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Data.SQLite;

namespace WinFormsPasswordManager.Models
{
    public class DatabaseOperations
    {
        public DatabaseOperations() { }
        public void OpenDatabase(string connectionString) 
        {
            AppSetting setting = new AppSetting();
            setting.SaveConnectionString("MyKey", connectionString);
        } 
        public void ClearConnectionString()
        {
            AppSetting setting = new AppSetting();
            setting.SaveConnectionString("MyKey", string.Empty);
        }
        public void CreateDatabase(string connectionString)
        {
            // SQLiteConnection.CreateFile(connectionString);
            OpenDatabase(connectionString);
            using var contex = new EntriesContext();
            contex.Database.EnsureCreated();

        }
    }
}
