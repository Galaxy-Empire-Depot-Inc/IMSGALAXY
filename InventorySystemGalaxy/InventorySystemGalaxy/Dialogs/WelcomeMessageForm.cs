using Google.Cloud.Firestore;
using Google.Cloud.Firestore.V1;

namespace InventorySystemGalaxy
{

    public partial class WelcomeMessageForm : Form
    {
        FirestoreDb db;
        Thread thread;
        string username;
        public WelcomeMessageForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            
        }

        public void openForm(object obj)
        {
            if (LoginForm.username == "Admin")
            {
                Application.Run(new HomeScreenForm());
            }
            else
            {
                Application.Run(new EmployeeHomeScreenForm());
            }

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

        private void WelcomeMessageForm_Load(object sender, EventArgs e)
        {

            string path = AppDomain.CurrentDomain.BaseDirectory + @"ims-firestore.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            db = FirestoreDb.Create("imsgalaxy-f7419");
        }
    }
}