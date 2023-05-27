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
            panel1 = new Panel();
            YesButton = new CustomButton();
            CancelButton = new CustomButton();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            LabelMessage = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(428, 35);
            panel1.TabIndex = 0;
            // 
            // YesButton
            // 
            YesButton.Font = new Font("SimSun", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            YesButton.HoverForeColor1 = Color.FromArgb(128, 255, 128);
            YesButton.HoverImage1 = null;
            YesButton.Image = Properties.Resources.icons8_check_30;
            YesButton.ImageAlign = ContentAlignment.MiddleLeft;
            YesButton.Location = new Point(79, 245);
            YesButton.Name = "YesButton";
            YesButton.NormalForeColor1 = Color.White;
            YesButton.NormalImage1 = null;
            YesButton.Padding = new Padding(5);
            YesButton.Size = new Size(91, 34);
            YesButton.TabIndex = 3;
            YesButton.Text = "Yes";
            YesButton.TextAlign = ContentAlignment.MiddleRight;
            YesButton.Tooltip1 = null;
            YesButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            CancelButton.Font = new Font("SimSun", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            CancelButton.HoverForeColor1 = Color.Red;
            CancelButton.HoverImage1 = null;
            CancelButton.Image = Properties.Resources.icons8_cancel_30;
            CancelButton.ImageAlign = ContentAlignment.MiddleLeft;
            CancelButton.Location = new Point(256, 245);
            CancelButton.Name = "CancelButton";
            CancelButton.NormalForeColor1 = Color.White;
            CancelButton.NormalImage1 = null;
            CancelButton.Padding = new Padding(5);
            CancelButton.Size = new Size(117, 34);
            CancelButton.TabIndex = 4;
            CancelButton.Text = "Cancel";
            CancelButton.TextAlign = ContentAlignment.MiddleRight;
            CancelButton.Tooltip1 = null;
            CancelButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_warning_100__2_;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 29);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(47, 9);
            label1.Name = "label1";
            label1.Size = new Size(79, 19);
            label1.TabIndex = 6;
            label1.Text = "Warning";
            label1.Click += label1_Click;
            // 
            // LabelMessage
            // 
            LabelMessage.AutoSize = true;
            LabelMessage.Font = new Font("SimSun", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelMessage.ForeColor = Color.Black;
            LabelMessage.Location = new Point(29, 168);
            LabelMessage.Name = "LabelMessage";
            LabelMessage.Size = new Size(379, 19);
            LabelMessage.TabIndex = 7;
            LabelMessage.Text = "Do you want to close the application?";
            // 
            // Warning_Message
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(428, 306);
            Controls.Add(LabelMessage);
            Controls.Add(CancelButton);
            Controls.Add(YesButton);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Warning_Message";
            Text = "Warning_Message";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private CustomButton YesButton;
        private CustomButton CancelButton;
        private PictureBox pictureBox1;
        private Label label1;
        private Label LabelMessage;
    }
}