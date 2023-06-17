namespace InventorySystemGalaxy.Dialogs
{
    partial class LogoutMessage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            LabelMessage = new Label();
            pictureBox1 = new PictureBox();
            NoBtn = new Button();
            YesBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Yellow;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(356, 35);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(8, 9);
            label1.Name = "label1";
            label1.Size = new Size(75, 19);
            label1.TabIndex = 6;
            label1.Text = "Logout";
            // 
            // LabelMessage
            // 
            LabelMessage.AutoSize = true;
            LabelMessage.Font = new Font("SimSun", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LabelMessage.ForeColor = Color.Black;
            LabelMessage.Location = new Point(103, 61);
            LabelMessage.Name = "LabelMessage";
            LabelMessage.Size = new Size(214, 48);
            LabelMessage.TabIndex = 8;
            LabelMessage.Text = "Are you sure you \r\nwant to Logout?";
            LabelMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_logout_100;
            pictureBox1.Location = new Point(36, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // NoBtn
            // 
            NoBtn.BackColor = Color.FromArgb(255, 128, 128);
            NoBtn.Cursor = Cursors.Hand;
            NoBtn.FlatAppearance.BorderSize = 0;
            NoBtn.FlatStyle = FlatStyle.Flat;
            NoBtn.Font = new Font("SimSun", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            NoBtn.Image = Properties.Resources.icons8_cancel_30;
            NoBtn.ImageAlign = ContentAlignment.MiddleLeft;
            NoBtn.Location = new Point(204, 124);
            NoBtn.Name = "NoBtn";
            NoBtn.Size = new Size(80, 34);
            NoBtn.TabIndex = 11;
            NoBtn.Text = "No";
            NoBtn.TextAlign = ContentAlignment.MiddleRight;
            NoBtn.UseVisualStyleBackColor = false;
            NoBtn.Click += NoBtn_Click;
            // 
            // YesBtn
            // 
            YesBtn.BackColor = Color.DarkSeaGreen;
            YesBtn.Cursor = Cursors.Hand;
            YesBtn.FlatAppearance.BorderSize = 0;
            YesBtn.FlatStyle = FlatStyle.Flat;
            YesBtn.Font = new Font("SimSun", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            YesBtn.Image = Properties.Resources.icons8_check_30;
            YesBtn.ImageAlign = ContentAlignment.MiddleLeft;
            YesBtn.Location = new Point(80, 124);
            YesBtn.Name = "YesBtn";
            YesBtn.Size = new Size(80, 34);
            YesBtn.TabIndex = 10;
            YesBtn.Text = "Yes";
            YesBtn.TextAlign = ContentAlignment.MiddleRight;
            YesBtn.UseVisualStyleBackColor = false;
            YesBtn.Click += YesBtn_Click;
            // 
            // LogoutMessage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(356, 174);
            Controls.Add(NoBtn);
            Controls.Add(YesBtn);
            Controls.Add(pictureBox1);
            Controls.Add(LabelMessage);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LogoutMessage";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label LabelMessage;
        private PictureBox pictureBox1;
        private Button NoBtn;
        private Button YesBtn;
    }
}
