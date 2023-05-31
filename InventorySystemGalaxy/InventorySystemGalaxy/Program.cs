using InventorySystemGalaxy.Classes;

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

<<<<<<< HEAD
            Application.Run(new SplashScreen());
=======
<<<<<<< HEAD
            FireStoreHelper.SetEnvironmentVariable();
            ApplicationConfiguration.Initialize();
            Application.Run(new SplashScreen());
           // Application.Run(new HomeScreenForm());
=======
            Application.Run(new HomeScreenForm());
>>>>>>> 9f8b4407e6595af3b51886765d86c538b49dad1f

>>>>>>> 2a7d7ab1dcc210f83795b885c096ecd9bec17bcc

        }
    }
}