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
<<<<<<< HEAD
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            //FireStoreHelper.SetEnvironmentVariable();
            ApplicationConfiguration.Initialize();
            Application.Run(new SplashScreen());
 
=======
            ApplicationConfiguration.Initialize();
            Application.Run(new EmployeeForm());


>>>>>>> 237cdd8127faa25b149fc488e5db276b425f8d92


        }
    }
}