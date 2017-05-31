namespace SlimGis.Samples
{
    public class ProjectionSampleCategory : SampleCategoryPlugin
    {
        public ProjectionSampleCategory()
        {
            Name = "Projection Samples";
        }

        protected override string SampleListManifestResourceName => "SlimGis.Samples.Samples.xml";
    }
}
