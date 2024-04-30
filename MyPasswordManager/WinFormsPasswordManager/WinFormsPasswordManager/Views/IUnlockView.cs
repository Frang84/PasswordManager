using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsPasswordManager.Views
{
    public interface IUnlockView
    {
        public string Password { get; set; }
        public bool IsCorrect { get; set; }

        event EventHandler UnlockDatabaseEvent;
        event EventHandler CancelEvent;

    }
    
}
