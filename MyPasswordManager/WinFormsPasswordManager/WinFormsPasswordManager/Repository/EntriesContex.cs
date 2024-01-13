using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsPasswordManager.Models;


namespace WinFormsPasswordManager.Repository
{
    public class EntriesContex : DbContext
    {
        public DbSet<Entry> Entries { get; set; }
        
    
        
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlite($"Data Source=C:\\studia\\rokIII\\Vsemestr\\wzorceProjektowe\\Projekt\\wszystko\\PasswordManager\\MyPasswordManager\\WinFormsPasswordManager\\WinFormsPasswordManager\\Repository\\entries.db");
        }
       
    }
}
