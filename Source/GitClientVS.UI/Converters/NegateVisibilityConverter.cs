﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GitClientVS.UI.Converters
{
    public class NegateVisibilityConverter : BaseMarkupExtensionConverter
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((Visibility)value) == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
