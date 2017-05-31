using System;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SlimGis.Samples
{
    [InheritedExport(typeof(SampleCategoryPlugin))]
    public abstract class SampleCategoryPlugin
    {
        private Collection<SampleModel> samples;

        protected SampleCategoryPlugin()
        { }

        public string Name { get; set; }

        public Collection<SampleModel> Samples
        {
            get
            {
                if (samples == null)
                {
                    samples = new Collection<SampleModel>();
                    foreach (var sample in GetSamples())
                    {
                        samples.Add(sample);
                    }
                }

                return samples;
            }
        }

        protected virtual string SampleListManifestResourceName { get { return null; } }

        protected virtual Collection<SampleModel> GetSamples()
        {
            Collection<SampleModel> samples = new Collection<SampleModel>();
            if (string.IsNullOrEmpty(SampleListManifestResourceName)) return samples;

            Stream stream = GetType().Assembly.GetManifestResourceStream(SampleListManifestResourceName);
            if (stream == null) return samples;

            var sampleElement = XDocument.Load(stream).Elements().FirstOrDefault();
            if (sampleElement == null) return samples;

            foreach (var element in sampleElement.Elements("sample"))
            {
                string name = element.Attribute("name").Value;
                string type = element.Attribute("type").Value;
                string uri = element.Attribute("uri").Value;
                string description = element.Value;
                SampleModel sampleModel = new SampleModel
                {
                    Name = name,
                    Description = description,
                    SourceUri = new Uri(uri, UriKind.RelativeOrAbsolute),
                    Initialize = sample => InitializeSample(sample, type),
                };

                samples.Add(sampleModel);
            }
            return samples;
        }

        protected virtual void InitializeSample(SampleModel sampleModel, string type)
        {
            SampleControl tempSampleControl = sampleModel.SampleControl as SampleControl;
            if (tempSampleControl == null) return;
            Type sampleType = GetType().Assembly.GetType($"SlimGis.Samples.{type}");
            if (sampleType == null) return;

            Control control = (Control)Activator.CreateInstance(sampleType);
            control.Dock = DockStyle.Fill;
            if (control != null) tempSampleControl.ControlContent.Controls.Add(control);

            PropertyInfo propertyInfo = control.GetType().GetProperty("MapContent");
            if (propertyInfo == null) return;
            Control mapControl = propertyInfo.GetValue(control, null) as Control;
            if (mapControl == null) return;

            mapControl.Dock = DockStyle.Fill;
            tempSampleControl.MapContent.Controls.Add(mapControl);
        }
    }
}
