﻿namespace InventorySystemGalaxy
{
    partial class CustomButton
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
            SuspendLayout();
            // 
            // CustomButton
            // 
            Font = new Font("SimSun", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Enter += CustomButton_Enter;
            Leave += CustomButton_Leave;
            MouseLeave += CustomButton_MouseLeave;
            MouseHover += CustomButton_MouseHover;
            ResumeLayout(false);
        }

        #endregion
    }
}
