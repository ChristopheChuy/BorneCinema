using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
namespace GestionCinema
{
    public class AgeToStringConverter:IValueConverter
    {
        // Converti un age en une chaine de caractères 
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            int age = (int)value;
            if (age != 0)
                return age.ToString() + " ans minimum";
            else return "Tout public";
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
