using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsPasswordManager.Models
{
    public class PasswordGenerator : WinFormsPasswordManager.Models.IPasswordIBuilder
    {
        private string _password;
        private int _length;
        private string _symbolPool;
        private readonly string _smallLetters;
        
        PasswordGenerator()
        {
            _password = string.Empty;
            _symbolPool = string.Empty;
            _smallLetters = "abcdefghijklmnopiqrstuvwxyz";
            
        }
        public void AddBigLetters(bool make)
        {
            if (make)
            {
                _symbolPool += _smallLetters.ToUpper();
            }
        }

        public void AddNumbers(bool make)
        {
            if (make)
            {
                _symbolPool += "0123456789";
            }
        }

        public void AddSmallLetters(bool make)
        {
            if (make)
            {
                _symbolPool += _smallLetters;
            }
        }

        public void AddSpecialCharacters(bool make)
        {
            if (make)
            {
                _symbolPool += "!@#$%^&*";
            }
        }

        public void SetLength(int length)
        {
            _length = length;
        }
        public void Generate()
        {
            for (int i = 0; i < _length; i++)
            {
                int random = RandomNumberGenerator.GetInt32(_symbolPool.Length);
                _password += _symbolPool[random];
            }
            
        }
        public void Reset()
        {
            _length = 0;
            _password = string.Empty;
            _symbolPool = string.Empty;

        }
        public string GetResult()
        {
            return _password;
        }
    }
}
