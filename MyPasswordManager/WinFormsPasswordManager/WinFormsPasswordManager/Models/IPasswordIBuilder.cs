using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsPasswordManager.Models
{
    public interface IPasswordIBuilder
    {
        public void AddSmallLetters(bool make);
        public void AddBigLetters(bool make);
        public void AddNumbers(bool make);
        public void SetLength(int length);
        public void AddSpecialCharacters(bool make);
        public void AddBrackets(bool make);
        public void Generate();
        public string GetResult();
        
    }
}
