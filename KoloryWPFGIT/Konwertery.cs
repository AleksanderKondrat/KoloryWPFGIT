using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace KoloryWPFGIT
{
    public class ByteToDoubleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return (double)(byte)value;
        }
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return (byte)(double)value;
        }
    }

    public class ColorToSolidColorBrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            Color kolor = (Color)value;
            return new SolidColorBrush(kolor);
        }
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class PartsARGBToSolidBrushConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            byte a = (byte)values[0];
            byte r = (byte)values[1];
            byte g = (byte)values[2];
            byte b = (byte)values[3];
            
            return new SolidColorBrush(Color.FromArgb(a,r,g,b));
        }
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            SolidColorBrush pedzel = value as SolidColorBrush;
            if(pedzel != null)
            {
                Color kolor = pedzel.Color;
                return new object[4] { kolor.A, kolor.R, kolor.G, kolor.B };
            }
            throw new NotImplementedException();
        }
    }

    public class PartsARGBDoubleToSolidBrushConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            byte a = (byte)(double)values[0];
            byte r = (byte)(double)values[1];
            byte g = (byte)(double)values[2];
            byte b = (byte)(double)values[3];

            return new SolidColorBrush(Color.FromArgb(a, r, g, b));
        }
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            /*
            SolidColorBrush pedzel = value as SolidColorBrush;
            if (pedzel != null)
            {
                Color kolor = pedzel.Color;
                return new object[4] { kolor.A, kolor.R, kolor.G, kolor.B };
            }
            */
            throw new NotImplementedException();
        }
    }

}
