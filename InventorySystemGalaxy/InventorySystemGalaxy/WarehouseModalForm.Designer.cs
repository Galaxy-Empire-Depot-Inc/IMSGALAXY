namespace InventorySystemGalaxy
{
    partial class WarehouseModalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WarehouseModalForm));
            bgPanel = new Panel();
            WarehouseCB = new CustomComboBox();
            qtyTextBox = new CustomTextBox();
            LabelProductModal = new Label();
            dpTextBox = new CustomTextBox();
            srpTextBox = new CustomTextBox();
            boxTextBox = new CustomTextBox();
            sizeTextBox = new CustomTextBox();
            ctnWTextBox = new CustomTextBox();
            ctnHTextBox = new CustomTextBox();
            ctnLTextBox = new CustomTextBox();
            wattsTextBox = new CustomTextBox();
            avTextbox = new CustomTextBox();
            colorTextBox = new CustomTextBox();
            itemCodeTextBox = new CustomTextBox();
            descriptionTextBox = new CustomTextBox();
            refTextBox = new CustomTextBox();
            sortTextBox = new CustomTextBox();
            Add_UpdateBTN = new CustomButton();
            CategoryCB = new CustomComboBox();
            label1 = new Label();
            AddPhotoBTN = new CustomButton();
            SelectImagePB = new PictureBox();
            CloseModal = new Button();
            bgPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SelectImagePB).BeginInit();
            SuspendLayout();
            // 
            // bgPanel
            // 
            bgPanel.BackColor = Color.FromArgb(59, 116, 192);
            bgPanel.Controls.Add(CloseModal);
            bgPanel.Controls.Add(WarehouseCB);
            bgPanel.Controls.Add(qtyTextBox);
            bgPanel.Controls.Add(LabelProductModal);
            bgPanel.Controls.Add(dpTextBox);
            bgPanel.Controls.Add(srpTextBox);
            bgPanel.Controls.Add(boxTextBox);
            bgPanel.Controls.Add(sizeTextBox);
            bgPanel.Controls.Add(ctnWTextBox);
            bgPanel.Controls.Add(ctnHTextBox);
            bgPanel.Controls.Add(ctnLTextBox);
            bgPanel.Controls.Add(wattsTextBox);
            bgPanel.Controls.Add(avTextbox);
            bgPanel.Controls.Add(colorTextBox);
            bgPanel.Controls.Add(itemCodeTextBox);
            bgPanel.Controls.Add(descriptionTextBox);
            bgPanel.Controls.Add(refTextBox);
            bgPanel.Controls.Add(sortTextBox);
            bgPanel.Controls.Add(Add_UpdateBTN);
            bgPanel.Controls.Add(CategoryCB);
            bgPanel.Controls.Add(label1);
            bgPanel.Controls.Add(AddPhotoBTN);
            bgPanel.Controls.Add(SelectImagePB);
            bgPanel.Dock = DockStyle.Fill;
            bgPanel.Location = new Point(13, 12);
            bgPanel.Margin = new Padding(3, 2, 3, 2);
            bgPanel.MaximumSize = new Size(660, 374);
            bgPanel.MinimumSize = new Size(660, 374);
            bgPanel.Name = "bgPanel";
            bgPanel.Padding = new Padding(9, 8, 9, 8);
            bgPanel.Size = new Size(660, 374);
            bgPanel.TabIndex = 1;
            // 
            // WarehouseCB
            // 
            WarehouseCB.BackColor = Color.White;
            WarehouseCB.BackColor1 = Color.White;
            WarehouseCB.Bordercolor = Color.DeepSkyBlue;
            WarehouseCB.BorderSize = 2;
            WarehouseCB.DropDownStyle = ComboBoxStyle.DropDownList;
            WarehouseCB.Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point);
            WarehouseCB.ForeColor = Color.DimGray;
            WarehouseCB.FormattingEnabled = true;
            WarehouseCB.IconColor = Color.Teal;
            WarehouseCB.Items.AddRange(new object[] { "--Warehouse--", "TMS", "STORE", "WAREHOUSE" });
            WarehouseCB.ListBackColor = Color.White;
            WarehouseCB.ListTextColor = Color.Black;
            WarehouseCB.Location = new Point(449, 214);
            WarehouseCB.Margin = new Padding(3, 2, 3, 2);
            WarehouseCB.MinimumSize = new Size(172, 0);
            WarehouseCB.Name = "WarehouseCB";
            WarehouseCB.Size = new Size(176, 24);
            WarehouseCB.TabIndex = 25;
            // 
            // qtyTextBox
            // 
            qtyTextBox.BorderStyle = BorderStyle.None;
            qtyTextBox.BottomBorderColor = Color.Black;
            qtyTextBox.BottomBorderOnFocusColor = Color.Blue;
            qtyTextBox.Cursor = Cursors.IBeam;
            qtyTextBox.Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point);
            qtyTextBox.Location = new Point(207, 219);
            qtyTextBox.Margin = new Padding(3, 2, 3, 2);
            qtyTextBox.Name = "qtyTextBox";
            qtyTextBox.PlaceholderText = "Box";
            qtyTextBox.Size = new Size(38, 19);
            qtyTextBox.TabIndex = 24;
            qtyTextBox.Text = "Qty";
            qtyTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // LabelProductModal
            // 
            LabelProductModal.AutoSize = true;
            LabelProductModal.Location = new Point(12, 351);
            LabelProductModal.Name = "LabelProductModal";
            LabelProductModal.Size = new Size(0, 12);
            LabelProductModal.TabIndex = 23;
            LabelProductModal.Visible = false;
            // 
            // dpTextBox
            // 
            dpTextBox.BorderStyle = BorderStyle.None;
            dpTextBox.BottomBorderColor = Color.Black;
            dpTextBox.BottomBorderOnFocusColor = Color.Blue;
            dpTextBox.Cursor = Cursors.IBeam;
            dpTextBox.Enabled = false;
            dpTextBox.Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dpTextBox.Location = new Point(444, 180);
            dpTextBox.Margin = new Padding(3, 2, 3, 2);
            dpTextBox.Name = "dpTextBox";
            dpTextBox.PlaceholderText = "D.P";
            dpTextBox.ReadOnly = true;
            dpTextBox.Size = new Size(104, 19);
            dpTextBox.TabIndex = 21;
            dpTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // srpTextBox
            // 
            srpTextBox.BorderStyle = BorderStyle.None;
            srpTextBox.BottomBorderColor = Color.Black;
            srpTextBox.BottomBorderOnFocusColor = Color.Blue;
            srpTextBox.Cursor = Cursors.IBeam;
            srpTextBox.Font = new Font("SimSun", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            srpTextBox.Location = new Point(444, 139);
            srpTextBox.Margin = new Padding(3, 2, 3, 2);
            srpTextBox.Name = "srpTextBox";
            srpTextBox.PlaceholderText = "零售价 S.R.P";
            srpTextBox.Size = new Size(93, 19);
            srpTextBox.TabIndex = 19;
            srpTextBox.TextAlign = HorizontalAlignment.Center;
            srpTextBox.TextChanged += srpTextBox_TextChanged;
            srpTextBox.KeyDown += srpTextBox_KeyDown;
            // 
            // boxTextBox
            // 
            boxTextBox.BorderStyle = BorderStyle.None;
            boxTextBox.BottomBorderColor = Color.Black;
            boxTextBox.BottomBorderOnFocusColor = Color.Blue;
            boxTextBox.Cursor = Cursors.IBeam;
            boxTextBox.Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point);
            boxTextBox.Location = new Point(150, 220);
            boxTextBox.Margin = new Padding(3, 2, 3, 2);
            boxTextBox.Name = "boxTextBox";
            boxTextBox.PlaceholderText = "Box";
            boxTextBox.Size = new Size(38, 19);
            boxTextBox.TabIndex = 20;
            boxTextBox.TextAlign = HorizontalAlignment.Center;
            boxTextBox.KeyDown += boxTextBox_KeyDown;
            // 
            // sizeTextBox
            // 
            sizeTextBox.BorderStyle = BorderStyle.None;
            sizeTextBox.BottomBorderColor = Color.Black;
            sizeTextBox.BottomBorderOnFocusColor = Color.Blue;
            sizeTextBox.Cursor = Cursors.IBeam;
            sizeTextBox.Font = new Font("SimSun", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            sizeTextBox.Location = new Point(323, 181);
            sizeTextBox.Margin = new Padding(3, 2, 3, 2);
            sizeTextBox.Name = "sizeTextBox";
            sizeTextBox.PlaceholderText = "尺寸 ᶲSize(mm)";
            sizeTextBox.Size = new Size(104, 19);
            sizeTextBox.TabIndex = 15;
            sizeTextBox.TextAlign = HorizontalAlignment.Center;
            sizeTextBox.KeyDown += sizeTextBox_KeyDown;
            // 
            // ctnWTextBox
            // 
            ctnWTextBox.BorderStyle = BorderStyle.None;
            ctnWTextBox.BottomBorderColor = Color.Black;
            ctnWTextBox.BottomBorderOnFocusColor = Color.Blue;
            ctnWTextBox.Cursor = Cursors.IBeam;
            ctnWTextBox.Font = new Font("SimSun", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ctnWTextBox.Location = new Point(262, 181);
            ctnWTextBox.Margin = new Padding(3, 2, 3, 2);
            ctnWTextBox.Name = "ctnWTextBox";
            ctnWTextBox.PlaceholderText = "Ctn W";
            ctnWTextBox.Size = new Size(38, 19);
            ctnWTextBox.TabIndex = 17;
            ctnWTextBox.TextAlign = HorizontalAlignment.Center;
            ctnWTextBox.KeyDown += ctnWTextBox_KeyDown;
            // 
            // ctnHTextBox
            // 
            ctnHTextBox.BorderStyle = BorderStyle.None;
            ctnHTextBox.BottomBorderColor = Color.Black;
            ctnHTextBox.BottomBorderOnFocusColor = Color.Blue;
            ctnHTextBox.Cursor = Cursors.IBeam;
            ctnHTextBox.Font = new Font("SimSun", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ctnHTextBox.Location = new Point(207, 181);
            ctnHTextBox.Margin = new Padding(3, 2, 3, 2);
            ctnHTextBox.Name = "ctnHTextBox";
            ctnHTextBox.PlaceholderText = "Ctn H";
            ctnHTextBox.Size = new Size(38, 19);
            ctnHTextBox.TabIndex = 18;
            ctnHTextBox.TextAlign = HorizontalAlignment.Center;
            ctnHTextBox.KeyDown += ctnHTextBox_KeyDown;
            // 
            // ctnLTextBox
            // 
            ctnLTextBox.BorderStyle = BorderStyle.None;
            ctnLTextBox.BottomBorderColor = Color.Black;
            ctnLTextBox.BottomBorderOnFocusColor = Color.Blue;
            ctnLTextBox.Cursor = Cursors.IBeam;
            ctnLTextBox.Font = new Font("SimSun", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ctnLTextBox.Location = new Point(150, 181);
            ctnLTextBox.Margin = new Padding(3, 2, 3, 2);
            ctnLTextBox.Name = "ctnLTextBox";
            ctnLTextBox.PlaceholderText = "Ctn L";
            ctnLTextBox.Size = new Size(38, 18);
            ctnLTextBox.TabIndex = 16;
            ctnLTextBox.TextAlign = HorizontalAlignment.Center;
            ctnLTextBox.KeyDown += ctnLTextBox_KeyDown;
            // 
            // wattsTextBox
            // 
            wattsTextBox.BorderStyle = BorderStyle.None;
            wattsTextBox.BottomBorderColor = Color.Black;
            wattsTextBox.BottomBorderOnFocusColor = Color.Blue;
            wattsTextBox.Cursor = Cursors.IBeam;
            wattsTextBox.Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point);
            wattsTextBox.Location = new Point(544, 138);
            wattsTextBox.Margin = new Padding(3, 2, 3, 2);
            wattsTextBox.Name = "wattsTextBox";
            wattsTextBox.PlaceholderText = "功率 Watts";
            wattsTextBox.Size = new Size(81, 19);
            wattsTextBox.TabIndex = 14;
            wattsTextBox.TextAlign = HorizontalAlignment.Center;
            wattsTextBox.KeyDown += wattsTextBox_KeyDown;
            // 
            // avTextbox
            // 
            avTextbox.BorderStyle = BorderStyle.None;
            avTextbox.BottomBorderColor = Color.Black;
            avTextbox.BottomBorderOnFocusColor = Color.Blue;
            avTextbox.Cursor = Cursors.IBeam;
            avTextbox.Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point);
            avTextbox.Location = new Point(574, 182);
            avTextbox.Margin = new Padding(3, 2, 3, 2);
            avTextbox.Name = "avTextbox";
            avTextbox.PlaceholderText = "电源AV";
            avTextbox.Size = new Size(51, 19);
            avTextbox.TabIndex = 12;
            avTextbox.TextAlign = HorizontalAlignment.Center;
            avTextbox.KeyDown += avTextbox_KeyDown;
            // 
            // colorTextBox
            // 
            colorTextBox.BorderStyle = BorderStyle.None;
            colorTextBox.BottomBorderColor = Color.Black;
            colorTextBox.BottomBorderOnFocusColor = Color.Blue;
            colorTextBox.Cursor = Cursors.IBeam;
            colorTextBox.Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point);
            colorTextBox.Location = new Point(262, 139);
            colorTextBox.Margin = new Padding(3, 2, 3, 2);
            colorTextBox.Name = "colorTextBox";
            colorTextBox.PlaceholderText = "颜色 Color";
            colorTextBox.Size = new Size(165, 19);
            colorTextBox.TabIndex = 10;
            colorTextBox.TextAlign = HorizontalAlignment.Center;
            colorTextBox.KeyDown += colorTextBox_KeyDown;
            // 
            // itemCodeTextBox
            // 
            itemCodeTextBox.BorderStyle = BorderStyle.None;
            itemCodeTextBox.BottomBorderColor = Color.Black;
            itemCodeTextBox.BottomBorderOnFocusColor = Color.Blue;
            itemCodeTextBox.Cursor = Cursors.IBeam;
            itemCodeTextBox.Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point);
            itemCodeTextBox.Location = new Point(150, 139);
            itemCodeTextBox.Margin = new Padding(3, 2, 3, 2);
            itemCodeTextBox.Name = "itemCodeTextBox";
            itemCodeTextBox.PlaceholderText = "Item Code";
            itemCodeTextBox.Size = new Size(95, 19);
            itemCodeTextBox.TabIndex = 5;
            itemCodeTextBox.TextAlign = HorizontalAlignment.Center;
            itemCodeTextBox.KeyDown += itemCodeTextBox_KeyDown;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.BorderStyle = BorderStyle.None;
            descriptionTextBox.BottomBorderColor = Color.Black;
            descriptionTextBox.BottomBorderOnFocusColor = Color.Blue;
            descriptionTextBox.Cursor = Cursors.IBeam;
            descriptionTextBox.Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point);
            descriptionTextBox.Location = new Point(444, 101);
            descriptionTextBox.Margin = new Padding(3, 2, 3, 2);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.PlaceholderText = "规格 Description";
            descriptionTextBox.Size = new Size(181, 19);
            descriptionTextBox.TabIndex = 11;
            descriptionTextBox.TextAlign = HorizontalAlignment.Center;
            descriptionTextBox.KeyDown += descriptionTextBox_KeyDown;
            // 
            // refTextBox
            // 
            refTextBox.BorderStyle = BorderStyle.None;
            refTextBox.BottomBorderColor = Color.Black;
            refTextBox.BottomBorderOnFocusColor = Color.Blue;
            refTextBox.Cursor = Cursors.IBeam;
            refTextBox.Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point);
            refTextBox.Location = new Point(262, 101);
            refTextBox.Margin = new Padding(3, 2, 3, 2);
            refTextBox.Name = "refTextBox";
            refTextBox.PlaceholderText = "工厂型号 Ref.code";
            refTextBox.Size = new Size(165, 19);
            refTextBox.TabIndex = 9;
            refTextBox.TextAlign = HorizontalAlignment.Center;
            refTextBox.KeyDown += refTextBox_KeyDown;
            // 
            // sortTextBox
            // 
            sortTextBox.BorderStyle = BorderStyle.None;
            sortTextBox.BottomBorderColor = Color.Black;
            sortTextBox.BottomBorderOnFocusColor = Color.Blue;
            sortTextBox.Cursor = Cursors.IBeam;
            sortTextBox.Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point);
            sortTextBox.Location = new Point(150, 101);
            sortTextBox.Margin = new Padding(3, 2, 3, 2);
            sortTextBox.Name = "sortTextBox";
            sortTextBox.PlaceholderText = "类别Sort";
            sortTextBox.Size = new Size(95, 19);
            sortTextBox.TabIndex = 0;
            sortTextBox.TextAlign = HorizontalAlignment.Center;
            sortTextBox.KeyDown += sortTextBox_KeyDown;
            // 
            // Add_UpdateBTN
            // 
            Add_UpdateBTN.BackColor = Color.White;
            Add_UpdateBTN.Cursor = Cursors.Hand;
            Add_UpdateBTN.FlatStyle = FlatStyle.Popup;
            Add_UpdateBTN.Font = new Font("SimSun", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Add_UpdateBTN.HoverForeColor1 = Color.SteelBlue;
            Add_UpdateBTN.HoverImage1 = null;
            Add_UpdateBTN.Location = new Point(538, 331);
            Add_UpdateBTN.Margin = new Padding(3, 2, 3, 2);
            Add_UpdateBTN.Name = "Add_UpdateBTN";
            Add_UpdateBTN.NormalForeColor1 = Color.Black;
            Add_UpdateBTN.NormalImage1 = null;
            Add_UpdateBTN.OnFocusEnterImage = null;
            Add_UpdateBTN.OnFocusLeaveImage = null;
            Add_UpdateBTN.Size = new Size(111, 32);
            Add_UpdateBTN.TabIndex = 22;
            Add_UpdateBTN.Text = "Add";
            Add_UpdateBTN.Tooltip1 = null;
            Add_UpdateBTN.UseVisualStyleBackColor = false;
            Add_UpdateBTN.Click += Add_UpdateBTN_Click;
            // 
            // CategoryCB
            // 
            CategoryCB.BackColor = Color.White;
            CategoryCB.BackColor1 = Color.White;
            CategoryCB.Bordercolor = Color.DeepSkyBlue;
            CategoryCB.BorderSize = 2;
            CategoryCB.DropDownStyle = ComboBoxStyle.DropDownList;
            CategoryCB.Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CategoryCB.ForeColor = Color.DimGray;
            CategoryCB.FormattingEnabled = true;
            CategoryCB.IconColor = Color.Teal;
            CategoryCB.Items.AddRange(new object[] { "--Category--", "GS Ceiling and Chandelier Lights", "GS Crystal Lights", "GS Fan", "GS Panel Lights", "GS Strip Lights", "New Chandelier Lights" });
            CategoryCB.ListBackColor = Color.White;
            CategoryCB.ListTextColor = Color.Black;
            CategoryCB.Location = new Point(262, 214);
            CategoryCB.Margin = new Padding(3, 2, 3, 2);
            CategoryCB.MinimumSize = new Size(172, 0);
            CategoryCB.Name = "CategoryCB";
            CategoryCB.Size = new Size(181, 24);
            CategoryCB.TabIndex = 13;
            CategoryCB.KeyDown += warehouseComboBox_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("SimSun", 20.25F, FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 16);
            label1.Name = "label1";
            label1.Size = new Size(278, 27);
            label1.TabIndex = 8;
            label1.Text = "Product Information";
            // 
            // AddPhotoBTN
            // 
            AddPhotoBTN.BackColor = Color.FromArgb(59, 116, 192);
            AddPhotoBTN.Font = new Font("SimSun", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            AddPhotoBTN.ForeColor = SystemColors.ControlLightLight;
            AddPhotoBTN.HoverForeColor1 = Color.SteelBlue;
            AddPhotoBTN.HoverImage1 = null;
            AddPhotoBTN.Location = new Point(3, 176);
            AddPhotoBTN.Margin = new Padding(3, 2, 3, 2);
            AddPhotoBTN.Name = "AddPhotoBTN";
            AddPhotoBTN.NormalForeColor1 = Color.Black;
            AddPhotoBTN.NormalImage1 = null;
            AddPhotoBTN.OnFocusEnterImage = null;
            AddPhotoBTN.OnFocusLeaveImage = null;
            AddPhotoBTN.Size = new Size(133, 27);
            AddPhotoBTN.TabIndex = 2;
            AddPhotoBTN.Text = "Add Photo";
            AddPhotoBTN.Tooltip1 = null;
            AddPhotoBTN.UseVisualStyleBackColor = false;
            AddPhotoBTN.Click += AddPhotoBTN_Click;
            // 
            // SelectImagePB
            // 
            SelectImagePB.Cursor = Cursors.Hand;
            SelectImagePB.Image = Properties.Resources.icons8_image_100;
            SelectImagePB.Location = new Point(17, 64);
            SelectImagePB.Margin = new Padding(3, 2, 3, 2);
            SelectImagePB.Name = "SelectImagePB";
            SelectImagePB.Size = new Size(107, 100);
            SelectImagePB.SizeMode = PictureBoxSizeMode.StretchImage;
            SelectImagePB.TabIndex = 1;
            SelectImagePB.TabStop = false;
            // 
            // CloseModal
            // 
            CloseModal.FlatAppearance.BorderSize = 0;
            CloseModal.FlatStyle = FlatStyle.Flat;
            CloseModal.Image = Properties.Resources.icons8_cancel_30;
            CloseModal.Location = new Point(624, 2);
            CloseModal.Name = "CloseModal";
            CloseModal.Size = new Size(35, 23);
            CloseModal.TabIndex = 26;
            CloseModal.UseVisualStyleBackColor = true;
            CloseModal.Click += CloseModal_click;
            // 
            // WarehouseModalForm
            // 
            AutoScaleDimensions = new SizeF(6F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(59, 116, 192);
            ClientSize = new Size(686, 398);
            Controls.Add(bgPanel);
            Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(686, 398);
            Name = "WarehouseModalForm";
            Padding = new Padding(13, 12, 13, 12);
            StartPosition = FormStartPosition.CenterParent;
            Text = "WarehouseModalForm";
            bgPanel.ResumeLayout(false);
            bgPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SelectImagePB).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel bgPanel;
        private CustomComboBox CategoryCB;
        private CustomTextBox avTextbox;
        private CustomTextBox descriptionTextBox;
        private CustomTextBox colorTextBox;
        private CustomTextBox refTextBox;
        private Label label1;
        private CustomTextBox itemCodeTextBox;
        private CustomButton AddPhotoBTN;
        private PictureBox SelectImagePB;
        private CustomTextBox sortTextBox;
        private CustomTextBox srpTextBox;
        private CustomTextBox ctnHTextBox;
        private CustomTextBox ctnWTextBox;
        private CustomTextBox ctnLTextBox;
        private CustomTextBox sizeTextBox;
        private CustomTextBox wattsTextBox;
        private CustomTextBox dpTextBox;
        private CustomTextBox boxTextBox;
        private CustomButton Add_UpdateBTN;
        private Label LabelProductModal;
        private CustomTextBox qtyTextBox;
        private CustomComboBox WarehouseCB;
        private Button CloseModal;
    }
}