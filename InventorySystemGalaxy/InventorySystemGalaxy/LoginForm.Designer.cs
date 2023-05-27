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
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            loginBtn = new CustomButton();
            customTextBox2 = new CustomTextBox();
            customTextBox1 = new CustomTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(771, 8);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(20, 20);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(741, 8);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(20, 20);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
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
            loginBtn.Padding = new Padding(15, 0, 0, 0);
            loginBtn.Size = new Size(179, 43);
            loginBtn.TabIndex = 6;
            loginBtn.Text = "Login";
            loginBtn.Tooltip1 = null;
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            loginBtn.KeyDown += customButton1_KeyDown;
            // 
            // customTextBox2
            // 
            customTextBox2.BorderStyle = BorderStyle.None;
            customTextBox2.BottomBorderColor = Color.LightSlateGray;
            customTextBox2.BottomBorderOnFocusColor = Color.CornflowerBlue;
            customTextBox2.Font = new Font("SimSun", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            customTextBox2.Location = new Point(292, 355);
            customTextBox2.Name = "customTextBox2";
            customTextBox2.PasswordChar = '•';
            customTextBox2.PlaceholderText = "Password";
            customTextBox2.Size = new Size(209, 30);
            customTextBox2.TabIndex = 5;
            customTextBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // customTextBox1
            // 
            customTextBox1.BorderStyle = BorderStyle.None;
            customTextBox1.BottomBorderColor = Color.LightSlateGray;
            customTextBox1.BottomBorderOnFocusColor = Color.CornflowerBlue;
            customTextBox1.Font = new Font("SimSun", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            customTextBox1.Location = new Point(292, 306);
            customTextBox1.Name = "customTextBox1";
            customTextBox1.PlaceholderText = "Username";
            customTextBox1.Size = new Size(209, 30);
            customTextBox1.TabIndex = 4;
            customTextBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(6F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 600);
            Controls.Add(loginBtn);
            Controls.Add(customTextBox2);
            Controls.Add(customTextBox1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoginForm";
            Padding = new Padding(45);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        private CustomButton loginBtn;
        private CustomTextBox customTextBox2;
        private CustomTextBox customTextBox1;
    }
}