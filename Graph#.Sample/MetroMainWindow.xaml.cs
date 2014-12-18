using System.Windows;
using GraphSharp.Sample.ViewModel;

namespace GraphSharp.Sample
{
    public partial class MetroMainWindow
    {
        public MetroMainWindow()
        {
            InitializeComponent();

            DataContext = new LayoutAnalyzerViewModel();
        }

        private void OnExecuteNotificationTest(object sender, RoutedEventArgs e)
        {
            new TestWindow().Show();
        }

        private void OnExecuteCompoundLayoutTest(object sender, RoutedEventArgs e)
        {
            new TestCompoundLayout().Show();
        }
    }
}