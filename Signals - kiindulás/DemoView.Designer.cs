namespace Signals
{
    partial class DemoView
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
            this.lblLastValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLastValue
            // 
            this.lblLastValue.AutoSize = true;
            this.lblLastValue.Location = new System.Drawing.Point(2, 0);
            this.lblLastValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastValue.Name = "lblLastValue";
            this.lblLastValue.Size = new System.Drawing.Size(20, 20);
            this.lblLastValue.TabIndex = 0;
            this.lblLastValue.Text = "A";
            // 
            // DemoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.lblLastValue);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DemoView";
            this.Size = new System.Drawing.Size(201, 192);
            this.Load += new System.EventHandler(this.DemoView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLastValue;
    }
}
