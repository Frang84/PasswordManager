using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsPasswordManager.Views
{
    public interface IPasswordGeneratorView
    {
        public bool BigLetters { get; set; }
        public bool SmallLetters { get; set; }
        public bool Numbers {  get; set; }
        public bool SpecialCharacters {  get; set; }    
        public bool Brackets {  get; set; }
        public int Length { get; set; }
    }
}
