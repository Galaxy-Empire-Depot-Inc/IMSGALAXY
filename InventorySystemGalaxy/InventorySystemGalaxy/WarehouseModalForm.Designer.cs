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
            addBtn = new CustomButton();
            warehouseComboBox = new CustomComboBox();
            label1 = new Label();
            customButton1 = new CustomButton();
            pictureBox1 = new PictureBox();
            bgPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // bgPanel
            // 
            bgPanel.BackColor = Color.FromArgb(59, 116, 192);
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
            bgPanel.Controls.Add(addBtn);
            bgPanel.Controls.Add(warehouseComboBox);
            bgPanel.Controls.Add(label1);
            bgPanel.Controls.Add(customButton1);
            bgPanel.Controls.Add(pictureBox1);
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
            // dpTextBox
            // 
            dpTextBox.BorderStyle = BorderStyle.None;
            dpTextBox.BottomBorderColor = Color.Black;
            dpTextBox.BottomBorderOnFocusColor = Color.Blue;
            dpTextBox.Enabled = false;
            dpTextBox.Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dpTextBox.Location = new Point(323, 220);
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
            srpTextBox.Font = new Font("SimSun", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            srpTextBox.Location = new Point(207, 220);
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
            wattsTextBox.Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point);
            wattsTextBox.Location = new Point(544, 139);
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
            avTextbox.Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point);
            avTextbox.Location = new Point(444, 139);
            avTextbox.Margin = new Padding(3, 2, 3, 2);
            avTextbox.Name = "avTextbox";
            avTextbox.PlaceholderText = "电源AV";
            avTextbox.Size = new Size(72, 19);
            avTextbox.TabIndex = 12;
            avTextbox.TextAlign = HorizontalAlignment.Center;
            avTextbox.KeyDown += avTextbox_KeyDown;
            // 
            // colorTextBox
            // 
            colorTextBox.BorderStyle = BorderStyle.None;
            colorTextBox.BottomBorderColor = Color.Black;
            colorTextBox.BottomBorderOnFocusColor = Color.Blue;
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
            // addBtn
            // 
            addBtn.BackColor = Color.White;
            addBtn.FlatStyle = FlatStyle.Popup;
            addBtn.Font = new Font("SimSun", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            addBtn.HoverForeColor1 = Color.SteelBlue;
            addBtn.HoverImage1 = null;
            addBtn.Location = new Point(538, 331);
            addBtn.Margin = new Padding(3, 2, 3, 2);
            addBtn.Name = "addBtn";
            addBtn.NormalForeColor1 = Color.Black;
            addBtn.NormalImage1 = null;
            addBtn.OnFocusEnterImage = null;
            addBtn.OnFocusLeaveImage = null;
            addBtn.Size = new Size(111, 32);
            addBtn.TabIndex = 22;
            addBtn.Text = "Add";
            addBtn.Tooltip1 = null;
            addBtn.UseVisualStyleBackColor = false;
            // 
            // warehouseComboBox
            // 
            warehouseComboBox.BackColor = Color.White;
            warehouseComboBox.BackColor1 = Color.White;
            warehouseComboBox.Bordercolor = Color.DeepSkyBlue;
            warehouseComboBox.BorderSize = 2;
            warehouseComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            warehouseComboBox.Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point);
            warehouseComboBox.ForeColor = Color.DimGray;
            warehouseComboBox.FormattingEnabled = true;
            warehouseComboBox.IconColor = Color.Teal;
            warehouseComboBox.Items.AddRange(new object[] { "--Warehouse--", "TMS", "STORE", "WAREHOUSE" });
            warehouseComboBox.ListBackColor = Color.White;
            warehouseComboBox.ListTextColor = Color.Black;
            warehouseComboBox.Location = new Point(444, 181);
            warehouseComboBox.Margin = new Padding(3, 2, 3, 2);
            warehouseComboBox.MinimumSize = new Size(172, 0);
            warehouseComboBox.Name = "warehouseComboBox";
            warehouseComboBox.Size = new Size(181, 24);
            warehouseComboBox.TabIndex = 13;
            warehouseComboBox.KeyDown += warehouseComboBox_KeyDown;
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
            // customButton1
            // 
            customButton1.BackColor = Color.White;
            customButton1.FlatStyle = FlatStyle.Popup;
            customButton1.Font = new Font("SimSun", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            customButton1.HoverForeColor1 = Color.SteelBlue;
            customButton1.HoverImage1 = null;
            customButton1.Location = new Point(11, 178);
            customButton1.Margin = new Padding(3, 2, 3, 2);
            customButton1.Name = "customButton1";
            customButton1.NormalForeColor1 = Color.Black;
            customButton1.NormalImage1 = null;
            customButton1.OnFocusEnterImage = null;
            customButton1.OnFocusLeaveImage = null;
            customButton1.Size = new Size(107, 24);
            customButton1.TabIndex = 2;
            customButton1.Text = "Add Photo";
            customButton1.Tooltip1 = null;
            customButton1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_product_100;
            pictureBox1.Location = new Point(11, 64);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(107, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel bgPanel;
        private CustomComboBox warehouseComboBox;
        private CustomTextBox avTextbox;
        private CustomTextBox descriptionTextBox;
        private CustomTextBox colorTextBox;
        private CustomTextBox refTextBox;
        private Label label1;
        private CustomTextBox itemCodeTextBox;
        private CustomButton customButton1;
        private PictureBox pictureBox1;
        private CustomTextBox sortTextBox;
        private CustomTextBox srpTextBox;
        private CustomTextBox ctnHTextBox;
        private CustomTextBox ctnWTextBox;
        private CustomTextBox ctnLTextBox;
        private CustomTextBox sizeTextBox;
        private CustomTextBox wattsTextBox;
        private CustomTextBox dpTextBox;
        private CustomTextBox boxTextBox;
        private CustomButton addBtn;
    }
}