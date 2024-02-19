using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsPasswordManager.Repository;

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
        public void CreateDatabase(string connectionString)
        {

        }
    }
}
