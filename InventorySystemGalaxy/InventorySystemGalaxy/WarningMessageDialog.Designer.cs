namespace InventorySystemGalaxy
{
    partial class Warning_Message
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            LabelMessage = new Label();
            panel1 = new Panel();
            YesBtn = new Button();
            NoBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(5, 9);
            label1.Name = "label1";
            label1.Size = new Size(79, 19);
            label1.TabIndex = 6;
            label1.Text = "Warning";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_warning_100__2_;
            pictureBox1.Location = new Point(50, 82);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // LabelMessage
            // 
            LabelMessage.AutoSize = true;
            LabelMessage.Font = new Font("SimSun", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LabelMessage.ForeColor = Color.Black;
            LabelMessage.Location = new Point(114, 83);
            LabelMessage.Name = "LabelMessage";
            LabelMessage.Size = new Size(250, 48);
            LabelMessage.TabIndex = 7;
            LabelMessage.Text = "Do you want to close\r\n the application?";
            LabelMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Yellow;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(428, 35);
            panel1.TabIndex = 0;
            // 
            // YesBtn
            // 
            YesBtn.BackColor = Color.DarkSeaGreen;
            YesBtn.FlatAppearance.BorderSize = 0;
            YesBtn.FlatStyle = FlatStyle.Flat;
            YesBtn.Font = new Font("SimSun", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            YesBtn.Image = Properties.Resources.icons8_check_30;
            YesBtn.ImageAlign = ContentAlignment.MiddleLeft;
            YesBtn.Location = new Point(114, 169);
            YesBtn.Name = "YesBtn";
            YesBtn.Size = new Size(80, 34);
            YesBtn.TabIndex = 8;
            YesBtn.Text = "Yes";
            YesBtn.TextAlign = ContentAlignment.MiddleRight;
            YesBtn.UseVisualStyleBackColor = false;
            YesBtn.Click += button1_Click;
            // 
            // NoBtn
            // 
            NoBtn.BackColor = Color.FromArgb(255, 128, 128);
            NoBtn.FlatAppearance.BorderSize = 0;
            NoBtn.FlatStyle = FlatStyle.Flat;
            NoBtn.Font = new Font("SimSun", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            NoBtn.Image = Properties.Resources.icons8_cancel_30;
            NoBtn.ImageAlign = ContentAlignment.MiddleLeft;
            NoBtn.Location = new Point(238, 169);
            NoBtn.Name = "NoBtn";
            NoBtn.Size = new Size(80, 34);
            NoBtn.TabIndex = 9;
            NoBtn.Text = "No";
            NoBtn.TextAlign = ContentAlignment.MiddleRight;
            NoBtn.UseVisualStyleBackColor = false;
            NoBtn.Click += NoBtn_Click;
            // 
            // Warning_Message
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(428, 247);
            Controls.Add(NoBtn);
            Controls.Add(YesBtn);
            Controls.Add(LabelMessage);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Warning_Message";
            Text = "Warning_Message";
            Load += Warning_Message_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label1;
        private Label LabelMessage;
        private Panel panel1;
        private Button YesBtn;
        private Button NoBtn;
    }
}