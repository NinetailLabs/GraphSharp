using System.Windows.Input;
using GraphSharp.Sample.ViewModel;
using System.Windows;

namespace GraphSharp.Sample
{
    /// <summary>
    /// Main window of the Proof of Concept application for the GraphLayout control.
    /// </summary>
    public partial class MainWindow
    {
        private readonly LayoutAnalyzerViewModel _analyzerViewModel = new LayoutAnalyzerViewModel();

        public MainWindow()
        {
            InitializeComponent();

            DataContext = _analyzerViewModel;
        }

        private void NotificationTest_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            var testWindow = new TestWindow();
            testWindow.Show();
        }

        private void Exit_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ContextualLayoutTest_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            var window = new TestContextualLayout(_analyzerViewModel.SelectedGraphModel.Graph);
            window.Show();
        }

        private void CompoundLayoutTest_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            var window = new TestCompoundLayout();
            window.Show();
        }

        private void AnimatedCompoundLayoutTest_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            var window = new PlainCompoundLayoutTest();
            window.Show();
        }
    }
}