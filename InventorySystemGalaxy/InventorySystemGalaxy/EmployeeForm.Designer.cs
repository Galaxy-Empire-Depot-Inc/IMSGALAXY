namespace InventorySystemGalaxy
{
    partial class EmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            panel1 = new Panel();
            panel6 = new Panel();
            employeeTable = new DataGridView();
            panel3 = new Panel();
            panel4 = new Panel();
            positionComboBox = new ComboBox();
            customButton2 = new CustomButton();
            panel5 = new Panel();
            SearchEmployeeBtn = new PictureBox();
            SearchEmployeeTxtBox = new CustomTextBox();
            customButton1 = new CustomButton();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)employeeTable).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SearchEmployeeBtn).BeginInit();
            panel2.SuspendLayout();
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
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(814, 713);
            panel1.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(employeeTable);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(5, 165);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(5);
            panel6.Size = new Size(804, 543);
            panel6.TabIndex = 2;
            // 
            // employeeTable
            // 
            employeeTable.AllowUserToAddRows = false;
            employeeTable.AllowUserToDeleteRows = false;
            employeeTable.AllowUserToOrderColumns = true;
            employeeTable.AllowUserToResizeColumns = false;
            employeeTable.AllowUserToResizeRows = false;
            employeeTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            employeeTable.BackgroundColor = Color.White;
            employeeTable.BorderStyle = BorderStyle.Fixed3D;
            employeeTable.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            employeeTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            employeeTable.Dock = DockStyle.Fill;
            employeeTable.GridColor = Color.White;
            employeeTable.Location = new Point(5, 5);
            employeeTable.Name = "employeeTable";
            employeeTable.ReadOnly = true;
            employeeTable.RowHeadersVisible = false;
            employeeTable.RowTemplate.Height = 100;
            employeeTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            employeeTable.Size = new Size(794, 533);
            employeeTable.TabIndex = 0;
            employeeTable.CellDoubleClick += employeeTable_CellDoubleClick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Snow;
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(5, 55);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(5);
            panel3.Size = new Size(804, 110);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(59, 116, 192);
            panel4.Controls.Add(positionComboBox);
            panel4.Controls.Add(customButton2);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(customButton1);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(5, 5);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(5);
            panel4.Size = new Size(794, 100);
            panel4.TabIndex = 0;
            // 
            // positionComboBox
            // 
            positionComboBox.FormattingEnabled = true;
            positionComboBox.Items.AddRange(new object[] { "--Departments--", "Accounting Department", "Customer Service Department", "Information Technology Department", "Sales Supervisor Department", "Warehouse Manager Department", "Warehouse Staff Department", "HR Manager Department" });
            positionComboBox.Location = new Point(345, 72);
            positionComboBox.Name = "positionComboBox";
            positionComboBox.Size = new Size(200, 20);
            positionComboBox.TabIndex = 22;
            positionComboBox.SelectedIndexChanged += positionComboBox_SelectedIndexChanged;
            // 
            // customButton2
            // 
            customButton2.FlatStyle = FlatStyle.Flat;
            customButton2.Font = new Font("SimSun", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            customButton2.ForeColor = Color.White;
            customButton2.HoverForeColor1 = Color.Black;
            customButton2.HoverImage1 = Properties.Resources.icons8_add_100__2___1_;
            customButton2.Image = Properties.Resources.icons8_add_100__1___1_;
            customButton2.ImageAlign = ContentAlignment.MiddleLeft;
            customButton2.Location = new Point(145, 42);
            customButton2.Name = "customButton2";
            customButton2.NormalForeColor1 = Color.White;
            customButton2.NormalImage1 = Properties.Resources.icons8_add_100__1___1_;
            customButton2.OnFocusEnterImage = null;
            customButton2.OnFocusLeaveImage = null;
            customButton2.Padding = new Padding(10);
            customButton2.Size = new Size(139, 50);
            customButton2.TabIndex = 2;
            customButton2.Text = "Export";
            customButton2.TextAlign = ContentAlignment.MiddleRight;
            customButton2.Tooltip1 = null;
            customButton2.UseVisualStyleBackColor = true;
            customButton2.Click += customButton2_Click;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel5.Controls.Add(SearchEmployeeBtn);
            panel5.Controls.Add(SearchEmployeeTxtBox);
            panel5.Location = new Point(551, 47);
            panel5.Name = "panel5";
            panel5.Size = new Size(240, 50);
            panel5.TabIndex = 0;
            // 
            // SearchEmployeeBtn
            // 
            SearchEmployeeBtn.Image = Properties.Resources.images_removebg_preview;
            SearchEmployeeBtn.Location = new Point(20, 13);
            SearchEmployeeBtn.Name = "SearchEmployeeBtn";
            SearchEmployeeBtn.Size = new Size(35, 35);
            SearchEmployeeBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            SearchEmployeeBtn.TabIndex = 1;
            SearchEmployeeBtn.TabStop = false;
            SearchEmployeeBtn.Click += SearchEmployeeBtn_Click;
            // 
            // SearchEmployeeTxtBox
            // 
            SearchEmployeeTxtBox.BorderStyle = BorderStyle.None;
            SearchEmployeeTxtBox.BottomBorderColor = Color.LightSlateGray;
            SearchEmployeeTxtBox.BottomBorderOnFocusColor = Color.CornflowerBlue;
            SearchEmployeeTxtBox.Font = new Font("SimSun", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            SearchEmployeeTxtBox.Location = new Point(39, 24);
            SearchEmployeeTxtBox.Name = "SearchEmployeeTxtBox";
            SearchEmployeeTxtBox.PlaceholderText = "Search";
            SearchEmployeeTxtBox.Size = new Size(177, 23);
            SearchEmployeeTxtBox.TabIndex = 0;
            SearchEmployeeTxtBox.TextAlign = HorizontalAlignment.Center;
            SearchEmployeeTxtBox.TextChanged += SearchEmployeeTxtBox_TextChanged;
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
            customButton1.Click += customButton1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.AliceBlue;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(5, 5);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(5);
            panel2.Size = new Size(804, 50);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDark;
            label1.Location = new Point(3, 11);
            label1.Name = "label1";
            label1.Size = new Size(124, 27);
            label1.TabIndex = 1;
            label1.Text = "Employee";
            // 
            // EmployeeForm
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
            Name = "EmployeeForm";
            Padding = new Padding(5);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeeForm";
            Load += EmployeeForm_Load;
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)employeeTable).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SearchEmployeeBtn).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Panel panel4;
        private PictureBox SearchEmployeeBtn;
        private CustomTextBox SearchEmployeeTxtBox;
        private Panel panel5;
        private Panel panel6;
        private CustomButton customButton1;
        private DataGridView employeeTable;
        private CustomButton customButton2;
        public ComboBox positionComboBox;
    }
}