using Google.Cloud.Firestore;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystemGalaxy
{
    public partial class DashboardForm : Form
    {

        FirestoreDb db;

        public DashboardForm()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

            string path = AppDomain.CurrentDomain.BaseDirectory + @"ims-firestore.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            db = FirestoreDb.Create("imsgalaxy-f7419");
            Display();

        }

        async void Display()
        {
            // Specify the collection reference for which you want to count the documents
            CollectionReference collectionRef = db.Collection("Products");

            // Query for all documents in the collection
            QuerySnapshot snapshot = await collectionRef.GetSnapshotAsync();

            // Get the count of documents in the snapshot
            int documentCount = snapshot.Count;

            // Assuming you have a Label control named "lblCount" in your form
            // Set the count as the text of the label
            lbl_TotalP.Text = documentCount.ToString();
        }

    }
 
}

