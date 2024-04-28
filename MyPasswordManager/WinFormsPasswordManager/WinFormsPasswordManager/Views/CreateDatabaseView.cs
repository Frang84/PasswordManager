using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsPasswordManager.Views
{
    public partial class CreateDatabaseView : Form, ICreateDatabaseView
    {
        private bool _isPasswordValid;
        private EntryView _entryView;
        public CreateDatabaseView()
        {
            InitializeComponent();
        }
        public CreateDatabaseView(Form main)
        {
            _entryView = (EntryView)main;
            InitializeComponent();
            AssociateAndRiseEvents();
        }

        private void AssociateAndRiseEvents()
        {
            buttonCreate.Click += delegate
            {
                ComparePasswordAndRepeat?.Invoke(this, EventArgs.Empty);
                if (!_isPasswordValid)
                {
                    MessageBox.Show("Password and Repeat are different.");
                }
                else
                {
                    string path = _entryView.DatabasePath;

                    Close();
                }
            };
            buttonCancel.Click += delegate
            {
                DeleteDatabase?.Invoke(this, EventArgs.Empty);
                _entryView.IsConnection = false;
                Close();
            };
        }
        public string Password { get => textBoxPassword.Text; set => textBoxPassword.Text = value; }
        public string RepeatPassword { get => textBoxRepeat.Text; set => textBoxRepeat.Text = value; }
        public bool IsPasswordValid { get => _isPasswordValid; set => _isPasswordValid = value; }
        public string DatabasePath { get => _entryView.DatabasePath; set => _entryView.DatabasePath = value; }

        public event EventHandler ComparePasswordAndRepeat;
        public event EventHandler DeleteDatabase;
    }
}
