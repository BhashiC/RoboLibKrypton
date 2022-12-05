
namespace RoboLib.Models.Communication.Pages
{
    partial class RS232Page
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
            this.rS232SettingsPanel1 = new RoboLib.Models.Communication.Pages.RS232SettingsPanel();
            this.rS232HeaderPanel1 = new RoboLib.Models.Communication.Pages.RS232HeaderPanel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.rS232SettingsPanel1);
            this.kryptonPanel1.Controls.Add(this.rS232HeaderPanel1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderCalendar;
            this.kryptonPanel1.Size = new System.Drawing.Size(245, 383);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // rS232SettingsPanel1
            // 
            this.rS232SettingsPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.rS232SettingsPanel1.Location = new System.Drawing.Point(3, 137);
            this.rS232SettingsPanel1.Name = "rS232SettingsPanel1";
            this.rS232SettingsPanel1.Size = new System.Drawing.Size(238, 242);
            this.rS232SettingsPanel1.TabIndex = 1;
            // 
            // rS232HeaderPanel1
            // 
            this.rS232HeaderPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.rS232HeaderPanel1.Location = new System.Drawing.Point(3, 3);
            this.rS232HeaderPanel1.Name = "rS232HeaderPanel1";
            this.rS232HeaderPanel1.Size = new System.Drawing.Size(238, 128);
            this.rS232HeaderPanel1.TabIndex = 0;
            // 
            // RS232Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "RS232Page";
            this.Size = new System.Drawing.Size(245, 383);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private RS232HeaderPanel rS232HeaderPanel1;
        private RS232SettingsPanel rS232SettingsPanel1;
    }
}
