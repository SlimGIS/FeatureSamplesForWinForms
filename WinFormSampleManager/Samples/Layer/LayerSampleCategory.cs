namespace SlimGis.Samples
{
    public class LayerSampleCategory : SampleCategoryPlugin
    {
        public LayerSampleCategory()
        {
            Name = "Layer Samples";
        }

        protected override string SampleListManifestResourceName => "SlimGis.Samples.Samples.Layer.Samples.xml";
    }
}
