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
            Application.Run(new HomeScreenForm());
>>>>>>> bf6e96075adcfe91673b24b028256b84390ec8ec

        }
    }
}