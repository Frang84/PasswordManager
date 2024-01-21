using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsPasswordManager.Models;
using WinFormsPasswordManager.Repository;

namespace WinFormsPasswordManager.Models
{
    public class SearchUserName : ISearchEngine
    {
        public List<Entry> Search(string userName)
        {
            List<Entry> entries = new List<Entry>();
            using(var contex = new EntriesContext()) 
            { 
                 entries = contex.Entries.Where(e => e.UserName.StartsWith(userName)).ToList();
            }
            return entries;
        }
    }
}
