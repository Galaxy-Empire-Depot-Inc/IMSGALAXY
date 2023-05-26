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
            ApplicationConfiguration.Initialize();
<<<<<<< HEAD
            Application.Run(new SplashScreen());
=======
            Application.Run(new WelcomeMessageForm());
>>>>>>> 4dbb8c15b58cf595efcd2b139a6f0264aadd6b7d
        }
    }
}