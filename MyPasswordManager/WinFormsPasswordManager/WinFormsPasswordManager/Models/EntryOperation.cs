using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsPasswordManager.Models;

namespace WinFormsPasswordManager.Models
{
    public class EntryOperation
    {
        private ISearchEngine _searchEngine;
        private Director _passwordGenerator;
        private List<Entry> _entryList;
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
        public void Search()
        {

        }
        public void Create()
        {

        }
        public List<Entry> GetEntries()
        {
            List<Entry> result = new List<Entry> ();
            
            foreach (Entry entry in _entryList) 
            {
                result.Add (new Entry(entry.Title, entry.Password, entry.UserName, entry.Url, entry.Notes, entry.DateOfLastChange));
            }
            return result;
        }
    }
}
