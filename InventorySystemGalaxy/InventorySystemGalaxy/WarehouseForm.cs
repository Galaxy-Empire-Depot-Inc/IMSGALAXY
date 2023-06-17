using Google.Cloud.Firestore;
using Google.Cloud.Firestore.V1;
using Google.Cloud.Storage.V1;
using InventorySystemGalaxy.Classes;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        DataTable dataTable;
        public WarehouseForm()
        {
            InitializeComponent();
        }

        private void ShowModal_Click(object sender, EventArgs e)
        {
            WarehouseModalForm warehouseModalForm = new WarehouseModalForm();
            warehouseModalForm.ShowDialog();
            warehouseModalForm.StartPosition = FormStartPosition.CenterParent;
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
<<<<<<< HEAD
            dataTable.Columns.Add("QTY");
            dataTable.Columns.Add("Image", typeof(Image));


            // dataTable.Columns.Add("Image", typeof(Image));
=======
            dataTable.Columns.Add("Box");
            dataTable.Columns.Add("Quantity");
            dataTable.Columns.Add("CTN L");
            dataTable.Columns.Add("CTN W");
            dataTable.Columns.Add("CTN H");
            dataTable.Columns.Add("Availability");
            dataTable.Columns.Add("Image", typeof(System.Drawing.Image));
>>>>>>> ab80740c571ba39f68ead8380ef10712b4524abd

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
<<<<<<< HEAD
                    Image downloadedImage = Image.FromStream(downloadStream);



                    // byte[] imageData = Convert.FromBase64String(data["imageUrl"].ToString());
                    //Image image = byteArrayToImage(imageData);
                    dataTable.Rows.Add(data["Sort"], data["Item_code"], data["Ref_code"], data["Srp"], data["Colour"], data["Description"],
                        data["Dp"], data["Av"], data["Watts"], data["ProductSize"], data["Warehouse"], data["Category"], data["Qty"], downloadedImage);
=======
                    System.Drawing.Image downloadedImage = System.Drawing.Image.FromStream(downloadStream);
                    dataTable.Rows.Add(data["Sort"], data["Item_code"], data["Ref_code"], data["Srp"], data["Colour"], data["Description"],
                        data["Dp"], data["Av"], data["Watts"], data["ProductSize"], data["Warehouse"], data["Category"], data["Box"],
                        data["Qty"], data["CtlL"], data["CtlW"], data["CtlH"], data["Availability"], downloadedImage);
>>>>>>> ab80740c571ba39f68ead8380ef10712b4524abd
                    // Add more fields as needed
                }
            }
            /*WarehouseTable.Columns["Image"].DefaultCellStyle = new DataGridViewCellStyle()
            {

                Alignment = DataGridViewContentAlignment.MiddleCenter,
                Padding = new Padding(5),
                //ImageLayout = DataGridViewImageCellLayout.Zoom
            };*/


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

        private async void searchText_TextChanged(object sender, EventArgs e)
        {
            /*string search = searchText.Text;

            if (string.IsNullOrWhiteSpace(search))
            {
                // If the search text is empty or whitespace, show all data
                WarehouseTable.DataSource = dataTable;
            }
            else
            {
                // Filter the data based on the search text using Firestore query
                CollectionReference collectionRef = db.Collection("Products");
                Query query = collectionRef.WhereEqualTo("Item_code", search);
                QuerySnapshot querySnapshot = await query.GetSnapshotAsync();

                List<DocumentSnapshot> filteredDocuments = querySnapshot.Documents.ToList();

                DataTable filteredDataTable = dataTable.Clone(); // Create a clone of the original DataTable structure

                foreach (DocumentSnapshot documentSnapshot in filteredDocuments)
                {
                    if (documentSnapshot.Exists)
                    {
                        Dictionary<string, object> documentData = documentSnapshot.ToDictionary();
                        DataRow newRow = filteredDataTable.Rows.Add();
                        foreach (var kvp in documentData)
                        {
                            newRow[kvp.Key] = kvp.Value;
                        }
                    }
                }

                WarehouseTable.DataSource = filteredDataTable;
            }*/
        }

    }
}
