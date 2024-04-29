using System;
using System.Globalization;
using System.Windows.Controls;
using System.Windows.Data;

namespace WPFDemoFull.Core.Converters;

/// <summary>
/// bool 转化为 Orientation
/// <list type="bullet">
/// <item> false => Orientation.Horizontal</item>
/// <item> true => Orientation.Vertical </item>
/// </list>
/// </summary>
/// 
public class BoolToOrientationConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is bool b)
        {
            return b ? Orientation.Vertical : Orientation.Horizontal;
        }
        return Orientation.Horizontal;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is Orientation o)
        {
            return o == Orientation.Vertical;
        }
        return false;
    }
}
