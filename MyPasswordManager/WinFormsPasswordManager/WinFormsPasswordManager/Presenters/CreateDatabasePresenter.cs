using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsPasswordManager.Views;
using WinFormsPasswordManager.Models.CreatePasswordModel;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using WinFormsPasswordManager.Models;

namespace WinFormsPasswordManager.Presenters
{
    public class CreateDatabasePresenter
    {
        private ICreateDatabaseView _view;
        private PasswordOperations _passwordOperations;
        public CreateDatabasePresenter() { }
        public CreateDatabasePresenter(ICreateDatabaseView view, PasswordOperations passwordOperations)
        {
            _view = view;
            _passwordOperations = passwordOperations;
            _view.ComparePasswordAndRepeat += Create;
            _view.DeleteDatabase += Delete;
            _passwordOperations = passwordOperations;
        }
        private void Create(object sender, EventArgs e) 
        {
            if(this._view.Password == this._view.RepeatPassword)
            {
                this._view.IsPasswordValid = true;
                DatabasePassword databasePassword = new DatabasePassword(_view.Password);
                this._passwordOperations.HashPassword(databasePassword);
                this._passwordOperations.Add(databasePassword);
                this._view.IsPasswordValid = true;

            }
            else
            {
                this._view.IsPasswordValid = false;
            }
        }
        private void Delete(object sender, EventArgs e)
        {
            DatabaseOperations databaseOperations = new DatabaseOperations();
            
            databaseOperations.DeleteDatabase(this._view.DatabasePath);
            databaseOperations.ClearConnectionString();
        }
    }
}
