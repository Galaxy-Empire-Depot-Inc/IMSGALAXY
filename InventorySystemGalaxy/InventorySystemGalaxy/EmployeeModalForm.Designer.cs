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
            CloseBtn = new PictureBox();
            positionComboBox = new ComboBox();
            statusComboBox = new CustomComboBox();
            add_UpdateBtn = new CustomButton();
            passwordTextbox = new CustomTextBox();
            usernameTextbox = new CustomTextBox();
            label2 = new Label();
            departmentTextBox = new CustomTextBox();
            lastNameTextBox = new CustomTextBox();
            idNumberTextBox = new CustomTextBox();
            middleNameTextBox = new CustomTextBox();
            label1 = new Label();
            contactNoTextBox = new CustomTextBox();
            addPhotoBtn = new CustomButton();
            employeePB = new PictureBox();
            firstNameTextBox = new CustomTextBox();
            bgPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CloseBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeePB).BeginInit();
            SuspendLayout();
            // 
            // bgPanel
            // 
            bgPanel.BackColor = Color.FromArgb(59, 116, 192);
            bgPanel.Controls.Add(CloseBtn);
            bgPanel.Controls.Add(positionComboBox);
            bgPanel.Controls.Add(statusComboBox);
            bgPanel.Controls.Add(add_UpdateBtn);
            bgPanel.Controls.Add(passwordTextbox);
            bgPanel.Controls.Add(usernameTextbox);
            bgPanel.Controls.Add(label2);
            bgPanel.Controls.Add(departmentTextBox);
            bgPanel.Controls.Add(lastNameTextBox);
            bgPanel.Controls.Add(idNumberTextBox);
            bgPanel.Controls.Add(middleNameTextBox);
            bgPanel.Controls.Add(label1);
            bgPanel.Controls.Add(contactNoTextBox);
            bgPanel.Controls.Add(addPhotoBtn);
            bgPanel.Controls.Add(employeePB);
            bgPanel.Controls.Add(firstNameTextBox);
            bgPanel.Dock = DockStyle.Fill;
            bgPanel.Location = new Point(0, 0);
            bgPanel.Name = "bgPanel";
            bgPanel.Padding = new Padding(10);
            bgPanel.Size = new Size(695, 575);
            bgPanel.TabIndex = 0;
            // 
            // CloseBtn
            // 
            CloseBtn.Image = Properties.Resources.icons8_cancel_100;
            CloseBtn.Location = new Point(656, 1);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(36, 37);
            CloseBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            CloseBtn.TabIndex = 22;
            CloseBtn.TabStop = false;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // positionComboBox
            // 
            positionComboBox.FormattingEnabled = true;
            positionComboBox.Items.AddRange(new object[] { "--Position--", "Accounting", "Customer Service", "Information Technology", "Sales Supervisor", "Warehouse Manager", "Warehouse Staff", "HR Manager" });
            positionComboBox.Location = new Point(10, 351);
            positionComboBox.Name = "positionComboBox";
            positionComboBox.Size = new Size(200, 24);
            positionComboBox.TabIndex = 21;
            positionComboBox.SelectionChangeCommitted += positionComboBox_SelectionChangeCommitted;
            // 
            // statusComboBox
            // 
            statusComboBox.BackColor = Color.White;
            statusComboBox.BackColor1 = Color.White;
            statusComboBox.Bordercolor = Color.DeepSkyBlue;
            statusComboBox.BorderSize = 2;
            statusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            statusComboBox.Enabled = false;
            statusComboBox.Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point);
            statusComboBox.ForeColor = Color.DimGray;
            statusComboBox.FormattingEnabled = true;
            statusComboBox.IconColor = Color.Teal;
            statusComboBox.Items.AddRange(new object[] { "Inactive", "Active" });
            statusComboBox.ListBackColor = Color.White;
            statusComboBox.ListTextColor = Color.Black;
            statusComboBox.Location = new Point(457, 304);
            statusComboBox.MinimumSize = new Size(200, 0);
            statusComboBox.Name = "statusComboBox";
            statusComboBox.Size = new Size(200, 24);
            statusComboBox.TabIndex = 20;
            // 
            // add_UpdateBtn
            // 
            add_UpdateBtn.BackColor = Color.White;
            add_UpdateBtn.FlatAppearance.BorderColor = Color.White;
            add_UpdateBtn.FlatStyle = FlatStyle.Popup;
            add_UpdateBtn.Font = new Font("SimSun", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            add_UpdateBtn.HoverForeColor1 = Color.SteelBlue;
            add_UpdateBtn.HoverImage1 = null;
            add_UpdateBtn.Location = new Point(543, 522);
            add_UpdateBtn.Name = "add_UpdateBtn";
            add_UpdateBtn.NormalForeColor1 = Color.Black;
            add_UpdateBtn.NormalImage1 = null;
            add_UpdateBtn.OnFocusEnterImage = null;
            add_UpdateBtn.OnFocusLeaveImage = null;
            add_UpdateBtn.Size = new Size(125, 30);
            add_UpdateBtn.TabIndex = 18;
            add_UpdateBtn.Text = "Add";
            add_UpdateBtn.Tooltip1 = null;
            add_UpdateBtn.UseVisualStyleBackColor = false;
            add_UpdateBtn.Click += addBtn_Click;
            // 
            // passwordTextbox
            // 
            passwordTextbox.BorderStyle = BorderStyle.None;
            passwordTextbox.BottomBorderColor = Color.Black;
            passwordTextbox.BottomBorderOnFocusColor = Color.Blue;
            passwordTextbox.Font = new Font("SimSun", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextbox.Location = new Point(232, 452);
            passwordTextbox.Name = "passwordTextbox";
            passwordTextbox.PlaceholderText = "Password";
            passwordTextbox.Size = new Size(200, 24);
            passwordTextbox.TabIndex = 16;
            passwordTextbox.TextAlign = HorizontalAlignment.Center;
            // 
            // usernameTextbox
            // 
            usernameTextbox.BorderStyle = BorderStyle.None;
            usernameTextbox.BottomBorderColor = Color.Black;
            usernameTextbox.BottomBorderOnFocusColor = Color.Blue;
            usernameTextbox.Font = new Font("SimSun", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            usernameTextbox.Location = new Point(13, 452);
            usernameTextbox.Name = "usernameTextbox";
            usernameTextbox.PlaceholderText = "Username";
            usernameTextbox.Size = new Size(200, 24);
            usernameTextbox.TabIndex = 15;
            usernameTextbox.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("SimSun", 20.25F, FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(13, 403);
            label2.Name = "label2";
            label2.Size = new Size(236, 27);
            label2.TabIndex = 14;
            label2.Text = "User Information";
            // 
            // departmentTextBox
            // 
            departmentTextBox.BorderStyle = BorderStyle.None;
            departmentTextBox.BottomBorderColor = Color.Black;
            departmentTextBox.BottomBorderOnFocusColor = Color.Blue;
            departmentTextBox.Font = new Font("SimSun", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            departmentTextBox.Location = new Point(232, 351);
            departmentTextBox.Name = "departmentTextBox";
            departmentTextBox.PlaceholderText = "Department";
            departmentTextBox.ReadOnly = true;
            departmentTextBox.Size = new Size(200, 24);
            departmentTextBox.TabIndex = 12;
            departmentTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.BorderStyle = BorderStyle.None;
            lastNameTextBox.BottomBorderColor = Color.Black;
            lastNameTextBox.BottomBorderOnFocusColor = Color.Blue;
            lastNameTextBox.Font = new Font("SimSun", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameTextBox.Location = new Point(457, 257);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.PlaceholderText = "Last Name";
            lastNameTextBox.Size = new Size(200, 24);
            lastNameTextBox.TabIndex = 11;
            lastNameTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // idNumberTextBox
            // 
            idNumberTextBox.BorderStyle = BorderStyle.None;
            idNumberTextBox.BottomBorderColor = Color.Black;
            idNumberTextBox.BottomBorderOnFocusColor = Color.Blue;
            idNumberTextBox.Font = new Font("SimSun", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            idNumberTextBox.Location = new Point(232, 304);
            idNumberTextBox.Name = "idNumberTextBox";
            idNumberTextBox.PlaceholderText = "Id Number";
            idNumberTextBox.Size = new Size(200, 24);
            idNumberTextBox.TabIndex = 10;
            idNumberTextBox.TextAlign = HorizontalAlignment.Center;
            idNumberTextBox.TextChanged += idNumberTextBox_TextChanged;
            // 
            // middleNameTextBox
            // 
            middleNameTextBox.BorderStyle = BorderStyle.None;
            middleNameTextBox.BottomBorderColor = Color.Black;
            middleNameTextBox.BottomBorderOnFocusColor = Color.Blue;
            middleNameTextBox.Font = new Font("SimSun", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            middleNameTextBox.Location = new Point(232, 257);
            middleNameTextBox.Name = "middleNameTextBox";
            middleNameTextBox.PlaceholderText = "Middle Name";
            middleNameTextBox.Size = new Size(200, 24);
            middleNameTextBox.TabIndex = 9;
            middleNameTextBox.TextAlign = HorizontalAlignment.Center;
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
            // contactNoTextBox
            // 
            contactNoTextBox.BorderStyle = BorderStyle.None;
            contactNoTextBox.BottomBorderColor = Color.Black;
            contactNoTextBox.BottomBorderOnFocusColor = Color.Blue;
            contactNoTextBox.Font = new Font("SimSun", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            contactNoTextBox.Location = new Point(10, 303);
            contactNoTextBox.Name = "contactNoTextBox";
            contactNoTextBox.PlaceholderText = "Contact No.";
            contactNoTextBox.Size = new Size(200, 24);
            contactNoTextBox.TabIndex = 5;
            contactNoTextBox.TextAlign = HorizontalAlignment.Center;
            contactNoTextBox.TextChanged += contactNoTextBox_TextChanged;
            contactNoTextBox.KeyPress += contactNoTextBox_KeyPress;
            // 
            // addPhotoBtn
            // 
            addPhotoBtn.BackColor = Color.White;
            addPhotoBtn.FlatAppearance.BorderColor = Color.White;
            addPhotoBtn.FlatStyle = FlatStyle.Popup;
            addPhotoBtn.Font = new Font("SimSun", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            addPhotoBtn.HoverForeColor1 = Color.SteelBlue;
            addPhotoBtn.HoverImage1 = null;
            addPhotoBtn.Location = new Point(13, 203);
            addPhotoBtn.Name = "addPhotoBtn";
            addPhotoBtn.NormalForeColor1 = Color.Black;
            addPhotoBtn.NormalImage1 = null;
            addPhotoBtn.OnFocusEnterImage = null;
            addPhotoBtn.OnFocusLeaveImage = null;
            addPhotoBtn.Size = new Size(125, 30);
            addPhotoBtn.TabIndex = 2;
            addPhotoBtn.Text = "Add Photo";
            addPhotoBtn.Tooltip1 = null;
            addPhotoBtn.UseVisualStyleBackColor = false;
            addPhotoBtn.Click += addPhotoBtn_Click;
            // 
            // employeePB
            // 
            employeePB.BackColor = Color.Transparent;
            employeePB.BorderStyle = BorderStyle.Fixed3D;
            employeePB.Cursor = Cursors.Hand;
            employeePB.Image = Properties.Resources.icons8_user_144__2_;
            employeePB.Location = new Point(13, 61);
            employeePB.Name = "employeePB";
            employeePB.Size = new Size(125, 125);
            employeePB.SizeMode = PictureBoxSizeMode.StretchImage;
            employeePB.TabIndex = 1;
            employeePB.TabStop = false;
            employeePB.DragDrop += imagePictureBox_DragDrop;
            employeePB.DragEnter += imagePictureBox_DragEnter;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.BorderStyle = BorderStyle.None;
            firstNameTextBox.BottomBorderColor = Color.Black;
            firstNameTextBox.BottomBorderOnFocusColor = Color.Blue;
            firstNameTextBox.Font = new Font("SimSun", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            firstNameTextBox.Location = new Point(10, 257);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.PlaceholderText = "First Name";
            firstNameTextBox.Size = new Size(200, 24);
            firstNameTextBox.TabIndex = 0;
            firstNameTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // EmployeeModalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(695, 575);
            Controls.Add(bgPanel);
            Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(500, 350);
            Name = "EmployeeModalForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "EmployeeModalForm";
            Load += EmployeeModalForm_Load;
            bgPanel.ResumeLayout(false);
            bgPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CloseBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeePB).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel bgPanel;
        private Label label1;
        private CustomButton addPhotoBtn;
        private Label label2;
        public CustomTextBox departmentTextBox;
        public CustomTextBox lastNameTextBox;
        public CustomTextBox idNumberTextBox;
        public CustomTextBox middleNameTextBox;
        public CustomTextBox contactNoTextBox;
        public CustomTextBox firstNameTextBox;
        public CustomTextBox passwordTextbox;
        public CustomTextBox usernameTextbox;
        public CustomComboBox statusComboBox;
        private PictureBox CloseBtn;
        public CustomButton add_UpdateBtn;
        public ComboBox positionComboBox;
        public PictureBox employeePB;
    }
}