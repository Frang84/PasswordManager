using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsPasswordManager.Models
{
    public interface IBuilder
    {
        public void reset();
        public void AddSmallLetters();
        public void AddBigLetters();
        public void AddSpecialCharacters();
        public void setLength();
        public string BuildBasicPassword();
        public string BuildAdvancedPassword();
    }
}
