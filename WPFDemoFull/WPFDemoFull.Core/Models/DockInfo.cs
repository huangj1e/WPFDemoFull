using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WPFDemoFull.Core.Models;

public class DockInfo : BindableBase
{




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

    public DockInfo(int index, double width = 200, double height = 200)
    {
        Index = index;
        Width = width;
        Height = height;
    }

    public double Height
    {
        get { return _height; }
        set { SetProperty(ref _height, value); }
    }
}