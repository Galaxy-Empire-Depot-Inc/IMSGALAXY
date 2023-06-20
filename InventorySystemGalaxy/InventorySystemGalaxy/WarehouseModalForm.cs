using Google.Cloud.Firestore;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Cloud.Storage.V1;
using System.Collections;


namespace InventorySystemGalaxy
{
    public partial class WarehouseModalForm : Form
    {

        FirestoreDb db;
        StorageClient storageClient = StorageClient.Create();
        Image image;
        string fileName, imageUrl;
        string bucketName = "imsgalaxy-f7419.appspot.com";

        DocumentReference documentReference;



        public WarehouseModalForm()
        {
            InitializeComponent();
            CategoryCB.SelectedIndex = 0;
            WarehouseCB.SelectedIndex = 0;

        }

        private void sortTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                refTextBox.Focus();
            }
        }

        private void refTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                descriptionTextBox.Focus();
            }

        }

        private void descriptionTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                itemCodeTextBox.Focus();
            }
        }

        private void itemCodeTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                colorTextBox.Focus();
            }
        }

        private void colorTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                avTextbox.Focus();
            }
        }

        private void avTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                wattsTextBox.Focus();
            }
        }

        private void wattsTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ctnLTextBox.Focus();
            }
        }

        private void ctnLTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ctnHTextBox.Focus();
            }
        }

        private void ctnHTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ctnWTextBox.Focus();
            }
        }

        private void ctnWTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                sizeTextBox.Focus();
            }
        }

        private void sizeTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                boxTextBox.Focus();
            }
        }

        private void boxTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                srpTextBox.Focus();
            }
        }

        private void srpTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CategoryCB.Focus();
            }
        }

        private void warehouseComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Add_UpdateBTN.Focus();
            }
        }

        private void srpTextBox_TextChanged(object sender, EventArgs e)
        {


        }

        private void Add_UpdateBTN_Click(object sender, EventArgs e)
        {

            //addProduct();
            //addStorageImage();

            

            if (Add_UpdateBTN.Text == "Update")
            {
                //MessageBox.Show("Update");
                UpdateProduct();
            }
            else
            {
                //MessageBox.Show("Add");
                addProduct();
            }


            // DocumentReference documentReference = db.Collection("product")
        }

        private void UpdateProduct()
        {
            string ITEMCODE = itemCodeTextBox.Text;
            string selectedWarehouse = WarehouseCB.GetItemText(WarehouseCB.SelectedItem);
            string selectedCategory = WarehouseCB.GetItemText(CategoryCB.SelectedItem);

            if (WarehouseCB.SelectedIndex == 0 || CategoryCB.SelectedIndex == 0)
            {

                MessageBox.Show("No Warehouse/Category Selected");


            }
            else
            {

                image = SelectImagePB.Image;
                //Generate unique FileName.jpg
                string fileName = $"{Guid.NewGuid()}.jpg";

                using (var memoryStream = new MemoryStream())
                {
                    image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] imageData = memoryStream.ToArray();

                    // Upload the image to Cloud Storage
                    storageClient.UploadObject(bucketName, fileName, "image/jpeg", new MemoryStream(imageData));
                }

                //get the link of the image in cloudstorage
                imageUrl = $"https://storage.googleapis.com/{bucketName}/{fileName}";

                DocumentReference documentReference = db.Collection("Products").Document(ITEMCODE);

                Dictionary<string, object> dict = new Dictionary<string, object>()
                {

                    {"Sort", sortTextBox.Text},
                    {"Item_code", itemCodeTextBox.Text},
                    {"Ref_code", refTextBox.Text},
                    {"Srp", srpTextBox.Text},
                    {"Colour", colorTextBox.Text},
                    {"Description", descriptionTextBox.Text},
                    {"Dp", dpTextBox.Text},
                    {"Av", avTextbox.Text},
                    {"Watts", wattsTextBox.Text},
                    {"ProductSize", sizeTextBox.Text},
                    {"Warehouse", selectedWarehouse},
                    {"Category", selectedCategory},
                    {"Box", boxTextBox.Text},
                    {"Qty", qtyTextBox.Text},
                    {"CtlH", ctnHTextBox.Text},
                    {"CtlW", ctnWTextBox.Text},
                    {"CtlL", ctnLTextBox.Text},
                    {"Availability", "Available" },
                    { "imageUrl", imageUrl }

                };


                if(MessageBox.Show("Do you want to Update this item?", "Confirmation Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    documentReference.UpdateAsync(dict);
                    MessageBox.Show("UPDATED SUCCESSFULLY");
                    ClearForm();
                }

            }
        }

        private async void addStorageImage()
        {
            /*if (SelectImagePB.Image != null)
            {
                // Convert the image to byte array
                byte[] imageBytes = null;
                using (MemoryStream ms = new MemoryStream())
                {
                    SelectImagePB.Image.Save(ms, SelectImagePB.Image.RawFormat);
                    imageBytes = ms.ToArray();
                }

                // Upload the image to Firebase Storage
                string bucketName = "imsgalaxy-f7419.appspot.com";
                string destinationPath = "images/";

                StorageClient storage = StorageClient.Create();
                using (MemoryStream stream = new MemoryStream(imageBytes))
                {
                    await storage.UploadObjectAsync(bucketName, destinationPath, null, stream);
                }

                MessageBox.Show("Image uploaded successfully!");
            }
            else
            {
                MessageBox.Show("No image selected!");
            }*/

            /*OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;

                // Upload the image
                string imageUrl = await UploadImageToStorage(imagePath);

                // Save the URL in Firestore
                DocumentReference documentReference = db.Collection("images").Document();
                await documentReference.SetAsync(new { ImageUrl = imageUrl });

                MessageBox.Show("Image uploaded successfully!");
            }*/


            //retrieve Image 
            DocumentReference docRef = db.Collection("images").Document("JUDING");
            DocumentSnapshot snapshot = docRef.GetSnapshotAsync().Result;
            string imageUrl = snapshot.GetValue<string>("imageUrl");

            // Create a client to interact with Cloud Storage
            var storageClient = StorageClient.Create();

            // Get the filename from the image URL
            string fileName = Path.GetFileName(imageUrl);

            // Download the image from Cloud Storage
            var downloadStream = new MemoryStream();
            storageClient.DownloadObject("imsgalaxy-f7419.appspot.com", fileName, downloadStream);
            downloadStream.Position = 0;

            // Create an Image object from the downloaded image data
            Image downloadedImage = Image.FromStream(downloadStream);

            // Display the image in the PictureBox
            SelectImagePB.Image = downloadedImage;


        }

        async Task<string> UploadImageToStorage(string imagePath)
        {
            // Generate a unique file name for the image
            // string fileName = Guid.NewGuid().ToString();

            string fileName = $"{Guid.NewGuid()}.jpg";

            // Upload the image to Cloud Storage
            //await storageClient.UploadObjectAsync("imsgalaxy-f7419.appspot.com", fileName, null, File.OpenRead(imagePath));

            using (var fileStream = File.OpenRead(imagePath))
            {
                storageClient.UploadObject("imsgalaxy-f7419.appspot.com", fileName, null, fileStream);
            }

            // Get the public URL of the uploaded image
            string imageUrl = $"https://storage.googleapis.com/imsgalaxy-f7419.appspot.com/{fileName}";

            return imageUrl;
        }

        async void addProduct()
        {

            /*Image pictureImage = SelectImagePB.Image;
            ImageConverter Converter = new ImageConverter();
            var ImageConvert = Converter.ConvertTo(pictureImage, typeof(byte[]));

            String SelectedWarehouse = WarehouseCB.GetItemText(WarehouseCB.SelectedItem);
            String SelectedCategory = CategoryCB.GetItemText(CategoryCB.SelectedItem);

            MemoryStream memoryStream = new MemoryStream();
            SelectImagePB.Image.Save(memoryStream, SelectImagePB.Image.RawFormat);
            byte[] img = memoryStream.ToArray();

            String saveQuery = "INSERT INTO product_table(sort, item_code,ref_code, picture, colour, av, watts, ctn_size_l, ctn_size_w, ctn_size_h, srp, warehouse, description, category, qty_per_box, box) " +
                    "VALUES(@sort, @item_code, @ref_code, @picture, @colour, @av, @watts, @ctn_size_l, @ctn_size_w, @ctn_size_h, @srp, @warehouse, @description, @category, @qty_per_box, @box)";

            if (SelectedWarehouse == "Select Warehouse" || SelectedCategory == "Select Category")
            {
                MessageBox.Show("Please Select Category/Warehouse");
            }
            else
            {
                connection.Open();
                command = new MySqlCommand(saveQuery, connection);

                command.Parameters.Add("@sort", MySqlDbType.VarChar, 45);
                command.Parameters.Add("@item_code", MySqlDbType.VarChar, 45);
                command.Parameters.Add("@ref_code", MySqlDbType.VarChar, 45);
                command.Parameters.Add("@picture", MySqlDbType.Blob);
                command.Parameters.Add("@colour", MySqlDbType.VarChar, 45);
                command.Parameters.Add("@av", MySqlDbType.VarChar, 45);
                command.Parameters.Add("@watts", MySqlDbType.VarChar, 45);
                command.Parameters.Add("@ctn_size_l", MySqlDbType.Double);
                command.Parameters.Add("@ctn_size_w", MySqlDbType.Double);
                command.Parameters.Add("@ctn_size_h", MySqlDbType.Double);
                command.Parameters.Add("@srp", MySqlDbType.Double);
                command.Parameters.Add("@warehouse", MySqlDbType.VarChar, 45);
                command.Parameters.Add("@description", MySqlDbType.VarChar, 45);
                command.Parameters.Add("@category", MySqlDbType.VarChar, 45);
                command.Parameters.Add("@qty_per_box", MySqlDbType.Double);
                command.Parameters.Add("@box", MySqlDbType.Double);

                command.Parameters["@sort"].Value = sortTextBox.Text;
                command.Parameters["@item_code"].Value = itemCodeTextBox.Text;
                command.Parameters["@ref_code"].Value = refTextBox.Text;
                command.Parameters["@picture"].Value = img;
                command.Parameters["@colour"].Value = colorTextBox.Text;
                command.Parameters["@av"].Value = avTextbox.Text;
                command.Parameters["@watts"].Value = wattsTextBox.Text;
                command.Parameters["@ctn_size_l"].Value = ctnLTextBox.Text;
                command.Parameters["@ctn_size_w"].Value = ctnWTextBox.Text;
                command.Parameters["@ctn_size_h"].Value = ctnHTextBox.Text;
                command.Parameters["@srp"].Value = srpTextBox.Text;
                command.Parameters["@warehouse"].Value = SelectedWarehouse;
                command.Parameters["@description"].Value = descriptionTextBox.Text;
                command.Parameters["@category"].Value = SelectedCategory;
                command.Parameters["@qty_per_box"].Value = qtyTextBox.Text;
                command.Parameters["@box"].Value = boxTextBox.Text;


                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("INSERTED");
                    ClearForm();


                }
                else
                {
                    MessageBox.Show("NOT INSERTED");
                }
                connection.Close();

            }*/

            string ITEMCODE = itemCodeTextBox.Text;
            string selectedWarehouse = WarehouseCB.GetItemText(WarehouseCB.SelectedItem);
            string selectedCategory = WarehouseCB.GetItemText(CategoryCB.SelectedItem);

            if (WarehouseCB.SelectedIndex == 0 || CategoryCB.SelectedIndex == 0)
            {

                MessageBox.Show("No Warehouse/Category Selected");


            }
            else
            {

                image = SelectImagePB.Image;
                //Generate unique FileName.jpg
                string fileName = $"{Guid.NewGuid()}.jpg";

                using (var memoryStream = new MemoryStream())
                {
                    image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] imageData = memoryStream.ToArray();

                    // Upload the image to Cloud Storage
                    storageClient.UploadObject(bucketName, fileName, "image/jpeg", new MemoryStream(imageData));
                }

                //get the link of the image in cloudstorage
                imageUrl = $"https://storage.googleapis.com/{bucketName}/{fileName}";

                DocumentReference documentReference = db.Collection("Products").Document(ITEMCODE);
                DocumentSnapshot snapshot = await documentReference.GetSnapshotAsync();

                if (snapshot.Exists)
                {
                    MessageBox.Show("ITEM CODE ALREADY EXIST");
                }
                else
                {
                    Dictionary<string, object> dict = new Dictionary<string, object>()
                {

                    {"Sort", sortTextBox.Text},
                    {"Item_code", itemCodeTextBox.Text},
                    {"Ref_code", refTextBox.Text},
                    {"Srp", srpTextBox.Text},
                    {"Colour", colorTextBox.Text},
                    {"Description", descriptionTextBox.Text},
                    {"Dp", dpTextBox.Text},
                    {"Av", avTextbox.Text},
                    {"Watts", wattsTextBox.Text},
                    {"ProductSize", sizeTextBox.Text},
                    {"Warehouse", selectedWarehouse},
                    {"Category", selectedCategory},
                    {"Box", boxTextBox.Text},
                    {"Qty", qtyTextBox.Text},
                    {"CtlH", ctnHTextBox.Text},
                    {"CtlW", ctnWTextBox.Text},
                    {"CtlL", ctnLTextBox.Text},
                    {"Availability", "Available" },
                    { "imageUrl", imageUrl }

                };

                    if (MessageBox.Show("Do you want to Update this item?", "Confirmation Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        documentReference.SetAsync(dict);
                        MessageBox.Show("ADDED SUCCESSFULLY");
                        ClearForm();
                    }

                    
                }

            }

        }

        private void AddPhotoBTN_Click(object sender, EventArgs e)
        {

            OpenFileDialog();


            /*OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.JPG;*.PNG;*.bmp;)|*.JPG;*PNG;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                SelectImagePB.Image = new Bitmap(open.FileName);
                //LabelProductModal.Text = Image.FromFile(open.FileName).ToString();
                //MessageBox.Show(Image.FromFile(open.FileName).ToString());

                //Get the Image from PictureBox
                Image image = SelectImagePB.Image;
                //Generate unique FileName.jpg
                string fileName = $"{Guid.NewGuid()}.jpg";

                using (var memoryStream = new MemoryStream())
                {
                    image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] imageData = memoryStream.ToArray();

                    // Upload the image to Cloud Storage
                    storageClient.UploadObject("imsgalaxy-f7419.appspot.com", fileName, "image/jpeg", new MemoryStream(imageData));
                }

                //get the link of the image in cloudstorage
                string imageUrl = $"https://storage.googleapis.com/{"imsgalaxy-f7419.appspot.com"}/{fileName}";

                //extract the data from cloud storage
                Dictionary<string, object> data = new Dictionary<string, object>
                {
                    { "imageUrl", imageUrl }
                };

                //save the link(from cloud storage) to  the firestore
                DocumentReference docRef = db.Collection("images").Document("JUDING");
                docRef.SetAsync(data);
                MessageBox.Show("Success");
                SelectImagePB.Image = Properties.Resources.icons8_image_100;


            }*/

        }

        void OpenFileDialog()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.JPG;*.PNG;*.bmp;)|*.JPG;*PNG;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                SelectImagePB.Image = new Bitmap(open.FileName);
            }

        }

        private void ClearForm()
        {
            sortTextBox.Text = "";
            itemCodeTextBox.Text = "";
            refTextBox.Text = "";
            colorTextBox.Text = "";
            avTextbox.Text = "";
            wattsTextBox.Text = "";
            ctnLTextBox.Text = "";
            ctnWTextBox.Text = "";
            ctnHTextBox.Text = "";
            srpTextBox.Text = "";
            descriptionTextBox.Text = "";
            qtyTextBox.Text = "";
            boxTextBox.Text = "";
            ctnHTextBox.Text = "";
            ctnWTextBox.Text = "";
            ctnLTextBox.Text = "";
            WarehouseCB.SelectedIndex = 0;
            CategoryCB.SelectedIndex = 0;
            SelectImagePB.Image = Properties.Resources.icons8_image_100;

        }

        private void CloseModal_click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WarehouseModalForm_Load(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"ims-firestore.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            db = FirestoreDb.Create("imsgalaxy-f7419");
        }

        private void colorTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void srpTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Allowing only one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
