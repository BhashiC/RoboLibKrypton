
namespace RoboJarvis.Comp.Motion.Pages
{
    partial class MotionHeaderPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rcbEnabled = new RoboLib.GUI.Controls.RCheckBox();
            this.rtbCurrentPosition = new RoboLib.GUI.Controls.RTextBox();
            this.kbtnHome = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnEnable = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.khName = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rcbEnabled
            // 
            this.rcbEnabled.LabelText = "Enabled";
            this.rcbEnabled.Location = new System.Drawing.Point(153, 4);
            this.rcbEnabled.Name = "rcbEnabled";
            this.rcbEnabled.Size = new System.Drawing.Size(73, 24);
            this.rcbEnabled.TabIndex = 4;
            this.rcbEnabled.Value = false;
            // 
            // rtbCurrentPosition
            // 
            this.rtbCurrentPosition.BackColor = System.Drawing.Color.Lime;
            this.rtbCurrentPosition.IsPasswordField = false;
            this.rtbCurrentPosition.LabelText = "Current Position";
            this.rtbCurrentPosition.LabelWidthPercent = -1;
            this.rtbCurrentPosition.Location = new System.Drawing.Point(0, 35);
            this.rtbCurrentPosition.Margin = new System.Windows.Forms.Padding(4);
            this.rtbCurrentPosition.Multiline = false;
            this.rtbCurrentPosition.Name = "rtbCurrentPosition";
            this.rtbCurrentPosition.Size = new System.Drawing.Size(225, 21);
            this.rtbCurrentPosition.TabIndex = 6;
            this.rtbCurrentPosition.ValueText = "";
            // 
            // kbtnHome
            // 
            this.kbtnHome.Location = new System.Drawing.Point(232, 36);
            this.kbtnHome.Name = "kbtnHome";
            this.kbtnHome.Size = new System.Drawing.Size(66, 25);
            this.kbtnHome.TabIndex = 7;
            this.kbtnHome.Values.Text = "Home";
            this.kbtnHome.Click += new System.EventHandler(this.kbtnHome_Click);
            // 
            // kbtnEnable
            // 
            this.kbtnEnable.Location = new System.Drawing.Point(232, 4);
            this.kbtnEnable.Name = "kbtnEnable";
            this.kbtnEnable.Size = new System.Drawing.Size(66, 25);
            this.kbtnEnable.TabIndex = 8;
            this.kbtnEnable.Values.Text = "Enable";
            this.kbtnEnable.Click += new System.EventHandler(this.kbtnEnable_Click);
            // 
            // khName
            // 
            this.khName.Location = new System.Drawing.Point(0, 0);
            this.khName.Name = "khName";
            this.khName.Size = new System.Drawing.Size(107, 33);
            this.khName.TabIndex = 10;
            this.khName.Values.Description = "";
            this.khName.Values.Heading = "Axis Name   ";
            this.khName.Values.Image = null;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.khName);
            this.kryptonPanel1.Controls.Add(this.kbtnHome);
            this.kryptonPanel1.Controls.Add(this.rcbEnabled);
            this.kryptonPanel1.Controls.Add(this.rtbCurrentPosition);
            this.kryptonPanel1.Controls.Add(this.kbtnEnable);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(303, 61);
            this.kryptonPanel1.TabIndex = 11;
            // 
            // MotionHeaderPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "MotionHeaderPanel";
            this.Size = new System.Drawing.Size(303, 61);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private RoboLib.GUI.Controls.RTextBox rtbCurrentPosition;
        private RoboLib.GUI.Controls.RCheckBox rcbEnabled;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnHome;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnEnable;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader khName;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
    }
}
