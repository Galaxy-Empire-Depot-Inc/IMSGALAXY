namespace InventorySystemGalaxy
{
    partial class ChangePasswordModal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordModal));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            passwordTextBox = new CustomTextBox();
            confirmPasswordTextBox = new CustomTextBox();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 154, 215);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 26);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_close_30;
            pictureBox1.Location = new Point(571, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(137, 84);
            label1.Name = "label1";
            label1.Size = new Size(295, 16);
            label1.TabIndex = 2;
            label1.Text = "Change to your Desired Passoword";
            // 
            // passwordTextBox
            // 
            passwordTextBox.BorderStyle = BorderStyle.None;
            passwordTextBox.BottomBorderColor = Color.Black;
            passwordTextBox.BottomBorderOnFocusColor = Color.Blue;
            passwordTextBox.Cursor = Cursors.IBeam;
            passwordTextBox.Font = new Font("SimSun", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextBox.Location = new Point(137, 116);
            passwordTextBox.Margin = new Padding(3, 2, 3, 2);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '•';
            passwordTextBox.PlaceholderText = "Password";
            passwordTextBox.Size = new Size(295, 30);
            passwordTextBox.TabIndex = 16;
            passwordTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // confirmPasswordTextBox
            // 
            confirmPasswordTextBox.BorderStyle = BorderStyle.None;
            confirmPasswordTextBox.BottomBorderColor = Color.Black;
            confirmPasswordTextBox.BottomBorderOnFocusColor = Color.Blue;
            confirmPasswordTextBox.Cursor = Cursors.IBeam;
            confirmPasswordTextBox.Font = new Font("SimSun", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            confirmPasswordTextBox.Location = new Point(137, 161);
            confirmPasswordTextBox.Margin = new Padding(3, 2, 3, 2);
            confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            confirmPasswordTextBox.PasswordChar = '•';
            confirmPasswordTextBox.PlaceholderText = "Confirm Password";
            confirmPasswordTextBox.Size = new Size(295, 30);
            confirmPasswordTextBox.TabIndex = 17;
            confirmPasswordTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 154, 215);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(214, 213);
            button1.Name = "button1";
            button1.Size = new Size(151, 46);
            button1.TabIndex = 18;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ChangePasswordModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 300);
            Controls.Add(button1);
            Controls.Add(confirmPasswordTextBox);
            Controls.Add(passwordTextBox);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ChangePasswordModal";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ChangePasswordModal";
            Load += ChangePasswordModal_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        public CustomTextBox passwordTextBox;
        public CustomTextBox confirmPasswordTextBox;
        private Button button1;
        private PictureBox pictureBox1;
    }
}