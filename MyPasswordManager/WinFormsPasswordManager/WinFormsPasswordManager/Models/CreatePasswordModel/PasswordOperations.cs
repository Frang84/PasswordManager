using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using WinFormsPasswordManager.Repository;

namespace WinFormsPasswordManager.Models.CreatePasswordModel
{
    public class PasswordOperations
    {
        public PasswordOperations() { }
        public void Add(DatabasePassword password) 
        { 
            using(var contex = new EntriesContext())
            {
                contex.Password.Add(password);
                contex.SaveChanges();
            }
        }
        public void HashPassword(DatabasePassword password)
        {
            using(SHA256 sHA256 = SHA256.Create())
            {
                byte[] bytes = sHA256.ComputeHash(Encoding.UTF8.GetBytes(password.Password));
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    sb.Append(bytes[i].ToString("x2"));
                }
                password.Password = sb.ToString();
            }
        }
    }
}
