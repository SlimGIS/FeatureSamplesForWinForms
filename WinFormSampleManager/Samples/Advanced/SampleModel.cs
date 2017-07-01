using System;
using System.Windows.Forms;

namespace SlimGis.Samples
{
    public class SampleModel
    {
        private bool isFullScreen;
        private Control sampleControl;

        public SampleModel()
        { }

        public Control SampleControl
        {
            get
            {
                if (sampleControl == null)
                {
                    SampleControl tempSampleControl = new SampleControl();
                    tempSampleControl.SampleName = Name;
                    tempSampleControl.SampleDescription = Description;
                    tempSampleControl.SourceUri = SourceUri;
                    sampleControl = tempSampleControl;
                    Initialize?.Invoke(this);
                }
                return sampleControl;
            }
            protected set { sampleControl = value; }
        }

        public string Name { get; set; }

        public virtual string Description { get; set; }

        public virtual Uri SourceUri { get; set; }

        public virtual bool IsFullScreen
        {
            get
            {
                return isFullScreen;
            }
            set
            {
                if (isFullScreen == value) return;
                isFullScreen = value;
                SampleControl tempSampleControl = SampleControl as SampleControl;
                if (isFullScreen) tempSampleControl?.FullScreen();
                else tempSampleControl?.ExitFullScreen();
            }
        }

        public Action<SampleModel> Initialize { get; set; }

        public void Reset()
        {
            sampleControl?.Dispose();
            sampleControl = null;
        }
    }
}
