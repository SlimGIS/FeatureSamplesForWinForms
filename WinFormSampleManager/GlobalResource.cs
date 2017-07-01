using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.Composition.Hosting;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace SlimGis.Samples
{
    public class GlobalResources : INotifyPropertyChanged
    {
        private static GlobalResources instance;
        private Collection<SampleCategoryPlugin> sampleCategories;
        private bool isLoaded;
        private bool loadSamplesFailedVisiable;
        private bool listPanelVisiable;

        public event PropertyChangedEventHandler PropertyChanged;

        public GlobalResources()
        {
            sampleCategories = new Collection<SampleCategoryPlugin>();
            loadSamplesFailedVisiable = false;
            listPanelVisiable = true;
        }

        public static GlobalResources Instance
        {
            get
            {
                return instance ?? (instance = new GlobalResources());
            }
        }

        public async Task LoadAsync()
        {
            Collection<SampleCategoryPlugin> samplePlugins = await LoadSamplePluginsAsync();
            foreach (SampleCategoryPlugin samplePlugin in samplePlugins)
            {
                try
                {
                    //SampleModel sampleModel = new SampleModel();
                    //sampleModel.Name = samplePlugin.Name;
                    //sampleModel.Description = string.Empty;
                    //foreach (var sample in samplePlugin.Samples)
                    //{
                    //    sampleModel.Samples.Add(sample);
                    //}

                    Samples.Add(samplePlugin);
                }
                catch { }
            }

            IsLoaded = true;
        }

        private async Task<Collection<SampleCategoryPlugin>> LoadSamplePluginsAsync()
        {
            return await Task.Run(() =>
            {
                string entryDllPath = Assembly.GetEntryAssembly().Location;
                string entryDir = new FileInfo(entryDllPath).Directory.FullName;
                string[] dllPaths = Directory.GetFiles(entryDir, "*.dll", SearchOption.AllDirectories).Where(f => !f.Equals(entryDllPath)).ToArray();

                AggregateCatalog catalog = new AggregateCatalog();
                foreach (var dllPath in dllPaths)
                {
                    if (dllPath.Contains(@"\obj\") || !Path.GetFileName(dllPath).StartsWith("SlimGis.Samples.")) continue;
                    try
                    {
                        AssemblyCatalog assemblyCatalog = new AssemblyCatalog(Assembly.LoadFile(dllPath));
                        catalog.Catalogs.Add(assemblyCatalog);
                    }
                    catch { }
                }
                catalog.Catalogs.Add(new AssemblyCatalog(Assembly.GetExecutingAssembly()));

                CompositionContainer container = new CompositionContainer(catalog);
                Collection<SampleCategoryPlugin> plugins = new Collection<SampleCategoryPlugin>();
                foreach (var samplePluginExport in container.GetExports<SampleCategoryPlugin>())
                {
                    try
                    {
                        SampleCategoryPlugin sampleCategoryPlugin = samplePluginExport.Value;
                        plugins.Add(sampleCategoryPlugin);
                    }
                    catch { }
                }

                return plugins;
            });
        }

        public Collection<SampleCategoryPlugin> Samples => sampleCategories;

        public bool IsLoaded
        {
            get { return isLoaded; }
            set
            {
                if (isLoaded == value) return;
                isLoaded = value;

                var currentSample = Samples.SelectMany(category => category.Samples).OfType<SampleModel>().FirstOrDefault();
                if (currentSample == null) LoadSamplesFailedVisiable = true;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsLoaded)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Samples)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(LoadingBarVisiable)));
            }
        }

        public bool LoadingBarVisiable { get { return !IsLoaded; } }

        public bool LoadSamplesFailedVisiable
        {
            get { return loadSamplesFailedVisiable; }
            set
            {
                if (loadSamplesFailedVisiable == value) return;
                loadSamplesFailedVisiable = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(LoadSamplesFailedVisiable)));
            }
        }

        public bool ListPanelVisiable
        {
            get { return listPanelVisiable; }
            set
            {
                listPanelVisiable = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ListPanelVisiable)));
            }
        }
    }
}
