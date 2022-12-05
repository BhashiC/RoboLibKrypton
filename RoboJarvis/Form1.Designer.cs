namespace RoboJarvis
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSettings = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonJoints = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBoxTheme = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonFixToFrame = new System.Windows.Forms.ToolStripButton();
            this.robotTrackBarPanel1 = new RoboJarvis.Pages.RobotTrackBarPanel();
            this.pathPlanPage1 = new RoboJarvis.Comp.PathPlan.Pages.PathPlanPage();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.BasePaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleOrange;
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.SparkleOrange;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.elementHost1);
            this.kryptonPanel1.Controls.Add(this.panel1);
            this.kryptonPanel1.Controls.Add(this.robotTrackBarPanel1);
            this.kryptonPanel1.Controls.Add(this.pathPlanPage1);
            this.kryptonPanel1.Controls.Add(this.toolStrip1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1579, 937);
            this.kryptonPanel1.TabIndex = 13;
            // 
            // elementHost1
            // 
            this.elementHost1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost1.Location = new System.Drawing.Point(444, 43);
            this.elementHost1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(606, 894);
            this.elementHost1.TabIndex = 20;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = null;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::RoboJarvis.Properties.Resources.Logo;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(83, 558);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 201);
            this.panel1.TabIndex = 19;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSettings,
            this.toolStripButtonJoints,
            this.toolStripComboBoxTheme,
            this.toolStripSeparator1,
            this.toolStripButtonFixToFrame});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStrip1.Size = new System.Drawing.Size(1579, 43);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonSettings
            // 
            this.toolStripButtonSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSettings.Image = global::RoboJarvis.Properties.Resources.Settings;
            this.toolStripButtonSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSettings.Name = "toolStripButtonSettings";
            this.toolStripButtonSettings.Size = new System.Drawing.Size(40, 40);
            this.toolStripButtonSettings.Text = "Settings";
            this.toolStripButtonSettings.Click += new System.EventHandler(this.toolStripButtonSettings_Click);
            // 
            // toolStripButtonJoints
            // 
            this.toolStripButtonJoints.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonJoints.Image = global::RoboJarvis.Properties.Resources.ControlPanel;
            this.toolStripButtonJoints.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonJoints.Name = "toolStripButtonJoints";
            this.toolStripButtonJoints.Size = new System.Drawing.Size(40, 40);
            this.toolStripButtonJoints.Text = "Joints";
            this.toolStripButtonJoints.Click += new System.EventHandler(this.toolStripButtonJoints_Click);
            // 
            // toolStripComboBoxTheme
            // 
            this.toolStripComboBoxTheme.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripComboBoxTheme.Name = "toolStripComboBoxTheme";
            this.toolStripComboBoxTheme.Size = new System.Drawing.Size(160, 43);
            this.toolStripComboBoxTheme.Text = "Theme";
            this.toolStripComboBoxTheme.ToolTipText = "Theme";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 43);
            // 
            // toolStripButtonFixToFrame
            // 
            this.toolStripButtonFixToFrame.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonFixToFrame.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFixToFrame.Image = global::RoboJarvis.Properties.Resources.Camera;
            this.toolStripButtonFixToFrame.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFixToFrame.Name = "toolStripButtonFixToFrame";
            this.toolStripButtonFixToFrame.Size = new System.Drawing.Size(40, 40);
            this.toolStripButtonFixToFrame.Text = "FixToFrame";
            this.toolStripButtonFixToFrame.Click += new System.EventHandler(this.toolStripButtonFixToFrame_Click);
            // 
            // robotTrackBarPanel1
            // 
            this.robotTrackBarPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.robotTrackBarPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.robotTrackBarPanel1.Location = new System.Drawing.Point(0, 43);
            this.robotTrackBarPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.robotTrackBarPanel1.Name = "robotTrackBarPanel1";
            this.robotTrackBarPanel1.Size = new System.Drawing.Size(444, 894);
            this.robotTrackBarPanel1.TabIndex = 18;
            // 
            // pathPlanPage1
            // 
            this.pathPlanPage1.BackColor = System.Drawing.SystemColors.Control;
            this.pathPlanPage1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pathPlanPage1.Location = new System.Drawing.Point(1050, 43);
            this.pathPlanPage1.Margin = new System.Windows.Forms.Padding(5);
            this.pathPlanPage1.Name = "pathPlanPage1";
            this.pathPlanPage1.Size = new System.Drawing.Size(529, 894);
            this.pathPlanPage1.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1579, 937);
            this.Controls.Add(this.kryptonPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleOrange;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonSettings;
        private System.Windows.Forms.ToolStripButton toolStripButtonJoints;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxTheme;
        private Comp.PathPlan.Pages.PathPlanPage pathPlanPage1;
        private Pages.RobotTrackBarPanel robotTrackBarPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private System.Windows.Forms.ToolStripButton toolStripButtonFixToFrame;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

