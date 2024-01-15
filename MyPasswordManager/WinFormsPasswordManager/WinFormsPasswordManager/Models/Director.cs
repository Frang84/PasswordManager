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
            _builder.AddBigLetters(true);
            _builder.AddSmallLetters(true);
            _builder.AddNumbers(true);
            _builder.AddSpecialCharacters(false);
            _builder.SetLength(20);
            _builder.Generate();
            string result = _builder.GetResult();
            return result;
        }
        public string GenerateAdvancedPassword(bool smallLetters, bool numbers, bool specialCharacters,bool brackets ,int length)
        {
            _builder.AddBigLetters(true);
            _builder.AddSmallLetters(smallLetters);
            _builder.AddNumbers(numbers);
            _builder.AddBrackets(brackets);
            _builder.AddSpecialCharacters(specialCharacters);
            _builder.SetLength(length);
            _builder.Generate();
            return _builder.GetResult();
        }
    }
}
