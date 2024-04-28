using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace WPFDemoFull.Core.Converters;

/// <summary>
///  Bool 转化为 Visibility
///  <list type="bullet">
/// <item>false => Visibility.Collapsed || Visibility.Hiden</item> 
/// <item>true => Visibility.Visible </item>
/// </list>
/// </summary>
public class BoolToVisibilityConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is bool && (bool)value)
            return Visibility.Visible;
        else
            return Visibility.Collapsed;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return value is Visibility visibility && visibility == Visibility.Visible;
    }
}
