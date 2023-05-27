namespace InventorySystemGalaxy
{
    partial class HomeScreenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeScreenForm));
            panel1 = new Panel();
            mainPanel = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            panel2 = new Panel();
            customButton4 = new CustomButton();
            customButton3 = new CustomButton();
            panel3 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            customButton1 = new CustomButton();
            customButton2 = new CustomButton();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(mainPanel);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1024, 768);
            panel1.TabIndex = 0;
            // 
            // mainPanel
            // 
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(200, 45);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(824, 723);
            mainPanel.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(56, 116, 192);
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Top;
            panel4.Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panel4.Location = new Point(200, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(824, 45);
            panel4.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel5.BackColor = Color.Transparent;
            panel5.Controls.Add(pictureBox3);
            panel5.Controls.Add(pictureBox2);
            panel5.Controls.Add(pictureBox4);
            panel5.Location = new Point(723, 7);
            panel5.Name = "panel5";
            panel5.Size = new Size(96, 30);
            panel5.TabIndex = 3;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(14, 5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(20, 20);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(66, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(20, 20);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(40, 5);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(20, 20);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(59, 116, 192);
            panel2.Controls.Add(customButton4);
            panel2.Controls.Add(customButton3);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(customButton1);
            panel2.Controls.Add(customButton2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 768);
            panel2.TabIndex = 0;
            // 
            // customButton4
            // 
            customButton4.FlatAppearance.BorderSize = 0;
            customButton4.FlatStyle = FlatStyle.Flat;
            customButton4.Font = new Font("SimSun", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            customButton4.ForeColor = Color.White;
            customButton4.HoverForeColor1 = Color.Black;
            customButton4.HoverImage1 = Properties.Resources.icons8_logout_100__1___1_;
            customButton4.Image = Properties.Resources.icons8_logout_100__2_;
            customButton4.ImageAlign = ContentAlignment.TopLeft;
            customButton4.Location = new Point(0, 399);
            customButton4.Name = "customButton4";
            customButton4.NormalForeColor1 = Color.White;
            customButton4.NormalImage1 = Properties.Resources.icons8_logout_100__2_;
            customButton4.OnFocusEnterImage = null;
            customButton4.OnFocusLeaveImage = null;
            customButton4.Padding = new Padding(10);
            customButton4.Size = new Size(200, 58);
            customButton4.TabIndex = 4;
            customButton4.Text = "    Logout";
            customButton4.TextAlign = ContentAlignment.MiddleLeft;
            customButton4.Tooltip1 = null;
            customButton4.UseVisualStyleBackColor = true;
            customButton4.Click += customButton4_Click;
            customButton4.Enter += customButton4_Enter;
            customButton4.Leave += customButton4_Leave;
            // 
            // customButton3
            // 
            customButton3.FlatAppearance.BorderSize = 0;
            customButton3.FlatStyle = FlatStyle.Flat;
            customButton3.Font = new Font("SimSun", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            customButton3.ForeColor = Color.White;
            customButton3.HoverForeColor1 = Color.Black;
            customButton3.HoverImage1 = Properties.Resources.icons8_warehouse_80__1_;
            customButton3.Image = Properties.Resources.icons8_warehouse_100__1_;
            customButton3.ImageAlign = ContentAlignment.TopLeft;
            customButton3.Location = new Point(0, 341);
            customButton3.Name = "customButton3";
            customButton3.NormalForeColor1 = Color.White;
            customButton3.NormalImage1 = Properties.Resources.icons8_warehouse_100__1_;
            customButton3.OnFocusEnterImage = null;
            customButton3.OnFocusLeaveImage = null;
            customButton3.Padding = new Padding(10);
            customButton3.Size = new Size(200, 58);
            customButton3.TabIndex = 3;
            customButton3.Text = "    Warehouse";
            customButton3.TextAlign = ContentAlignment.MiddleLeft;
            customButton3.Tooltip1 = null;
            customButton3.UseVisualStyleBackColor = true;
            customButton3.Click += customButton3_Click;
            customButton3.Enter += customButton3_Enter;
            customButton3.Leave += customButton3_Leave;
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 225);
            panel3.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(10, 182);
            label1.Name = "label1";
            label1.Size = new Size(180, 27);
            label1.TabIndex = 1;
            label1.Text = "Hi, Username";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_user_144__2_;
            pictureBox1.Location = new Point(54, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // customButton1
            // 
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.Font = new Font("SimSun", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            customButton1.ForeColor = Color.White;
            customButton1.HoverForeColor1 = Color.Black;
            customButton1.HoverImage1 = Properties.Resources.icons8_dashboard_64__1___1_;
            customButton1.Image = Properties.Resources.icons8_dashboard_64__2_;
            customButton1.ImageAlign = ContentAlignment.TopLeft;
            customButton1.Location = new Point(0, 225);
            customButton1.Name = "customButton1";
            customButton1.NormalForeColor1 = Color.White;
            customButton1.NormalImage1 = Properties.Resources.icons8_dashboard_64__2_;
            customButton1.OnFocusEnterImage = Properties.Resources.icons8_dashboard_64__1___1_;
            customButton1.OnFocusLeaveImage = Properties.Resources.icons8_dashboard_64__2_;
            customButton1.Padding = new Padding(10);
            customButton1.Size = new Size(200, 58);
            customButton1.TabIndex = 1;
            customButton1.Text = "    Dashboard";
            customButton1.TextAlign = ContentAlignment.MiddleLeft;
            customButton1.Tooltip1 = null;
            customButton1.UseVisualStyleBackColor = true;
            customButton1.Click += customButton1_Click;
            customButton1.Enter += customButton1_Enter;
            customButton1.Leave += customButton1_Leave;
            // 
            // customButton2
            // 
            customButton2.FlatAppearance.BorderSize = 0;
            customButton2.FlatStyle = FlatStyle.Flat;
            customButton2.Font = new Font("SimSun", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            customButton2.ForeColor = Color.White;
            customButton2.HoverForeColor1 = Color.Black;
            customButton2.HoverImage1 = Properties.Resources.icons8_user_144__3_;
            customButton2.Image = Properties.Resources.icons8_user_144__2___1_;
            customButton2.ImageAlign = ContentAlignment.TopLeft;
            customButton2.Location = new Point(0, 283);
            customButton2.Name = "customButton2";
            customButton2.NormalForeColor1 = Color.White;
            customButton2.NormalImage1 = Properties.Resources.icons8_user_144__2___1_;
            customButton2.OnFocusEnterImage = null;
            customButton2.OnFocusLeaveImage = null;
            customButton2.Padding = new Padding(10);
            customButton2.Size = new Size(200, 58);
            customButton2.TabIndex = 2;
            customButton2.Text = "    Employee";
            customButton2.TextAlign = ContentAlignment.MiddleLeft;
            customButton2.Tooltip1 = null;
            customButton2.UseVisualStyleBackColor = true;
            customButton2.Click += customButton2_Click;
            customButton2.Enter += customButton2_Enter;
            customButton2.Leave += customButton2_Leave;
            // 
            // HomeScreenForm
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1024, 768);
            Controls.Add(panel1);
            Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(1024, 768);
            Name = "HomeScreenForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomeScreenForm";
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private CustomButton customButton1;
        private Label label1;
        private PictureBox pictureBox1;
        private CustomButton customButton3;
        private CustomButton customButton2;
        private Panel panel4;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Panel panel5;
        private CustomButton customButton4;
        private Panel mainPanel;
    }
}