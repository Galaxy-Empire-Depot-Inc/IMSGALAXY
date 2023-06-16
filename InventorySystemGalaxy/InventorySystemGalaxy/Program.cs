using InventorySystemGalaxy.Classes;
using Google.Cloud.Firestore;

namespace InventorySystemGalaxy
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

            //FireStoreHelper.SetEnvironmentVariable();
            ApplicationConfiguration.Initialize();
<<<<<<< HEAD
            Application.Run(new LoginForm());
=======
            Application.Run(new EmployeeForm());
>>>>>>> c5c6ecb25ff6e873faac66dd003d4aaf5a525229
 

            //ApplicationConfiguration.Initialize();
            //Application.Run(new EmployeeForm());



        }
    }
}