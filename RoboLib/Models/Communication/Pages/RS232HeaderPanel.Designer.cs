
namespace RoboLib.Models.Communication.Pages
{
    partial class RS232HeaderPanel
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
            this.rtbResponse = new RoboLib.GUI.Controls.RTextBox();
            this.rcbCommand = new RoboLib.GUI.Controls.RComboBox();
            this.rcbConnected = new RoboLib.GUI.Controls.RCheckBox();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtnConnect = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnSend = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnHelp = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.khName = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.kryptonGroup1 = new ComponentFactory.Krypton.Toolkit.KryptonGroup();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).BeginInit();
            this.kryptonGroup1.Panel.SuspendLayout();
            this.kryptonGroup1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbResponse
            // 
            this.rtbResponse.AutoScroll = true;
            this.rtbResponse.BackColor = System.Drawing.Color.Lime;
            this.rtbResponse.IsPasswordField = false;
            this.rtbResponse.LabelText = "Response";
            this.rtbResponse.LabelWidthPercent = -1;
            this.rtbResponse.Location = new System.Drawing.Point(3, 96);
            this.rtbResponse.Multiline = true;
            this.rtbResponse.Name = "rtbResponse";
            this.rtbResponse.Size = new System.Drawing.Size(231, 36);
            this.rtbResponse.TabIndex = 20;
            this.rtbResponse.ValueText = "";
            // 
            // rcbCommand
            // 
            this.rcbCommand.LabelText = "Comand";
            this.rcbCommand.Location = new System.Drawing.Point(3, 69);
            this.rcbCommand.Name = "rcbCommand";
            this.rcbCommand.Size = new System.Drawing.Size(231, 21);
            this.rcbCommand.TabIndex = 23;
            this.rcbCommand.ValueText = "";
            // 
            // rcbConnected
            // 
            this.rcbConnected.LabelText = "Connected";
            this.rcbConnected.Location = new System.Drawing.Point(3, 3);
            this.rcbConnected.Name = "rcbConnected";
            this.rcbConnected.Size = new System.Drawing.Size(86, 21);
            this.rcbConnected.TabIndex = 22;
            this.rcbConnected.Value = false;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonGroup1);
            this.kryptonPanel1.Controls.Add(this.kbtnSend);
            this.kryptonPanel1.Controls.Add(this.kbtnHelp);
            this.kryptonPanel1.Controls.Add(this.khName);
            this.kryptonPanel1.Controls.Add(this.rcbCommand);
            this.kryptonPanel1.Controls.Add(this.rtbResponse);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(238, 128);
            this.kryptonPanel1.TabIndex = 26;
            // 
            // kbtnConnect
            // 
            this.kbtnConnect.Location = new System.Drawing.Point(3, 30);
            this.kbtnConnect.Name = "kbtnConnect";
            this.kbtnConnect.Size = new System.Drawing.Size(86, 25);
            this.kbtnConnect.TabIndex = 29;
            this.kbtnConnect.Values.Text = "Connect";
            this.kbtnConnect.Click += new System.EventHandler(this.kbtnConnect_Click);
            // 
            // kbtnSend
            // 
            this.kbtnSend.Location = new System.Drawing.Point(61, 38);
            this.kbtnSend.Name = "kbtnSend";
            this.kbtnSend.Size = new System.Drawing.Size(73, 25);
            this.kbtnSend.TabIndex = 28;
            this.kbtnSend.Values.Text = "Send";
            this.kbtnSend.Click += new System.EventHandler(this.kbtnSend_Click);
            // 
            // kbtnHelp
            // 
            this.kbtnHelp.Location = new System.Drawing.Point(3, 38);
            this.kbtnHelp.Name = "kbtnHelp";
            this.kbtnHelp.Size = new System.Drawing.Size(52, 25);
            this.kbtnHelp.TabIndex = 27;
            this.kbtnHelp.Values.Text = "Help";
            this.kbtnHelp.Click += new System.EventHandler(this.kbtnHelp_Click);
            // 
            // khName
            // 
            this.khName.Location = new System.Drawing.Point(0, 0);
            this.khName.Name = "khName";
            this.khName.Size = new System.Drawing.Size(101, 31);
            this.khName.TabIndex = 26;
            this.khName.Values.Description = "";
            this.khName.Values.Heading = "232 Name";
            this.khName.Values.Image = null;
            // 
            // kryptonGroup1
            // 
            this.kryptonGroup1.Location = new System.Drawing.Point(140, 3);
            this.kryptonGroup1.Name = "kryptonGroup1";
            // 
            // kryptonGroup1.Panel
            // 
            this.kryptonGroup1.Panel.Controls.Add(this.rcbConnected);
            this.kryptonGroup1.Panel.Controls.Add(this.kbtnConnect);
            this.kryptonGroup1.Size = new System.Drawing.Size(94, 60);
            this.kryptonGroup1.TabIndex = 30;
            // 
            // RS232HeaderPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "RS232HeaderPanel";
            this.Size = new System.Drawing.Size(238, 128);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).EndInit();
            this.kryptonGroup1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).EndInit();
            this.kryptonGroup1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private GUI.Controls.RTextBox rtbResponse;
        private GUI.Controls.RComboBox rcbCommand;
        private GUI.Controls.RCheckBox rcbConnected;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnConnect;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnSend;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnHelp;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader khName;
        private ComponentFactory.Krypton.Toolkit.KryptonGroup kryptonGroup1;
    }
}
