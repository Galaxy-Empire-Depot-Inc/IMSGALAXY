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
            panel5 = new Panel();
            pictureBox1 = new PictureBox();
            customTextBox1 = new CustomTextBox();
            customButton1 = new CustomButton();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)employeeTable).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(customButton1);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(5, 5);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(5);
            panel4.Size = new Size(794, 100);
            panel4.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel5.Controls.Add(pictureBox1);
            panel5.Controls.Add(customTextBox1);
            panel5.Location = new Point(551, 47);
            panel5.Name = "panel5";
            panel5.Size = new Size(240, 50);
            panel5.TabIndex = 0;
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
            MaximumSize = new Size(824, 723);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
        private CustomTextBox customTextBox1;
        private Panel panel5;
        private Panel panel6;
        private CustomButton customButton1;
        private DataGridView employeeTable;
    }
}