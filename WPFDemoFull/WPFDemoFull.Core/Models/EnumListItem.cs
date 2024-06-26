﻿using MaterialDesignThemes.Wpf.Transitions;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace WPFDemoFull.Core.Models;


/// <summary>
/// 从枚举类型中获取枚举的列表
/// </summary>
public class EnumListItem
{
    public static IEnumerable<TransitionEffectKind> TransitionEffectKindOptions { get => Enum.GetValues(typeof(TransitionEffectKind)) as IEnumerable<TransitionEffectKind>; }

    public static IEnumerable<Dock> DockOptions { get => Enum.GetValues(typeof(Dock)) as IEnumerable<Dock>; }

    public static IEnumerable<HorizontalAlignment> HorizontalAlignmentOptions { get => Enum.GetValues(typeof(HorizontalAlignment)) as IEnumerable<HorizontalAlignment>; }

    public static IEnumerable<VerticalAlignment> VerticalAlignmentOptions { get => Enum.GetValues(typeof(VerticalAlignment)) as IEnumerable<VerticalAlignment>; }


    public static IEnumerable<Orientation> OrientationOptions { get => Enum.GetValues(typeof(Orientation)) as IEnumerable<Orientation>; }

    public static IEnumerable<TextAlignment> TextAlignmentOptions { get => Enum.GetValues(typeof(TextAlignment)) as IEnumerable<TextAlignment>; }
}
