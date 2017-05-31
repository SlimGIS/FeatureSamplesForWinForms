namespace SlimGis.Samples
{
    public class WinFormSpecificSampleCategory : SampleCategoryPlugin
    {
        public WinFormSpecificSampleCategory()
        {
            Name = "WinForm Specific";
        }

        protected override string SampleListManifestResourceName => "SlimGis.Samples.Samples.xml";
    }
}
