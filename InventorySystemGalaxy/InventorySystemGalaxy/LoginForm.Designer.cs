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
            panel1 = new Panel();
            customTextBox2 = new CustomTextBox();
            customTextBox1 = new CustomTextBox();
            customButton1 = new CustomButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(customButton1);
            panel1.Controls.Add(customTextBox2);
            panel1.Controls.Add(customTextBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(45, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(281, 359);
            panel1.TabIndex = 0;
            // 
            // customTextBox2
            // 
            customTextBox2.BorderStyle = BorderStyle.None;
            customTextBox2.BottomBorderColor = Color.SlateBlue;
            customTextBox2.BottomBorderOnFocusColor = Color.Blue;
            customTextBox2.Font = new Font("SimSun", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            customTextBox2.Location = new Point(52, 203);
            customTextBox2.Name = "customTextBox2";
            customTextBox2.PasswordChar = '•';
            customTextBox2.PlaceholderText = "Password";
            customTextBox2.Size = new Size(179, 23);
            customTextBox2.TabIndex = 1;
            customTextBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // customTextBox1
            // 
            customTextBox1.BorderStyle = BorderStyle.None;
            customTextBox1.BottomBorderColor = Color.SlateBlue;
            customTextBox1.BottomBorderOnFocusColor = Color.Blue;
            customTextBox1.Font = new Font("SimSun", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            customTextBox1.Location = new Point(52, 154);
            customTextBox1.Name = "customTextBox1";
            customTextBox1.PlaceholderText = "Username";
            customTextBox1.Size = new Size(179, 23);
            customTextBox1.TabIndex = 0;
            customTextBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // customButton1
            // 
            customButton1.BackColor = Color.SlateBlue;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.Font = new Font("SimSun", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            customButton1.ForeColor = Color.White;
            customButton1.HoverForeColor1 = SystemColors.ActiveCaptionText;
            customButton1.HoverImage1 = Properties.Resources.icons8_login_64__1_;
            customButton1.Image = Properties.Resources.icons8_login_96__1_;
            customButton1.ImageAlign = ContentAlignment.MiddleLeft;
            customButton1.Location = new Point(52, 264);
            customButton1.Name = "customButton1";
            customButton1.NormalForeColor1 = Color.White;
            customButton1.NormalImage1 = Properties.Resources.icons8_login_96__1_;
            customButton1.Padding = new Padding(15, 0, 0, 0);
            customButton1.Size = new Size(179, 46);
            customButton1.TabIndex = 2;
            customButton1.Text = "Login";
            customButton1.Tooltip1 = null;
            customButton1.UseVisualStyleBackColor = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(6F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(371, 449);
            Controls.Add(panel1);
            Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoginForm";
            Padding = new Padding(45);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private CustomTextBox customTextBox2;
        private CustomTextBox customTextBox1;
        private CustomButton customButton1;
    }
}