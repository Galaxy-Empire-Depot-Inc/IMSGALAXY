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
using DGVPrinterHelper;
using Microsoft.Office.Interop.Excel;
using Microsoft.VisualBasic;
using PdfSharp.Charting;

namespace InventorySystemGalaxy
{
    public partial class EmployeeForm : Form
    {
        FirestoreDb db;
        System.Data.DataTable tableEmployee;
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

            tableEmployee = new System.Data.DataTable();
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
            if (e.ColumnIndex == 0)
            {
                // Set the image cell style to zoom
                /*DataGridViewImageCell cell = (DataGridViewImageCell)employeeTable.Rows[e.RowIndex].Cells[e.ColumnIndex];
                cell.ImageLayout = DataGridViewImageCellLayout.Stretch;*/

                if (e.Value is Image image)
                {
                    e.Value = ResizeImage(image, 100, 100);
                    e.FormattingApplied = true;
                }
            }
        }

        private Image ResizeImage(Image image, int width, int height)
        {
            Bitmap resizedImage = new Bitmap(width, height);
            using (Graphics graphics = Graphics.FromImage(resizedImage))
            {
                graphics.DrawImage(image, 0, 0, width, height);
            }
            return resizedImage;
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"ims-firestore.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            db = FirestoreDb.Create("imsgalaxy-f7419");
            positionComboBox.SelectedIndex = 0;
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

        private void customButton2_Click(object sender, EventArgs e)
        {

            /*

             DGVPrinter dGVPrinter = new DGVPrinter();
             dGVPrinter.Title = "Employees";
             dGVPrinter.SubTitle = string.Format("Date:{0}", System.DateTime.Now.Date.ToString("MM/dd/yyyy"));
             dGVPrinter.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
             dGVPrinter.PageNumbers = true;
             dGVPrinter.PageNumberInHeader = false;
             dGVPrinter.PorportionalColumns = true;
             dGVPrinter.HeaderCellAlignment = StringAlignment.Near;
             dGVPrinter.Footer = "Galaxy Empire Depot Inc.";
             dGVPrinter.FooterSpacing = 5;
             dGVPrinter.RowHeight = (DGVPrinter.RowHeightSetting)50;
             dGVPrinter.ColumnWidth = (DGVPrinter.ColumnWidthSetting)50;
             DataGridViewAutoSizeColumnMode[] columnModes = new DataGridViewAutoSizeColumnMode[employeeTable.Columns.Count];
             for (int i = 0; i < employeeTable.Columns.Count; i++)
             {
                 columnModes[i] = employeeTable.Columns[i].AutoSizeMode;
             }

             // Set the AutoSizeMode of the columns to Fill
             for (int i = 0; i < employeeTable.Columns.Count; i++)
             {
                 employeeTable.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
             }

             // Print the DataGridView
             // ... Your existing code for printing the DataGridView ...

             // Restore the original AutoSizeMode of the columns
             for (int i = 0; i < employeeTable.Columns.Count; i++)
             {
                 employeeTable.Columns[i].AutoSizeMode = columnModes[i];
             }
             dGVPrinter.PrintPreviewDataGridView(employeeTable);
             dGVPrinter.PrintDataGridView(employeeTable);*/

        }

        private void positionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (positionComboBox.SelectedIndex == 0)
            {
                DisplayEmployeeTable();
            }

            if (positionComboBox.SelectedIndex == 1)
            {
                MessageBox.Show("Accounting");
                AccountDept();
            }
            if (positionComboBox.SelectedIndex == 2)
            {
                MessageBox.Show("Customer Service");
                Customer_Service();
            }
            if (positionComboBox.SelectedIndex == 3)
            {
                MessageBox.Show("Information Technology");
                Information_Technology();
            }
            if (positionComboBox.SelectedIndex == 4)
            {
                MessageBox.Show("Sales Supervisor");
                Sales_Supervisor();
            }
            if (positionComboBox.SelectedIndex == 5)
            {
                MessageBox.Show("Warehouse Manager");
                Warehouse_Manager();
            }
            if (positionComboBox.SelectedIndex == 6)
            {
                MessageBox.Show("Warehouse Staff");
                Warehouse_Staff();
            }
            if (positionComboBox.SelectedIndex == 7)
            {
                MessageBox.Show("HR Manager");
                HR_Manager();
            }
        }


        async void AccountDept()
        {
            //CollectionReference collectionRef = db.Collection("Products");
            Query query = db.Collection("Employees").WhereEqualTo("Department", "Accounting Department");
            QuerySnapshot snapshot = await query.GetSnapshotAsync();

            tableEmployee = new System.Data.DataTable();
            tableEmployee.Columns.Add("Image", typeof(Image));
            tableEmployee.Columns.Add("ID number");
            tableEmployee.Columns.Add("Department");
            tableEmployee.Columns.Add("Position");
            tableEmployee.Columns.Add("First Name");
            tableEmployee.Columns.Add("Middle Name");
            tableEmployee.Columns.Add("Last Name");
            tableEmployee.Columns.Add("Contact No.");
            tableEmployee.Columns.Add("Username");
            tableEmployee.Columns.Add("Password");
            tableEmployee.Columns.Add("Status");

            foreach (DocumentSnapshot documentSnapshot in snapshot.Documents)
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

                    tableEmployee.Rows.Add(downloadedImage, data["IdNumber"], data["Department"], data["Position"], data["FirstName"], data["MiddleName"], data["LastName"], data["ContactNo"]
                        , data["Username"], data["Password"], data["Status"]);

                }




                // Handle the CellFormatting event
                employeeTable.CellFormatting += DataGridView1_CellFormatting;
                employeeTable.DataSource = tableEmployee;

            }

        }

        async void Customer_Service()
        {
            //CollectionReference collectionRef = db.Collection("Products");
            Query query = db.Collection("Employees").WhereEqualTo("Department", "Customer Service Department");
            QuerySnapshot snapshot = await query.GetSnapshotAsync();

            tableEmployee = new System.Data.DataTable();
            tableEmployee.Columns.Add("Image", typeof(Image));
            tableEmployee.Columns.Add("ID number");
            tableEmployee.Columns.Add("Department");
            tableEmployee.Columns.Add("Position");
            tableEmployee.Columns.Add("First Name");
            tableEmployee.Columns.Add("Middle Name");
            tableEmployee.Columns.Add("Last Name");
            tableEmployee.Columns.Add("Contact No.");
            tableEmployee.Columns.Add("Username");
            tableEmployee.Columns.Add("Password");
            tableEmployee.Columns.Add("Status");

            foreach (DocumentSnapshot documentSnapshot in snapshot.Documents)
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

                    tableEmployee.Rows.Add(downloadedImage, data["IdNumber"], data["Department"], data["Position"], data["FirstName"], data["MiddleName"], data["LastName"], data["ContactNo"]
                        , data["Username"], data["Password"], data["Status"]);

                }




                // Handle the CellFormatting event
                employeeTable.CellFormatting += DataGridView1_CellFormatting;
                employeeTable.DataSource = tableEmployee;

            }

        }

        async void Information_Technology()
        {
            //CollectionReference collectionRef = db.Collection("Products");
            Query query = db.Collection("Employees").WhereEqualTo("Department", "Information Technology Department");
            QuerySnapshot snapshot = await query.GetSnapshotAsync();

            tableEmployee = new System.Data.DataTable();
            tableEmployee.Columns.Add("Image", typeof(Image));
            tableEmployee.Columns.Add("ID number");
            tableEmployee.Columns.Add("Department");
            tableEmployee.Columns.Add("Position");
            tableEmployee.Columns.Add("First Name");
            tableEmployee.Columns.Add("Middle Name");
            tableEmployee.Columns.Add("Last Name");
            tableEmployee.Columns.Add("Contact No.");
            tableEmployee.Columns.Add("Username");
            tableEmployee.Columns.Add("Password");
            tableEmployee.Columns.Add("Status");

            foreach (DocumentSnapshot documentSnapshot in snapshot.Documents)
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

                    tableEmployee.Rows.Add(downloadedImage, data["IdNumber"], data["Department"], data["Position"], data["FirstName"], data["MiddleName"], data["LastName"], data["ContactNo"]
                        , data["Username"], data["Password"], data["Status"]);

                }




                // Handle the CellFormatting event
                employeeTable.CellFormatting += DataGridView1_CellFormatting;
                employeeTable.DataSource = tableEmployee;

            }

        }

        async void Sales_Supervisor()
        {
            //CollectionReference collectionRef = db.Collection("Products");
            Query query = db.Collection("Employees").WhereEqualTo("Department", "Sales Supervisor Department");
            QuerySnapshot snapshot = await query.GetSnapshotAsync();

            tableEmployee = new System.Data.DataTable();
            tableEmployee.Columns.Add("Image", typeof(Image));
            tableEmployee.Columns.Add("ID number");
            tableEmployee.Columns.Add("Department");
            tableEmployee.Columns.Add("Position");
            tableEmployee.Columns.Add("First Name");
            tableEmployee.Columns.Add("Middle Name");
            tableEmployee.Columns.Add("Last Name");
            tableEmployee.Columns.Add("Contact No.");
            tableEmployee.Columns.Add("Username");
            tableEmployee.Columns.Add("Password");
            tableEmployee.Columns.Add("Status");

            foreach (DocumentSnapshot documentSnapshot in snapshot.Documents)
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

                    tableEmployee.Rows.Add(downloadedImage, data["IdNumber"], data["Department"], data["Position"], data["FirstName"], data["MiddleName"], data["LastName"], data["ContactNo"]
                        , data["Username"], data["Password"], data["Status"]);

                }




                // Handle the CellFormatting event
                employeeTable.CellFormatting += DataGridView1_CellFormatting;
                employeeTable.DataSource = tableEmployee;

            }

        }

        async void Warehouse_Manager()
        {
            //CollectionReference collectionRef = db.Collection("Products");
            Query query = db.Collection("Employees").WhereEqualTo("Department", "Warehouse Manager Department");
            QuerySnapshot snapshot = await query.GetSnapshotAsync();

            tableEmployee = new System.Data.DataTable();
            tableEmployee.Columns.Add("Image", typeof(Image));
            tableEmployee.Columns.Add("ID number");
            tableEmployee.Columns.Add("Department");
            tableEmployee.Columns.Add("Position");
            tableEmployee.Columns.Add("First Name");
            tableEmployee.Columns.Add("Middle Name");
            tableEmployee.Columns.Add("Last Name");
            tableEmployee.Columns.Add("Contact No.");
            tableEmployee.Columns.Add("Username");
            tableEmployee.Columns.Add("Password");
            tableEmployee.Columns.Add("Status");

            foreach (DocumentSnapshot documentSnapshot in snapshot.Documents)
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

                    tableEmployee.Rows.Add(downloadedImage, data["IdNumber"], data["Department"], data["Position"], data["FirstName"], data["MiddleName"], data["LastName"], data["ContactNo"]
                        , data["Username"], data["Password"], data["Status"]);

                }




                // Handle the CellFormatting event
                employeeTable.CellFormatting += DataGridView1_CellFormatting;
                employeeTable.DataSource = tableEmployee;

            }

        }

        async void Warehouse_Staff()
        {
            //CollectionReference collectionRef = db.Collection("Products");
            Query query = db.Collection("Employees").WhereEqualTo("Department", "Warehouse Staff Department");
            QuerySnapshot snapshot = await query.GetSnapshotAsync();

            tableEmployee = new System.Data.DataTable();
            tableEmployee.Columns.Add("Image", typeof(Image));
            tableEmployee.Columns.Add("ID number");
            tableEmployee.Columns.Add("Department");
            tableEmployee.Columns.Add("Position");
            tableEmployee.Columns.Add("First Name");
            tableEmployee.Columns.Add("Middle Name");
            tableEmployee.Columns.Add("Last Name");
            tableEmployee.Columns.Add("Contact No.");
            tableEmployee.Columns.Add("Username");
            tableEmployee.Columns.Add("Password");
            tableEmployee.Columns.Add("Status");

            foreach (DocumentSnapshot documentSnapshot in snapshot.Documents)
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

                    tableEmployee.Rows.Add(downloadedImage, data["IdNumber"], data["Department"], data["Position"], data["FirstName"], data["MiddleName"], data["LastName"], data["ContactNo"]
                        , data["Username"], data["Password"], data["Status"]);

                }




                // Handle the CellFormatting event
                employeeTable.CellFormatting += DataGridView1_CellFormatting;
                employeeTable.DataSource = tableEmployee;

            }

        }

        async void HR_Manager()
        {
            //CollectionReference collectionRef = db.Collection("Products");
            Query query = db.Collection("Employees").WhereEqualTo("Department", "HR Manager Department");
            QuerySnapshot snapshot = await query.GetSnapshotAsync();

            tableEmployee = new System.Data.DataTable();
            tableEmployee.Columns.Add("Image", typeof(Image));
            tableEmployee.Columns.Add("ID number");
            tableEmployee.Columns.Add("Department");
            tableEmployee.Columns.Add("Position");
            tableEmployee.Columns.Add("First Name");
            tableEmployee.Columns.Add("Middle Name");
            tableEmployee.Columns.Add("Last Name");
            tableEmployee.Columns.Add("Contact No.");
            tableEmployee.Columns.Add("Username");
            tableEmployee.Columns.Add("Password");
            tableEmployee.Columns.Add("Status");

            foreach (DocumentSnapshot documentSnapshot in snapshot.Documents)
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

                    tableEmployee.Rows.Add(downloadedImage, data["IdNumber"], data["Department"], data["Position"], data["FirstName"], data["MiddleName"], data["LastName"], data["ContactNo"]
                        , data["Username"], data["Password"], data["Status"]);

                }




                // Handle the CellFormatting event
                employeeTable.CellFormatting += DataGridView1_CellFormatting;
                employeeTable.DataSource = tableEmployee;

            }

        }


        private async Task SearchAndUpdateDataGridView(string searchTerm)
        {
            // Manually query Firestore for documents that match the search term
            Query query = db.Collection("Employees")
                            .WhereEqualTo("Username", searchTerm);

            // Execute the query and retrieve the matching documents
            QuerySnapshot querySnapshot = await query.GetSnapshotAsync();
            List<DocumentSnapshot> documents = querySnapshot.Documents.ToList();

            // Clear the DataGridView
            //dataTable.Rows.Clear();

            tableEmployee = new System.Data.DataTable();
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


            foreach (DocumentSnapshot document in documents)
            {

                string imageUrl = document.GetValue<string>("imageUrl");

                if (document.Exists)
                {
                    var data = document.ToDictionary();

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

        private async void SearchEmployeeBtn_Click(object sender, EventArgs e)
        {
            string searchTerm = SearchEmployeeTxtBox.Text;
            await SearchAndUpdateDataGridView(searchTerm);
        }

        private async void SearchEmployeeTxtBox_TextChanged(object sender, EventArgs e)
        {
            /*string searchTerm = SearchEmployeeTxtBox.Text;
            await SearchAndUpdateDataGridView(searchTerm);*/
        }
    }
}
