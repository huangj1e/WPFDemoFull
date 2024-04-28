using Prism.Mvvm;
using System.Windows;
using System.Windows.Controls;

namespace WPFDemoFull.Core.Models;

public class DockInfo : BindableBase
{
    private HorizontalAlignment _horizontalAlignment;
    public HorizontalAlignment HorizontalAlignment
    {
        get { return _horizontalAlignment; }
        set { SetProperty(ref _horizontalAlignment, value); }
    }

    private HorizontalAlignment _horizontalContentAlignment;

    public HorizontalAlignment HorizontalContentAlignment
    {
        get { return _horizontalContentAlignment; }
        set { SetProperty(ref _horizontalContentAlignment, value); }
    }

    private VerticalAlignment _verticalAlignment;

    public VerticalAlignment VerticalAlignment
    {
        get { return _verticalAlignment; }
        set { SetProperty(ref _verticalAlignment, value); }
    }

    private VerticalAlignment _verticalContentAlignment;

    public VerticalAlignment VerticalContentAlignment
    {
        get { return _verticalContentAlignment; }
        set { SetProperty(ref _verticalContentAlignment, value); }
    }

    private int _index;

    public int Index
    {
        get { return _index; }
        set { SetProperty(ref _index, value); }
    }


    private Dock _selectedDock;
    public Dock SelectedDock
    {
        get { return _selectedDock; }
        set { SetProperty(ref _selectedDock, value); }
    }

    private double _width;

    public double Width
    {
        get { return _width; }
        set { SetProperty(ref _width, value); }
    }

    private double _height;

    public double Height
    {
        get { return _height; }
        set { SetProperty(ref _height, value); }
    }

    private bool _isshowDockOptions;

    public bool IsShowDockOptions
    {
        get { return _isshowDockOptions; }
        set { SetProperty(ref _isshowDockOptions, value); }
    }

    /// <summary>
    /// 显示Dock选项
    /// </summary>
    public void ShowDockOptions() => IsShowDockOptions = true;
    /// <summary>
    /// 隐藏Dock选项
    /// </summary>
    public void HideDockOptions() => IsShowDockOptions = false;

    /// <summary>
    /// 一个示例用的用户控件Model
    /// </summary>
    /// <param name="index">控件Id，用于分辨外观相同的不同控件</param>
    /// <param name="isshowDockOptions">是否显示DockOptions ComboBox</param>
    /// <param name="width">控件的初始宽</param>
    /// <param name="height">控件的初始高</param>
    public DockInfo(
        int index = 0,
        bool isshowDockOptions = false,
        double width = 200,
        double height = 450)
    {
        Index = index;
        IsShowDockOptions = isshowDockOptions;
        Width = width;
        Height = height;
    }
}