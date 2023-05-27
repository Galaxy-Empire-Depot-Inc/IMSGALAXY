namespace InventorySystemGalaxy
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel9 = new Panel();
            panel15 = new Panel();
            producttable = new DataGridView();
            itemCodeLabel = new DataGridViewTextBoxColumn();
            imageLabel = new DataGridViewImageColumn();
            descriptionLabel = new DataGridViewImageColumn();
            panel14 = new Panel();
            label11 = new Label();
            panel8 = new Panel();
            panel13 = new Panel();
            customButton4 = new CustomButton();
            panel12 = new Panel();
            customButton3 = new CustomButton();
            panel11 = new Panel();
            customButton2 = new CustomButton();
            panel10 = new Panel();
            customButton1 = new CustomButton();
            panel7 = new Panel();
            label10 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            panel4 = new Panel();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            panel5 = new Panel();
            pictureBox3 = new PictureBox();
            label6 = new Label();
            label7 = new Label();
            panel6 = new Panel();
            pictureBox4 = new PictureBox();
            label8 = new Label();
            label9 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel9.SuspendLayout();
            panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)producttable).BeginInit();
            panel14.SuspendLayout();
            panel8.SuspendLayout();
            panel13.SuspendLayout();
            panel12.SuspendLayout();
            panel11.SuspendLayout();
            panel10.SuspendLayout();
            panel7.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(5, 5);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(814, 713);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.Snow;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel2.Controls.Add(panel9, 1, 0);
            tableLayoutPanel2.Controls.Add(panel8, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(5, 295);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(5);
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(804, 413);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // panel9
            // 
            panel9.BackColor = Color.White;
            panel9.Controls.Add(panel15);
            panel9.Controls.Add(panel14);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(206, 8);
            panel9.Name = "panel9";
            panel9.Padding = new Padding(5);
            panel9.Size = new Size(590, 397);
            panel9.TabIndex = 1;
            // 
            // panel15
            // 
            panel15.Controls.Add(producttable);
            panel15.Dock = DockStyle.Fill;
            panel15.Location = new Point(5, 43);
            panel15.Name = "panel15";
            panel15.Size = new Size(580, 349);
            panel15.TabIndex = 1;
            // 
            // producttable
            // 
            producttable.AllowUserToAddRows = false;
            producttable.AllowUserToDeleteRows = false;
            producttable.AllowUserToResizeColumns = false;
            producttable.AllowUserToResizeRows = false;
            producttable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            producttable.BackgroundColor = Color.White;
            producttable.BorderStyle = BorderStyle.None;
            producttable.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            producttable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            producttable.Columns.AddRange(new DataGridViewColumn[] { itemCodeLabel, imageLabel, descriptionLabel });
            producttable.Dock = DockStyle.Fill;
            producttable.GridColor = Color.White;
            producttable.Location = new Point(0, 0);
            producttable.Name = "producttable";
            producttable.ReadOnly = true;
            producttable.RowHeadersVisible = false;
            producttable.RowTemplate.Height = 140;
            producttable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            producttable.Size = new Size(580, 349);
            producttable.TabIndex = 0;
            // 
            // itemCodeLabel
            // 
            itemCodeLabel.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            itemCodeLabel.HeaderText = "Item Code";
            itemCodeLabel.Name = "itemCodeLabel";
            itemCodeLabel.ReadOnly = true;
            // 
            // imageLabel
            // 
            imageLabel.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            imageLabel.HeaderText = "Images";
            imageLabel.Name = "imageLabel";
            imageLabel.ReadOnly = true;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            descriptionLabel.HeaderText = "Description";
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.ReadOnly = true;
            // 
            // panel14
            // 
            panel14.Controls.Add(label11);
            panel14.Dock = DockStyle.Top;
            panel14.Location = new Point(5, 5);
            panel14.Name = "panel14";
            panel14.Padding = new Padding(5);
            panel14.Size = new Size(580, 38);
            panel14.TabIndex = 0;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("SimSun", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(3, 13);
            label11.Name = "label11";
            label11.Size = new Size(98, 21);
            label11.TabIndex = 0;
            label11.Text = "Products";
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(59, 116, 192);
            panel8.Controls.Add(panel13);
            panel8.Controls.Add(panel12);
            panel8.Controls.Add(panel11);
            panel8.Controls.Add(panel10);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(8, 8);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(5);
            panel8.Size = new Size(192, 397);
            panel8.TabIndex = 0;
            // 
            // panel13
            // 
            panel13.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel13.Controls.Add(customButton4);
            panel13.Location = new Point(0, 310);
            panel13.Name = "panel13";
            panel13.Size = new Size(194, 60);
            panel13.TabIndex = 1;
            // 
            // customButton4
            // 
            customButton4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customButton4.BackColor = Color.FromArgb(59, 116, 192);
            customButton4.FlatAppearance.BorderSize = 0;
            customButton4.FlatStyle = FlatStyle.Flat;
            customButton4.Font = new Font("SimSun", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            customButton4.ForeColor = Color.White;
            customButton4.HoverForeColor1 = Color.Black;
            customButton4.HoverImage1 = null;
            customButton4.Location = new Point(0, 0);
            customButton4.Name = "customButton4";
            customButton4.NormalForeColor1 = Color.White;
            customButton4.NormalImage1 = null;
            customButton4.OnFocusEnterImage = null;
            customButton4.OnFocusLeaveImage = null;
            customButton4.Size = new Size(192, 60);
            customButton4.TabIndex = 0;
            customButton4.Text = "Displayed Products";
            customButton4.Tooltip1 = null;
            customButton4.UseVisualStyleBackColor = false;
            // 
            // panel12
            // 
            panel12.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel12.Controls.Add(customButton3);
            panel12.Location = new Point(0, 244);
            panel12.Name = "panel12";
            panel12.Size = new Size(194, 60);
            panel12.TabIndex = 1;
            // 
            // customButton3
            // 
            customButton3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customButton3.BackColor = Color.FromArgb(59, 116, 192);
            customButton3.FlatAppearance.BorderSize = 0;
            customButton3.FlatStyle = FlatStyle.Flat;
            customButton3.Font = new Font("SimSun", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            customButton3.ForeColor = Color.White;
            customButton3.HoverForeColor1 = Color.Black;
            customButton3.HoverImage1 = null;
            customButton3.Location = new Point(0, 0);
            customButton3.Name = "customButton3";
            customButton3.NormalForeColor1 = Color.White;
            customButton3.NormalImage1 = null;
            customButton3.OnFocusEnterImage = null;
            customButton3.OnFocusLeaveImage = null;
            customButton3.Size = new Size(192, 60);
            customButton3.TabIndex = 0;
            customButton3.Text = "Damaged Products";
            customButton3.Tooltip1 = null;
            customButton3.UseVisualStyleBackColor = false;
            // 
            // panel11
            // 
            panel11.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel11.Controls.Add(customButton2);
            panel11.Location = new Point(1, 178);
            panel11.Name = "panel11";
            panel11.Size = new Size(194, 60);
            panel11.TabIndex = 1;
            // 
            // customButton2
            // 
            customButton2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customButton2.BackColor = Color.FromArgb(59, 116, 192);
            customButton2.FlatAppearance.BorderSize = 0;
            customButton2.FlatStyle = FlatStyle.Flat;
            customButton2.Font = new Font("SimSun", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            customButton2.ForeColor = Color.White;
            customButton2.HoverForeColor1 = Color.Black;
            customButton2.HoverImage1 = null;
            customButton2.Location = new Point(0, 0);
            customButton2.Name = "customButton2";
            customButton2.NormalForeColor1 = Color.White;
            customButton2.NormalImage1 = null;
            customButton2.OnFocusEnterImage = null;
            customButton2.OnFocusLeaveImage = null;
            customButton2.Size = new Size(192, 60);
            customButton2.TabIndex = 0;
            customButton2.Text = "Available Products";
            customButton2.Tooltip1 = null;
            customButton2.UseVisualStyleBackColor = false;
            // 
            // panel10
            // 
            panel10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel10.Controls.Add(customButton1);
            panel10.Location = new Point(0, 112);
            panel10.Name = "panel10";
            panel10.Size = new Size(194, 60);
            panel10.TabIndex = 0;
            // 
            // customButton1
            // 
            customButton1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customButton1.BackColor = Color.FromArgb(59, 116, 192);
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.Font = new Font("SimSun", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            customButton1.ForeColor = Color.White;
            customButton1.HoverForeColor1 = Color.Black;
            customButton1.HoverImage1 = null;
            customButton1.Location = new Point(0, 0);
            customButton1.Name = "customButton1";
            customButton1.NormalForeColor1 = Color.White;
            customButton1.NormalImage1 = null;
            customButton1.OnFocusEnterImage = null;
            customButton1.OnFocusLeaveImage = null;
            customButton1.Size = new Size(192, 60);
            customButton1.TabIndex = 0;
            customButton1.Text = "Total Products";
            customButton1.Tooltip1 = null;
            customButton1.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(209, 222, 240);
            panel7.Controls.Add(label10);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(5, 249);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(5);
            panel7.Size = new Size(804, 46);
            panel7.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("SimSun", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(128, 165, 214);
            label10.Location = new Point(3, 8);
            label10.Name = "label10";
            label10.Size = new Size(141, 29);
            label10.TabIndex = 0;
            label10.Text = "Overview";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Snow;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(panel3, 0, 0);
            tableLayoutPanel1.Controls.Add(panel4, 1, 0);
            tableLayoutPanel1.Controls.Add(panel5, 2, 0);
            tableLayoutPanel1.Controls.Add(panel6, 3, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(5, 55);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(5);
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(804, 194);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(45, 71, 154);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(8, 8);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(5);
            panel3.Size = new Size(192, 178);
            panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_product_100;
            pictureBox1.Location = new Point(1, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("SimSun", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(124, 1);
            label3.Name = "label3";
            label3.Size = new Size(74, 37);
            label3.TabIndex = 1;
            label3.Text = "350";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(61, 118);
            label2.Name = "label2";
            label2.Size = new Size(133, 58);
            label2.TabIndex = 0;
            label2.Text = "Total\r\nProducts";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(45, 71, 154);
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label5);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(206, 8);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(5);
            panel4.Size = new Size(192, 178);
            panel4.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_sell_100;
            pictureBox2.Location = new Point(0, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 100);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("SimSun", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(123, 1);
            label4.Name = "label4";
            label4.Size = new Size(74, 37);
            label4.TabIndex = 4;
            label4.Text = "350";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("SimSun", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(47, 116);
            label5.Name = "label5";
            label5.Size = new Size(148, 58);
            label5.TabIndex = 3;
            label5.Text = "Available\r\nProducts";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(45, 71, 154);
            panel5.Controls.Add(pictureBox3);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(label7);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(404, 8);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(5);
            panel5.Size = new Size(192, 178);
            panel5.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.icons8_used_product_80;
            pictureBox3.Location = new Point(0, -1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 100);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("SimSun", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(123, 1);
            label6.Name = "label6";
            label6.Size = new Size(74, 37);
            label6.TabIndex = 4;
            label6.Text = "350";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("SimSun", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(62, 117);
            label7.Name = "label7";
            label7.Size = new Size(133, 58);
            label7.TabIndex = 3;
            label7.Text = "Damaged\r\nProducts";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(45, 71, 154);
            panel6.Controls.Add(pictureBox4);
            panel6.Controls.Add(label8);
            panel6.Controls.Add(label9);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(602, 8);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(5);
            panel6.Size = new Size(194, 178);
            panel6.TabIndex = 3;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.icons8_open_box_100;
            pictureBox4.Location = new Point(2, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(100, 100);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("SimSun", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(123, 0);
            label8.Name = "label8";
            label8.Size = new Size(74, 37);
            label8.TabIndex = 4;
            label8.Text = "350";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("SimSun", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(49, 116);
            label9.Name = "label9";
            label9.Size = new Size(148, 58);
            label9.TabIndex = 3;
            label9.Text = "Displayed\r\nProducts";
            label9.TextAlign = ContentAlignment.MiddleRight;
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
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDark;
            label1.Location = new Point(3, 11);
            label1.Name = "label1";
            label1.Size = new Size(138, 27);
            label1.TabIndex = 0;
            label1.Text = "Dashboard";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(824, 723);
            Controls.Add(panel1);
            Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(824, 723);
            Name = "Dashboard";
            Padding = new Padding(5);
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)producttable).EndInit();
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            panel8.ResumeLayout(false);
            panel13.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label2;
        private Panel panel4;
        private PictureBox pictureBox2;
        private Label label4;
        private Label label5;
        private Panel panel5;
        private PictureBox pictureBox3;
        private Label label6;
        private Label label7;
        private Panel panel6;
        private PictureBox pictureBox4;
        private Label label8;
        private Label label9;
        private Panel panel2;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel8;
        private Panel panel9;
        private Panel panel7;
        private Label label10;
        private Panel panel10;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel13;
        private CustomButton customButton4;
        private Panel panel12;
        private CustomButton customButton3;
        private Panel panel11;
        private CustomButton customButton2;
        private CustomButton customButton1;
        private Panel panel15;
        private DataGridView producttable;
        private Panel panel14;
        private Label label11;
        private DataGridViewTextBoxColumn itemCodeLabel;
        private DataGridViewImageColumn imageLabel;
        private DataGridViewImageColumn descriptionLabel;
    }
}