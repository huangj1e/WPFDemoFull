using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFDemoFull.Core.Models;

namespace WPFDemoFull.PanelChildTemplate;

/// <summary>
/// DockChildControl.xaml 的交互逻辑
/// </summary>
public partial class DockChildControl : UserControl
{
    public DockChildControl()
    {
        InitializeComponent();
        DataContext = DockInfos;
    }




    [Bindable(true)]
    public DockInfo DockInfos
    {
        get { return (DockInfo)GetValue(DockInfosProperty); }
        set { SetValue(DockInfosProperty, value); }
    }

    // Using a DependencyProperty as the backing store for DockInfos.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty DockInfosProperty = DependencyProperty.Register(
        "DockInfos",
        typeof(DockInfo),
        typeof(DockChildControl),
        new FrameworkPropertyMetadata(
        new DockInfo(),
        new PropertyChangedCallback(OnDockInfosChanged)
        )
    );

    private static void OnDockInfosChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        ((DockChildControl)d).DockInfos = (DockInfo)e.NewValue;
    }


    [Bindable(true)]
    public int Title
    {
        get { return (int)GetValue(TitleProperty); }
        set { SetValue(TitleProperty, value); }
    }

    // Using a DependencyProperty as the backing store for Title.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty TitleProperty =
        DependencyProperty.Register("Title", typeof(int), typeof(DockChildControl), new PropertyMetadata(6, new PropertyChangedCallback(OnTitleChange)));

    private static void OnTitleChange(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        ((DockChildControl)d).UpdateTitle((int)e.NewValue);
    }

    private void UpdateTitle(int value)
    {
        DockInfos = new(value);
    }
}
