namespace SlimGis.Samples
{
    partial class BuildInToolsMapContentControl
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
            this.mapControl = new SlimGis.MapKit.WinForms.MapControl();
            this.zoomBar = new SlimGis.MapKit.WinForms.ZoomBar();
            this.viewportBlock = new SlimGis.MapKit.WinForms.ViewportBlock();
            this.scaleBar = new SlimGis.MapKit.WinForms.ScaleBar();
            this.SuspendLayout();
            // 
            // mapControl
            // 
            this.mapControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mapControl.Location = new System.Drawing.Point(0, 0);
            this.mapControl.MapUnit = SlimGis.MapKit.Geometries.GeoUnit.Unknown;
            this.mapControl.Name = "mapControl";
            this.mapControl.Size = new System.Drawing.Size(697, 558);
            this.mapControl.SpatialReference = null;
            this.mapControl.TabIndex = 0;
            this.mapControl.Text = "mapControl1";
            // 
            // zoomBar
            // 
            this.zoomBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.zoomBar.Location = new System.Drawing.Point(638, 12);
            this.zoomBar.Map = this.mapControl;
            this.zoomBar.Name = "zoomBar";
            this.zoomBar.Size = new System.Drawing.Size(46, 89);
            this.zoomBar.TabIndex = 1;
            // 
            // viewportBlock
            // 
            this.viewportBlock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.viewportBlock.Location = new System.Drawing.Point(0, 540);
            this.viewportBlock.Map = this.mapControl;
            this.viewportBlock.Name = "viewportBlock";
            this.viewportBlock.Size = new System.Drawing.Size(890, 18);
            this.viewportBlock.TabIndex = 2;
            this.viewportBlock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewportBlock.ViewportInfoTypes = SlimGis.MapKit.WinForms.ViewportInfoTypes.Bound;
            // 
            // scaleBar
            // 
            this.scaleBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.scaleBar.Location = new System.Drawing.Point(0, 521);
            this.scaleBar.Map = this.mapControl;
            this.scaleBar.Name = "scaleBar";
            this.scaleBar.Size = new System.Drawing.Size(120, 18);
            this.scaleBar.TabIndex = 3;
            // 
            // BuildInToolsMapContentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scaleBar);
            this.Controls.Add(this.viewportBlock);
            this.Controls.Add(this.zoomBar);
            this.Controls.Add(this.mapControl);
            this.Name = "BuildInToolsMapContentControl";
            this.Size = new System.Drawing.Size(697, 558);
            this.ResumeLayout(false);

        }

        #endregion

        private MapKit.WinForms.MapControl mapControl;
        private MapKit.WinForms.ZoomBar zoomBar;
        private MapKit.WinForms.ViewportBlock viewportBlock;
        private MapKit.WinForms.ScaleBar scaleBar;
    }
}
