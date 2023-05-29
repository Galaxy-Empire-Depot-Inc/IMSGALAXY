namespace InventorySystemGalaxy
{
    partial class Warehouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Warehouse));
            label1 = new Label();
            customButton1 = new CustomButton();
            panel5 = new Panel();
            panel4 = new Panel();
            panel7 = new Panel();
            pictureBox1 = new PictureBox();
            customTextBox1 = new CustomTextBox();
            panel3 = new Panel();
            employeeTable = new DataGridView();
            panel6 = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            sortLabel = new DataGridViewTextBoxColumn();
            itemCodeLabel = new DataGridViewTextBoxColumn();
            refCodeLabel = new DataGridViewTextBoxColumn();
            pictureLabel = new DataGridViewImageColumn();
            colorLabel = new DataGridViewTextBoxColumn();
            descriptionLabel = new DataGridViewTextBoxColumn();
            avLabel = new DataGridViewTextBoxColumn();
            wattsLabel = new DataGridViewTextBoxColumn();
            sizeLabel = new DataGridViewTextBoxColumn();
            ctnSizeLLabel = new DataGridViewTextBoxColumn();
            ctnSizeWLabel = new DataGridViewTextBoxColumn();
            ctnSizeHLabel = new DataGridViewTextBoxColumn();
            srpLabel = new DataGridViewTextBoxColumn();
            downPaymentLabel = new DataGridViewTextBoxColumn();
            warehouseLabel = new DataGridViewTextBoxColumn();
            qtyLabel = new DataGridViewTextBoxColumn();
            boxLabel = new DataGridViewTextBoxColumn();
            panel4.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)employeeTable).BeginInit();
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDark;
            label1.Location = new Point(8, 16);
            label1.Name = "label1";
            label1.Size = new Size(208, 27);
            label1.TabIndex = 1;
            label1.Text = "Warehouse(ALL)";
            // 
            // customButton1
            // 
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.Font = new Font("SimSun", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            customButton1.ForeColor = Color.White;
            customButton1.HoverForeColor1 = Color.Black;
            customButton1.HoverImage1 = Properties.Resources.icons8_add_100__2___1_;
            customButton1.Image = Properties.Resources.icons8_add_100__1___1_;
            customButton1.ImageAlign = ContentAlignment.MiddleLeft;
            customButton1.Location = new Point(7, 42);
            customButton1.Name = "customButton1";
            customButton1.NormalForeColor1 = Color.White;
            customButton1.NormalImage1 = Properties.Resources.icons8_add_100__1___1_;
            customButton1.OnFocusEnterImage = null;
            customButton1.OnFocusLeaveImage = null;
            customButton1.Padding = new Padding(10);
            customButton1.Size = new Size(115, 50);
            customButton1.TabIndex = 1;
            customButton1.Text = "   New";
            customButton1.TextAlign = ContentAlignment.MiddleLeft;
            customButton1.Tooltip1 = null;
            customButton1.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel5.Location = new Point(1135, 47);
            panel5.Name = "panel5";
            panel5.Size = new Size(240, 50);
            panel5.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(59, 116, 192);
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(customButton1);
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(5, 5);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(5);
            panel4.Size = new Size(920, 100);
            panel4.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel7.Controls.Add(pictureBox1);
            panel7.Controls.Add(customTextBox1);
            panel7.Location = new Point(680, 49);
            panel7.Name = "panel7";
            panel7.Size = new Size(240, 50);
            panel7.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.images_removebg_preview;
            pictureBox1.Location = new Point(13, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // customTextBox1
            // 
            customTextBox1.BorderStyle = BorderStyle.None;
            customTextBox1.BottomBorderColor = Color.LightSlateGray;
            customTextBox1.BottomBorderOnFocusColor = Color.CornflowerBlue;
            customTextBox1.Font = new Font("SimSun", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            customTextBox1.Location = new Point(54, 18);
            customTextBox1.Name = "customTextBox1";
            customTextBox1.PlaceholderText = "Search";
            customTextBox1.Size = new Size(177, 23);
            customTextBox1.TabIndex = 0;
            customTextBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Snow;
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(5, 55);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(5);
            panel3.Size = new Size(930, 110);
            panel3.TabIndex = 1;
            // 
            // employeeTable
            // 
            employeeTable.AllowUserToAddRows = false;
            employeeTable.AllowUserToDeleteRows = false;
            employeeTable.AllowUserToOrderColumns = true;
            employeeTable.AllowUserToResizeColumns = false;
            employeeTable.AllowUserToResizeRows = false;
            employeeTable.BackgroundColor = Color.White;
            employeeTable.BorderStyle = BorderStyle.Fixed3D;
            employeeTable.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            employeeTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            employeeTable.Columns.AddRange(new DataGridViewColumn[] { sortLabel, itemCodeLabel, refCodeLabel, pictureLabel, colorLabel, descriptionLabel, avLabel, wattsLabel, sizeLabel, ctnSizeLLabel, ctnSizeWLabel, ctnSizeHLabel, srpLabel, downPaymentLabel, warehouseLabel, qtyLabel, boxLabel });
            employeeTable.Dock = DockStyle.Fill;
            employeeTable.GridColor = Color.White;
            employeeTable.Location = new Point(5, 5);
            employeeTable.Name = "employeeTable";
            employeeTable.ReadOnly = true;
            employeeTable.RowHeadersVisible = false;
            employeeTable.RowTemplate.Height = 100;
            employeeTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            employeeTable.Size = new Size(920, 588);
            employeeTable.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(employeeTable);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(5, 165);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(5);
            panel6.Size = new Size(930, 598);
            panel6.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.AliceBlue;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(5, 5);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(5);
            panel2.Size = new Size(930, 50);
            panel2.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(940, 768);
            panel1.TabIndex = 1;
            // 
            // sortLabel
            // 
            sortLabel.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            sortLabel.HeaderText = "类别Sort";
            sortLabel.Name = "sortLabel";
            sortLabel.ReadOnly = true;
            sortLabel.Width = 96;
            // 
            // itemCodeLabel
            // 
            itemCodeLabel.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            itemCodeLabel.HeaderText = "Item Code";
            itemCodeLabel.Name = "itemCodeLabel";
            itemCodeLabel.ReadOnly = true;
            itemCodeLabel.Width = 104;
            // 
            // refCodeLabel
            // 
            refCodeLabel.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            refCodeLabel.HeaderText = "工厂型号 Ref.code";
            refCodeLabel.Name = "refCodeLabel";
            refCodeLabel.ReadOnly = true;
            refCodeLabel.Width = 96;
            // 
            // pictureLabel
            // 
            pictureLabel.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            pictureLabel.HeaderText = "图片 Picture";
            pictureLabel.Name = "pictureLabel";
            pictureLabel.ReadOnly = true;
            pictureLabel.Width = 140;
            // 
            // colorLabel
            // 
            colorLabel.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colorLabel.HeaderText = " 颜色 Color";
            colorLabel.Name = "colorLabel";
            colorLabel.ReadOnly = true;
            colorLabel.Resizable = DataGridViewTriState.True;
            colorLabel.SortMode = DataGridViewColumnSortMode.NotSortable;
            colorLabel.Width = 55;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            descriptionLabel.HeaderText = "规格 Decription";
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.ReadOnly = true;
            descriptionLabel.Resizable = DataGridViewTriState.True;
            descriptionLabel.SortMode = DataGridViewColumnSortMode.NotSortable;
            descriptionLabel.Width = 120;
            // 
            // avLabel
            // 
            avLabel.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            avLabel.HeaderText = "电源AV";
            avLabel.Name = "avLabel";
            avLabel.ReadOnly = true;
            avLabel.Resizable = DataGridViewTriState.True;
            avLabel.SortMode = DataGridViewColumnSortMode.NotSortable;
            avLabel.Width = 55;
            // 
            // wattsLabel
            // 
            wattsLabel.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            wattsLabel.HeaderText = "功率 Watts";
            wattsLabel.Name = "wattsLabel";
            wattsLabel.ReadOnly = true;
            wattsLabel.Resizable = DataGridViewTriState.True;
            wattsLabel.SortMode = DataGridViewColumnSortMode.NotSortable;
            wattsLabel.Width = 84;
            // 
            // sizeLabel
            // 
            sizeLabel.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            sizeLabel.HeaderText = "尺寸 ᶲSize(mm)";
            sizeLabel.Name = "sizeLabel";
            sizeLabel.ReadOnly = true;
            sizeLabel.Width = 129;
            // 
            // ctnSizeLLabel
            // 
            ctnSizeLLabel.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ctnSizeLLabel.HeaderText = "Ctn Size L";
            ctnSizeLLabel.Name = "ctnSizeLLabel";
            ctnSizeLLabel.ReadOnly = true;
            ctnSizeLLabel.Width = 88;
            // 
            // ctnSizeWLabel
            // 
            ctnSizeWLabel.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ctnSizeWLabel.HeaderText = "Ctn Size W";
            ctnSizeWLabel.Name = "ctnSizeWLabel";
            ctnSizeWLabel.ReadOnly = true;
            ctnSizeWLabel.Width = 88;
            // 
            // ctnSizeHLabel
            // 
            ctnSizeHLabel.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ctnSizeHLabel.HeaderText = "Ctn Size H";
            ctnSizeHLabel.Name = "ctnSizeHLabel";
            ctnSizeHLabel.ReadOnly = true;
            ctnSizeHLabel.Width = 88;
            // 
            // srpLabel
            // 
            srpLabel.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            srpLabel.HeaderText = "S.R.P";
            srpLabel.Name = "srpLabel";
            srpLabel.ReadOnly = true;
            srpLabel.Width = 72;
            // 
            // downPaymentLabel
            // 
            downPaymentLabel.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            downPaymentLabel.HeaderText = "D.P";
            downPaymentLabel.Name = "downPaymentLabel";
            downPaymentLabel.ReadOnly = true;
            downPaymentLabel.Width = 56;
            // 
            // warehouseLabel
            // 
            warehouseLabel.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            warehouseLabel.HeaderText = "Warehouse";
            warehouseLabel.Name = "warehouseLabel";
            warehouseLabel.ReadOnly = true;
            warehouseLabel.Width = 104;
            // 
            // qtyLabel
            // 
            qtyLabel.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            qtyLabel.HeaderText = "Quantity";
            qtyLabel.Name = "qtyLabel";
            qtyLabel.ReadOnly = true;
            qtyLabel.Width = 96;
            // 
            // boxLabel
            // 
            boxLabel.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            boxLabel.HeaderText = "Box(per pieces)";
            boxLabel.Name = "boxLabel";
            boxLabel.ReadOnly = true;
            boxLabel.Width = 88;
            // 
            // Warehouse
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 768);
            Controls.Add(panel1);
            Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(940, 768);
            Name = "Warehouse";
            Text = "Warehouse";
            panel4.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)employeeTable).EndInit();
            panel6.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;

        private CustomButton customButton1;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private DataGridView employeeTable;
        private Panel panel6;
        private Panel panel2;
        private Panel panel1;
        private Panel panel7;
        private PictureBox pictureBox1;
        private CustomTextBox customTextBox1;
        private DataGridViewTextBoxColumn sortLabel;
        private DataGridViewTextBoxColumn itemCodeLabel;
        private DataGridViewTextBoxColumn refCodeLabel;
        private DataGridViewImageColumn pictureLabel;
        private DataGridViewTextBoxColumn colorLabel;
        private DataGridViewTextBoxColumn descriptionLabel;
        private DataGridViewTextBoxColumn avLabel;
        private DataGridViewTextBoxColumn wattsLabel;
        private DataGridViewTextBoxColumn sizeLabel;
        private DataGridViewTextBoxColumn ctnSizeLLabel;
        private DataGridViewTextBoxColumn ctnSizeWLabel;
        private DataGridViewTextBoxColumn ctnSizeHLabel;
        private DataGridViewTextBoxColumn srpLabel;
        private DataGridViewTextBoxColumn downPaymentLabel;
        private DataGridViewTextBoxColumn warehouseLabel;
        private DataGridViewTextBoxColumn qtyLabel;
        private DataGridViewTextBoxColumn boxLabel;
    }
}