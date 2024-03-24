using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsPasswordManager.Models
{
    public class DatabasePassword
    {
        [Key]
        public string Password { get; set; }
    }
}
