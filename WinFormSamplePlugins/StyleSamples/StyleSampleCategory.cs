using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlimGis.Samples
{
    public class StyleSampleCategory : SampleCategoryPlugin
    {
        public StyleSampleCategory()
        {
            Name = "Style Samples";
        }

        protected override string SampleListManifestResourceName => "SlimGis.Samples.Samples.xml";
    }
}
