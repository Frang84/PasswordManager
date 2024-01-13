using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsPasswordManager.Models;

namespace WinFormsPasswordManager.Views
{
    public partial class EntryView : Form, IEntryOperationView
    {

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
            buttonCreate.Click += delegate { CreateEvent?.Invoke(this, EventArgs.Empty); };
        }

        public string EntryTitle { get => textBoxTitle.Text; set => textBoxTitle.Text = value; }
        public string EntryPassword { get => textBoxPassword.Text; set => textBoxPassword.Text = value; }
        public string EntryName { get => textBoxName.Text; set => textBoxName.Text = value; }
        public string EntryUrl { get => textBoxUrl.Text; set => textBoxUrl.Text = value; }
        public string EntryNotes { get => textBoxNotes.Text; set => textBoxNotes.Text = value; }
        public string SearchValue { get => textBoxSearchEntry.Text; set => textBoxSearchEntry.Text = value; }
        //public bool SearchByNameOrTitle { get => ByTitleCheckBox.Checked; set => ByTitleCheckBox.Checked = value; }

        public event EventHandler SearchEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler EditEvent;
        public event EventHandler CreateEvent;

        public void SetEntryListBindingSource(BindingSource entryList)
        {
            dataGridViewEntries.DataSource = entryList;
        }


    }
}
