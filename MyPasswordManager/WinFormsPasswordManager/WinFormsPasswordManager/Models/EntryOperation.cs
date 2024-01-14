using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsPasswordManager.Models;
using WinFormsPasswordManager.Repository;
using WinFormsPasswordManager.Views;

namespace WinFormsPasswordManager.Models
{
    public class EntryOperation
    {
        private ISearchEngine _searchEngine;
        private Director _passwordGenerator;
        private List<Entry> _entryList;

        public EntryOperation()
        {
            _entryList = new List<Entry>();
        }
        
        public EntryOperation(List<Entry> entryList)
        {
            _entryList = entryList;
        }
        public EntryOperation(List<Entry> entryList,Director passwordGenerator, ISearchEngine searchEngine)
        {
            _entryList = entryList;
            _passwordGenerator = passwordGenerator;
            _searchEngine = searchEngine;

        }
        public void Edit()
        {

        }
        public void Delete() 
        {

        }
        public List<Entry> Search(string searchValue)
        {
            List<Entry> result = null;
            using(var contex = new EntriesContext())
            {
                result = contex.Entries.Where(e => e.Title.StartsWith(searchValue)).ToList();
            }
            return result;
        }
        public void Create(Entry toCreate)
        {

            using (var context = new EntriesContext())
            {
                context.Add(toCreate);
                context.SaveChanges();
            }

        }
        public List<Entry> GetEntries()
        {
            List<Entry> result = null;
            using(var context = new EntriesContext())
            {
                result = context.Entries.ToList();
            }
            return result;
        }
    }
}
