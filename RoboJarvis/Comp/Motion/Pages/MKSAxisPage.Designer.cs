namespace RoboJarvis.Comp.Motion.Pages
{
    partial class MKSAxisPage
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
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kgbSettings = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.mksSettingsPanel1 = new RoboJarvis.Comp.Motion.Pages.MKSSettingsPanel();
            this.kgbSoftLimits = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.softLimitPanel1 = new RoboJarvis.Comp.Motion.Pages.SoftLimitPanel();
            this.kgbTestPositions = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kpTestPositions = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kgbJog = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.jogPanel1 = new RoboJarvis.Comp.Motion.Pages.JogPanel();
            this.motionHeaderPanel1 = new RoboJarvis.Comp.Motion.Pages.MotionHeaderPanel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kgbSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kgbSettings.Panel)).BeginInit();
            this.kgbSettings.Panel.SuspendLayout();
            this.kgbSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kgbSoftLimits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kgbSoftLimits.Panel)).BeginInit();
            this.kgbSoftLimits.Panel.SuspendLayout();
            this.kgbSoftLimits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kgbTestPositions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kgbTestPositions.Panel)).BeginInit();
            this.kgbTestPositions.Panel.SuspendLayout();
            this.kgbTestPositions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kpTestPositions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kgbJog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kgbJog.Panel)).BeginInit();
            this.kgbJog.Panel.SuspendLayout();
            this.kgbJog.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kgbSettings);
            this.kryptonPanel1.Controls.Add(this.kgbSoftLimits);
            this.kryptonPanel1.Controls.Add(this.kgbTestPositions);
            this.kryptonPanel1.Controls.Add(this.kgbJog);
            this.kryptonPanel1.Controls.Add(this.motionHeaderPanel1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderCalendar;
            this.kryptonPanel1.Size = new System.Drawing.Size(307, 410);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kgbSettings
            // 
            this.kgbSettings.Location = new System.Drawing.Point(0, 298);
            this.kgbSettings.Name = "kgbSettings";
            // 
            // kgbSettings.Panel
            // 
            this.kgbSettings.Panel.Controls.Add(this.mksSettingsPanel1);
            this.kgbSettings.Size = new System.Drawing.Size(307, 106);
            this.kgbSettings.TabIndex = 4;
            this.kgbSettings.Values.Heading = "Settings";
            // 
            // mksSettingsPanel1
            // 
            this.mksSettingsPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.mksSettingsPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mksSettingsPanel1.Location = new System.Drawing.Point(0, 0);
            this.mksSettingsPanel1.Name = "mksSettingsPanel1";
            this.mksSettingsPanel1.Size = new System.Drawing.Size(303, 82);
            this.mksSettingsPanel1.TabIndex = 0;
            // 
            // kgbSoftLimits
            // 
            this.kgbSoftLimits.Location = new System.Drawing.Point(0, 231);
            this.kgbSoftLimits.Name = "kgbSoftLimits";
            // 
            // kgbSoftLimits.Panel
            // 
            this.kgbSoftLimits.Panel.Controls.Add(this.softLimitPanel1);
            this.kgbSoftLimits.Size = new System.Drawing.Size(307, 67);
            this.kgbSoftLimits.TabIndex = 3;
            this.kgbSoftLimits.Values.Heading = "Soft Limits";
            // 
            // softLimitPanel1
            // 
            this.softLimitPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.softLimitPanel1.Location = new System.Drawing.Point(0, 0);
            this.softLimitPanel1.Name = "softLimitPanel1";
            this.softLimitPanel1.Size = new System.Drawing.Size(303, 43);
            this.softLimitPanel1.TabIndex = 0;
            // 
            // kgbTestPositions
            // 
            this.kgbTestPositions.Location = new System.Drawing.Point(0, 146);
            this.kgbTestPositions.Name = "kgbTestPositions";
            // 
            // kgbTestPositions.Panel
            // 
            this.kgbTestPositions.Panel.Controls.Add(this.kpTestPositions);
            this.kgbTestPositions.Size = new System.Drawing.Size(307, 85);
            this.kgbTestPositions.TabIndex = 2;
            this.kgbTestPositions.Values.Heading = "Test Positions";
            // 
            // kpTestPositions
            // 
            this.kpTestPositions.AccessibleRole = System.Windows.Forms.AccessibleRole.List;
            this.kpTestPositions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kpTestPositions.Location = new System.Drawing.Point(0, 0);
            this.kpTestPositions.Name = "kpTestPositions";
            this.kpTestPositions.Size = new System.Drawing.Size(303, 61);
            this.kpTestPositions.TabIndex = 0;
            // 
            // kgbJog
            // 
            this.kgbJog.Location = new System.Drawing.Point(0, 61);
            this.kgbJog.Name = "kgbJog";
            // 
            // kgbJog.Panel
            // 
            this.kgbJog.Panel.Controls.Add(this.jogPanel1);
            this.kgbJog.Size = new System.Drawing.Size(307, 85);
            this.kgbJog.TabIndex = 1;
            this.kgbJog.Values.Heading = "Jog";
            // 
            // jogPanel1
            // 
            this.jogPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jogPanel1.Location = new System.Drawing.Point(0, 0);
            this.jogPanel1.Name = "jogPanel1";
            this.jogPanel1.Size = new System.Drawing.Size(303, 61);
            this.jogPanel1.TabIndex = 4;
            // 
            // motionHeaderPanel1
            // 
            this.motionHeaderPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.motionHeaderPanel1.Location = new System.Drawing.Point(0, 0);
            this.motionHeaderPanel1.Name = "motionHeaderPanel1";
            this.motionHeaderPanel1.Size = new System.Drawing.Size(307, 61);
            this.motionHeaderPanel1.TabIndex = 0;
            // 
            // MKSAxisPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "MKSAxisPage";
            this.Size = new System.Drawing.Size(307, 410);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kgbSettings.Panel)).EndInit();
            this.kgbSettings.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kgbSettings)).EndInit();
            this.kgbSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kgbSoftLimits.Panel)).EndInit();
            this.kgbSoftLimits.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kgbSoftLimits)).EndInit();
            this.kgbSoftLimits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kgbTestPositions.Panel)).EndInit();
            this.kgbTestPositions.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kgbTestPositions)).EndInit();
            this.kgbTestPositions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kpTestPositions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kgbJog.Panel)).EndInit();
            this.kgbJog.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kgbJog)).EndInit();
            this.kgbJog.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kgbSoftLimits;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kgbTestPositions;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kpTestPositions;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kgbJog;
        private JogPanel jogPanel1;
        private MotionHeaderPanel motionHeaderPanel1;
        private SoftLimitPanel softLimitPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kgbSettings;
        private MKSSettingsPanel mksSettingsPanel1;
    }
}
