﻿namespace InventorySystemGalaxy
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
            logoutBtn = new CustomButton();
            warehouseBtn = new CustomButton();
            panel3 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dashboardBtn = new CustomButton();
            employeeBtn = new CustomButton();
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
            panel2.Controls.Add(logoutBtn);
            panel2.Controls.Add(warehouseBtn);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(dashboardBtn);
            panel2.Controls.Add(employeeBtn);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 768);
            panel2.TabIndex = 0;
            // 
            // logoutBtn
            // 
            logoutBtn.FlatAppearance.BorderSize = 0;
            logoutBtn.FlatStyle = FlatStyle.Flat;
            logoutBtn.Font = new Font("SimSun", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            logoutBtn.ForeColor = Color.White;
            logoutBtn.HoverForeColor1 = Color.Black;
            logoutBtn.HoverImage1 = Properties.Resources.icons8_logout_100__1___1_;
            logoutBtn.Image = Properties.Resources.icons8_logout_100__2_;
            logoutBtn.ImageAlign = ContentAlignment.TopLeft;
            logoutBtn.Location = new Point(0, 399);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.NormalForeColor1 = Color.White;
            logoutBtn.NormalImage1 = Properties.Resources.icons8_logout_100__2_;
            logoutBtn.OnFocusEnterImage = Properties.Resources.icons8_logout_100__1___1_;
            logoutBtn.OnFocusLeaveImage = Properties.Resources.icons8_logout_100__2_;
            logoutBtn.Padding = new Padding(10);
            logoutBtn.Size = new Size(200, 58);
            logoutBtn.TabIndex = 4;
            logoutBtn.Text = "    Logout";
            logoutBtn.TextAlign = ContentAlignment.MiddleLeft;
            logoutBtn.Tooltip1 = null;
            logoutBtn.UseVisualStyleBackColor = true;
            logoutBtn.Click += customButton4_Click;
            logoutBtn.Enter += customButton4_Enter;
            logoutBtn.Leave += customButton4_Leave;
            // 
            // warehouseBtn
            // 
            warehouseBtn.FlatAppearance.BorderSize = 0;
            warehouseBtn.FlatStyle = FlatStyle.Flat;
            warehouseBtn.Font = new Font("SimSun", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            warehouseBtn.ForeColor = Color.White;
            warehouseBtn.HoverForeColor1 = Color.Black;
            warehouseBtn.HoverImage1 = Properties.Resources.icons8_warehouse_80__1_;
            warehouseBtn.Image = Properties.Resources.icons8_warehouse_100__1_;
            warehouseBtn.ImageAlign = ContentAlignment.TopLeft;
            warehouseBtn.Location = new Point(0, 341);
            warehouseBtn.Name = "warehouseBtn";
            warehouseBtn.NormalForeColor1 = Color.White;
            warehouseBtn.NormalImage1 = Properties.Resources.icons8_warehouse_100__1_;
            warehouseBtn.OnFocusEnterImage = Properties.Resources.icons8_warehouse_80__1_;
            warehouseBtn.OnFocusLeaveImage = Properties.Resources.icons8_warehouse_100__1_;
            warehouseBtn.Padding = new Padding(10);
            warehouseBtn.Size = new Size(200, 58);
            warehouseBtn.TabIndex = 3;
            warehouseBtn.Text = "    Warehouse";
            warehouseBtn.TextAlign = ContentAlignment.MiddleLeft;
            warehouseBtn.Tooltip1 = null;
            warehouseBtn.UseVisualStyleBackColor = true;
            warehouseBtn.Click += customButton3_Click;
            warehouseBtn.Enter += customButton3_Enter;
            warehouseBtn.Leave += customButton3_Leave;
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
            // dashboardBtn
            // 
            dashboardBtn.FlatAppearance.BorderSize = 0;
            dashboardBtn.FlatStyle = FlatStyle.Flat;
            dashboardBtn.Font = new Font("SimSun", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dashboardBtn.ForeColor = Color.White;
            dashboardBtn.HoverForeColor1 = Color.Black;
            dashboardBtn.HoverImage1 = Properties.Resources.icons8_dashboard_64__1___1_;
            dashboardBtn.Image = Properties.Resources.icons8_dashboard_64__2_;
            dashboardBtn.ImageAlign = ContentAlignment.TopLeft;
            dashboardBtn.Location = new Point(0, 225);
            dashboardBtn.Name = "dashboardBtn";
            dashboardBtn.NormalForeColor1 = Color.White;
            dashboardBtn.NormalImage1 = Properties.Resources.icons8_dashboard_64__2_;
            dashboardBtn.OnFocusEnterImage = Properties.Resources.icons8_dashboard_64__1___1_;
            dashboardBtn.OnFocusLeaveImage = Properties.Resources.icons8_dashboard_64__2_;
            dashboardBtn.Padding = new Padding(10);
            dashboardBtn.Size = new Size(200, 58);
            dashboardBtn.TabIndex = 1;
            dashboardBtn.Text = "    Dashboard";
            dashboardBtn.TextAlign = ContentAlignment.MiddleLeft;
            dashboardBtn.Tooltip1 = null;
            dashboardBtn.UseVisualStyleBackColor = true;
            dashboardBtn.Click += customButton1_Click;
            dashboardBtn.Enter += customButton1_Enter;
            dashboardBtn.Leave += customButton1_Leave;
            // 
            // employeeBtn
            // 
            employeeBtn.FlatAppearance.BorderSize = 0;
            employeeBtn.FlatStyle = FlatStyle.Flat;
            employeeBtn.Font = new Font("SimSun", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            employeeBtn.ForeColor = Color.White;
            employeeBtn.HoverForeColor1 = Color.Black;
            employeeBtn.HoverImage1 = Properties.Resources.icons8_user_144__3_;
            employeeBtn.Image = Properties.Resources.icons8_user_144__2___1_;
            employeeBtn.ImageAlign = ContentAlignment.TopLeft;
            employeeBtn.Location = new Point(0, 283);
            employeeBtn.Name = "employeeBtn";
            employeeBtn.NormalForeColor1 = Color.White;
            employeeBtn.NormalImage1 = Properties.Resources.icons8_user_144__2___1_;
            employeeBtn.OnFocusEnterImage = Properties.Resources.icons8_user_144__3_;
            employeeBtn.OnFocusLeaveImage = Properties.Resources.icons8_user_144__2___1_;
            employeeBtn.Padding = new Padding(10);
            employeeBtn.Size = new Size(200, 58);
            employeeBtn.TabIndex = 2;
            employeeBtn.Text = "    Employee";
            employeeBtn.TextAlign = ContentAlignment.MiddleLeft;
            employeeBtn.Tooltip1 = null;
            employeeBtn.UseVisualStyleBackColor = true;
            employeeBtn.Click += customButton2_Click;
            employeeBtn.Enter += customButton2_Enter;
            employeeBtn.Leave += customButton2_Leave;
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
        private CustomButton dashboardBtn;
        private Label label1;
        private PictureBox pictureBox1;
        private CustomButton warehouseBtn;
        private CustomButton employeeBtn;
        private Panel panel4;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Panel panel5;
        private CustomButton logoutBtn;
        private Panel mainPanel;
    }
}