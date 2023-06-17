using Google.Cloud.Firestore.V1;
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
using Google.Cloud.Storage.V1;

namespace InventorySystemGalaxy
{
    public partial class EmployeeForm : Form
    {
        FirestoreDb db;

        public EmployeeForm()
        {
            InitializeComponent();

        }



        private void customButton1_Click(object sender, EventArgs e)
        {
            EmployeeModalForm employeeModalForm = new EmployeeModalForm();
            employeeModalForm.ShowDialog();
            this.Hide();
        }




        async void DisplayData()
        {
            /*Query productQuery = db.Collection("Products");
            QuerySnapshot querySnap = await productQuery.GetSnapshotAsync();

            WarehouseTable.Rows.Clear();

            foreach (DocumentSnapshot documentSnapshot in querySnap.Documents)
            {
                ProductData productData = documentSnapshot.ConvertTo<ProductData>();
                WarehouseTable.Rows.Add(productData.Sort, productData.Item_code, productData.Ref_code);
            }*/

            CollectionReference collectionRef = db.Collection("Employee");
            QuerySnapshot snapshot = await collectionRef.GetSnapshotAsync();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("First Name");
            dataTable.Columns.Add("Middle Name");
            dataTable.Columns.Add("Last Name");
            dataTable.Columns.Add("Status");
            dataTable.Columns.Add("Department");
            dataTable.Columns.Add("Position");
            dataTable.Columns.Add("Username");
            dataTable.Columns.Add("Password");
            dataTable.Columns.Add("Contact No.");
            dataTable.Columns.Add("ID number");
            dataTable.Columns.Add("Image", typeof(Image));



            // dataTable.Columns.Add("Image", typeof(Image));


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



                    // byte[] imageData = Convert.FromBase64String(data["imageUrl"].ToString());
                    //Image image = byteArrayToImage(imageData);
                    dataTable.Rows.Add(data["FirstName"], data["MiddleName"], data["LastName"], data["Status"], data["Department"],
                        data["Position"], data["Username"], data["Password"], data["ContactNo"], data["IdNumber"], downloadedImage);
                    // Add more fields as needed
                }
            }
            /*WarehouseTable.Columns["Image"].DefaultCellStyle = new DataGridViewCellStyle()
            {

                Alignment = DataGridViewContentAlignment.MiddleCenter,
                Padding = new Padding(5),
                //ImageLayout = DataGridViewImageCellLayout.Zoom
            };*/

            employeeTable.DataSource = dataTable;

        }

        private Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private async void EmployeeForm_Load(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"ims-firestore.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            db = FirestoreDb.Create("imsgalaxy-f7419");
            DisplayData();

        }
    }
}
