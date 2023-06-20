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
            RepairPanel = new Panel();
            repairText = new CustomTextBox();
            label4 = new Label();
            DisplayPanel = new Panel();
            displayText = new CustomTextBox();
            label3 = new Label();
            AvailablityPanel = new Panel();
            availabilityText = new CustomTextBox();
            label2 = new Label();
            CloseModal = new Button();
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
            bgPanel.SuspendLayout();
            RepairPanel.SuspendLayout();
            DisplayPanel.SuspendLayout();
            AvailablityPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SelectImagePB).BeginInit();
            SuspendLayout();
            // 
            // bgPanel
            // 
            bgPanel.BackColor = Color.FromArgb(59, 116, 192);
            bgPanel.Controls.Add(RepairPanel);
            bgPanel.Controls.Add(DisplayPanel);
            bgPanel.Controls.Add(AvailablityPanel);
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
            // RepairPanel
            // 
            RepairPanel.Controls.Add(repairText);
            RepairPanel.Controls.Add(label4);
            RepairPanel.Location = new Point(402, 291);
            RepairPanel.Name = "RepairPanel";
            RepairPanel.Size = new Size(103, 32);
            RepairPanel.TabIndex = 33;
            RepairPanel.Visible = false;
            // 
            // repairText
            // 
            repairText.BorderStyle = BorderStyle.None;
            repairText.BottomBorderColor = Color.Black;
            repairText.BottomBorderOnFocusColor = Color.Blue;
            repairText.Cursor = Cursors.IBeam;
            repairText.Enabled = false;
            repairText.Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point);
            repairText.Location = new Point(47, 3);
            repairText.Margin = new Padding(3, 2, 3, 2);
            repairText.Name = "repairText";
            repairText.Size = new Size(52, 28);
            repairText.TabIndex = 31;
            repairText.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(4, 9);
            label4.Name = "label4";
            label4.Size = new Size(41, 12);
            label4.TabIndex = 0;
            label4.Text = "Repair";
            // 
            // DisplayPanel
            // 
            DisplayPanel.Controls.Add(displayText);
            DisplayPanel.Controls.Add(label3);
            DisplayPanel.Location = new Point(286, 291);
            DisplayPanel.Name = "DisplayPanel";
            DisplayPanel.Size = new Size(110, 32);
            DisplayPanel.TabIndex = 32;
            DisplayPanel.Visible = false;
            // 
            // displayText
            // 
            displayText.BorderStyle = BorderStyle.None;
            displayText.BottomBorderColor = Color.Black;
            displayText.BottomBorderOnFocusColor = Color.Blue;
            displayText.Cursor = Cursors.IBeam;
            displayText.Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point);
            displayText.Location = new Point(50, 2);
            displayText.Margin = new Padding(3, 2, 3, 2);
            displayText.Name = "displayText";
            displayText.Size = new Size(52, 28);
            displayText.TabIndex = 31;
            displayText.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(2, 8);
            label3.Name = "label3";
            label3.Size = new Size(47, 12);
            label3.TabIndex = 0;
            label3.Text = "Display";
            // 
            // AvailablityPanel
            // 
            AvailablityPanel.Controls.Add(availabilityText);
            AvailablityPanel.Controls.Add(label2);
            AvailablityPanel.Location = new Point(145, 291);
            AvailablityPanel.Name = "AvailablityPanel";
            AvailablityPanel.Size = new Size(135, 32);
            AvailablityPanel.TabIndex = 30;
            AvailablityPanel.Visible = false;
            // 
            // availabilityText
            // 
            availabilityText.BorderStyle = BorderStyle.None;
            availabilityText.BottomBorderColor = Color.Black;
            availabilityText.BottomBorderOnFocusColor = Color.Blue;
            availabilityText.Cursor = Cursors.IBeam;
            availabilityText.Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point);
            availabilityText.Location = new Point(72, 1);
            availabilityText.Margin = new Padding(3, 2, 3, 2);
            availabilityText.Name = "availabilityText";
            availabilityText.Size = new Size(52, 28);
            availabilityText.TabIndex = 31;
            availabilityText.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(5, 7);
            label2.Name = "label2";
            label2.Size = new Size(59, 12);
            label2.TabIndex = 0;
            label2.Text = "Available";
            label2.Click += label2_Click;
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
            WarehouseCB.Items.AddRange(new object[] { "--Warehouse--", "TMS", "STORE", "MLB" });
            WarehouseCB.ListBackColor = Color.White;
            WarehouseCB.ListTextColor = Color.Black;
            WarehouseCB.Location = new Point(145, 217);
            WarehouseCB.Margin = new Padding(3, 2, 3, 2);
            WarehouseCB.MinimumSize = new Size(172, 0);
            WarehouseCB.Name = "WarehouseCB";
            WarehouseCB.Size = new Size(243, 24);
            WarehouseCB.TabIndex = 25;
            // 
            // qtyTextBox
            // 
            qtyTextBox.BorderStyle = BorderStyle.None;
            qtyTextBox.BottomBorderColor = Color.Black;
            qtyTextBox.BottomBorderOnFocusColor = Color.Blue;
            qtyTextBox.Cursor = Cursors.IBeam;
            qtyTextBox.Font = new Font("SimSun", 13F, FontStyle.Regular, GraphicsUnit.Point);
            qtyTextBox.Location = new Point(245, 251);
            qtyTextBox.Margin = new Padding(3, 2, 3, 2);
            qtyTextBox.Name = "qtyTextBox";
            qtyTextBox.PlaceholderText = "Qty";
            qtyTextBox.Size = new Size(90, 30);
            qtyTextBox.TabIndex = 24;
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
            dpTextBox.Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dpTextBox.Location = new Point(539, 140);
            dpTextBox.Margin = new Padding(3, 2, 3, 2);
            dpTextBox.Name = "dpTextBox";
            dpTextBox.PlaceholderText = "D.P";
            dpTextBox.Size = new Size(99, 30);
            dpTextBox.TabIndex = 21;
            dpTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // srpTextBox
            // 
            srpTextBox.BorderStyle = BorderStyle.None;
            srpTextBox.BottomBorderColor = Color.Black;
            srpTextBox.BottomBorderOnFocusColor = Color.Blue;
            srpTextBox.Cursor = Cursors.IBeam;
            srpTextBox.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            srpTextBox.Location = new Point(543, 98);
            srpTextBox.Margin = new Padding(3, 2, 3, 2);
            srpTextBox.Name = "srpTextBox";
            srpTextBox.PlaceholderText = "零售价 S.R.P";
            srpTextBox.Size = new Size(95, 30);
            srpTextBox.TabIndex = 19;
            srpTextBox.TextAlign = HorizontalAlignment.Center;
            srpTextBox.TextChanged += srpTextBox_TextChanged;
            srpTextBox.KeyDown += srpTextBox_KeyDown;
            srpTextBox.KeyPress += srpTextBox_KeyPress;
            // 
            // boxTextBox
            // 
            boxTextBox.BorderStyle = BorderStyle.None;
            boxTextBox.BottomBorderColor = Color.Black;
            boxTextBox.BottomBorderOnFocusColor = Color.Blue;
            boxTextBox.Cursor = Cursors.IBeam;
            boxTextBox.Font = new Font("SimSun", 13F, FontStyle.Regular, GraphicsUnit.Point);
            boxTextBox.Location = new Point(146, 251);
            boxTextBox.Margin = new Padding(3, 2, 3, 2);
            boxTextBox.Name = "boxTextBox";
            boxTextBox.PlaceholderText = "Box";
            boxTextBox.Size = new Size(55, 30);
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
            sizeTextBox.Location = new Point(315, 179);
            sizeTextBox.Margin = new Padding(3, 2, 3, 2);
            sizeTextBox.Name = "sizeTextBox";
            sizeTextBox.PlaceholderText = "尺寸 ᶲSize(mm)";
            sizeTextBox.Size = new Size(323, 30);
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
            ctnWTextBox.Font = new Font("SimSun", 13F, FontStyle.Regular, GraphicsUnit.Point);
            ctnWTextBox.Location = new Point(568, 251);
            ctnWTextBox.Margin = new Padding(3, 2, 3, 2);
            ctnWTextBox.Name = "ctnWTextBox";
            ctnWTextBox.PlaceholderText = "Ctn W";
            ctnWTextBox.Size = new Size(70, 30);
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
            ctnHTextBox.Font = new Font("SimSun", 13F, FontStyle.Regular, GraphicsUnit.Point);
            ctnHTextBox.Location = new Point(463, 251);
            ctnHTextBox.Margin = new Padding(3, 2, 3, 2);
            ctnHTextBox.Name = "ctnHTextBox";
            ctnHTextBox.PlaceholderText = "Ctn H";
            ctnHTextBox.Size = new Size(70, 30);
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
            ctnLTextBox.Font = new Font("SimSun", 13F, FontStyle.Regular, GraphicsUnit.Point);
            ctnLTextBox.Location = new Point(366, 251);
            ctnLTextBox.Margin = new Padding(3, 2, 3, 2);
            ctnLTextBox.Name = "ctnLTextBox";
            ctnLTextBox.PlaceholderText = "Ctn L";
            ctnLTextBox.Size = new Size(70, 30);
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
            wattsTextBox.Location = new Point(214, 179);
            wattsTextBox.Margin = new Padding(3, 2, 3, 2);
            wattsTextBox.Name = "wattsTextBox";
            wattsTextBox.PlaceholderText = "功率 Watts";
            wattsTextBox.Size = new Size(90, 30);
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
            avTextbox.Font = new Font("SimSun", 13F, FontStyle.Regular, GraphicsUnit.Point);
            avTextbox.Location = new Point(145, 179);
            avTextbox.Margin = new Padding(3, 2, 3, 2);
            avTextbox.Name = "avTextbox";
            avTextbox.PlaceholderText = "电源AV";
            avTextbox.Size = new Size(55, 30);
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
            colorTextBox.Font = new Font("SimSun", 13F, FontStyle.Regular, GraphicsUnit.Point);
            colorTextBox.Location = new Point(145, 140);
            colorTextBox.Margin = new Padding(3, 2, 3, 2);
            colorTextBox.Name = "colorTextBox";
            colorTextBox.PlaceholderText = "颜色 Color";
            colorTextBox.Size = new Size(155, 30);
            colorTextBox.TabIndex = 10;
            colorTextBox.TextAlign = HorizontalAlignment.Center;
            colorTextBox.TextChanged += colorTextBox_TextChanged;
            colorTextBox.KeyDown += colorTextBox_KeyDown;
            // 
            // itemCodeTextBox
            // 
            itemCodeTextBox.BorderStyle = BorderStyle.None;
            itemCodeTextBox.BottomBorderColor = Color.Black;
            itemCodeTextBox.BottomBorderOnFocusColor = Color.Blue;
            itemCodeTextBox.Cursor = Cursors.IBeam;
            itemCodeTextBox.Font = new Font("SimSun", 13F, FontStyle.Regular, GraphicsUnit.Point);
            itemCodeTextBox.Location = new Point(266, 98);
            itemCodeTextBox.Margin = new Padding(3, 2, 3, 2);
            itemCodeTextBox.Name = "itemCodeTextBox";
            itemCodeTextBox.PlaceholderText = "Item Code";
            itemCodeTextBox.Size = new Size(100, 30);
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
            descriptionTextBox.Location = new Point(306, 140);
            descriptionTextBox.Margin = new Padding(3, 2, 3, 2);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.PlaceholderText = "规格 Description";
            descriptionTextBox.Size = new Size(227, 30);
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
            refTextBox.Font = new Font("Microsoft Sans Serif", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            refTextBox.Location = new Point(372, 98);
            refTextBox.Margin = new Padding(3, 2, 3, 2);
            refTextBox.Name = "refTextBox";
            refTextBox.PlaceholderText = "工厂型号 Ref.code";
            refTextBox.Size = new Size(165, 30);
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
            sortTextBox.Font = new Font("SimSun", 13F, FontStyle.Regular, GraphicsUnit.Point);
            sortTextBox.Location = new Point(145, 98);
            sortTextBox.Margin = new Padding(3, 2, 3, 2);
            sortTextBox.Name = "sortTextBox";
            sortTextBox.PlaceholderText = "类别Sort";
            sortTextBox.Size = new Size(115, 30);
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
            CategoryCB.Location = new Point(394, 217);
            CategoryCB.Margin = new Padding(3, 2, 3, 2);
            CategoryCB.MinimumSize = new Size(172, 0);
            CategoryCB.Name = "CategoryCB";
            CategoryCB.Size = new Size(244, 24);
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
            AddPhotoBTN.Cursor = Cursors.Hand;
            AddPhotoBTN.Font = new Font("SimSun", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            AddPhotoBTN.ForeColor = SystemColors.ControlLightLight;
            AddPhotoBTN.HoverForeColor1 = Color.SteelBlue;
            AddPhotoBTN.HoverImage1 = null;
            AddPhotoBTN.Location = new Point(5, 188);
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
            SelectImagePB.Location = new Point(19, 76);
            SelectImagePB.Margin = new Padding(3, 2, 3, 2);
            SelectImagePB.Name = "SelectImagePB";
            SelectImagePB.Size = new Size(107, 100);
            SelectImagePB.SizeMode = PictureBoxSizeMode.StretchImage;
            SelectImagePB.TabIndex = 1;
            SelectImagePB.TabStop = false;
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
            Opacity = 0.9D;
            Padding = new Padding(13, 12, 13, 12);
            StartPosition = FormStartPosition.CenterParent;
            Text = "WarehouseModalForm";
            Load += WarehouseModalForm_Load;
            bgPanel.ResumeLayout(false);
            bgPanel.PerformLayout();
            RepairPanel.ResumeLayout(false);
            RepairPanel.PerformLayout();
            DisplayPanel.ResumeLayout(false);
            DisplayPanel.PerformLayout();
            AvailablityPanel.ResumeLayout(false);
            AvailablityPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SelectImagePB).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel bgPanel;
        private Label label1;
        private Label LabelProductModal;
        private Button CloseModal;
        public CustomButton Add_UpdateBTN;
        public CustomTextBox refTextBox;
        public CustomTextBox itemCodeTextBox;
        public CustomTextBox sortTextBox;
        public CustomTextBox srpTextBox;
        public CustomTextBox avTextbox;
        public CustomTextBox descriptionTextBox;
        public CustomTextBox colorTextBox;
        public CustomTextBox ctnHTextBox;
        public CustomTextBox ctnWTextBox;
        public CustomTextBox ctnLTextBox;
        public CustomTextBox sizeTextBox;
        public CustomTextBox wattsTextBox;
        public CustomTextBox dpTextBox;
        public CustomTextBox boxTextBox;
        public CustomTextBox qtyTextBox;
        public CustomComboBox CategoryCB;
        public CustomComboBox WarehouseCB;
        public PictureBox SelectImagePB;
        private Label label2;
        public CustomTextBox repairText;
        private Label label4;
        public CustomTextBox displayText;
        private Label label3;
        public CustomTextBox availabilityText;
        public Panel AvailablityPanel;
        public Panel RepairPanel;
        public Panel DisplayPanel;
        public CustomButton AddPhotoBTN;
    }
}