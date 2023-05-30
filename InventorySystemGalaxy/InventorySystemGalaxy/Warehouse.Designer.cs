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
            panel1 = new Panel();
            panel6 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            customButton1 = new CustomButton();
            boxLabel = new DataGridViewTextBoxColumn();
            qtyLabel = new DataGridViewTextBoxColumn();
            warehouseLabel = new DataGridViewTextBoxColumn();
            downPaymentLabel = new DataGridViewTextBoxColumn();
            srpLabel = new DataGridViewTextBoxColumn();
            ctnSizeHLabel = new DataGridViewTextBoxColumn();
            ctnSizeWLabel = new DataGridViewTextBoxColumn();
            ctnSizeLLabel = new DataGridViewTextBoxColumn();
            sizeLabel = new DataGridViewTextBoxColumn();
            wattsLabel = new DataGridViewTextBoxColumn();
            avLabel = new DataGridViewTextBoxColumn();
            descriptionLabel = new DataGridViewTextBoxColumn();
            colorLabel = new DataGridViewTextBoxColumn();
            pictureLabel = new DataGridViewImageColumn();
            refCodeLabel = new DataGridViewTextBoxColumn();
            itemCodeLabel = new DataGridViewTextBoxColumn();
            sortLabel = new DataGridViewTextBoxColumn();
            employeeTable = new DataGridView();
            panel7 = new Panel();
            pictureBox1 = new PictureBox();
            customTextBox1 = new CustomTextBox();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)employeeTable).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(5, 5);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(4, 4, 4, 4);
            panel1.Size = new Size(814, 713);
            panel1.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.Controls.Add(employeeTable);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(4, 124);
            panel6.Margin = new Padding(2, 2, 2, 2);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(4, 4, 4, 4);
            panel6.Size = new Size(806, 585);
            panel6.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.AliceBlue;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(4, 4);
            panel2.Margin = new Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(4, 4, 4, 4);
            panel2.Size = new Size(806, 38);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDark;
            label1.Location = new Point(6, 12);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(208, 27);
            label1.TabIndex = 1;
            label1.Text = "Warehouse(ALL)";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Snow;
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(4, 42);
            panel3.Margin = new Padding(2, 2, 2, 2);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(4, 4, 4, 4);
            panel3.Size = new Size(806, 82);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(59, 116, 192);
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(customButton1);
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(4, 4);
            panel4.Margin = new Padding(2, 2, 2, 2);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(4, 4, 4, 4);
            panel4.Size = new Size(798, 74);
            panel4.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel5.Location = new Point(960, 35);
            panel5.Margin = new Padding(2, 2, 2, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(180, 38);
            panel5.TabIndex = 0;
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
            customButton1.Location = new Point(6, 24);
            customButton1.Margin = new Padding(2, 2, 2, 2);
            customButton1.Name = "customButton1";
            customButton1.NormalForeColor1 = Color.White;
            customButton1.NormalImage1 = Properties.Resources.icons8_add_100__1___1_;
            customButton1.OnFocusEnterImage = null;
            customButton1.OnFocusLeaveImage = null;
            customButton1.Padding = new Padding(8, 8, 8, 8);
            customButton1.Size = new Size(103, 46);
            customButton1.TabIndex = 1;
            customButton1.Text = "   New";
            customButton1.TextAlign = ContentAlignment.MiddleLeft;
            customButton1.Tooltip1 = null;
            customButton1.UseVisualStyleBackColor = true;
            // 
            // boxLabel
            // 
            boxLabel.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            boxLabel.HeaderText = "Box(per pieces)";
            boxLabel.Name = "boxLabel";
            boxLabel.ReadOnly = true;
            // 
            // qtyLabel
            // 
            qtyLabel.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            qtyLabel.HeaderText = "Quantity";
            qtyLabel.Name = "qtyLabel";
            qtyLabel.ReadOnly = true;
            // 
            // warehouseLabel
            // 
            warehouseLabel.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            warehouseLabel.HeaderText = "Warehouse";
            warehouseLabel.Name = "warehouseLabel";
            warehouseLabel.ReadOnly = true;
            // 
            // downPaymentLabel
            // 
            downPaymentLabel.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            downPaymentLabel.HeaderText = "D.P";
            downPaymentLabel.Name = "downPaymentLabel";
            downPaymentLabel.ReadOnly = true;
            // 
            // srpLabel
            // 
            srpLabel.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            srpLabel.HeaderText = "S.R.P";
            srpLabel.Name = "srpLabel";
            srpLabel.ReadOnly = true;
            // 
            // ctnSizeHLabel
            // 
            ctnSizeHLabel.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ctnSizeHLabel.HeaderText = "Ctn Size H";
            ctnSizeHLabel.Name = "ctnSizeHLabel";
            ctnSizeHLabel.ReadOnly = true;
            // 
            // ctnSizeWLabel
            // 
            ctnSizeWLabel.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ctnSizeWLabel.HeaderText = "Ctn Size W";
            ctnSizeWLabel.Name = "ctnSizeWLabel";
            ctnSizeWLabel.ReadOnly = true;
            // 
            // ctnSizeLLabel
            // 
            ctnSizeLLabel.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ctnSizeLLabel.HeaderText = "Ctn Size L";
            ctnSizeLLabel.Name = "ctnSizeLLabel";
            ctnSizeLLabel.ReadOnly = true;
            // 
            // sizeLabel
            // 
            sizeLabel.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            sizeLabel.HeaderText = "尺寸 ᶲSize(mm)";
            sizeLabel.Name = "sizeLabel";
            sizeLabel.ReadOnly = true;
            // 
            // wattsLabel
            // 
            wattsLabel.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            wattsLabel.HeaderText = "功率 Watts";
            wattsLabel.Name = "wattsLabel";
            wattsLabel.ReadOnly = true;
            wattsLabel.Resizable = DataGridViewTriState.True;
            wattsLabel.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // avLabel
            // 
            avLabel.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            avLabel.HeaderText = "电源AV";
            avLabel.Name = "avLabel";
            avLabel.ReadOnly = true;
            avLabel.Resizable = DataGridViewTriState.True;
            avLabel.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            descriptionLabel.HeaderText = "规格 Decription";
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.ReadOnly = true;
            descriptionLabel.Resizable = DataGridViewTriState.True;
            descriptionLabel.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colorLabel
            // 
            colorLabel.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colorLabel.HeaderText = " 颜色 Color";
            colorLabel.Name = "colorLabel";
            colorLabel.ReadOnly = true;
            colorLabel.Resizable = DataGridViewTriState.True;
            colorLabel.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // pictureLabel
            // 
            pictureLabel.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            pictureLabel.HeaderText = "图片 Picture";
            pictureLabel.Name = "pictureLabel";
            pictureLabel.ReadOnly = true;
            pictureLabel.Width = 140;
            // 
            // refCodeLabel
            // 
            refCodeLabel.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            refCodeLabel.HeaderText = "工厂型号 Ref.code";
            refCodeLabel.Name = "refCodeLabel";
            refCodeLabel.ReadOnly = true;
            // 
            // itemCodeLabel
            // 
            itemCodeLabel.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            itemCodeLabel.HeaderText = "Item Code";
            itemCodeLabel.Name = "itemCodeLabel";
            itemCodeLabel.ReadOnly = true;
            // 
            // sortLabel
            // 
            sortLabel.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            sortLabel.HeaderText = "类别Sort";
            sortLabel.Name = "sortLabel";
            sortLabel.ReadOnly = true;
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
            employeeTable.Location = new Point(4, 4);
            employeeTable.Margin = new Padding(2, 2, 2, 2);
            employeeTable.Name = "employeeTable";
            employeeTable.ReadOnly = true;
            employeeTable.RowHeadersVisible = false;
            employeeTable.RowTemplate.Height = 100;
            employeeTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            employeeTable.Size = new Size(798, 577);
            employeeTable.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel7.Controls.Add(pictureBox1);
            panel7.Controls.Add(customTextBox1);
            panel7.Location = new Point(555, 21);
            panel7.Name = "panel7";
            panel7.Size = new Size(240, 50);
            panel7.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.images_removebg_preview;
            pictureBox1.Location = new Point(20, 13);
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
            customTextBox1.Location = new Point(61, 25);
            customTextBox1.Name = "customTextBox1";
            customTextBox1.PlaceholderText = "Search";
            customTextBox1.Size = new Size(177, 23);
            customTextBox1.TabIndex = 0;
            customTextBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // Warehouse
            // 
            AutoScaleDimensions = new SizeF(6F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 723);
            Controls.Add(panel1);
            Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(824, 723);
            Name = "Warehouse";
            Padding = new Padding(5);
            Text = "Warehouse";
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)employeeTable).EndInit();
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel6;
        private DataGridView employeeTable;
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
        private Panel panel3;
        private Panel panel4;
        private CustomButton customButton1;
        private Panel panel5;
        private Panel panel2;
        private Label label1;
        private Panel panel7;
        private PictureBox pictureBox1;
        private CustomTextBox customTextBox1;
    }
}