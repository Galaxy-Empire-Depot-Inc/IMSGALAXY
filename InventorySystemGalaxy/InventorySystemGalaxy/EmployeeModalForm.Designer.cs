namespace InventorySystemGalaxy
{
    partial class EmployeeModalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeModalForm));
            bgPanel = new Panel();
            SuspendLayout();
            // 
            // bgPanel
            // 
            bgPanel.BackColor = Color.FromArgb(59, 116, 192);
            bgPanel.Dock = DockStyle.Fill;
            bgPanel.Location = new Point(15, 15);
            bgPanel.Name = "bgPanel";
            bgPanel.Size = new Size(570, 570);
            bgPanel.TabIndex = 0;
            // 
            // EmployeeModalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(59, 116, 192);
            ClientSize = new Size(600, 600);
            Controls.Add(bgPanel);
            Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "EmployeeModalForm";
            Padding = new Padding(15);
            StartPosition = FormStartPosition.CenterParent;
            Text = "EmployeeModalForm";
            ResumeLayout(false);
        }

        #endregion

        private Panel bgPanel;
    }
}