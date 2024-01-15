using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsPasswordManager.Views;
using WinFormsPasswordManager.Models;
using System.Drawing.Text;

namespace WinFormsPasswordManager.Presenters
{
    public class EntryOperationsPresenter
    {
        private IEntryOperationView _entryOperationView;
        private EntryOperation _entryOperation;
        private BindingSource _entrysBindingSource;
        private IEnumerable<Entry> _entries;
        public EntryOperationsPresenter(IEntryOperationView entryOperationView, EntryOperation entryOperation)
        {
            _entryOperationView = entryOperationView;
            _entryOperation = entryOperation;
            _entrysBindingSource = new BindingSource();

            this._entryOperationView.CreateEvent += Create;
            this._entryOperationView.EditEvent += Edit;
            this._entryOperationView.DeleteEvent += Delete;
            this._entryOperationView.SearchEvent += Search;
            this._entryOperationView.PasswordGenerateEvent += GeneratePassword;
            this._entryOperationView.AdvancedPasswordGenerateEvent += GenerateAdvancedPassword;
            this._entryOperationView.CancelEntryDetailsEvent += Cancel;
            this._entryOperationView.CancelPasswordManagerEvent += Cancel;


            this._entryOperationView.SetEntryListBindingSource(_entrysBindingSource);
            LoadAllEntriesList();

        }

        private void LoadAllEntriesList()
        {
            this._entries = _entryOperation.GetEntries();
            _entrysBindingSource.DataSource = this._entries;
        }

        private void Search(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrEmpty(this._entryOperationView.SearchValue);
            if (emptyValue)
            {
                this._entries = this._entryOperation.GetEntries();
            }
            else
            {
                this._entries = this._entryOperation.Search(this._entryOperationView.SearchValue);
            }
            _entrysBindingSource.DataSource = _entries;
        }

        private void Delete(object sender, EventArgs e)
        {
            try
            {
                var entry = (Entry)_entrysBindingSource.Current;
                this._entryOperation.Delete(entry);
                _entryOperationView.Message = "Deleted succesfully";
                LoadAllEntriesList();
            }catch(Exception ex)
            {
                _entryOperationView.Message = "Delete operation failed";
            }
        }

        private void Edit(object sender, EventArgs e)
        {    
            var entry = (Entry)_entrysBindingSource.Current;
            _entryOperationView.Id = entry.Id;
            _entryOperationView.EntryName = entry.UserName;
            _entryOperationView.EntryTitle = entry.Title;
            _entryOperationView.EntryPassword = entry.Password;
            _entryOperationView.EntryNotes = entry.Notes;
            _entryOperationView.EntryUrl = entry.Url;
            _entryOperationView.IsEdit = true;
                
        }
        private void GeneratePassword(object sender, EventArgs e)
        {
           _entryOperationView.EntryPassword = _entryOperation._passwordGenerator.GenerateBasicPassword();
        }
        private void GenerateAdvancedPassword(object sender, EventArgs e)
        {
            int length = 0;
            try
            {
                length = Int32.Parse(_entryOperationView.LengthOfPassword);
            }
            catch(FormatException ex)
            {
                Console.WriteLine($"Unable to parse '{_entryOperationView.LengthOfPassword}'");
            }

            _entryOperationView.EntryPassword = _entryOperation._passwordGenerator.GenerateAdvancedPassword(
                _entryOperationView.SmallLetters,
                _entryOperationView.Numbers,
                _entryOperationView.SpecialCharacters,
                _entryOperationView.Brackets,
                length);
        }

        private void Create(object sender, EventArgs e)
        {
            long id = _entryOperationView.Id;
            string title = _entryOperationView.EntryTitle.Trim();
            string password = _entryOperationView.EntryPassword.Trim();
            string name = _entryOperationView.EntryName.Trim();
            string url = _entryOperationView.EntryUrl;
            string notes = _entryOperationView.EntryNotes;
            if (!(string.IsNullOrEmpty(title) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(name)))
            {

                var entry = new Entry(title, password, name, url, notes, DateTime.Now, id);
                if (_entryOperationView.IsEdit)
                {
                    _entryOperation.Edit(entry);
                    this._entryOperationView.Message = "Entry edited";
                }
                else
                {
                    _entryOperation.Create(entry);
                    this._entryOperationView.Message = "Entry created";
                }
                LoadAllEntriesList();
            }
            else
            {
                this._entryOperationView.Message = "title, password and name are mandatory";
            }
            
            CleanViewFields();
        }
        private void Cancel(object sender, EventArgs e)
        {
            CleanViewFields();
        }
        private void CleanViewFields()
        {
            _entryOperationView.EntryName = string.Empty;
            _entryOperationView.EntryPassword = string.Empty;
            _entryOperationView.EntryTitle = string.Empty;
            _entryOperationView.EntryUrl = string.Empty;
        }
    }
}
