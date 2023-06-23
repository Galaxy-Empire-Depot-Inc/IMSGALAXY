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
        DataTable tableEmployee;
        string bucketName = "imsgalaxy-f7419.appspot.com";
        private List<DocumentSnapshot> data;



        public EmployeeForm()
        {
            InitializeComponent();

        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            EmployeeModalForm employeeModalForm = new EmployeeModalForm();
            employeeModalForm.ShowDialog();
        }


        async void DisplayEmployeeTable()
        {
            CollectionReference employeeRef = db.Collection("Employees");
            QuerySnapshot querySnap = await employeeRef.GetSnapshotAsync();

            tableEmployee = new DataTable();
            tableEmployee.Columns.Add("Image", typeof(Image));
            tableEmployee.Columns.Add("ID number");
            tableEmployee.Columns.Add("Department");
            tableEmployee.Columns.Add("First Name");
            tableEmployee.Columns.Add("Middle Name");
            tableEmployee.Columns.Add("Last Name");
            tableEmployee.Columns.Add("Contact No.");
            tableEmployee.Columns.Add("Username");
            tableEmployee.Columns.Add("Password");
            tableEmployee.Columns.Add("Status");

            foreach (DocumentSnapshot documentSnapshot in querySnap.Documents)
            {

                string imageUrl = documentSnapshot.GetValue<string>("imageUrl");

                if (documentSnapshot.Exists)
                {
                    var data = documentSnapshot.ToDictionary();

                    var storageClient = StorageClient.Create();
                    string fileName = Path.GetFileName(imageUrl);
                    var downloadStream = new MemoryStream();
                    storageClient.DownloadObject(bucketName, fileName, downloadStream);
                    downloadStream.Position = 0;
                    Image downloadedImage = Image.FromStream(downloadStream);

                    tableEmployee.Rows.Add(downloadedImage, data["IdNumber"], data["Department"], data["FirstName"], data["MiddleName"], data["LastName"], data["ContactNo"]
                        , data["Username"], data["Password"], data["Status"]);

                }

                // Handle the CellFormatting event
                employeeTable.CellFormatting += DataGridView1_CellFormatting;
                employeeTable.DataSource = tableEmployee;

            }
        }

        private void DataGridView1_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (employeeTable.Columns[e.ColumnIndex].Name == "Image" && e.Value != null)
            {
                // Set the image cell style to zoom
                DataGridViewImageCell cell = (DataGridViewImageCell)employeeTable.Rows[e.RowIndex].Cells[e.ColumnIndex];
                cell.ImageLayout = DataGridViewImageCellLayout.Stretch;
            }
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"ims-firestore.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            db = FirestoreDb.Create("imsgalaxy-f7419");

            DisplayEmployeeTable();
        }

        private void employeeTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EmployeeModalForm employeeModalForm = new EmployeeModalForm();

            employeeModalForm.add_UpdateBtn.Text = "Update";

            //Display the Data into Modal
            employeeModalForm.idNumberTextBox.Text = this.employeeTable.CurrentRow.Cells["ID number"].Value.ToString();
            employeeModalForm.departmentTextBox.Text = this.employeeTable.CurrentRow.Cells["Department"].Value.ToString();
            employeeModalForm.firstNameTextBox.Text = this.employeeTable.CurrentRow.Cells["First Name"].Value.ToString();
            employeeModalForm.middleNameTextBox.Text = this.employeeTable.CurrentRow.Cells["Middle Name"].Value.ToString();
            employeeModalForm.lastNameTextBox.Text = this.employeeTable.CurrentRow.Cells["Last Name"].Value.ToString();
            employeeModalForm.contactNoTextBox.Text = this.employeeTable.CurrentRow.Cells["Contact No."].Value.ToString();
            employeeModalForm.usernameTextbox.Text = this.employeeTable.CurrentRow.Cells["Username"].Value.ToString();
            employeeModalForm.passwordTextbox.Text = this.employeeTable.CurrentRow.Cells["Password"].Value.ToString();

            //get value from custombox
            string statusSelected = this.employeeTable.CurrentRow.Cells["Status"].Value.ToString();
            string departmentSelected = this.employeeTable.CurrentRow.Cells["Department"].Value.ToString();

            if (statusSelected == "active")
            {
                employeeModalForm.statusComboBox.SelectedIndex = 1;
            }

            if (statusSelected == "inactive")
            {
                employeeModalForm.statusComboBox.SelectedIndex = 0;
            }

            //display image when row selected
            if (e.RowIndex >= 0 && employeeTable.Rows[e.RowIndex].Cells["Image"].Value is System.Drawing.Image)
            {
                // Retrieve the image from the selected row
                System.Drawing.Image selectedImage = (System.Drawing.Image)employeeTable.Rows[e.RowIndex].Cells["Image"].Value;

                // Display the image in the PictureBox
                employeeModalForm.employeePB.Image = selectedImage;
            }

            employeeModalForm.ShowDialog(this);
        }
    }
}
