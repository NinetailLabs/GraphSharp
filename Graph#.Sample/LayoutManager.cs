using System.Collections.Generic;
using System.Windows;
using GraphSharp.Sample.ViewModel;

namespace GraphSharp.Sample
{
    public class LayoutManager : DependencyObject
    {
        private static LayoutManager _instance;

        public static readonly DependencyProperty ManagedLayoutProperty =
                DependencyProperty.RegisterAttached("ManagedLayout", typeof (bool), typeof (LayoutManager), new PropertyMetadata(false, OnManagedLayoutPropertyChanged));

        private readonly HashSet<PocGraphLayout> _graphLayouts = new HashSet<PocGraphLayout>();

        public static LayoutManager Instance
        {
            get { return _instance ?? (_instance = new LayoutManager()); }
        }

        public void ContinueLayout()
        {
            foreach (PocGraphLayout layout in _graphLayouts)
                layout.ContinueLayout();
        }

        public void Relayout()
        {
            foreach (PocGraphLayout layout in _graphLayouts)
                layout.Relayout();
        }

        [AttachedPropertyBrowsableForChildren]
        public static bool GetManagedLayout(DependencyObject obj)
        {
            return (bool) obj.GetValue(ManagedLayoutProperty);
        }

        public static void SetManagedLayout(DependencyObject obj, bool value)
        {
            obj.SetValue(ManagedLayoutProperty, value);
        }

        private static void OnManagedLayoutPropertyChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            var graphLayout = obj as PocGraphLayout;
            if (graphLayout == null)
                return;

            if ((bool) e.NewValue)
            {
                Instance._graphLayouts.Add(graphLayout);
                graphLayout.Unloaded += OnGraphLayoutUnloaded;
            }
            else if ((bool) e.OldValue && (((bool) e.NewValue) == false) && Instance._graphLayouts.Contains(graphLayout))
            {
                Instance._graphLayouts.Remove(graphLayout);
                graphLayout.Unloaded -= OnGraphLayoutUnloaded;
            }
        }

        private static void OnGraphLayoutUnloaded(object s, RoutedEventArgs args)
        {
            if (s is PocGraphLayout)
                Instance._graphLayouts.Remove(s as PocGraphLayout);
        }
    }
}