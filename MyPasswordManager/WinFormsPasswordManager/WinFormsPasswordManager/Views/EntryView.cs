using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsPasswordManager.Models;

namespace WinFormsPasswordManager.Views
{
    public partial class EntryView : Form, IEntryOperationView
    {
        private string _title;
        private string _password;
        private string _name;
        private string _url;
        private string _notes;

        public EntryView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            //tabPageEntryList.TabPages.Remove(tabPage2);
        }

        private void AssociateAndRaiseViewEvents()
        {
            SearchButton.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            textBoxSearchEntry.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };
        }

        public string EntryTitle { get => _title; set => _title = value; }
        public string EntryPassword { get => _password; set => _password = value; }
        public string EntryName { get => _name; set => _name = value; }
        public string EntryUrl { get => _url; set => _url = value; }
        public string EntryNotes { get => _notes; set => _notes = value; }
        public string SearchValue { get => textBoxSearchEntry.Text; set => textBoxSearchEntry.Text = value; }
        //public bool SearchByNameOrTitle { get => ByTitleCheckBox.Checked; set => ByTitleCheckBox.Checked = value; }

        public event EventHandler SearchEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler EditEvent;
        public event EventHandler CreateEvent;

        public void SetEntryListBindingSource(BindingSource entryList)
        {
            dataGridViewEntris.DataSource = entryList;
        }
    }
}
