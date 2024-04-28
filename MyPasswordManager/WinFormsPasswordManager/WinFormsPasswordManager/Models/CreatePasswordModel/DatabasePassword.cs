using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsPasswordManager.Models.CreatePasswordModel
{
    public class DatabasePassword
    {
        [Key]
        public string Password { get; set; }

        public DatabasePassword() { }
        public DatabasePassword(string password)
        {
            this.Password = password;
        }
    }
}
