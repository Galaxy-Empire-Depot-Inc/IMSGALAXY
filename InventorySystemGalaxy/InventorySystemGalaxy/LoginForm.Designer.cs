namespace InventorySystemGalaxy
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            pictureBox2 = new PictureBox();
            loginBtn = new CustomButton();
            PassTxtBox = new CustomTextBox();
            UserTxtBox = new CustomTextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            MinBtn = new Button();
            CloseBTN = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.usericon1;
            pictureBox2.Location = new Point(249, 91);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(300, 300);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.FromArgb(0, 154, 215);
            loginBtn.FlatAppearance.BorderSize = 0;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Font = new Font("SimSun", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            loginBtn.ForeColor = Color.White;
            loginBtn.HoverForeColor1 = SystemColors.ActiveCaptionText;
            loginBtn.HoverImage1 = Properties.Resources.icons8_login_64__1_;
            loginBtn.Image = Properties.Resources.icons8_login_96__1_;
            loginBtn.ImageAlign = ContentAlignment.MiddleLeft;
            loginBtn.Location = new Point(309, 410);
            loginBtn.Name = "loginBtn";
            loginBtn.NormalForeColor1 = Color.White;
            loginBtn.NormalImage1 = Properties.Resources.icons8_login_96__1_;
            loginBtn.OnFocusEnterImage = null;
            loginBtn.OnFocusLeaveImage = null;
            loginBtn.Padding = new Padding(15, 0, 0, 0);
            loginBtn.Size = new Size(179, 43);
            loginBtn.TabIndex = 6;
            loginBtn.Text = "Login";
            loginBtn.Tooltip1 = null;
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            loginBtn.KeyDown += customButton1_KeyDown;
            // 
            // PassTxtBox
            // 
            PassTxtBox.BorderStyle = BorderStyle.None;
            PassTxtBox.BottomBorderColor = Color.LightSlateGray;
            PassTxtBox.BottomBorderOnFocusColor = Color.CornflowerBlue;
            PassTxtBox.Cursor = Cursors.IBeam;
            PassTxtBox.Font = new Font("SimSun", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            PassTxtBox.Location = new Point(292, 355);
            PassTxtBox.Name = "PassTxtBox";
            PassTxtBox.PasswordChar = '•';
            PassTxtBox.PlaceholderText = "Password";
            PassTxtBox.Size = new Size(209, 30);
            PassTxtBox.TabIndex = 5;
            PassTxtBox.TextAlign = HorizontalAlignment.Center;
            PassTxtBox.KeyPress += PassTxtBox_KeyPress;
            // 
            // UserTxtBox
            // 
            UserTxtBox.BorderStyle = BorderStyle.None;
            UserTxtBox.BottomBorderColor = Color.LightSlateGray;
            UserTxtBox.BottomBorderOnFocusColor = Color.CornflowerBlue;
            UserTxtBox.Cursor = Cursors.IBeam;
            UserTxtBox.Font = new Font("SimSun", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            UserTxtBox.Location = new Point(292, 306);
            UserTxtBox.Name = "UserTxtBox";
            UserTxtBox.PlaceholderText = "Username";
            UserTxtBox.Size = new Size(209, 30);
            UserTxtBox.TabIndex = 4;
            UserTxtBox.TextAlign = HorizontalAlignment.Center;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 154, 215);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(803, 34);
            panel1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.Controls.Add(MinBtn);
            panel2.Controls.Add(CloseBTN);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(712, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(91, 34);
            panel2.TabIndex = 0;
            // 
            // MinBtn
            // 
            MinBtn.BackColor = Color.FromArgb(241, 196, 15);
            MinBtn.Cursor = Cursors.Hand;
            MinBtn.FlatAppearance.BorderSize = 0;
            MinBtn.FlatStyle = FlatStyle.Flat;
            MinBtn.Image = Properties.Resources.icons8_minimize_30;
            MinBtn.Location = new Point(16, 4);
            MinBtn.Name = "MinBtn";
            MinBtn.Size = new Size(25, 25);
            MinBtn.TabIndex = 10;
            MinBtn.UseVisualStyleBackColor = false;
            MinBtn.Click += MinBtn_Click;
            // 
            // CloseBTN
            // 
            CloseBTN.BackColor = Color.FromArgb(231, 76, 60);
            CloseBTN.Cursor = Cursors.Hand;
            CloseBTN.FlatAppearance.BorderSize = 0;
            CloseBTN.FlatStyle = FlatStyle.Flat;
            CloseBTN.Image = Properties.Resources.icons8_close_30;
            CloseBTN.Location = new Point(54, 4);
            CloseBTN.Name = "CloseBTN";
            CloseBTN.Size = new Size(25, 25);
            CloseBTN.TabIndex = 9;
            CloseBTN.UseVisualStyleBackColor = false;
            CloseBTN.Click += CloseBTN_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(6F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 600);
            Controls.Add(panel1);
            Controls.Add(loginBtn);
            Controls.Add(PassTxtBox);
            Controls.Add(UserTxtBox);
            Controls.Add(pictureBox2);
            Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoginForm";
            Padding = new Padding(45);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private CustomButton loginBtn;
        private CustomTextBox PassTxtBox;
        private CustomTextBox UserTxtBox;
        private Panel panel1;
        private Panel panel2;
        private Button CloseBTN;
        private Button MinBtn;
    }
}