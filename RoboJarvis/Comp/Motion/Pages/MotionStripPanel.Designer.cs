
namespace RoboJarvis.Comp.Motion.Pages
{
    partial class MotionStripPanel
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
            this.rtbPosition = new RoboLib.GUI.Controls.RTextBox();
            this.kbtnMove = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.rtbSpeed = new RoboLib.GUI.Controls.RTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.rtbPosition);
            this.kryptonPanel1.Controls.Add(this.kbtnMove);
            this.kryptonPanel1.Controls.Add(this.rtbSpeed);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(294, 25);
            this.kryptonPanel1.TabIndex = 8;
            // 
            // rtbPosition
            // 
            this.rtbPosition.IsPasswordField = false;
            this.rtbPosition.LabelText = "Position";
            this.rtbPosition.LabelWidthPercent = -1;
            this.rtbPosition.Location = new System.Drawing.Point(0, 1);
            this.rtbPosition.Multiline = false;
            this.rtbPosition.Name = "rtbPosition";
            this.rtbPosition.Size = new System.Drawing.Size(134, 21);
            this.rtbPosition.TabIndex = 5;
            this.rtbPosition.ValueText = "";
            // 
            // kbtnMove
            // 
            this.kbtnMove.Location = new System.Drawing.Point(252, 2);
            this.kbtnMove.Name = "kbtnMove";
            this.kbtnMove.Size = new System.Drawing.Size(39, 22);
            this.kbtnMove.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-1, -3, -1, -1);
            this.kbtnMove.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Webdings", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.kbtnMove.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kbtnMove.TabIndex = 7;
            this.kbtnMove.Values.Text = "44";
            this.kbtnMove.Click += new System.EventHandler(this.kbtnMove_Click);
            // 
            // rtbSpeed
            // 
            this.rtbSpeed.IsPasswordField = false;
            this.rtbSpeed.LabelText = "Speed";
            this.rtbSpeed.LabelWidthPercent = -1;
            this.rtbSpeed.Location = new System.Drawing.Point(140, 1);
            this.rtbSpeed.Multiline = false;
            this.rtbSpeed.Name = "rtbSpeed";
            this.rtbSpeed.Size = new System.Drawing.Size(106, 21);
            this.rtbSpeed.TabIndex = 6;
            this.rtbSpeed.ValueText = "";
            // 
            // MotionStripPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "MotionStripPanel";
            this.Size = new System.Drawing.Size(294, 25);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private RoboLib.GUI.Controls.RTextBox rtbPosition;
        private RoboLib.GUI.Controls.RTextBox rtbSpeed;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnMove;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
    }
}
