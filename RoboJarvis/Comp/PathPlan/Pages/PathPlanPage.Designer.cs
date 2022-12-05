namespace RoboJarvis.Comp.PathPlan.Pages
{
    partial class PathPlanPage
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
            this.kgbPathPatterns = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kbtnRemovePattern = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.rtbCreateNewPattern = new RoboLib.GUI.Controls.RTextBox();
            this.rcbCurrentPathPatern = new RoboLib.GUI.Controls.RComboBox();
            this.kbtnLoadPattern = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnCreatePattern = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kgbPathPoints = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.rcbRoundAngles = new RoboLib.GUI.Controls.RCheckBox();
            this.kryptonGroup1 = new ComponentFactory.Krypton.Toolkit.KryptonGroup();
            this.kbtnRun = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.rcbSimulating = new RoboLib.GUI.Controls.RCheckBox();
            this.kbtnInvKinSimStart = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnStop = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnHome = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kdgvPathPoints = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.ktbRemovePointAt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.rtbWorkingPatern = new RoboLib.GUI.Controls.RTextBox();
            this.rtbWorkingPointNo = new RoboLib.GUI.Controls.RTextBox();
            this.ktbCopyToPointAt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kbtnAddPoint = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ktbAddPointAt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kbtnDeletePoint = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnCopyAngles = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label1 = new System.Windows.Forms.Label();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.kgbPathPatterns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kgbPathPatterns.Panel)).BeginInit();
            this.kgbPathPatterns.Panel.SuspendLayout();
            this.kgbPathPatterns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kgbPathPoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kgbPathPoints.Panel)).BeginInit();
            this.kgbPathPoints.Panel.SuspendLayout();
            this.kgbPathPoints.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).BeginInit();
            this.kryptonGroup1.Panel.SuspendLayout();
            this.kryptonGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kdgvPathPoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kgbPathPatterns
            // 
            this.kgbPathPatterns.Location = new System.Drawing.Point(4, 4);
            this.kgbPathPatterns.Name = "kgbPathPatterns";
            // 
            // kgbPathPatterns.Panel
            // 
            this.kgbPathPatterns.Panel.Controls.Add(this.kbtnRemovePattern);
            this.kgbPathPatterns.Panel.Controls.Add(this.rtbCreateNewPattern);
            this.kgbPathPatterns.Panel.Controls.Add(this.rcbCurrentPathPatern);
            this.kgbPathPatterns.Panel.Controls.Add(this.kbtnLoadPattern);
            this.kgbPathPatterns.Panel.Controls.Add(this.kbtnCreatePattern);
            this.kgbPathPatterns.Size = new System.Drawing.Size(393, 127);
            this.kgbPathPatterns.TabIndex = 0;
            this.kgbPathPatterns.Values.Heading = "Path Patterns";
            // 
            // kbtnRemovePattern
            // 
            this.kbtnRemovePattern.Location = new System.Drawing.Point(296, 64);
            this.kbtnRemovePattern.Name = "kbtnRemovePattern";
            this.kbtnRemovePattern.Size = new System.Drawing.Size(90, 25);
            this.kbtnRemovePattern.TabIndex = 12;
            this.kbtnRemovePattern.Values.Text = "Delete Pattern";
            this.kbtnRemovePattern.Click += new System.EventHandler(this.kbtnRemovePattern_Click);
            // 
            // rtbCreateNewPattern
            // 
            this.rtbCreateNewPattern.BackColor = System.Drawing.SystemColors.Control;
            this.rtbCreateNewPattern.IsPasswordField = false;
            this.rtbCreateNewPattern.LabelText = "Create New Pattern";
            this.rtbCreateNewPattern.LabelWidthPercent = -1;
            this.rtbCreateNewPattern.Location = new System.Drawing.Point(4, 4);
            this.rtbCreateNewPattern.Margin = new System.Windows.Forms.Padding(4);
            this.rtbCreateNewPattern.Multiline = false;
            this.rtbCreateNewPattern.Name = "rtbCreateNewPattern";
            this.rtbCreateNewPattern.Size = new System.Drawing.Size(285, 21);
            this.rtbCreateNewPattern.TabIndex = 9;
            this.rtbCreateNewPattern.ValueText = "";
            // 
            // rcbCurrentPathPatern
            // 
            this.rcbCurrentPathPatern.BackColor = System.Drawing.SystemColors.Control;
            this.rcbCurrentPathPatern.LabelText = "Current Path Pattern";
            this.rcbCurrentPathPatern.Location = new System.Drawing.Point(4, 33);
            this.rcbCurrentPathPatern.Margin = new System.Windows.Forms.Padding(4);
            this.rcbCurrentPathPatern.Name = "rcbCurrentPathPatern";
            this.rcbCurrentPathPatern.Size = new System.Drawing.Size(285, 21);
            this.rcbCurrentPathPatern.TabIndex = 0;
            this.rcbCurrentPathPatern.ValueText = "";
            // 
            // kbtnLoadPattern
            // 
            this.kbtnLoadPattern.Location = new System.Drawing.Point(296, 33);
            this.kbtnLoadPattern.Name = "kbtnLoadPattern";
            this.kbtnLoadPattern.Size = new System.Drawing.Size(90, 25);
            this.kbtnLoadPattern.TabIndex = 11;
            this.kbtnLoadPattern.Values.Text = "Load Pattern";
            this.kbtnLoadPattern.Click += new System.EventHandler(this.kbtnLoadPattern_Click);
            // 
            // kbtnCreatePattern
            // 
            this.kbtnCreatePattern.Location = new System.Drawing.Point(296, 4);
            this.kbtnCreatePattern.Name = "kbtnCreatePattern";
            this.kbtnCreatePattern.Size = new System.Drawing.Size(90, 25);
            this.kbtnCreatePattern.TabIndex = 10;
            this.kbtnCreatePattern.Values.Text = "Create Pattern";
            this.kbtnCreatePattern.Click += new System.EventHandler(this.kbtnCreatePattern_Click);
            // 
            // kgbPathPoints
            // 
            this.kgbPathPoints.Location = new System.Drawing.Point(4, 137);
            this.kgbPathPoints.Name = "kgbPathPoints";
            // 
            // kgbPathPoints.Panel
            // 
            this.kgbPathPoints.Panel.Controls.Add(this.rcbRoundAngles);
            this.kgbPathPoints.Panel.Controls.Add(this.kryptonGroup1);
            this.kgbPathPoints.Panel.Controls.Add(this.kdgvPathPoints);
            this.kgbPathPoints.Panel.Controls.Add(this.ktbRemovePointAt);
            this.kgbPathPoints.Panel.Controls.Add(this.rtbWorkingPatern);
            this.kgbPathPoints.Panel.Controls.Add(this.rtbWorkingPointNo);
            this.kgbPathPoints.Panel.Controls.Add(this.ktbCopyToPointAt);
            this.kgbPathPoints.Panel.Controls.Add(this.kbtnAddPoint);
            this.kgbPathPoints.Panel.Controls.Add(this.ktbAddPointAt);
            this.kgbPathPoints.Panel.Controls.Add(this.kbtnDeletePoint);
            this.kgbPathPoints.Panel.Controls.Add(this.kbtnCopyAngles);
            this.kgbPathPoints.Panel.Controls.Add(this.label1);
            this.kgbPathPoints.Size = new System.Drawing.Size(393, 380);
            this.kgbPathPoints.TabIndex = 1;
            this.kgbPathPoints.Values.Heading = "Path Pattern Points";
            // 
            // rcbRoundAngles
            // 
            this.rcbRoundAngles.LabelText = "Round and copy";
            this.rcbRoundAngles.Location = new System.Drawing.Point(7, 329);
            this.rcbRoundAngles.Name = "rcbRoundAngles";
            this.rcbRoundAngles.Size = new System.Drawing.Size(126, 22);
            this.rcbRoundAngles.TabIndex = 35;
            this.rcbRoundAngles.Value = false;
            // 
            // kryptonGroup1
            // 
            this.kryptonGroup1.Location = new System.Drawing.Point(186, 238);
            this.kryptonGroup1.Name = "kryptonGroup1";
            // 
            // kryptonGroup1.Panel
            // 
            this.kryptonGroup1.Panel.Controls.Add(this.kbtnRun);
            this.kryptonGroup1.Panel.Controls.Add(this.rcbSimulating);
            this.kryptonGroup1.Panel.Controls.Add(this.kbtnInvKinSimStart);
            this.kryptonGroup1.Panel.Controls.Add(this.kbtnStop);
            this.kryptonGroup1.Panel.Controls.Add(this.kbtnHome);
            this.kryptonGroup1.Size = new System.Drawing.Size(130, 87);
            this.kryptonGroup1.TabIndex = 33;
            // 
            // kbtnRun
            // 
            this.kbtnRun.Location = new System.Drawing.Point(3, 3);
            this.kbtnRun.Name = "kbtnRun";
            this.kbtnRun.Size = new System.Drawing.Size(36, 36);
            this.kbtnRun.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Webdings", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.kbtnRun.StateCommon.Content.ShortText.MultiLineH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kbtnRun.TabIndex = 9;
            this.kbtnRun.Values.Text = "4";
            this.kbtnRun.Click += new System.EventHandler(this.kbtnRun_Click);
            // 
            // rcbSimulating
            // 
            this.rcbSimulating.LabelText = "Running";
            this.rcbSimulating.Location = new System.Drawing.Point(44, 59);
            this.rcbSimulating.Name = "rcbSimulating";
            this.rcbSimulating.Size = new System.Drawing.Size(79, 22);
            this.rcbSimulating.TabIndex = 32;
            this.rcbSimulating.Value = false;
            // 
            // kbtnInvKinSimStart
            // 
            this.kbtnInvKinSimStart.Location = new System.Drawing.Point(3, 45);
            this.kbtnInvKinSimStart.Name = "kbtnInvKinSimStart";
            this.kbtnInvKinSimStart.Size = new System.Drawing.Size(36, 36);
            this.kbtnInvKinSimStart.TabIndex = 12;
            this.kbtnInvKinSimStart.Values.Text = "Inv\r\n";
            this.kbtnInvKinSimStart.Click += new System.EventHandler(this.kbtnInvKinSimStart_Click);
            // 
            // kbtnStop
            // 
            this.kbtnStop.Location = new System.Drawing.Point(45, 3);
            this.kbtnStop.Name = "kbtnStop";
            this.kbtnStop.Size = new System.Drawing.Size(36, 36);
            this.kbtnStop.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Webdings", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.kbtnStop.StateCommon.Content.ShortText.MultiLineH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kbtnStop.TabIndex = 10;
            this.kbtnStop.Values.Text = "<";
            this.kbtnStop.Click += new System.EventHandler(this.kbtnStop_Click);
            // 
            // kbtnHome
            // 
            this.kbtnHome.Location = new System.Drawing.Point(87, 3);
            this.kbtnHome.Name = "kbtnHome";
            this.kbtnHome.Size = new System.Drawing.Size(36, 36);
            this.kbtnHome.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Webdings", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.kbtnHome.StateCommon.Content.ShortText.MultiLineH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kbtnHome.TabIndex = 11;
            this.kbtnHome.Values.Text = "H";
            this.kbtnHome.Click += new System.EventHandler(this.kbtnHome_Click);
            // 
            // kdgvPathPoints
            // 
            this.kdgvPathPoints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kdgvPathPoints.Location = new System.Drawing.Point(7, 32);
            this.kdgvPathPoints.Name = "kdgvPathPoints";
            this.kdgvPathPoints.Size = new System.Drawing.Size(379, 161);
            this.kdgvPathPoints.TabIndex = 2;
            // 
            // ktbRemovePointAt
            // 
            this.ktbRemovePointAt.Location = new System.Drawing.Point(137, 300);
            this.ktbRemovePointAt.Name = "ktbRemovePointAt";
            this.ktbRemovePointAt.Size = new System.Drawing.Size(43, 23);
            this.ktbRemovePointAt.TabIndex = 31;
            this.ktbRemovePointAt.TextChanged += new System.EventHandler(this.ktbRemovePointAt_TextChanged);
            // 
            // rtbWorkingPatern
            // 
            this.rtbWorkingPatern.BackColor = System.Drawing.SystemColors.Control;
            this.rtbWorkingPatern.IsPasswordField = false;
            this.rtbWorkingPatern.LabelText = "Working Pattern Name";
            this.rtbWorkingPatern.LabelWidthPercent = -1;
            this.rtbWorkingPatern.Location = new System.Drawing.Point(4, 4);
            this.rtbWorkingPatern.Margin = new System.Windows.Forms.Padding(4);
            this.rtbWorkingPatern.Multiline = false;
            this.rtbWorkingPatern.Name = "rtbWorkingPatern";
            this.rtbWorkingPatern.Size = new System.Drawing.Size(285, 21);
            this.rtbWorkingPatern.TabIndex = 7;
            this.rtbWorkingPatern.ValueText = "";
            // 
            // rtbWorkingPointNo
            // 
            this.rtbWorkingPointNo.BackColor = System.Drawing.SystemColors.Control;
            this.rtbWorkingPointNo.IsPasswordField = false;
            this.rtbWorkingPointNo.LabelText = "No";
            this.rtbWorkingPointNo.LabelWidthPercent = -1;
            this.rtbWorkingPointNo.Location = new System.Drawing.Point(298, 4);
            this.rtbWorkingPointNo.Margin = new System.Windows.Forms.Padding(4);
            this.rtbWorkingPointNo.Multiline = false;
            this.rtbWorkingPointNo.Name = "rtbWorkingPointNo";
            this.rtbWorkingPointNo.Size = new System.Drawing.Size(87, 21);
            this.rtbWorkingPointNo.TabIndex = 23;
            this.rtbWorkingPointNo.ValueText = "";
            // 
            // ktbCopyToPointAt
            // 
            this.ktbCopyToPointAt.Location = new System.Drawing.Point(137, 269);
            this.ktbCopyToPointAt.Name = "ktbCopyToPointAt";
            this.ktbCopyToPointAt.Size = new System.Drawing.Size(43, 23);
            this.ktbCopyToPointAt.TabIndex = 30;
            this.ktbCopyToPointAt.TextChanged += new System.EventHandler(this.ktbCopyToPointAt_TextChanged);
            // 
            // kbtnAddPoint
            // 
            this.kbtnAddPoint.Location = new System.Drawing.Point(7, 238);
            this.kbtnAddPoint.Name = "kbtnAddPoint";
            this.kbtnAddPoint.Size = new System.Drawing.Size(124, 25);
            this.kbtnAddPoint.TabIndex = 27;
            this.kbtnAddPoint.Values.Text = "Add New Point to";
            this.kbtnAddPoint.Click += new System.EventHandler(this.kbtnAddPoint_Click);
            // 
            // ktbAddPointAt
            // 
            this.ktbAddPointAt.Location = new System.Drawing.Point(137, 238);
            this.ktbAddPointAt.Name = "ktbAddPointAt";
            this.ktbAddPointAt.Size = new System.Drawing.Size(43, 23);
            this.ktbAddPointAt.TabIndex = 9;
            this.ktbAddPointAt.TextChanged += new System.EventHandler(this.ktbAddPointAt_TextChanged);
            // 
            // kbtnDeletePoint
            // 
            this.kbtnDeletePoint.Location = new System.Drawing.Point(7, 300);
            this.kbtnDeletePoint.Name = "kbtnDeletePoint";
            this.kbtnDeletePoint.Size = new System.Drawing.Size(123, 25);
            this.kbtnDeletePoint.TabIndex = 29;
            this.kbtnDeletePoint.Values.Text = "Delete Point No";
            this.kbtnDeletePoint.Click += new System.EventHandler(this.kbtnDeletePoint_Click);
            // 
            // kbtnCopyAngles
            // 
            this.kbtnCopyAngles.Location = new System.Drawing.Point(7, 269);
            this.kbtnCopyAngles.Name = "kbtnCopyAngles";
            this.kbtnCopyAngles.Size = new System.Drawing.Size(124, 25);
            this.kbtnCopyAngles.TabIndex = 28;
            this.kbtnCopyAngles.Values.Text = "Copy Joint Angles to";
            this.kbtnCopyAngles.Click += new System.EventHandler(this.kbtnCopyAngles_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 220);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Point No";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kgbPathPoints);
            this.kryptonPanel1.Controls.Add(this.kgbPathPatterns);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(400, 521);
            this.kryptonPanel1.TabIndex = 8;
            // 
            // PathPlanPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "PathPlanPage";
            this.Size = new System.Drawing.Size(400, 521);
            ((System.ComponentModel.ISupportInitialize)(this.kgbPathPatterns.Panel)).EndInit();
            this.kgbPathPatterns.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kgbPathPatterns)).EndInit();
            this.kgbPathPatterns.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kgbPathPoints.Panel)).EndInit();
            this.kgbPathPoints.Panel.ResumeLayout(false);
            this.kgbPathPoints.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kgbPathPoints)).EndInit();
            this.kgbPathPoints.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).EndInit();
            this.kryptonGroup1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).EndInit();
            this.kryptonGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kdgvPathPoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kgbPathPatterns;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnRemovePattern;
        private RoboLib.GUI.Controls.RTextBox rtbCreateNewPattern;
        private RoboLib.GUI.Controls.RComboBox rcbCurrentPathPatern;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnLoadPattern;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnCreatePattern;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kgbPathPoints;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kdgvPathPoints;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ktbRemovePointAt;
        private RoboLib.GUI.Controls.RTextBox rtbWorkingPatern;
        private RoboLib.GUI.Controls.RTextBox rtbWorkingPointNo;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ktbCopyToPointAt;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnAddPoint;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnHome;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ktbAddPointAt;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnStop;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnDeletePoint;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnInvKinSimStart;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnRun;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnCopyAngles;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private RoboLib.GUI.Controls.RCheckBox rcbSimulating;
        private ComponentFactory.Krypton.Toolkit.KryptonGroup kryptonGroup1;
        private RoboLib.GUI.Controls.RCheckBox rcbRoundAngles;
    }
}
