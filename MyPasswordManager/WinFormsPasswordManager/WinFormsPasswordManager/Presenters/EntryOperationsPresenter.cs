using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsPasswordManager.Views;
using WinFormsPasswordManager.Models;

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
            // this._entryOperationView.EditEvent += Edit;
            this._entryOperationView.DeleteEvent += Delete;
            this._entryOperationView.SearchEvent += Search;
            
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
                _entryOperationView.Message = "Delete operation Failed";
            }
        }

        private void Edit(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Create(object sender, EventArgs e)
        {
            string title = _entryOperationView.EntryName.Trim();
            string password = _entryOperationView.EntryPassword.Trim();
            string name = _entryOperationView.EntryName.Trim();
            string url = _entryOperationView.EntryUrl;
            string notes = _entryOperationView.EntryNotes;
            if (!(string.IsNullOrEmpty(title) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(name)) )
            {
                
                var entryToAdd = new Entry(title, password, name, url, notes, DateTime.Now);
                _entryOperation.Create(entryToAdd);
                this._entryOperationView.Message = "Entry created";
                LoadAllEntriesList();
            }
            else
            {
                this._entryOperationView.Message = "title, password and name are mandatory";
            }
            

        }
    }
}
