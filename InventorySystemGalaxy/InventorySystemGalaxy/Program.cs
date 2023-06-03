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
            //FireStoreHelper.SetEnvironmentVariable();
            ApplicationConfiguration.Initialize();
            Application.Run(new SplashScreen());
           // Application.Run(new HomeScreenForm());
=======
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
>>>>>>> dc3502728d3742ed5d119e66b29bd8274b0552c0

            //Application.Run(new HomeScreenForm());


        }
    }
}