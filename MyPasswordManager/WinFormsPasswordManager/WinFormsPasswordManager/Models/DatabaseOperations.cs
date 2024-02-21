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

namespace WinFormsPasswordManager.Models
{
    public class DatabaseOperations
    {
        public DatabaseOperations() { }
        public void OpenDatabase(string connectionString) 
        {
            try
            {
                SqliteHelper helper = new SqliteHelper(connectionString);
                if (helper.IsConnection)
                {
                    AppSetting setting = new AppSetting();
                    setting.SaveConnectionString("MyKey", connectionString);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 
        public void ClearConnectionString()
        {
            //Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //ConnectionStringsSection connectionStringsSection = config.ConnectionStrings;
            //connectionStringsSection.ConnectionStrings["MyKey"].ConnectionString = string.Empty;
            //config.Save(ConfigurationSaveMode.Modified);
            //ConfigurationManager.RefreshSection("connectionStrings");

            AppSetting setting = new AppSetting();
            setting.SaveConnectionString("MyKey", string.Empty);
        }
        public void CreateDatabase(string connectionString)
        {

        }
    }
}
