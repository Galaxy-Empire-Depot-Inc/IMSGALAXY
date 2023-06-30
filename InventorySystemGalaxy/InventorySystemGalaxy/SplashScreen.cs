using System.Threading;

namespace InventorySystemGalaxy
{
    public partial class SplashScreen : Form
    {
        Thread thread;
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
                /* LoginForm loginForm = new LoginForm();
                 loginForm.Show();
                 this.Hide();*/
                this.Close();
                LoginForm LoginForm = new LoginForm();
                LoginForm.Hide();
                thread = new Thread(openForm);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }


        }
        public void openForm(object obj)
        {
            Application.Run(new LoginForm());
        }
    }
}