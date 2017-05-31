namespace SlimGis.Samples
{
    partial class GetWellKnownDataControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.wktTextBox = new System.Windows.Forms.TextBox();
            this.wktPanel = new System.Windows.Forms.Panel();
            this.wkbPanel = new System.Windows.Forms.Panel();
            this.wkbTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.wktPanel.SuspendLayout();
            this.wkbPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Well-Known Text (WKT)";
            // 
            // wktTextBox
            // 
            this.wktTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.wktTextBox.Location = new System.Drawing.Point(0, 33);
            this.wktTextBox.Multiline = true;
            this.wktTextBox.Name = "wktTextBox";
            this.wktTextBox.Size = new System.Drawing.Size(323, 223);
            this.wktTextBox.TabIndex = 1;
            // 
            // wktPanel
            // 
            this.wktPanel.Controls.Add(this.wktTextBox);
            this.wktPanel.Controls.Add(this.label1);
            this.wktPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.wktPanel.Location = new System.Drawing.Point(0, 0);
            this.wktPanel.Name = "wktPanel";
            this.wktPanel.Size = new System.Drawing.Size(323, 256);
            this.wktPanel.TabIndex = 2;
            // 
            // wkbPanel
            // 
            this.wkbPanel.Controls.Add(this.wkbTextBox);
            this.wkbPanel.Controls.Add(this.label2);
            this.wkbPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.wkbPanel.Location = new System.Drawing.Point(0, 262);
            this.wkbPanel.Name = "wkbPanel";
            this.wkbPanel.Size = new System.Drawing.Size(323, 298);
            this.wkbPanel.TabIndex = 3;
            // 
            // wkbTextBox
            // 
            this.wkbTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.wkbTextBox.Location = new System.Drawing.Point(0, 33);
            this.wkbTextBox.Multiline = true;
            this.wkbTextBox.Name = "wkbTextBox";
            this.wkbTextBox.Size = new System.Drawing.Size(323, 265);
            this.wkbTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Well-Known Binary (WKB)";
            // 
            // GetWellKnownDataControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.wkbPanel);
            this.Controls.Add(this.wktPanel);
            this.Name = "GetWellKnownDataControl";
            this.Size = new System.Drawing.Size(323, 560);
            this.Load += new System.EventHandler(this.GetWellKnownDataControl_Load);
            this.SizeChanged += new System.EventHandler(this.GetWellKnownDataControl_SizeChanged);
            this.wktPanel.ResumeLayout(false);
            this.wktPanel.PerformLayout();
            this.wkbPanel.ResumeLayout(false);
            this.wkbPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox wktTextBox;
        private System.Windows.Forms.Panel wktPanel;
        private System.Windows.Forms.Panel wkbPanel;
        private System.Windows.Forms.TextBox wkbTextBox;
        private System.Windows.Forms.Label label2;
    }
}
