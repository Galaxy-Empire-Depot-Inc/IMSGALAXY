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
>>>>>>> ab80740c571ba39f68ead8380ef10712b4524abd

            Application.Run(new SplashScreen());




        }
    }
}