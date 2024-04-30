using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsPasswordManager.Models.CreatePasswordModel;
using WinFormsPasswordManager.Views;

namespace WinFormsPasswordManager.Presenters
{
    public class UnlockPresenter
    {
        private IUnlockView _unlockView;
        private PasswordOperations _passwordOperations;
        private string _passwordToCheck;
        public UnlockPresenter() { }
        public UnlockPresenter(IUnlockView unlockView, PasswordOperations passwordOperations)
        {
            _unlockView = unlockView;
            _passwordOperations = passwordOperations;
            _unlockView.UnlockDatabaseEvent += UnlockDatabase;
        }
        private void UnlockDatabase(object sender, EventArgs eventArgs)
        {
            string passwordHash = _passwordOperations.HashPassword(_unlockView.Password);
            string databasePassword = _passwordOperations.Get().Password;
            if (passwordHash.Equals(databasePassword))
            {
                _unlockView.IsCorrect = true;
            }
            else
            {
                _unlockView.IsCorrect = false; 
            }

        }
        public string PasswordToCheck
        {
            get => _passwordToCheck;
            set => _passwordToCheck = value; 
        }

    }
}
