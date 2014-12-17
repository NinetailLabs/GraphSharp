using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace GraphSharp.Controls.Zoom
{
    public class ZoomContentPresenter : ContentPresenter
    {
        public delegate void ContentSizeChangedHandler(object sender, Size newSize);

        public event ContentSizeChangedHandler ContentSizeChanged;

        private Size _contentSize;

        public Size ContentSize
        {
            get { return _contentSize; }
            private set {
                if (value == _contentSize)
                    return;

                _contentSize = value;
                if (ContentSizeChanged != null)
                    ContentSizeChanged(this, _contentSize);
            }
        }

        protected override Size MeasureOverride(Size constraint)
        {
            base.MeasureOverride(new Size(double.PositiveInfinity, double.PositiveInfinity));
            const double max = 1e9;
            var x = double.IsInfinity(constraint.Width) ? max : constraint.Width;
            var y = double.IsInfinity(constraint.Height) ? max : constraint.Height;
            return new Size(x, y);
        }

        protected override Size ArrangeOverride(Size arrangeBounds)
        {
            UIElement child = VisualChildrenCount > 0
                                  ? VisualTreeHelper.GetChild(this, 0) as UIElement
                                  : null;
            if (child == null)
                return arrangeBounds;

            //set the ContentSize
            ContentSize = child.DesiredSize;
            child.Arrange(new Rect(child.DesiredSize));

            return arrangeBounds;
        }
    }
}
