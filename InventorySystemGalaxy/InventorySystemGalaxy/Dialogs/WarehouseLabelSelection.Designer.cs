namespace InventorySystemGalaxy.Dialogs
{
    partial class WarehouseLabelSelection
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
            grpRadio = new GroupBox();
            mlbRB = new RadioButton();
            tmsRB = new RadioButton();
            storeRB = new RadioButton();
            allRB = new RadioButton();
            SelectWarehouseBtn = new ButtonCustom();
            grpRadio.SuspendLayout();
            SuspendLayout();
            // 
            // grpRadio
            // 
            grpRadio.Controls.Add(mlbRB);
            grpRadio.Controls.Add(tmsRB);
            grpRadio.Controls.Add(storeRB);
            grpRadio.Controls.Add(allRB);
            grpRadio.Font = new Font("SimSun", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            grpRadio.ForeColor = Color.White;
            grpRadio.Location = new Point(12, 12);
            grpRadio.Name = "grpRadio";
            grpRadio.Size = new Size(165, 188);
            grpRadio.TabIndex = 1;
            grpRadio.TabStop = false;
            grpRadio.Text = "Warehouse";
            // 
            // mlbRB
            // 
            mlbRB.AutoSize = true;
            mlbRB.Font = new Font("SimSun", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            mlbRB.ForeColor = Color.White;
            mlbRB.Location = new Point(25, 140);
            mlbRB.Name = "mlbRB";
            mlbRB.Size = new Size(61, 25);
            mlbRB.TabIndex = 3;
            mlbRB.TabStop = true;
            mlbRB.Text = "MLB";
            mlbRB.UseVisualStyleBackColor = true;
            // 
            // tmsRB
            // 
            tmsRB.AutoSize = true;
            tmsRB.Font = new Font("SimSun", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            tmsRB.ForeColor = Color.White;
            tmsRB.Location = new Point(25, 104);
            tmsRB.Name = "tmsRB";
            tmsRB.Size = new Size(61, 25);
            tmsRB.TabIndex = 2;
            tmsRB.TabStop = true;
            tmsRB.Text = "TMS";
            tmsRB.UseVisualStyleBackColor = true;
            // 
            // storeRB
            // 
            storeRB.AutoSize = true;
            storeRB.Font = new Font("SimSun", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            storeRB.ForeColor = Color.White;
            storeRB.Location = new Point(25, 70);
            storeRB.Name = "storeRB";
            storeRB.Size = new Size(83, 25);
            storeRB.TabIndex = 1;
            storeRB.TabStop = true;
            storeRB.Text = "Store";
            storeRB.UseVisualStyleBackColor = true;
            // 
            // allRB
            // 
            allRB.AutoSize = true;
            allRB.Font = new Font("SimSun", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            allRB.ForeColor = Color.White;
            allRB.Location = new Point(25, 36);
            allRB.Name = "allRB";
            allRB.Size = new Size(61, 25);
            allRB.TabIndex = 0;
            allRB.TabStop = true;
            allRB.Text = "All";
            allRB.UseVisualStyleBackColor = true;
            // 
            // SelectWarehouseBtn
            // 
            SelectWarehouseBtn.BackColor = Color.White;
            SelectWarehouseBtn.Cursor = Cursors.Hand;
            SelectWarehouseBtn.FlatAppearance.BorderSize = 0;
            SelectWarehouseBtn.FlatStyle = FlatStyle.Flat;
            SelectWarehouseBtn.ForeColor = Color.Black;
            SelectWarehouseBtn.Location = new Point(37, 206);
            SelectWarehouseBtn.Name = "SelectWarehouseBtn";
            SelectWarehouseBtn.Size = new Size(110, 32);
            SelectWarehouseBtn.TabIndex = 2;
            SelectWarehouseBtn.Text = "Select";
            SelectWarehouseBtn.UseVisualStyleBackColor = false;
            SelectWarehouseBtn.Click += SelectWarehouseBtn_Click;
            // 
            // WarehouseLabelSelection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(59, 116, 192);
            ClientSize = new Size(192, 250);
            Controls.Add(SelectWarehouseBtn);
            Controls.Add(grpRadio);
            FormBorderStyle = FormBorderStyle.None;
            Name = "WarehouseLabelSelection";
            Text = "WarehouseLabelSelection";
            grpRadio.ResumeLayout(false);
            grpRadio.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpRadio;
        private ButtonCustom SelectWarehouseBtn;
        public RadioButton mlbRB;
        public RadioButton tmsRB;
        public RadioButton storeRB;
        public RadioButton allRB;
    }
}