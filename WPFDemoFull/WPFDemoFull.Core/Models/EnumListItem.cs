using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace WPFDemoFull.Core.Models;

public class EnumListItem
{
    public static IEnumerable<Dock> DockOptions { get => Enum.GetValues(typeof(Dock)) as IEnumerable<Dock>; }

    public static IEnumerable<HorizontalAlignment> HorizontalAlignmentOptions { get => Enum.GetValues(typeof(HorizontalAlignment)) as IEnumerable<HorizontalAlignment>; }

    public static IEnumerable<VerticalAlignment> VerticalAlignmentOptions { get => Enum.GetValues(typeof(VerticalAlignment)) as IEnumerable<VerticalAlignment>; }
}
