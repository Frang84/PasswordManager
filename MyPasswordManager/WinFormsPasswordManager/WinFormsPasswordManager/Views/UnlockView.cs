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
    public partial class UnlockView : Form, IUnlockView
    {
        private bool _isCorrect;
        public UnlockView()
        {
            InitializeComponent();
            RiseAndInitializeEvents();
            IsCorrect = false;
        }



        public void RiseAndInitializeEvents()
        {
            buttonUnlock.Click += delegate
            {
                UnlockDatabaseEvent?.Invoke(this, EventArgs.Empty);
                if (!_isCorrect )
                {
                    MessageBox.Show("Incorrect password.");
                }
                else
                {
                    Close();
                }
            };
        }

        public string Password
        {
            get => textBoxPassword.Text;
            set => textBoxPassword.Text = value;
        }
        public bool IsCorrect { get => _isCorrect; set => _isCorrect = value; }

        public event EventHandler UnlockDatabaseEvent;
        public event EventHandler CancelEvent;
    }
}
