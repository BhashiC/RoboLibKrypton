
namespace RoboLib.Models.Communication.Pages
{
    partial class RS232SettingsPanel
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
            this.rtbTimeout = new RoboLib.GUI.Controls.RTextBox();
            this.rtbDataBits = new RoboLib.GUI.Controls.RTextBox();
            this.rcbBaudRate = new RoboLib.GUI.Controls.RComboBox();
            this.rcbComPort = new RoboLib.GUI.Controls.RComboBox();
            this.rcbHandShake = new RoboLib.GUI.Controls.RComboBox();
            this.rcbNewLine = new RoboLib.GUI.Controls.RComboBox();
            this.rcbStopBits = new RoboLib.GUI.Controls.RComboBox();
            this.rcbParity = new RoboLib.GUI.Controls.RComboBox();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbTimeout
            // 
            this.rtbTimeout.IsPasswordField = false;
            this.rtbTimeout.LabelText = "Timeout";
            this.rtbTimeout.LabelWidthPercent = -1;
            this.rtbTimeout.Location = new System.Drawing.Point(3, 192);
            this.rtbTimeout.Multiline = false;
            this.rtbTimeout.Name = "rtbTimeout";
            this.rtbTimeout.Size = new System.Drawing.Size(223, 21);
            this.rtbTimeout.TabIndex = 10;
            this.rtbTimeout.ValueText = "";
            // 
            // rtbDataBits
            // 
            this.rtbDataBits.IsPasswordField = false;
            this.rtbDataBits.LabelText = "Data Bits";
            this.rtbDataBits.LabelWidthPercent = -1;
            this.rtbDataBits.Location = new System.Drawing.Point(3, 57);
            this.rtbDataBits.Multiline = false;
            this.rtbDataBits.Name = "rtbDataBits";
            this.rtbDataBits.Size = new System.Drawing.Size(223, 21);
            this.rtbDataBits.TabIndex = 9;
            this.rtbDataBits.ValueText = "";
            // 
            // rcbBaudRate
            // 
            this.rcbBaudRate.LabelText = "Baud Rate";
            this.rcbBaudRate.Location = new System.Drawing.Point(3, 30);
            this.rcbBaudRate.Name = "rcbBaudRate";
            this.rcbBaudRate.Size = new System.Drawing.Size(223, 21);
            this.rcbBaudRate.TabIndex = 2;
            this.rcbBaudRate.ValueText = "";
            // 
            // rcbComPort
            // 
            this.rcbComPort.LabelText = "COM Port";
            this.rcbComPort.Location = new System.Drawing.Point(3, 3);
            this.rcbComPort.Name = "rcbComPort";
            this.rcbComPort.Size = new System.Drawing.Size(223, 21);
            this.rcbComPort.TabIndex = 3;
            this.rcbComPort.ValueText = "";
            // 
            // rcbHandShake
            // 
            this.rcbHandShake.LabelText = "Hand Shake";
            this.rcbHandShake.Location = new System.Drawing.Point(3, 84);
            this.rcbHandShake.Name = "rcbHandShake";
            this.rcbHandShake.Size = new System.Drawing.Size(223, 21);
            this.rcbHandShake.TabIndex = 4;
            this.rcbHandShake.ValueText = "";
            // 
            // rcbNewLine
            // 
            this.rcbNewLine.LabelText = "New Line";
            this.rcbNewLine.Location = new System.Drawing.Point(3, 111);
            this.rcbNewLine.Name = "rcbNewLine";
            this.rcbNewLine.Size = new System.Drawing.Size(223, 21);
            this.rcbNewLine.TabIndex = 6;
            this.rcbNewLine.ValueText = "";
            // 
            // rcbStopBits
            // 
            this.rcbStopBits.LabelText = "Stop Bits";
            this.rcbStopBits.Location = new System.Drawing.Point(3, 165);
            this.rcbStopBits.Name = "rcbStopBits";
            this.rcbStopBits.Size = new System.Drawing.Size(223, 21);
            this.rcbStopBits.TabIndex = 8;
            this.rcbStopBits.ValueText = "";
            // 
            // rcbParity
            // 
            this.rcbParity.LabelText = "Parity";
            this.rcbParity.Location = new System.Drawing.Point(3, 138);
            this.rcbParity.Name = "rcbParity";
            this.rcbParity.Size = new System.Drawing.Size(223, 21);
            this.rcbParity.TabIndex = 7;
            this.rcbParity.ValueText = "";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonGroupBox1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(238, 242);
            this.kryptonPanel1.TabIndex = 11;
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.rtbTimeout);
            this.kryptonGroupBox1.Panel.Controls.Add(this.rcbComPort);
            this.kryptonGroupBox1.Panel.Controls.Add(this.rtbDataBits);
            this.kryptonGroupBox1.Panel.Controls.Add(this.rcbParity);
            this.kryptonGroupBox1.Panel.Controls.Add(this.rcbBaudRate);
            this.kryptonGroupBox1.Panel.Controls.Add(this.rcbStopBits);
            this.kryptonGroupBox1.Panel.Controls.Add(this.rcbNewLine);
            this.kryptonGroupBox1.Panel.Controls.Add(this.rcbHandShake);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(238, 242);
            this.kryptonGroupBox1.TabIndex = 0;
            this.kryptonGroupBox1.Values.Heading = "Settings";
            // 
            // RS232SettingsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "RS232SettingsPanel";
            this.Size = new System.Drawing.Size(238, 242);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private GUI.Controls.RComboBox rcbBaudRate;
        private GUI.Controls.RComboBox rcbComPort;
        private GUI.Controls.RComboBox rcbHandShake;
        private GUI.Controls.RComboBox rcbNewLine;
        private GUI.Controls.RComboBox rcbStopBits;
        private GUI.Controls.RComboBox rcbParity;
        private GUI.Controls.RTextBox rtbTimeout;
        private GUI.Controls.RTextBox rtbDataBits;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
    }
}
