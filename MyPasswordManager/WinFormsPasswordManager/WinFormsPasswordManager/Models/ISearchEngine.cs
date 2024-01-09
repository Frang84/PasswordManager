using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsPasswordManager.Models;

namespace WinFormsPasswordManager.Models
{
    public interface ISearchEngine
    {
        public Entry Search();
    }
}
