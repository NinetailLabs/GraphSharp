using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using System.Windows.Input;
using GraphSharp.Sample.Model;
using GraphSharp.Sample.Properties;

namespace GraphSharp.Sample.ViewModel
{
    public partial class LayoutAnalyzerViewModel : INotifyPropertyChanged
    {
        public ICommand RelayoutCommand { get; private set; }

        public ICommand OpenGraphsCommand { get; private set; }

        public ICommand SaveGraphsCommand { get; private set; }

        private GraphModel _selectedGraphModel;

        public ObservableCollection<GraphModel> GraphModels { get; private set; }

        public GraphModel SelectedGraphModel
        {
            get { return _selectedGraphModel; }
            set
            {
                if (_selectedGraphModel != value)
                {
                    _selectedGraphModel = value;
                    SelectedGraphChanged();
                    NotifyChanged("SelectedGraphModel");
                }
            }
        }

        private void SelectedGraphChanged()
        {
            if (AnalyzedLayouts != null)
            {
                AnalyzedLayouts.Graph = _selectedGraphModel.Graph;
            }
        }

        public GraphLayoutViewModel AnalyzedLayouts { get; private set; }

        public LayoutAnalyzerViewModel()
        {
            AnalyzedLayouts = new GraphLayoutViewModel
            {
                LayoutAlgorithmType = "EfficientSugiyama"
            };
            GraphModels = new ObservableCollection<GraphModel>();

            RelayoutCommand = new RelayCommand(p => Relayout(), p => AnalyzedLayouts != null, "Relayout");
            OpenGraphsCommand = new RelayCommand(p => OpenGraphs(), title: "Open Graphs");
            SaveGraphsCommand = new RelayCommand(p => SaveGraphs(), p => GraphModels.Count > 0, "Save Graphs");

            CreateSampleGraphs();
        }

        partial void CreateSampleGraphs();

        private static void Relayout()
        {
            LayoutManager.Instance.Relayout();
        }

        private void OpenGraphs()
        {
            var ofd = new OpenFileDialog
                        {
                            CheckPathExists = true
                        };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //open the file and load the graphs
                var graph = PocSerializeHelper.LoadGraph(ofd.FileName);

                GraphModels.Add(new GraphModel(Path.GetFileNameWithoutExtension(ofd.FileName), graph));
            }
        }

        private void SaveGraphs()
        {
            var fd = new FolderBrowserDialog
                        {
                            ShowNewFolderButton = true
                        };
            if (fd.ShowDialog() == DialogResult.OK)
            {
                foreach (var model in GraphModels)
                {
                    PocSerializeHelper.SaveGraph(model.Graph, Path.Combine(fd.SelectedPath, string.Format("{0}.{1}", model.Name, Settings.Default.GraphMLExtension)));
                }
            }
        }

        private void NotifyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}