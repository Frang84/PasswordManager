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
            // this._entryOperationView.EditEvent += Edit();
            //this._entryOperationView.DeleteEvent += Delete();
            //this._entryOperationView.SearchEvent += Search();
            
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
            throw new NotImplementedException();
        }

        private void Delete(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Edit(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Create(object sender, EventArgs e)
        {
            string title = _entryOperationView.EntryName;
            string password = _entryOperationView.EntryPassword;
            string name = _entryOperationView.EntryName;
            string url = _entryOperationView.EntryUrl;
            string notes = _entryOperationView.EntryNotes;
            var entryToAdd = new Entry(title, password, name, url, notes, DateTime.Now);
            _entryOperation.Create(entryToAdd);
            LoadAllEntriesList();

        }
    }
}
