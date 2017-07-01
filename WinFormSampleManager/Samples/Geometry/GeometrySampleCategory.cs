namespace SlimGis.Samples
{
    public class GeometrySampleCategory : SampleCategoryPlugin
    {
        public GeometrySampleCategory()
        {
            Name = "Geometry Samples";
        }

        protected override string SampleListManifestResourceName => "SlimGis.Samples.Samples.Geometry.Samples.xml";
    }
}
