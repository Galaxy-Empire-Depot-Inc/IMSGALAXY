using Google.Cloud.Firestore;
using Google.Cloud.Storage.V1;
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

        DataTable dataTable;

        public DashboardForm()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

            string path = AppDomain.CurrentDomain.BaseDirectory + @"ims-firestore.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            db = FirestoreDb.Create("imsgalaxy-f7419");
            DisplayTotalProduct();
            TotalAvailableProduct();
            DisplayProduct();
            //DisplayDamage();

        }

        async void DisplayTotalProduct()
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
            TotalProductTable();
        }

        async void TotalAvailableProduct()
        {

            // Create a query to filter documents where the field contains the specified value
            Query query = db.Collection("Products").WhereEqualTo("Available", "Yes");

            // Execute the query and get the count of matching documents
            QuerySnapshot snapshot = await query.GetSnapshotAsync();
            int count = snapshot.Count;

            lbl_AvailableP.Text = count.ToString();
        }


        async void DisplayProduct()
        {

            // Create a query to filter documents where the field contains the specified value
            Query query = db.Collection("Products").WhereEqualTo("Display", "Yes");

            // Execute the query and get the count of matching documents
            QuerySnapshot snapshot = await query.GetSnapshotAsync();
            int count = snapshot.Count;

            lbl_DisplayP.Text = count.ToString();
        }

        async void DisplayDamage()
        {
            /*Query query = db.Collection("Products");

            List<string> fieldValues = new List<string>();

            QuerySnapshot snapshot = await query.GetSnapshotAsync();
            foreach (DocumentSnapshot documentSnapshot in snapshot.Documents)
            {
                if (documentSnapshot.Exists)
                {
                    if (documentSnapshot.TryGetValue("Repair", out object fieldValue))
                    {
                        fieldValues.Add(fieldValue.ToString());
                    }
                }
            }

            lbl_DamageP.Text = fieldValues.ToString();*/

        }

        private void btn_AvailableP_Click(object sender, EventArgs e)
        {
            AvailableProductTable();
        }

        private void btn_DamageP_Click(object sender, EventArgs e)
        {

        }

        private void btn_DisplayP_Click(object sender, EventArgs e)
        {
            DisplayProductTable();
        }

        private void btn_TotalP_Click(object sender, EventArgs e)
        {
            TotalProductTable();
        }

        async void TotalProductTable()
        {
            CollectionReference collectionRef = db.Collection("Products");
            QuerySnapshot snapshot = await collectionRef.GetSnapshotAsync();

            dataTable = new DataTable();
            dataTable.Columns.Add("Image", typeof(Image));
            dataTable.Columns.Add("Item Code");
            dataTable.Columns.Add("Category");
            dataTable.Columns.Add("Description");

            foreach (DocumentSnapshot documentSnapshot in snapshot.Documents)
            {

                string imageUrl = documentSnapshot.GetValue<string>("imageUrl");

                if (documentSnapshot.Exists)
                {
                    var data = documentSnapshot.ToDictionary();

                    var storageClient = StorageClient.Create();
                    string fileName = Path.GetFileName(imageUrl);
                    var downloadStream = new MemoryStream();
                    storageClient.DownloadObject("imsgalaxy-f7419.appspot.com", fileName, downloadStream);
                    downloadStream.Position = 0;
                    Image downloadedImage = Image.FromStream(downloadStream);
                    dataTable.Rows.Add(downloadedImage, data["Item_code"], data["Category"], data["Description"]);
                    // Add more fields as needed
                }
            }

            // Handle the CellFormatting event
            TableProduct.CellFormatting += DataGridView1_CellFormatting;
            TableProduct.DataSource = dataTable;
        }

        async void AvailableProductTable()
        {
            //CollectionReference collectionRef = db.Collection("Products");
            Query query = db.Collection("Products").WhereEqualTo("Available", "Yes");
            QuerySnapshot snapshot = await query.GetSnapshotAsync();

            dataTable = new DataTable();
            dataTable.Columns.Add("Image", typeof(Image));
            dataTable.Columns.Add("Item Code");
            dataTable.Columns.Add("Category");
            dataTable.Columns.Add("Available");

            foreach (DocumentSnapshot documentSnapshot in snapshot.Documents)
            {

                string imageUrl = documentSnapshot.GetValue<string>("imageUrl");

                if (documentSnapshot.Exists)
                {
                    var data = documentSnapshot.ToDictionary();

                    var storageClient = StorageClient.Create();
                    string fileName = Path.GetFileName(imageUrl);
                    var downloadStream = new MemoryStream();
                    storageClient.DownloadObject("imsgalaxy-f7419.appspot.com", fileName, downloadStream);
                    downloadStream.Position = 0;
                    Image downloadedImage = Image.FromStream(downloadStream);
                    dataTable.Rows.Add(downloadedImage, data["Item_code"], data["Category"], data["Available"]);
                    // Add more fields as needed
                }
            }

            // Handle the CellFormatting event
            TableProduct.CellFormatting += DataGridView1_CellFormatting;
            TableProduct.DataSource = dataTable;
        }


        async void DisplayProductTable()
        {
            //CollectionReference collectionRef = db.Collection("Products");
            Query query = db.Collection("Products").WhereEqualTo("Display", "Yes");
            QuerySnapshot snapshot = await query.GetSnapshotAsync();

            dataTable = new DataTable();
            dataTable.Columns.Add("Image", typeof(Image));
            dataTable.Columns.Add("Item Code");
            dataTable.Columns.Add("Category");
            dataTable.Columns.Add("Display");

            foreach (DocumentSnapshot documentSnapshot in snapshot.Documents)
            {

                string imageUrl = documentSnapshot.GetValue<string>("imageUrl");

                if (documentSnapshot.Exists)
                {
                    var data = documentSnapshot.ToDictionary();

                    var storageClient = StorageClient.Create();
                    string fileName = Path.GetFileName(imageUrl);
                    var downloadStream = new MemoryStream();
                    storageClient.DownloadObject("imsgalaxy-f7419.appspot.com", fileName, downloadStream);
                    downloadStream.Position = 0;
                    Image downloadedImage = Image.FromStream(downloadStream);
                    dataTable.Rows.Add(downloadedImage, data["Item_code"], data["Category"], data["Display"]);
                    // Add more fields as needed
                }
            }

            // Handle the CellFormatting event
            TableProduct.CellFormatting += DataGridView1_CellFormatting;
            TableProduct.DataSource = dataTable;
        }

        private void DataGridView1_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (TableProduct.Columns[e.ColumnIndex].Name == "Image" && e.Value != null)
            {
                // Set the image cell style to zoom
                DataGridViewImageCell cell = (DataGridViewImageCell)TableProduct.Rows[e.RowIndex].Cells[e.ColumnIndex];
                cell.ImageLayout = DataGridViewImageCellLayout.Stretch;
            }
        }

    }

}

