﻿
namespace RoboJarvis.Comp.Motion.Pages
{
    partial class SoftLimitPanel
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
            this.rtbLowerLimit = new RoboLib.GUI.Controls.RTextBox();
            this.rtbUpperLimit = new RoboLib.GUI.Controls.RTextBox();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbLowerLimit
            // 
            this.rtbLowerLimit.IsPasswordField = false;
            this.rtbLowerLimit.LabelText = "Lower Limit";
            this.rtbLowerLimit.LabelWidthPercent = -1;
            this.rtbLowerLimit.Location = new System.Drawing.Point(3, 3);
            this.rtbLowerLimit.Multiline = false;
            this.rtbLowerLimit.Name = "rtbLowerLimit";
            this.rtbLowerLimit.Size = new System.Drawing.Size(140, 21);
            this.rtbLowerLimit.TabIndex = 0;
            this.rtbLowerLimit.ValueText = "";
            // 
            // rtbUpperLimit
            // 
            this.rtbUpperLimit.IsPasswordField = false;
            this.rtbUpperLimit.LabelText = "Upper Limit";
            this.rtbUpperLimit.LabelWidthPercent = -1;
            this.rtbUpperLimit.Location = new System.Drawing.Point(150, 3);
            this.rtbUpperLimit.Multiline = false;
            this.rtbUpperLimit.Name = "rtbUpperLimit";
            this.rtbUpperLimit.Size = new System.Drawing.Size(140, 21);
            this.rtbUpperLimit.TabIndex = 1;
            this.rtbUpperLimit.ValueText = "";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.rtbLowerLimit);
            this.kryptonPanel1.Controls.Add(this.rtbUpperLimit);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(294, 25);
            this.kryptonPanel1.TabIndex = 2;
            // 
            // SoftLimitPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "SoftLimitPanel";
            this.Size = new System.Drawing.Size(294, 25);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RoboLib.GUI.Controls.RTextBox rtbLowerLimit;
        private RoboLib.GUI.Controls.RTextBox rtbUpperLimit;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
    }
}
