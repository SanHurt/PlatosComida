using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace PlatosComida
{
    class ConverterTipo : IValueConverter
    {
        private const string MEXICANA = "Mexicana";
        private const string CHINA = "China";
        private const string AMERICANA = "Americana";
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string tipo = (string)value;
            string imagenTipo;
            if (tipo == MEXICANA)
                imagenTipo = "Assets/mexico.png";
            else if(tipo == CHINA)
                imagenTipo = "Assets/china.png";
            else
                imagenTipo = "Assets/united_states.png";
            return imagenTipo;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
