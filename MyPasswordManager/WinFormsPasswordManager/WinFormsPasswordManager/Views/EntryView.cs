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
    enum SearchEnum
    {
        Name = 1,
        Title = 2
    }
    public partial class EntryView : Form, IEntryOperationView
    {
        private string _message;
        private bool _isEdit;
        private long _id;
        private string _databasePath;



        public EntryView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            SetComboBox();
            tabPageEntriesOperations.TabPages.Remove(tabPageEntryDetails);
            tabPageEntriesOperations.TabPages.Remove(tabPagePasswordGenerator);
        }

        private void SetComboBox()
        {
            //comboBoxSearchBy.SelectedIndex = 0;
            List<SearchEnum> searchVal = new List<SearchEnum>();
            searchVal.Add(SearchEnum.Name);
            searchVal.Add(SearchEnum.Title);
            comboBoxSearchBy.DataSource = searchVal;
            comboBoxSearchBy.SelectedIndex = 0;
        }

        private void AssociateAndRaiseViewEvents()
        {
            SearchButton.Click += delegate
            {
                SearchEvent?.Invoke(this, EventArgs.Empty);

            };
            textBoxSearchEntry.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }

            };
            buttonSave.Click += delegate
            {
                CreateEvent?.Invoke(this, EventArgs.Empty);
                tabPageEntriesOperations.TabPages.Add(EntryList);
                tabPageEntriesOperations.TabPages.Remove(tabPageEntryDetails);
                tabPageEntriesOperations.TabPages.Remove(tabPagePasswordGenerator);
                MessageBox.Show(_message);
            };
            buttonAdd.Click += delegate
            {
                PasswordGenerateEvent?.Invoke(this, EventArgs.Empty);
                tabPageEntriesOperations.TabPages.Remove(EntryList);
                tabPageEntriesOperations.TabPages.Add(tabPageEntryDetails);
                //tabPageEntriesOperations.TabPages.Add(tabPagePasswordGenerator);
            };
            buttonDelete.Click += delegate
            {
                var result = MessageBox.Show("Are you sure you want to delete selected entry?",
                "Warning",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);

                }
            };
            buttonEdit.Click += delegate
            {
                tabPageEntriesOperations.TabPages.Remove(EntryList);
                tabPageEntriesOperations.TabPages.Add(tabPageEntryDetails);
                EditEvent?.Invoke(this, EventArgs.Empty);
            };
            buttonGeneratePassword.Click += delegate
            {
                tabPageEntriesOperations.TabPages.Remove(tabPageEntryDetails);
                tabPageEntriesOperations.TabPages.Add(tabPagePasswordGenerator);
                PasswordGenerateEvent?.Invoke(this, EventArgs.Empty);
            };
            buttonGenerate.Click += delegate
            {
                AdvancedPasswordGenerateEvent?.Invoke(this, EventArgs.Empty);
                tabPageEntriesOperations.TabPages.Add(tabPageEntryDetails);
                tabPageEntriesOperations.TabPages.Remove(tabPagePasswordGenerator);
            };
            buttonCancelEntryDetails.Click += delegate
            {
                CancelEntryDetailsEvent?.Invoke(this, EventArgs.Empty);
                tabPageEntriesOperations.TabPages.Add(EntryList);
                tabPageEntriesOperations.TabPages.Remove(tabPagePasswordGenerator);
                tabPageEntriesOperations.TabPages.Remove(tabPageEntryDetails);
            };
            buttonCancelPasswordGenerator.Click += delegate
            {
                tabPageEntriesOperations.TabPages.Add(tabPageEntryDetails);
                tabPageEntriesOperations.TabPages.Remove(tabPagePasswordGenerator);
            };
            openToolStripMenuItem.Click += delegate
            {
                var openFileDialog = new OpenFileDialog();
                openFileDialog.Title = "Select database";
                openFileDialog.InitialDirectory = @"C:\";
                openFileDialog.Filter = "All Files (*.*)|*.*|Database File (*.db)|*.db";
                openFileDialog.FilterIndex = 1;
                openFileDialog.ShowDialog();
                DatabasePath = openFileDialog.FileName;
                OpenDatabaseEvent?.Invoke(this, EventArgs.Empty);
            };
            closeToolStripMenuItem.Click += delegate
            {
                CloseEvent?.Invoke(this, EventArgs.Empty);
            };

        }

        public string EntryTitle { get => textBoxTitle.Text; set => textBoxTitle.Text = value; }
        public string EntryPassword { get => textBoxPassword.Text; set => textBoxPassword.Text = value; }
        public string EntryName { get => textBoxName.Text; set => textBoxName.Text = value; }
        public string EntryUrl { get => textBoxUrl.Text; set => textBoxUrl.Text = value; }
        public string EntryNotes { get => textBoxNotes.Text; set => textBoxNotes.Text = value; }
        public string SearchValue { get => textBoxSearchEntry.Text; set => textBoxSearchEntry.Text = value; }
        //public bool SearchByNameOrTitle { get => ByTitleCheckBox.Checked; set => ByTitleCheckBox.Checked = value; }
        public string Message { get => _message; set => _message = value; }
        public bool IsEdit { get => _isEdit; set => _isEdit = value; }
        public long Id { get => _id; set => _id = value; }
        public bool SmallLetters { get => checkBoxSmallLetters.Checked; }
        public bool Numbers { get => checkBoxNumbers.Checked; }
        public bool SpecialCharacters { get => checkBoxSpecialCharacters.Checked; }
        public bool Brackets { get => checkBoxSpecialBrackets.Checked; }
        public string LengthOfPassword { get => textBoxLength.Text; set => textBoxLength.Text = value; }
        public string DatabasePath { get => _databasePath; set => _databasePath = value; }
        public string SearchBy { get => comboBoxSearchBy.Text; }

        public event EventHandler SearchEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler EditEvent;
        public event EventHandler CreateEvent;
        public event EventHandler SaveEvent;
        public event EventHandler PasswordGenerateEvent;
        public event EventHandler AdvancedPasswordGenerateEvent;
        public event EventHandler CancelEntryDetailsEvent;
        public event EventHandler OpenDatabaseEvent;
        public event EventHandler CloseEvent;



        public void SetEntryListBindingSource(BindingSource entryList)
        {
            dataGridViewEntries.DataSource = entryList;
        }
    }
}
