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
    public class availablePagesToBackground : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            availablePages home = availablePages.Home;
            PatientAvailablePage p = PatientAvailablePage.Nouveau;
            var Is_availablePagesObject = availablePages.TryParse(value.ToString(), true, out home);
            var Is_availablePatientPageObject =PatientAvailablePage.TryParse(value.ToString(), true, out p);
            var param = parameter.ToString();
            if (Is_availablePagesObject)
            {
            var a = (availablePages)value;
                
                if (a.ToString() == param) return (SolidColorBrush)(new BrushConverter().ConvertFrom("#507091"));

            return "Transparent";
            }
            if (Is_availablePatientPageObject)
            {
                var a = (PatientAvailablePage)value;
                if (a.ToString() == param) return "#3D5672";
                return "Transparent";
            }


            return "Transparent";


        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
