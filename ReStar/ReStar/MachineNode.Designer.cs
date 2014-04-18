namespace ReStar
{
    partial class MachineNode
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
            this.components = new System.ComponentModel.Container();
            this.MachineLabel = new System.Windows.Forms.Label();
            this.tmrPingTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // MachineLabel
            // 
            this.MachineLabel.AutoSize = true;
            this.MachineLabel.Location = new System.Drawing.Point(3, 12);
            this.MachineLabel.Name = "MachineLabel";
            this.MachineLabel.Size = new System.Drawing.Size(114, 13);
            this.MachineLabel.TabIndex = 0;
            this.MachineLabel.Text = "<New Machine Node>";
            // 
            // tmrPingTimer
            // 
            this.tmrPingTimer.Enabled = true;
            this.tmrPingTimer.Interval = 3000;
            this.tmrPingTimer.Tick += new System.EventHandler(this.tmrPingTimer_Tick);
            // 
            // MachineNode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MachineLabel);
            this.Name = "MachineNode";
            this.Size = new System.Drawing.Size(223, 42);
            this.Load += new System.EventHandler(this.MachineNode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MachineLabel;
        private System.Windows.Forms.Timer tmrPingTimer;
    }
}
