namespace InventorySystemGalaxy
{
    public partial class WelcomeMessageForm : Form
    {

        Thread thread;
        public WelcomeMessageForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public void openForm(object obj)
        {
            Application.Run(new HomeScreenForm());
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
            LoginForm LoginForm = new LoginForm();
            LoginForm.Hide();
            thread = new Thread(openForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            
            /*HomeScreenForm HMSF = new HomeScreenForm();
            HMSF.ShowDialog();
            LoginForm LoginForm = new LoginForm();
            this.Close();
            LoginForm.Close();*/
        }
    }
}