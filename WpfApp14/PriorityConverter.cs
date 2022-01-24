using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace WpfApp14
{
    class PriorityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (((int)value) == 1)
            {
                return "Data/яблоки.jfif";
            }
            if (((int)value) == 2)
            {
                return "Data/Молоко.jfif";
            }
            if (((int)value) == 3)
            {
                return "Data/Кофеварка.jfif";
            }
            if (((int)value) == 4)
            {
                return "Data/микроволновка.jfif";
            }
            return "Data/чайник.jpg";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }
    }



}
