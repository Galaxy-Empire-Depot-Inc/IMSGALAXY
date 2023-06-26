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
            if (username == "Admin")
            {


                Application.Run(new HomeScreenForm());
            }
            else
            {
                Application.Run(new EmployeeHomeScreenForm());
            }
        }

        async void LoadUserName()
        {
            DocumentReference documentReference = db.Collection("Admin_User").Document(LoginForm.username);
            DocumentSnapshot documentSnapshot = await documentReference.GetSnapshotAsync();
             username = documentSnapshot.GetValue<string>("Username");
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