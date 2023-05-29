namespace InventorySystemGalaxy
{
    partial class EmployeeModalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeModalForm));
            bgPanel = new Panel();
            positionComboBox = new CustomComboBox();
            customTextBox9 = new CustomTextBox();
            customTextBox10 = new CustomTextBox();
            customTextBox7 = new CustomTextBox();
            customTextBox8 = new CustomTextBox();
            label1 = new Label();
            customTextBox6 = new CustomTextBox();
            customButton1 = new CustomButton();
            pictureBox1 = new PictureBox();
            customTextBox1 = new CustomTextBox();
            bgPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // bgPanel
            // 
            bgPanel.BackColor = Color.FromArgb(59, 116, 192);
            bgPanel.Controls.Add(positionComboBox);
            bgPanel.Controls.Add(customTextBox9);
            bgPanel.Controls.Add(customTextBox10);
            bgPanel.Controls.Add(customTextBox7);
            bgPanel.Controls.Add(customTextBox8);
            bgPanel.Controls.Add(label1);
            bgPanel.Controls.Add(customTextBox6);
            bgPanel.Controls.Add(customButton1);
            bgPanel.Controls.Add(pictureBox1);
            bgPanel.Controls.Add(customTextBox1);
            bgPanel.Dock = DockStyle.Fill;
            bgPanel.Location = new Point(15, 15);
            bgPanel.Name = "bgPanel";
            bgPanel.Padding = new Padding(10);
            bgPanel.Size = new Size(670, 670);
            bgPanel.TabIndex = 0;
            // 
            // positionComboBox
            // 
            positionComboBox.BackColor = Color.White;
            positionComboBox.BackColor1 = Color.White;
            positionComboBox.Bordercolor = Color.DeepSkyBlue;
            positionComboBox.BorderSize = 2;
            positionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            positionComboBox.Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point);
            positionComboBox.ForeColor = Color.DimGray;
            positionComboBox.FormattingEnabled = true;
            positionComboBox.IconColor = Color.Teal;
            positionComboBox.Items.AddRange(new object[] { "--Position--", "Accounting", "Customer Service", "Information Technology", "Sales Supervisor", "Warehouse Manager", "Warehouse Staff", "HR Manager" });
            positionComboBox.ListBackColor = Color.White;
            positionComboBox.ListTextColor = Color.Black;
            positionComboBox.Location = new Point(457, 322);
            positionComboBox.MinimumSize = new Size(200, 0);
            positionComboBox.Name = "positionComboBox";
            positionComboBox.Size = new Size(200, 24);
            positionComboBox.TabIndex = 13;
            // 
            // customTextBox9
            // 
            customTextBox9.BorderStyle = BorderStyle.None;
            customTextBox9.BottomBorderColor = Color.Black;
            customTextBox9.BottomBorderOnFocusColor = Color.Blue;
            customTextBox9.Font = new Font("SimSun", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            customTextBox9.Location = new Point(10, 365);
            customTextBox9.Name = "customTextBox9";
            customTextBox9.PlaceholderText = "Department";
            customTextBox9.ReadOnly = true;
            customTextBox9.Size = new Size(200, 24);
            customTextBox9.TabIndex = 12;
            customTextBox9.TextAlign = HorizontalAlignment.Center;
            // 
            // customTextBox10
            // 
            customTextBox10.BorderStyle = BorderStyle.None;
            customTextBox10.BottomBorderColor = Color.Black;
            customTextBox10.BottomBorderOnFocusColor = Color.Blue;
            customTextBox10.Font = new Font("SimSun", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            customTextBox10.Location = new Point(457, 276);
            customTextBox10.Name = "customTextBox10";
            customTextBox10.PlaceholderText = "Last Name";
            customTextBox10.Size = new Size(200, 24);
            customTextBox10.TabIndex = 11;
            customTextBox10.TextAlign = HorizontalAlignment.Center;
            // 
            // customTextBox7
            // 
            customTextBox7.BorderStyle = BorderStyle.None;
            customTextBox7.BottomBorderColor = Color.Black;
            customTextBox7.BottomBorderOnFocusColor = Color.Blue;
            customTextBox7.Font = new Font("SimSun", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            customTextBox7.Location = new Point(232, 323);
            customTextBox7.Name = "customTextBox7";
            customTextBox7.PlaceholderText = "Id Number";
            customTextBox7.Size = new Size(200, 24);
            customTextBox7.TabIndex = 10;
            customTextBox7.TextAlign = HorizontalAlignment.Center;
            // 
            // customTextBox8
            // 
            customTextBox8.BorderStyle = BorderStyle.None;
            customTextBox8.BottomBorderColor = Color.Black;
            customTextBox8.BottomBorderOnFocusColor = Color.Blue;
            customTextBox8.Font = new Font("SimSun", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            customTextBox8.Location = new Point(232, 276);
            customTextBox8.Name = "customTextBox8";
            customTextBox8.PlaceholderText = "Middle Name";
            customTextBox8.Size = new Size(200, 24);
            customTextBox8.TabIndex = 9;
            customTextBox8.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("SimSun", 20.25F, FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(13, 10);
            label1.Name = "label1";
            label1.Size = new Size(278, 27);
            label1.TabIndex = 8;
            label1.Text = "Account Information";
            // 
            // customTextBox6
            // 
            customTextBox6.BorderStyle = BorderStyle.None;
            customTextBox6.BottomBorderColor = Color.Black;
            customTextBox6.BottomBorderOnFocusColor = Color.Blue;
            customTextBox6.Font = new Font("SimSun", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            customTextBox6.Location = new Point(10, 322);
            customTextBox6.Name = "customTextBox6";
            customTextBox6.PlaceholderText = "Contact No.";
            customTextBox6.Size = new Size(200, 24);
            customTextBox6.TabIndex = 5;
            customTextBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // customButton1
            // 
            customButton1.Font = new Font("SimSun", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            customButton1.HoverForeColor1 = Color.Empty;
            customButton1.HoverImage1 = null;
            customButton1.Location = new Point(13, 222);
            customButton1.Name = "customButton1";
            customButton1.NormalForeColor1 = Color.Empty;
            customButton1.NormalImage1 = null;
            customButton1.OnFocusEnterImage = null;
            customButton1.OnFocusLeaveImage = null;
            customButton1.Size = new Size(125, 30);
            customButton1.TabIndex = 2;
            customButton1.Text = "Add Photo";
            customButton1.Tooltip1 = null;
            customButton1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(13, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 125);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // customTextBox1
            // 
            customTextBox1.BorderStyle = BorderStyle.None;
            customTextBox1.BottomBorderColor = Color.Black;
            customTextBox1.BottomBorderOnFocusColor = Color.Blue;
            customTextBox1.Font = new Font("SimSun", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            customTextBox1.Location = new Point(10, 276);
            customTextBox1.Name = "customTextBox1";
            customTextBox1.PlaceholderText = "First Name";
            customTextBox1.Size = new Size(200, 24);
            customTextBox1.TabIndex = 0;
            customTextBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // EmployeeModalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(59, 116, 192);
            ClientSize = new Size(700, 700);
            Controls.Add(bgPanel);
            Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(700, 700);
            Name = "EmployeeModalForm";
            Padding = new Padding(15);
            StartPosition = FormStartPosition.CenterParent;
            Text = "EmployeeModalForm";
            bgPanel.ResumeLayout(false);
            bgPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel bgPanel;
        private CustomTextBox customTextBox9;
        private CustomTextBox customTextBox10;
        private CustomTextBox customTextBox7;
        private CustomTextBox customTextBox8;
        private Label label1;
        private CustomTextBox customTextBox6;
        private CustomButton customButton1;
        private PictureBox pictureBox1;
        private CustomTextBox customTextBox1;
        private CustomComboBox positionComboBox;
    }
}