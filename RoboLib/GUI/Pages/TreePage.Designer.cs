namespace RoboLib.GUI.Pages
{
    partial class TreePage
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
            this.treeViewRobot = new ComponentFactory.Krypton.Toolkit.KryptonTreeView();
            this.SuspendLayout();
            // 
            // treeViewRobot
            // 
            this.treeViewRobot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewRobot.Location = new System.Drawing.Point(0, 0);
            this.treeViewRobot.Name = "treeViewRobot";
            this.treeViewRobot.Size = new System.Drawing.Size(223, 400);
            this.treeViewRobot.TabIndex = 1;
            // 
            // TreePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeViewRobot);
            this.Name = "TreePage";
            this.Size = new System.Drawing.Size(223, 400);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonTreeView treeViewRobot;
    }
}
