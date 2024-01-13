using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsPasswordManager.Models
{
    public class Entry
    {

        public long Id { get; set; }
        private string _title;
        private string _password;
        private string _userName;
        private string _url;
        private string _notes;
        private DateTime _dateOfLastChange;

        public Entry(string title, string password, string userName, string url, string notes, DateTime dateOfLastChange)
        {
            Title = title;
            Password = password;
            UserName = userName;
            Url = url;
            Notes = notes;
            DateOfLastChange = dateOfLastChange;
        }
       

        public string Title { get => _title; set => _title = value; }
        public string Password { get => _password; set => _password = value; }
        public string UserName { get => _userName; set => _userName = value; }
        public string Url { get => _url; set => _url = value; }
        public string Notes { get => _notes; set => _notes = value; }
        public DateTime DateOfLastChange { get => _dateOfLastChange; set => _dateOfLastChange = value; }
    }
}
