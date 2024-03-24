using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsPasswordManager.Models;

namespace WinFormsPasswordManager.Presenters.Common
{
    static public class DataValidation
    {
        public static bool IsConnectionStringCorrect(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                return false;
            }
            string extension = Path.GetExtension(connectionString);
            if (!extension.Equals(".db"))
            {
                return false;
            }
            return true;
        }
    }
}
