using System.Windows;
using System.Windows.Input;
using GraphSharp.Sample.ViewModel;

namespace GraphSharp.Sample
{
    public partial class MainWindow
    {
        private readonly LayoutAnalyzerViewModel _analyzerViewModel = new LayoutAnalyzerViewModel();

        public MainWindow()
        {
            InitializeComponent();

            DataContext = _analyzerViewModel;
        }

        private void OnExecuteNotificationTest(object sender, ExecutedRoutedEventArgs e)
        {
            var testWindow = new TestWindow();
            testWindow.Show();
        }

        private void OnExecuteExit(object sender, ExecutedRoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void OnExecuteCompoundLayoutTest(object sender, ExecutedRoutedEventArgs e)
        {
            var window = new TestCompoundLayout();
            window.Show();
        }

        private void OnNewLayout(object sender, ExecutedRoutedEventArgs e)
        {
            var window = new MetroMainWindow {DataContext = DataContext};
            window.Show();
        }
    }
}