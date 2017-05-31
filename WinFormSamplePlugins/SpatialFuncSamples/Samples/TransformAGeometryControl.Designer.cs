namespace SlimGis.Samples
{
    partial class TransformAGeometryControl
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
            this.scaleDownButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.rotateButton = new System.Windows.Forms.Button();
            this.scaleUpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // scaleDownButton
            // 
            this.scaleDownButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scaleDownButton.Location = new System.Drawing.Point(3, 3);
            this.scaleDownButton.Name = "scaleDownButton";
            this.scaleDownButton.Size = new System.Drawing.Size(306, 30);
            this.scaleDownButton.TabIndex = 0;
            this.scaleDownButton.Text = "Scale Down by 10%";
            this.scaleDownButton.UseVisualStyleBackColor = true;
            this.scaleDownButton.Click += new System.EventHandler(this.ScaleDownButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resetButton.Location = new System.Drawing.Point(3, 111);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(306, 30);
            this.resetButton.TabIndex = 1;
            this.resetButton.Text = "Reset to Default";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // rotateButton
            // 
            this.rotateButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rotateButton.Location = new System.Drawing.Point(3, 75);
            this.rotateButton.Name = "rotateButton";
            this.rotateButton.Size = new System.Drawing.Size(306, 30);
            this.rotateButton.TabIndex = 2;
            this.rotateButton.Text = "Rotate by 10 Degrees";
            this.rotateButton.UseVisualStyleBackColor = true;
            this.rotateButton.Click += new System.EventHandler(this.RotateButton_Click);
            // 
            // scaleUpButton
            // 
            this.scaleUpButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scaleUpButton.Location = new System.Drawing.Point(3, 39);
            this.scaleUpButton.Name = "scaleUpButton";
            this.scaleUpButton.Size = new System.Drawing.Size(306, 30);
            this.scaleUpButton.TabIndex = 3;
            this.scaleUpButton.Text = "Scale Up by 10%";
            this.scaleUpButton.UseVisualStyleBackColor = true;
            this.scaleUpButton.Click += new System.EventHandler(this.ScaleUpButton_Click);
            // 
            // TransformAGeometryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scaleUpButton);
            this.Controls.Add(this.rotateButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.scaleDownButton);
            this.Name = "TransformAGeometryControl";
            this.Size = new System.Drawing.Size(312, 473);
            this.Load += new System.EventHandler(this.TransformAGeometryControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button scaleDownButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button rotateButton;
        private System.Windows.Forms.Button scaleUpButton;
    }
}
