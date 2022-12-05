
namespace RoboJarvis.Comp.Motion.Pages
{
    partial class MKSSettingsPanel
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
            this.rcbUseGearBox = new RoboLib.GUI.Controls.RCheckBox();
            this.rtbGearRation = new RoboLib.GUI.Controls.RTextBox();
            this.rcbMicroStep = new RoboLib.GUI.Controls.RComboBox();
            this.rcbMotorCurrent = new RoboLib.GUI.Controls.RComboBox();
            this.rcbHoldCurrent = new RoboLib.GUI.Controls.RComboBox();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonGroup1 = new ComponentFactory.Krypton.Toolkit.KryptonGroup();
            this.kbtnCalibrate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnSetMotorCurrent = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnSetHoldCurrent = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnSetMicroStep = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).BeginInit();
            this.kryptonGroup1.Panel.SuspendLayout();
            this.kryptonGroup1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rcbUseGearBox
            // 
            this.rcbUseGearBox.LabelText = "Use GBox";
            this.rcbUseGearBox.Location = new System.Drawing.Point(3, 3);
            this.rcbUseGearBox.Name = "rcbUseGearBox";
            this.rcbUseGearBox.Size = new System.Drawing.Size(76, 21);
            this.rcbUseGearBox.TabIndex = 10;
            this.rcbUseGearBox.Value = false;
            // 
            // rtbGearRation
            // 
            this.rtbGearRation.IsPasswordField = false;
            this.rtbGearRation.LabelText = "Ratio";
            this.rtbGearRation.LabelWidthPercent = -1;
            this.rtbGearRation.Location = new System.Drawing.Point(3, 26);
            this.rtbGearRation.Multiline = false;
            this.rtbGearRation.Name = "rtbGearRation";
            this.rtbGearRation.Size = new System.Drawing.Size(76, 21);
            this.rtbGearRation.TabIndex = 9;
            this.rtbGearRation.ValueText = "";
            // 
            // rcbMicroStep
            // 
            this.rcbMicroStep.LabelText = "Micro Steps";
            this.rcbMicroStep.Location = new System.Drawing.Point(3, 3);
            this.rcbMicroStep.Name = "rcbMicroStep";
            this.rcbMicroStep.Size = new System.Drawing.Size(170, 21);
            this.rcbMicroStep.TabIndex = 2;
            this.rcbMicroStep.ValueText = "";
            // 
            // rcbMotorCurrent
            // 
            this.rcbMotorCurrent.LabelText = "Motor Current";
            this.rcbMotorCurrent.Location = new System.Drawing.Point(3, 57);
            this.rcbMotorCurrent.Name = "rcbMotorCurrent";
            this.rcbMotorCurrent.Size = new System.Drawing.Size(170, 21);
            this.rcbMotorCurrent.TabIndex = 1;
            this.rcbMotorCurrent.ValueText = "";
            // 
            // rcbHoldCurrent
            // 
            this.rcbHoldCurrent.LabelText = "Hold Current";
            this.rcbHoldCurrent.Location = new System.Drawing.Point(3, 30);
            this.rcbHoldCurrent.Name = "rcbHoldCurrent";
            this.rcbHoldCurrent.Size = new System.Drawing.Size(170, 21);
            this.rcbHoldCurrent.TabIndex = 0;
            this.rcbHoldCurrent.ValueText = "";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonGroup1);
            this.kryptonPanel1.Controls.Add(this.kbtnSetMotorCurrent);
            this.kryptonPanel1.Controls.Add(this.kbtnSetHoldCurrent);
            this.kryptonPanel1.Controls.Add(this.kbtnSetMicroStep);
            this.kryptonPanel1.Controls.Add(this.rcbMicroStep);
            this.kryptonPanel1.Controls.Add(this.rcbHoldCurrent);
            this.kryptonPanel1.Controls.Add(this.rcbMotorCurrent);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(303, 87);
            this.kryptonPanel1.TabIndex = 12;
            // 
            // kryptonGroup1
            // 
            this.kryptonGroup1.Location = new System.Drawing.Point(216, 4);
            this.kryptonGroup1.Name = "kryptonGroup1";
            // 
            // kryptonGroup1.Panel
            // 
            this.kryptonGroup1.Panel.Controls.Add(this.rcbUseGearBox);
            this.kryptonGroup1.Panel.Controls.Add(this.kbtnCalibrate);
            this.kryptonGroup1.Panel.Controls.Add(this.rtbGearRation);
            this.kryptonGroup1.Size = new System.Drawing.Size(84, 78);
            this.kryptonGroup1.TabIndex = 12;
            // 
            // kbtnCalibrate
            // 
            this.kbtnCalibrate.Location = new System.Drawing.Point(3, 49);
            this.kbtnCalibrate.Name = "kbtnCalibrate";
            this.kbtnCalibrate.Size = new System.Drawing.Size(76, 25);
            this.kbtnCalibrate.TabIndex = 11;
            this.kbtnCalibrate.Values.Text = "Calibrate";
            this.kbtnCalibrate.Click += new System.EventHandler(this.kbtnCalibrate_Click);
            // 
            // kbtnSetMotorCurrent
            // 
            this.kbtnSetMotorCurrent.Location = new System.Drawing.Point(176, 57);
            this.kbtnSetMotorCurrent.Name = "kbtnSetMotorCurrent";
            this.kbtnSetMotorCurrent.Size = new System.Drawing.Size(36, 25);
            this.kbtnSetMotorCurrent.TabIndex = 2;
            this.kbtnSetMotorCurrent.Values.Text = "Set";
            this.kbtnSetMotorCurrent.Click += new System.EventHandler(this.kbtnSetMotorCurrent_Click);
            // 
            // kbtnSetHoldCurrent
            // 
            this.kbtnSetHoldCurrent.Location = new System.Drawing.Point(176, 30);
            this.kbtnSetHoldCurrent.Name = "kbtnSetHoldCurrent";
            this.kbtnSetHoldCurrent.Size = new System.Drawing.Size(36, 25);
            this.kbtnSetHoldCurrent.TabIndex = 1;
            this.kbtnSetHoldCurrent.Values.Text = "Set";
            this.kbtnSetHoldCurrent.Click += new System.EventHandler(this.kbtnSetHoldCurrent_Click);
            // 
            // kbtnSetMicroStep
            // 
            this.kbtnSetMicroStep.Location = new System.Drawing.Point(176, 3);
            this.kbtnSetMicroStep.Name = "kbtnSetMicroStep";
            this.kbtnSetMicroStep.Size = new System.Drawing.Size(36, 25);
            this.kbtnSetMicroStep.TabIndex = 0;
            this.kbtnSetMicroStep.Values.Text = "Set";
            this.kbtnSetMicroStep.Click += new System.EventHandler(this.kbtnSetMicroStep_Click);
            // 
            // MKSSettingsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "MKSSettingsPanel";
            this.Size = new System.Drawing.Size(303, 87);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).EndInit();
            this.kryptonGroup1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).EndInit();
            this.kryptonGroup1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RoboLib.GUI.Controls.RComboBox rcbHoldCurrent;
        private RoboLib.GUI.Controls.RComboBox rcbMotorCurrent;
        private RoboLib.GUI.Controls.RComboBox rcbMicroStep;
        private RoboLib.GUI.Controls.RTextBox rtbGearRation;
        private RoboLib.GUI.Controls.RCheckBox rcbUseGearBox;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonGroup kryptonGroup1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnCalibrate;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnSetMotorCurrent;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnSetHoldCurrent;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnSetMicroStep;
    }
}
