using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsPasswordManager.Views
{
    public interface ICreateDatabaseView
    {
         
       
        string Password { get; set; }
        string RepeatPassword { get; set; }
        string DatabasePath { get; set; }
        bool IsPasswordValid { get; set; }  


        event EventHandler ComparePasswordAndRepeat;
        event EventHandler DeleteDatabase;
    }
}
