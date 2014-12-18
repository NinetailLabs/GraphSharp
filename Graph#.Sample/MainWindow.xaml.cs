using System.Windows;
using System.Windows.Input;
using GraphSharp.Sample.ViewModel;

namespace GraphSharp.Sample
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new LayoutAnalyzerViewModel();
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
            var window = new MetroMainWindow();
            window.Show();
        }
    }
}