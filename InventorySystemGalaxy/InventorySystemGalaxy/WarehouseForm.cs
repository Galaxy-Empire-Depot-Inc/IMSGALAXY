using Google.Cloud.Firestore;
using Google.Cloud.Firestore.V1;
using Google.Cloud.Storage.V1;
using Google.Type;
using InventorySystemGalaxy.Classes;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InventorySystemGalaxy
{
    public partial class WarehouseForm : Form
    {

        FirestoreDb db;

        DataTable dataTable, dt1;

        private List<DocumentSnapshot> data;
        CollectionReference collectionReference;
        private List<DocumentSnapshot> searchResults;

        public WarehouseForm()
        {
            InitializeComponent();
            FirestoreDbBuilder builder = new FirestoreDbBuilder
            {
                ProjectId = "imsgalaxy-f7419",
                // Add additional configuration as needed
            };
            db = builder.Build();

            WarehouseTable.DataSource = data;
            GetDataFromFirestore();

        }

        async void DisplayData()
        {

            CollectionReference collectionRef = db.Collection("Products");
            QuerySnapshot snapshot = await collectionRef.GetSnapshotAsync();

            dataTable = new DataTable();
            dataTable.Columns.Add("Sort");
            dataTable.Columns.Add("Item Code");
            dataTable.Columns.Add("Reference Code");
            dataTable.Columns.Add("SRP");
            dataTable.Columns.Add("Colour");
            dataTable.Columns.Add("Description");
            dataTable.Columns.Add("DP");
            dataTable.Columns.Add("AV");
            dataTable.Columns.Add("Watts");
            dataTable.Columns.Add("ProductSize");
            dataTable.Columns.Add("Warehouse");
            dataTable.Columns.Add("Category");
            dataTable.Columns.Add("Box");
            dataTable.Columns.Add("Quantity");
            dataTable.Columns.Add("CTN L");
            dataTable.Columns.Add("CTN W");
            dataTable.Columns.Add("CTN H");
            dataTable.Columns.Add("Available");
            dataTable.Columns.Add("Display");
            dataTable.Columns.Add("Repair");
            dataTable.Columns.Add("Image", typeof(System.Drawing.Image));

            //set the property of every column

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
                    System.Drawing.Image downloadedImage = System.Drawing.Image.FromStream(downloadStream);
                    dataTable.Rows.Add(data["Sort"], data["Item_code"], data["Ref_code"], data["Srp"], data["Colour"], data["Description"],
                        data["Dp"], data["Av"], data["Watts"], data["ProductSize"], data["Warehouse"], data["Category"], data["Box"],
                        data["Qty"], data["CtlL"], data["CtlW"], data["CtlH"], data["Available"], data["Display"], data["Repair"], downloadedImage);
                    // Add more fields as needed
                }
            }
  
            // Handle the CellFormatting event
            WarehouseTable.CellFormatting += DataGridView1_CellFormatting;
            WarehouseTable.DataSource = dataTable;

        }

        //to view the image in Zoom mode
        private void DataGridView1_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (WarehouseTable.Columns[e.ColumnIndex].Name == "Image" && e.Value != null)
            {
                // Set the image cell style to zoom
                DataGridViewImageCell cell = (DataGridViewImageCell)WarehouseTable.Rows[e.RowIndex].Cells[e.ColumnIndex];
                cell.ImageLayout = DataGridViewImageCellLayout.Stretch;
            }
        }

        /*private Image byteArrayToImage(byte[] byteArrayIn)
        {

            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;

        }*/

        private async void WarehouseForm_Load(object sender, EventArgs e)
        {

            string path = AppDomain.CurrentDomain.BaseDirectory + @"ims-firestore.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            db = FirestoreDb.Create("imsgalaxy-f7419");
            DisplayData();

        }

        private void WarehouseTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            WarehouseModalForm warehouseModal = new WarehouseModalForm();

            //Change the text in button
            warehouseModal.Add_UpdateBTN.Text = "Update";

            //Show R.D.A
            warehouseModal.AvailablityPanel.Visible = true;
            warehouseModal.RepairPanel.Visible = true;
            warehouseModal.DisplayPanel.Visible = true;

            //Display the Data into Modal
            warehouseModal.sortTextBox.Text = this.WarehouseTable.CurrentRow.Cells["Sort"].Value.ToString();
            warehouseModal.itemCodeTextBox.Text = this.WarehouseTable.CurrentRow.Cells["Item code"].Value.ToString();
            warehouseModal.refTextBox.Text = this.WarehouseTable.CurrentRow.Cells["Reference code"].Value.ToString();
            warehouseModal.srpTextBox.Text = this.WarehouseTable.CurrentRow.Cells["SRP"].Value.ToString();
            warehouseModal.colorTextBox.Text = this.WarehouseTable.CurrentRow.Cells["Colour"].Value.ToString();
            warehouseModal.descriptionTextBox.Text = this.WarehouseTable.CurrentRow.Cells["Description"].Value.ToString();
            warehouseModal.dpTextBox.Text = this.WarehouseTable.CurrentRow.Cells["DP"].Value.ToString();
            warehouseModal.avTextbox.Text = this.WarehouseTable.CurrentRow.Cells["AV"].Value.ToString();
            warehouseModal.wattsTextBox.Text = this.WarehouseTable.CurrentRow.Cells["Watts"].Value.ToString();
            warehouseModal.sizeTextBox.Text = this.WarehouseTable.CurrentRow.Cells["ProductSize"].Value.ToString();
            warehouseModal.boxTextBox.Text = this.WarehouseTable.CurrentRow.Cells["Box"].Value.ToString();
            warehouseModal.qtyTextBox.Text = this.WarehouseTable.CurrentRow.Cells["Quantity"].Value.ToString();
            warehouseModal.ctnLTextBox.Text = this.WarehouseTable.CurrentRow.Cells["CTN L"].Value.ToString();
            warehouseModal.ctnHTextBox.Text = this.WarehouseTable.CurrentRow.Cells["CTN H"].Value.ToString();
            warehouseModal.ctnWTextBox.Text = this.WarehouseTable.CurrentRow.Cells["CTN W"].Value.ToString();
            warehouseModal.availabilityText.Text = this.WarehouseTable.CurrentRow.Cells["Available"].Value.ToString();
            warehouseModal.displayText.Text = this.WarehouseTable.CurrentRow.Cells["Display"].Value.ToString();
            warehouseModal.repairText.Text = this.WarehouseTable.CurrentRow.Cells["Repair"].Value.ToString();

            //get value from custombox
            string CategorySelected = this.WarehouseTable.CurrentRow.Cells["Category"].Value.ToString();
            string WarehouseSelected = this.WarehouseTable.CurrentRow.Cells["Warehouse"].Value.ToString();

            //View Only Textboxes
            warehouseModal.itemCodeTextBox.ReadOnly = true;
            warehouseModal.refTextBox.ReadOnly = true;
            warehouseModal.descriptionTextBox.ReadOnly = true;
            warehouseModal.colorTextBox.ReadOnly = true;
            warehouseModal.ctnHTextBox.ReadOnly = true;
            warehouseModal.ctnLTextBox.ReadOnly = true;
            warehouseModal.ctnWTextBox.ReadOnly = true;
            warehouseModal.sortTextBox.ReadOnly = true;
            warehouseModal.sizeTextBox.ReadOnly = true;

            //Conditional statement for Warehouse Selected Data
            if (WarehouseSelected == "TMS")
            {
                warehouseModal.WarehouseCB.SelectedIndex = 1;
            }
            if (WarehouseSelected == "STORE")
            {
                warehouseModal.WarehouseCB.SelectedIndex = 2;
            }
            if (WarehouseSelected == "MLB")
            {
                warehouseModal.WarehouseCB.SelectedIndex = 3;
            }

            //Conditional statement for Category Selected Data
            if (CategorySelected == "GS Ceiling and Chandelier Lights")
            {
                warehouseModal.CategoryCB.SelectedIndex = 1;
            }
            if (CategorySelected == "GS Crystal Lights")
            {
                warehouseModal.CategoryCB.SelectedIndex = 2;
            }
            if (CategorySelected == "GS Fan")
            {
                warehouseModal.CategoryCB.SelectedIndex = 3;
            }
            if (CategorySelected == "GS Panel Lights")
            {
                warehouseModal.CategoryCB.SelectedIndex = 4;
            }
            if (CategorySelected == "GS Strip Lights")
            {
                warehouseModal.CategoryCB.SelectedIndex = 5;
            }
            if (CategorySelected == "New Chandelier Lights")
            {
                warehouseModal.CategoryCB.SelectedIndex = 6;
            }


            //display image when row selected
            if (e.RowIndex >= 0 && WarehouseTable.Rows[e.RowIndex].Cells["Image"].Value is System.Drawing.Image)
            {
                // Retrieve the image from the selected row
                System.Drawing.Image selectedImage = (System.Drawing.Image)WarehouseTable.Rows[e.RowIndex].Cells["Image"].Value;

                // Display the image in the PictureBox
                warehouseModal.SelectImagePB.Image = selectedImage;
            }

            warehouseModal.ShowDialog(this);

        }
        private async void GetDataFromFirestore()
        {
            CollectionReference collectionRef = db.Collection("Products");

            // Perform the query to retrieve data from Firestore
            QuerySnapshot snapshot = await collectionRef.GetSnapshotAsync();
            data = snapshot.Documents.ToList();
        }


        // Search Firestore and update the DataGridView
        private async Task SearchAndUpdateDataGridView(string searchTerm)
        {
            // Manually query Firestore for documents that match the search term
            Query query = db.Collection("Products")
                            .WhereEqualTo("Item_code", searchTerm);

            // Execute the query and retrieve the matching documents
            QuerySnapshot querySnapshot = await query.GetSnapshotAsync();
            List<DocumentSnapshot> documents = querySnapshot.Documents.ToList();

            // Clear the DataGridView
            //dataTable.Rows.Clear();

            dataTable = new DataTable();
            dataTable.Columns.Add("Sort");
            dataTable.Columns.Add("Item Code");
            dataTable.Columns.Add("Reference Code");
            dataTable.Columns.Add("SRP");
            dataTable.Columns.Add("Colour");
            dataTable.Columns.Add("Description");
            dataTable.Columns.Add("DP");
            dataTable.Columns.Add("AV");
            dataTable.Columns.Add("Watts");
            dataTable.Columns.Add("ProductSize");
            dataTable.Columns.Add("Warehouse");
            dataTable.Columns.Add("Category");
            dataTable.Columns.Add("Box");
            dataTable.Columns.Add("Quantity");
            dataTable.Columns.Add("CTN L");
            dataTable.Columns.Add("CTN W");
            dataTable.Columns.Add("CTN H");
            dataTable.Columns.Add("Available");
            dataTable.Columns.Add("Display");
            dataTable.Columns.Add("Repair");
            dataTable.Columns.Add("Image", typeof(System.Drawing.Image));

            // Populate the DataGridView with the search results
            foreach (DocumentSnapshot document in documents)
            {

                string imageUrl = document.GetValue<string>("imageUrl");


                if (document.Exists)
                {
                    // Extract data from the Firestore document and add it to the DataGridView
                    // Example: Assuming you have "field1" and "field2" in your Firestore documents
                    /*string sortValue = document.GetValue<string>("Sort");
                    string itemCodeValue = document.GetValue<string>("field2");
                    string RefCodeValue = document.GetValue<string>("field2");
                    string srpValue = document.GetValue<string>("field2");
                    string colourValue = document.GetValue<string>("field2");
                    string DescriptionValue = document.GetValue<string>("field2");
                    string DpValue = document.GetValue<string>("field2");
                    string AvValue = document.GetValue<string>("field2");
                    string WattsValue = document.GetValue<string>("field2");
                    string productSizeValue = document.GetValue<string>("field2");
                    string warehouseCategory = document.GetValue<string>("field2");
                    string categoryValue = document.GetValue<string>("field2");
                    string boxValue = document.GetValue<string>("field2");
                    string qtyValue = document.GetValue<string>("field2");
                    string ctnHValue = document.GetValue<string>("field2");
                    string ctnLValue = document.GetValue<string>("field2");
                    string ctnWValue = document.GetValue<string>("field2");
                    string availabiltiyValue = document.GetValue<string>("field2");*/

                    var data = document.ToDictionary();

                    var storageClient = StorageClient.Create();
                    string fileName = Path.GetFileName(imageUrl);
                    var downloadStream = new MemoryStream();
                    storageClient.DownloadObject("imsgalaxy-f7419.appspot.com", fileName, downloadStream);
                    downloadStream.Position = 0;
                    System.Drawing.Image downloadedImage = System.Drawing.Image.FromStream(downloadStream);
                    dataTable.Rows.Add(data["Sort"], data["Item_code"], data["Ref_code"], data["Srp"], data["Colour"], data["Description"],
                        data["Dp"], data["Av"], data["Watts"], data["ProductSize"], data["Warehouse"], data["Category"], data["Box"],
                        data["Qty"], data["CtlL"], data["CtlW"], data["CtlH"], data["Available"], data["Display"], data["Repair"], downloadedImage);

                }

            }

            WarehouseTable.CellFormatting += DataGridView1_CellFormatting;
            WarehouseTable.DataSource = dataTable;
        }

        private async void SearchBTN_Click(object sender, EventArgs e)
        {
            string searchTerm = searchText.Text;
            await SearchAndUpdateDataGridView(searchTerm);
        }

        private void searchText_TextChanged(object sender, EventArgs e)
        {

            string searchTerm = searchText.Text.Trim().ToLower();

            List<DocumentSnapshot> filteredData = data.Where(document =>
            {
                // Replace "your-field" with the field you want to filter by
                string fieldValue = document.GetValue<string>("Item_code");
                return fieldValue.ToLower().Contains(searchTerm);
            }).ToList();

            WarehouseTable.DataSource = filteredData;
        }

        private void ShowModal_Click_1(object sender, EventArgs e)
        {
            WarehouseModalForm warehouseModalForm = new WarehouseModalForm();
            warehouseModalForm.ShowDialog();
            warehouseModalForm.StartPosition = FormStartPosition.CenterParent;

        }
    }
}
