namespace InventorySystemGalaxy
{
    partial class SplashScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            progressBarTick = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            progressBar = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // progressBarTick
            // 
            progressBarTick.Enabled = true;
            progressBarTick.Interval = 4;
            progressBarTick.Tick += progressBarTick_Tick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(progressBar);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(794, 594);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(29, 53);
            label2.Name = "label2";
            label2.Size = new Size(71, 13);
            label2.TabIndex = 6;
            label2.Text = "ⒸJJC 2023";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(121, 277);
            label1.Name = "label1";
            label1.Size = new Size(555, 64);
            label1.TabIndex = 5;
            label1.Text = "Inventory System";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(29, 69);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(735, 190);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // progressBar
            // 
            progressBar.BackColor = Color.FromArgb(59, 116, 192);
            progressBar.Location = new Point(5, 564);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(92, 25);
            progressBar.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(5, 564);
            panel2.Name = "panel2";
            panel2.Size = new Size(784, 25);
            panel2.TabIndex = 0;
            // 
            // SplashScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 600);
            Controls.Add(panel1);
            Font = new Font("SimSun", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "SplashScreen";
            Padding = new Padding(3);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer progressBarTick;
        private Panel panel1;
        private Panel progressBar;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Button button1;
        private Label label1;
        private Label label2;
    }
}