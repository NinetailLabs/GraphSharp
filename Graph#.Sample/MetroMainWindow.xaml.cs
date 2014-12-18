using System.Windows;

namespace GraphSharp.Sample
{
    public partial class MetroMainWindow
    {
        public MetroMainWindow()
        {
            InitializeComponent();
        }

        private void OnExecuteNotificationTest(object sender, RoutedEventArgs e)
        {
            new TestWindow().Show();
        }

        private void OnExecuteCompoundLayoutTest(object sender, RoutedEventArgs e)
        {
            new TestCompoundLayout().Show();
        }

        private void OnShowFlyoutClicked(object sender, RoutedEventArgs e)
        {
            Flyout.IsOpen = !Flyout.IsOpen;
        }
    }
}