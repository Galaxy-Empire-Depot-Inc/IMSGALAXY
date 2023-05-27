namespace InventorySystemGalaxy
{
    public partial class SplashScreen : Form
    {

        public SplashScreen()
        {
            InitializeComponent();
        }

        private void progressBarTick_Tick(object sender, EventArgs e)
        {
            progressBar.Width += 3;
            if (progressBar.Width >= 784)
            {
                progressBarTick.Stop();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();

            }
        }
    }
}