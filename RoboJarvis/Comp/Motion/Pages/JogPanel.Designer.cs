
namespace RoboJarvis.Comp.Motion.Pages
{
    partial class JogPanel
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
            this.rtbJogDistance = new RoboLib.GUI.Controls.RTextBox();
            this.rtbJogSpeed = new RoboLib.GUI.Controls.RTextBox();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtnJogNeg = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnJogPos = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbJogDistance
            // 
            this.rtbJogDistance.IsPasswordField = false;
            this.rtbJogDistance.LabelText = "Jog Distance";
            this.rtbJogDistance.LabelWidthPercent = -1;
            this.rtbJogDistance.Location = new System.Drawing.Point(3, 28);
            this.rtbJogDistance.Margin = new System.Windows.Forms.Padding(4);
            this.rtbJogDistance.Multiline = false;
            this.rtbJogDistance.Name = "rtbJogDistance";
            this.rtbJogDistance.Size = new System.Drawing.Size(183, 21);
            this.rtbJogDistance.TabIndex = 1;
            this.rtbJogDistance.ValueText = "";
            // 
            // rtbJogSpeed
            // 
            this.rtbJogSpeed.IsPasswordField = false;
            this.rtbJogSpeed.LabelText = "Jog Speed";
            this.rtbJogSpeed.LabelWidthPercent = -1;
            this.rtbJogSpeed.Location = new System.Drawing.Point(3, 3);
            this.rtbJogSpeed.Multiline = false;
            this.rtbJogSpeed.Name = "rtbJogSpeed";
            this.rtbJogSpeed.Size = new System.Drawing.Size(184, 21);
            this.rtbJogSpeed.TabIndex = 7;
            this.rtbJogSpeed.ValueText = "";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kbtnJogPos);
            this.kryptonPanel1.Controls.Add(this.kbtnJogNeg);
            this.kryptonPanel1.Controls.Add(this.rtbJogSpeed);
            this.kryptonPanel1.Controls.Add(this.rtbJogDistance);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(294, 53);
            this.kryptonPanel1.TabIndex = 8;
            // 
            // kbtnJogNeg
            // 
            this.kbtnJogNeg.Location = new System.Drawing.Point(193, 3);
            this.kbtnJogNeg.Name = "kbtnJogNeg";
            this.kbtnJogNeg.Size = new System.Drawing.Size(46, 46);
            this.kbtnJogNeg.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnJogNeg.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kbtnJogNeg.TabIndex = 8;
            this.kbtnJogNeg.Values.Text = "- -";
            this.kbtnJogNeg.Click += new System.EventHandler(this.kbtnJogNeg_Click);
            // 
            // kbtnJogPos
            // 
            this.kbtnJogPos.Location = new System.Drawing.Point(245, 3);
            this.kbtnJogPos.Name = "kbtnJogPos";
            this.kbtnJogPos.Size = new System.Drawing.Size(46, 46);
            this.kbtnJogPos.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnJogPos.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kbtnJogPos.TabIndex = 9;
            this.kbtnJogPos.Values.Text = "++";
            this.kbtnJogPos.Click += new System.EventHandler(this.kbtnJogPos_Click);
            // 
            // JogPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "JogPanel";
            this.Size = new System.Drawing.Size(294, 53);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private RoboLib.GUI.Controls.RTextBox rtbJogDistance;
        private RoboLib.GUI.Controls.RTextBox rtbJogSpeed;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnJogPos;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnJogNeg;
    }
}
