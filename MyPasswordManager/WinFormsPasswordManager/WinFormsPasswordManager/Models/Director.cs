using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsPasswordManager.Models
{
    public class Director
    {
        private IPasswordIBuilder _builder;
        private bool _bigLetters;
        private bool _digits;
        private int _length;
        private bool _specialCharacters;
        private bool _smallLettres;
        public Director(IPasswordIBuilder builder)
        {
            _builder = builder;
        }
        public void ChangeDirector(IPasswordIBuilder builder)
        {
            _builder = builder;
        }

        public string GenerateBasicPassword()
        {
            return null;
        }
        public string GenerateAdvancedPassword()
        {
            return null;
        }
    }
}
