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
        
    
      
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyKey"].ConnectionString;
            optionsBuilder.UseSqlite(connectionString);
            //optionsBuilder.UseSqlite(@"Data Source=C:\studia\rokIII\Vsemestr\wzorceProjektowe\Projekt\wszystko\PasswordManager\MyPasswordManager\WinFormsPasswordManager\WinFormsPasswordManager\Repository\entries.db;");
        }
       
    }
}
