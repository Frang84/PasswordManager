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

            IPasswordIBuilder passwordIBuilder = new PasswordGenerator();
            Director director = new Director(passwordIBuilder);
            EntryOperation entryOperation = new EntryOperation(director, null);
            EntryView view = new EntryView();
            DatabaseOperations databaseOperations = new DatabaseOperations();
            EntryOperationsPresenter presenter = new EntryOperationsPresenter(view, entryOperation, databaseOperations);


            Application.Run(view);
        }
    }
}