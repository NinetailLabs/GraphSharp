using System;
using System.Globalization;
using System.Windows.Data;
using GraphSharp.Algorithms.Layout.Compound;

namespace GraphSharp.Sample.Model
{
    public class PocVertexToLayoutModeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var vertex = value as string;
            return vertex == "2" || vertex == "3" ? CompoundVertexInnerLayoutType.Fixed : CompoundVertexInnerLayoutType.Automatic;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
