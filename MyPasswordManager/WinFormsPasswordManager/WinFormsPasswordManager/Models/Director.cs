using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsPasswordManager.Models
{
    public class Director
    {
        private IBuilder _builder;
        private bool _bigLetters;
        private bool _digits;
        private int _length;
        private bool _specialCharacters;
        private bool _smallLettres;
        public Director(IBuilder builder)
        {
            _builder = builder;
        }

        public string MakePasswordWithFlags()
        {
            return null;
        }
    }
}
