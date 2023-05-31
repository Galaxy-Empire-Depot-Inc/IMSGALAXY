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
            panel14 = new Panel();
            label11 = new Label();
            panel8 = new Panel();
            panel13 = new Panel();
            btn_DisplayP = new CustomButton();
            panel12 = new Panel();
            btn_DamageP = new CustomButton();
            panel11 = new Panel();
            btn_AvailableP = new CustomButton();
            panel10 = new Panel();
            btn_TotalP = new CustomButton();
            panel7 = new Panel();
            label10 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            lbl_TotalP = new Label();
            label2 = new Label();
            panel4 = new Panel();
            pictureBox2 = new PictureBox();
            lbl_AvailableP = new Label();
            label5 = new Label();
            panel5 = new Panel();
            pictureBox3 = new PictureBox();
            lbl_DamageP = new Label();
            label7 = new Label();
            panel6 = new Panel();
            pictureBox4 = new PictureBox();
            lbl_DisplayP = new Label();
            label9 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            itemCodeLabel = new DataGridViewTextBoxColumn();
            descriptionLabel = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            imageLabel = new DataGridViewImageColumn();
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
            producttable.Columns.AddRange(new DataGridViewColumn[] { itemCodeLabel, descriptionLabel, Category, imageLabel });
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
            panel13.Controls.Add(btn_DisplayP);
            panel13.Location = new Point(0, 310);
            panel13.Name = "panel13";
            panel13.Size = new Size(194, 60);
            panel13.TabIndex = 1;
            // 
            // btn_DisplayP
            // 
            btn_DisplayP.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_DisplayP.BackColor = Color.FromArgb(59, 116, 192);
            btn_DisplayP.FlatAppearance.BorderSize = 0;
            btn_DisplayP.FlatStyle = FlatStyle.Flat;
            btn_DisplayP.Font = new Font("SimSun", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_DisplayP.ForeColor = Color.White;
            btn_DisplayP.HoverForeColor1 = Color.Black;
            btn_DisplayP.HoverImage1 = null;
            btn_DisplayP.Location = new Point(0, 0);
            btn_DisplayP.Name = "btn_DisplayP";
            btn_DisplayP.NormalForeColor1 = Color.White;
            btn_DisplayP.NormalImage1 = null;
            btn_DisplayP.OnFocusEnterImage = null;
            btn_DisplayP.OnFocusLeaveImage = null;
            btn_DisplayP.Size = new Size(192, 60);
            btn_DisplayP.TabIndex = 0;
            btn_DisplayP.Text = "Displayed Products";
            btn_DisplayP.Tooltip1 = null;
            btn_DisplayP.UseVisualStyleBackColor = false;
            // 
            // panel12
            // 
            panel12.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel12.Controls.Add(btn_DamageP);
            panel12.Location = new Point(0, 244);
            panel12.Name = "panel12";
            panel12.Size = new Size(194, 60);
            panel12.TabIndex = 1;
            // 
            // btn_DamageP
            // 
            btn_DamageP.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_DamageP.BackColor = Color.FromArgb(59, 116, 192);
            btn_DamageP.FlatAppearance.BorderSize = 0;
            btn_DamageP.FlatStyle = FlatStyle.Flat;
            btn_DamageP.Font = new Font("SimSun", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_DamageP.ForeColor = Color.White;
            btn_DamageP.HoverForeColor1 = Color.Black;
            btn_DamageP.HoverImage1 = null;
            btn_DamageP.Location = new Point(0, 0);
            btn_DamageP.Name = "btn_DamageP";
            btn_DamageP.NormalForeColor1 = Color.White;
            btn_DamageP.NormalImage1 = null;
            btn_DamageP.OnFocusEnterImage = null;
            btn_DamageP.OnFocusLeaveImage = null;
            btn_DamageP.Size = new Size(192, 60);
            btn_DamageP.TabIndex = 0;
            btn_DamageP.Text = "Damaged Products";
            btn_DamageP.Tooltip1 = null;
            btn_DamageP.UseVisualStyleBackColor = false;
            // 
            // panel11
            // 
            panel11.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel11.Controls.Add(btn_AvailableP);
            panel11.Location = new Point(1, 178);
            panel11.Name = "panel11";
            panel11.Size = new Size(194, 60);
            panel11.TabIndex = 1;
            // 
            // btn_AvailableP
            // 
            btn_AvailableP.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_AvailableP.BackColor = Color.FromArgb(59, 116, 192);
            btn_AvailableP.FlatAppearance.BorderSize = 0;
            btn_AvailableP.FlatStyle = FlatStyle.Flat;
            btn_AvailableP.Font = new Font("SimSun", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_AvailableP.ForeColor = Color.White;
            btn_AvailableP.HoverForeColor1 = Color.Black;
            btn_AvailableP.HoverImage1 = null;
            btn_AvailableP.Location = new Point(0, 0);
            btn_AvailableP.Name = "btn_AvailableP";
            btn_AvailableP.NormalForeColor1 = Color.White;
            btn_AvailableP.NormalImage1 = null;
            btn_AvailableP.OnFocusEnterImage = null;
            btn_AvailableP.OnFocusLeaveImage = null;
            btn_AvailableP.Size = new Size(192, 60);
            btn_AvailableP.TabIndex = 0;
            btn_AvailableP.Text = "Available Products";
            btn_AvailableP.Tooltip1 = null;
            btn_AvailableP.UseVisualStyleBackColor = false;
            // 
            // panel10
            // 
            panel10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel10.Controls.Add(btn_TotalP);
            panel10.Location = new Point(0, 112);
            panel10.Name = "panel10";
            panel10.Size = new Size(194, 60);
            panel10.TabIndex = 0;
            // 
            // btn_TotalP
            // 
            btn_TotalP.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_TotalP.BackColor = Color.FromArgb(59, 116, 192);
            btn_TotalP.FlatAppearance.BorderSize = 0;
            btn_TotalP.FlatStyle = FlatStyle.Flat;
            btn_TotalP.Font = new Font("SimSun", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_TotalP.ForeColor = Color.White;
            btn_TotalP.HoverForeColor1 = Color.Black;
            btn_TotalP.HoverImage1 = null;
            btn_TotalP.Location = new Point(0, 0);
            btn_TotalP.Name = "btn_TotalP";
            btn_TotalP.NormalForeColor1 = Color.White;
            btn_TotalP.NormalImage1 = null;
            btn_TotalP.OnFocusEnterImage = null;
            btn_TotalP.OnFocusLeaveImage = null;
            btn_TotalP.Size = new Size(192, 60);
            btn_TotalP.TabIndex = 0;
            btn_TotalP.Text = "Total Products";
            btn_TotalP.Tooltip1 = null;
            btn_TotalP.UseVisualStyleBackColor = false;
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
            panel3.Controls.Add(lbl_TotalP);
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
            // lbl_TotalP
            // 
            lbl_TotalP.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_TotalP.AutoSize = true;
            lbl_TotalP.Font = new Font("SimSun", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_TotalP.ForeColor = Color.White;
            lbl_TotalP.Location = new Point(124, 1);
            lbl_TotalP.Name = "lbl_TotalP";
            lbl_TotalP.Size = new Size(74, 37);
            lbl_TotalP.TabIndex = 1;
            lbl_TotalP.Text = "350";
            lbl_TotalP.TextAlign = ContentAlignment.MiddleRight;
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
            panel4.Controls.Add(lbl_AvailableP);
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
            // lbl_AvailableP
            // 
            lbl_AvailableP.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_AvailableP.AutoSize = true;
            lbl_AvailableP.Font = new Font("SimSun", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_AvailableP.ForeColor = Color.White;
            lbl_AvailableP.Location = new Point(123, 1);
            lbl_AvailableP.Name = "lbl_AvailableP";
            lbl_AvailableP.Size = new Size(74, 37);
            lbl_AvailableP.TabIndex = 4;
            lbl_AvailableP.Text = "350";
            lbl_AvailableP.TextAlign = ContentAlignment.MiddleRight;
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
            panel5.Controls.Add(lbl_DamageP);
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
            // lbl_DamageP
            // 
            lbl_DamageP.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_DamageP.AutoSize = true;
            lbl_DamageP.Font = new Font("SimSun", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_DamageP.ForeColor = Color.White;
            lbl_DamageP.Location = new Point(123, 1);
            lbl_DamageP.Name = "lbl_DamageP";
            lbl_DamageP.Size = new Size(74, 37);
            lbl_DamageP.TabIndex = 4;
            lbl_DamageP.Text = "350";
            lbl_DamageP.TextAlign = ContentAlignment.MiddleRight;
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
            panel6.Controls.Add(lbl_DisplayP);
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
            // lbl_DisplayP
            // 
            lbl_DisplayP.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_DisplayP.AutoSize = true;
            lbl_DisplayP.Font = new Font("SimSun", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_DisplayP.ForeColor = Color.White;
            lbl_DisplayP.Location = new Point(123, 0);
            lbl_DisplayP.Name = "lbl_DisplayP";
            lbl_DisplayP.Size = new Size(74, 37);
            lbl_DisplayP.TabIndex = 4;
            lbl_DisplayP.Text = "350";
            lbl_DisplayP.TextAlign = ContentAlignment.MiddleRight;
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
            // itemCodeLabel
            // 
            itemCodeLabel.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            itemCodeLabel.DataPropertyName = "item_code";
            itemCodeLabel.HeaderText = "Item Code";
            itemCodeLabel.Name = "itemCodeLabel";
            itemCodeLabel.ReadOnly = true;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            descriptionLabel.DataPropertyName = "description";
            descriptionLabel.HeaderText = "Description";
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.ReadOnly = true;
            descriptionLabel.Resizable = DataGridViewTriState.True;
            descriptionLabel.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Category
            // 
            Category.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Category.DataPropertyName = "category";
            Category.HeaderText = "Category";
            Category.Name = "Category";
            Category.ReadOnly = true;
            Category.Width = 96;
            // 
            // imageLabel
            // 
            imageLabel.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            imageLabel.DataPropertyName = "picture";
            imageLabel.HeaderText = "Images";
            imageLabel.ImageLayout = DataGridViewImageCellLayout.Stretch;
            imageLabel.Name = "imageLabel";
            imageLabel.ReadOnly = true;
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
            Load += Dashboard_Load;
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
        private Label lbl_TotalP;
        private Label label2;
        private Panel panel4;
        private PictureBox pictureBox2;
        private Label lbl_AvailableP;
        private Label label5;
        private Panel panel5;
        private PictureBox pictureBox3;
        private Label lbl_DamageP;
        private Label label7;
        private Panel panel6;
        private PictureBox pictureBox4;
        private Label lbl_DisplayP;
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
        private CustomButton btn_DisplayP;
        private Panel panel12;
        private CustomButton btn_DamageP;
        private Panel panel11;
        private CustomButton btn_AvailableP;
        private CustomButton btn_TotalP;
        private Panel panel15;
        private DataGridView producttable;
        private Panel panel14;
        private Label label11;
        private DataGridViewTextBoxColumn itemCodeLabel;
        private DataGridViewTextBoxColumn descriptionLabel;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewImageColumn imageLabel;
    }
}