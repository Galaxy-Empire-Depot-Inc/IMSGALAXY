﻿namespace InventorySystemGalaxy
{
    partial class WarehouseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WarehouseForm));
            label1 = new Label();
            ShowModal = new CustomButton();
            panel1 = new Panel();
            panel6 = new Panel();
            WarehouseTable = new DataGridView();
            panel3 = new Panel();
            panel4 = new Panel();
            panel7 = new Panel();
            pictureBox2 = new PictureBox();
            searchText = new CustomTextBox();
            panel5 = new Panel();
            pictureBox1 = new PictureBox();
            customTextBox1 = new CustomTextBox();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)WarehouseTable).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDark;
            label1.Location = new Point(8, 16);
            label1.Name = "label1";
            label1.Size = new Size(208, 27);
            label1.TabIndex = 1;
            label1.Text = "Warehouse(ALL)";
            // 
            // ShowModal
            // 
            ShowModal.FlatStyle = FlatStyle.Flat;
            ShowModal.Font = new Font("SimSun", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ShowModal.ForeColor = Color.White;
            ShowModal.HoverForeColor1 = Color.Black;
            ShowModal.HoverImage1 = Properties.Resources.icons8_add_100__2___1_;
            ShowModal.Image = Properties.Resources.icons8_add_100__1___1_;
            ShowModal.ImageAlign = ContentAlignment.MiddleLeft;
            ShowModal.Location = new Point(7, 42);
            ShowModal.Name = "ShowModal";
            ShowModal.NormalForeColor1 = Color.White;
            ShowModal.NormalImage1 = Properties.Resources.icons8_add_100__1___1_;
            ShowModal.OnFocusEnterImage = null;
            ShowModal.OnFocusLeaveImage = null;
            ShowModal.Padding = new Padding(10);
            ShowModal.Size = new Size(115, 50);
            ShowModal.TabIndex = 1;
            ShowModal.Text = "   New";
            ShowModal.TextAlign = ContentAlignment.MiddleLeft;
            ShowModal.Tooltip1 = null;
            ShowModal.UseVisualStyleBackColor = true;
            ShowModal.Click += ShowModal_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(5, 5);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(814, 713);
            panel1.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.Controls.Add(WarehouseTable);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(5, 165);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(5);
            panel6.Size = new Size(804, 543);
            panel6.TabIndex = 2;
            // 
            // WarehouseTable
            // 
            WarehouseTable.AllowUserToAddRows = false;
            WarehouseTable.AllowUserToDeleteRows = false;
            WarehouseTable.AllowUserToOrderColumns = true;
            WarehouseTable.AllowUserToResizeColumns = false;
            WarehouseTable.AllowUserToResizeRows = false;
            WarehouseTable.BackgroundColor = Color.White;
            WarehouseTable.BorderStyle = BorderStyle.Fixed3D;
            WarehouseTable.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            WarehouseTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            WarehouseTable.Dock = DockStyle.Fill;
            WarehouseTable.GridColor = Color.White;
            WarehouseTable.Location = new Point(5, 5);
            WarehouseTable.Name = "WarehouseTable";
            WarehouseTable.ReadOnly = true;
            WarehouseTable.RowHeadersVisible = false;
            WarehouseTable.RowTemplate.Height = 100;
            WarehouseTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            WarehouseTable.Size = new Size(794, 533);
            WarehouseTable.TabIndex = 0;
            WarehouseTable.CellDoubleClick += WarehouseTable_CellDoubleClick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Snow;
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(5, 55);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(5);
            panel3.Size = new Size(804, 110);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(59, 116, 192);
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(ShowModal);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(5, 5);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(5);
            panel4.Size = new Size(794, 100);
            panel4.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel7.Controls.Add(pictureBox2);
            panel7.Controls.Add(searchText);
            panel7.Location = new Point(546, 42);
            panel7.Name = "panel7";
            panel7.Size = new Size(240, 50);
            panel7.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.images_removebg_preview;
            pictureBox2.Location = new Point(20, 13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // searchText
            // 
            searchText.BorderStyle = BorderStyle.None;
            searchText.BottomBorderColor = Color.LightSlateGray;
            searchText.BottomBorderOnFocusColor = Color.CornflowerBlue;
            searchText.Font = new Font("SimSun", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            searchText.Location = new Point(61, 25);
            searchText.Name = "searchText";
            searchText.PlaceholderText = "Search";
            searchText.Size = new Size(177, 23);
            searchText.TabIndex = 0;
            searchText.TextAlign = HorizontalAlignment.Center;
            searchText.TextChanged += searchText_TextChanged;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel5.Controls.Add(pictureBox1);
            panel5.Controls.Add(customTextBox1);
            panel5.Location = new Point(1140, 52);
            panel5.Name = "panel5";
            panel5.Size = new Size(240, 50);
            panel5.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.images_removebg_preview;
            pictureBox1.Location = new Point(20, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // customTextBox1
            // 
            customTextBox1.BorderStyle = BorderStyle.None;
            customTextBox1.BottomBorderColor = Color.LightSlateGray;
            customTextBox1.BottomBorderOnFocusColor = Color.CornflowerBlue;
            customTextBox1.Font = new Font("SimSun", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            customTextBox1.Location = new Point(61, 25);
            customTextBox1.Name = "customTextBox1";
            customTextBox1.PlaceholderText = "Search";
            customTextBox1.Size = new Size(177, 23);
            customTextBox1.TabIndex = 0;
            customTextBox1.TextAlign = HorizontalAlignment.Center;
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
            panel2.TabIndex = 0;
            // 
            // WarehouseForm
            // 
            AutoScaleDimensions = new SizeF(6F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 723);
            Controls.Add(panel1);
            Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(824, 723);
            Name = "WarehouseForm";
            Padding = new Padding(5);
            Text = "WarehouseForm";
            Load += WarehouseForm_Load;
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)WarehouseTable).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private CustomButton ShowModal;
        private Panel panel1;
        private Panel panel6;
        private DataGridView WarehouseTable;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private PictureBox pictureBox1;
        private CustomTextBox customTextBox1;
        private Panel panel2;
        private Panel panel7;
        private PictureBox pictureBox2;
        private CustomTextBox searchText;
    }
}