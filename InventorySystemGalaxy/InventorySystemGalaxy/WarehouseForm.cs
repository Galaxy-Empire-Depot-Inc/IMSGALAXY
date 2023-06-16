using Google.Cloud.Firestore;
using Google.Cloud.Firestore.V1;
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

namespace InventorySystemGalaxy
{
    public partial class WarehouseForm : Form
    {

        FirestoreDb db;
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
            /*Query productQuery = db.Collection("Products");
            QuerySnapshot querySnap = await productQuery.GetSnapshotAsync();

            WarehouseTable.Rows.Clear();

            foreach (DocumentSnapshot documentSnapshot in querySnap.Documents)
            {
                ProductData productData = documentSnapshot.ConvertTo<ProductData>();
                WarehouseTable.Rows.Add(productData.Sort, productData.Item_code, productData.Ref_code);
            }*/

            CollectionReference collectionRef = db.Collection("Products");
            QuerySnapshot snapshot = await collectionRef.GetSnapshotAsync();

            DataTable dataTable = new DataTable();
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
            dataTable.Columns.Add("QTY");

            // dataTable.Columns.Add("Image", typeof(Image));


            foreach (DocumentSnapshot documentSnapshot in snapshot.Documents)
            {
                if (documentSnapshot.Exists)
                {
                    var data = documentSnapshot.ToDictionary();
                   // byte[] imageData = Convert.FromBase64String(data["imageUrl"].ToString());
                    //Image image = byteArrayToImage(imageData);
                    dataTable.Rows.Add(data["Sort"], data["Item_code"], data["Ref_code"], data["Srp"], data["Colour"], data["Description"],
                        data["Dp"], data["Av"], data["Watts"], data["ProductSize"], data["Warehouse"], data["Category"], data["Qty"]);
                    // Add more fields as needed
                }
            }

            WarehouseTable.DataSource = dataTable;

        }

        private Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private async void WarehouseForm_Load(object sender, EventArgs e)
        {

            string path = AppDomain.CurrentDomain.BaseDirectory + @"ims-firestore.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            db = FirestoreDb.Create("imsgalaxy-f7419");
            DisplayData();


        }
    }
}
