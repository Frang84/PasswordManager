using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsPasswordManager.Models;


namespace WinFormsPasswordManager.Repository
{
    public class EntriesContext : DbContext
    {
        public DbSet<Entry> Entries { get; set; }
       // private static bool _created = false;
        //public EntriesContext()
        //{
        //    _created = true;
        //    Database.EnsureDeleted();
        //    Database.EnsureCreated();

        //}
    
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyKey"].ConnectionString;
            optionsBuilder.UseSqlite(connectionString);  
        }
       
    }
}
