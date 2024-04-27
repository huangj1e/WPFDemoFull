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

    public DockInfo(int index = 0, double width = 200, double height = 450)
    {
        Index = index;
        Width = width;
        Height = height;
    }
}