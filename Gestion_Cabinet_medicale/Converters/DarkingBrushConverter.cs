using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace Gestion_Cabinet_medicale
{
    public class DarkingBrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var isBrush = value as Brush;
            if (value is null) return Brushes.White;
            var SolidcolorB = (SolidColorBrush)isBrush;
            var a = isBrush.ToString();
           // cant combine tow brushes
            return Brushes.Black;

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
