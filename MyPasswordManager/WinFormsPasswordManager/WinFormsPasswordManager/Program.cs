using WinFormsPasswordManager.Views;
using WinFormsPasswordManager.Models;
using WinFormsPasswordManager.Presenters;
namespace WinFormsPasswordManager
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            
            
            List<Entry> entries = new List<Entry> { 
            new Entry("Onet", "abcd", "Marek", "www.one.pl", "haslo do onet", DateTime.Now),
            new Entry("Onet", "abcd", "Marek", "www.one.pl", "haslo do onet", DateTime.Now),
            new Entry("Onet", "abcd", "Marek", "www.one.pl", "haslo do onet", DateTime.Now)
            };
            EntryOperation entryOperation = new EntryOperation(entries);
            EntryView view = new EntryView();
            EntryOperationsPresenter presenter = new EntryOperationsPresenter(view, entryOperation);

            Application.Run(view);
        }
    }
}