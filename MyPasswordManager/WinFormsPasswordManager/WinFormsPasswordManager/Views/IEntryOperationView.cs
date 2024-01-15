﻿ using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsPasswordManager.Views
{
    public interface IEntryOperationView
    {
        public long Id { get; set; }
        public string EntryTitle { get; set; }
        public string EntryPassword { get; set; }
        public string EntryName { get; set; }
        public string EntryUrl { get; set; }
        public string EntryNotes {  get; set; }
        public string SearchValue { get; set; }
        public string Message {  get; set; }
        public bool IsEdit {  get; set; }
        //public bool SearchByNameOrTitle { get; set; }

        

        event EventHandler SearchEvent;
        event EventHandler DeleteEvent;
        event EventHandler EditEvent;
        event EventHandler CreateEvent;
        event EventHandler SaveEvent;
        event EventHandler PasswordGenerateEvent;

        void SetEntryListBindingSource(BindingSource entryList);
        
    }
}
