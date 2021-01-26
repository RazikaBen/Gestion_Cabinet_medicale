using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace Gestion_Cabinet_medicale
{
    public class WidthHeightToRectMultiConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            // hna rhi bayna
            //values rhi array donc ghadi yji fiha les valeurs li ghadi tb3tihom ml XAML
            // ghadi neseyyou nhwlohom lel doubles rki m3aya ? woui yla mshi doubles fizouj return null

            var width = values[0] as double?;
            var height = values[1] as double?;
            if (width is null || height is null)
                return null;

            // in case the width and height are valid
            return new Rect(0, 0, width.Value, height.Value);

            // say hna converter rh bayn ?ouii
            // drwk hadi partie li jayta lazm mtnsayhach diri build bach converter ytl3 fel UI

        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
