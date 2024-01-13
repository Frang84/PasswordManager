using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsPasswordManager;

namespace WinFormsPasswordManager.Models
{
    public class PasswordQualitySafe : IPasswordQuality
    {
        public int Quality()
        {
            throw new NotImplementedException();
        }
    }
}
