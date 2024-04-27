using System.Windows;
using System.Windows.Controls;
using WPFDemoFull.Core.Models;

namespace WPFDemoFull.ItemPanelTemplate;

/// <summary>
/// Interaction logic for PanelChild.xaml
/// </summary>
public partial class PanelChild : UserControl
{
    public PanelChild()
    {
        InitializeComponent();
        Loaded += PanelChild_Loaded;
        DataContext = this;
    }

    private void PanelChild_Loaded(object sender, RoutedEventArgs e)
    {
        DockInfos ??= new();
    }

    public DockInfo DockInfos
    {
        get { return (DockInfo)GetValue(DockInfosProperty); }
        set { SetValue(DockInfosProperty, value); }
    }

    // Using a DependencyProperty as the backing store for DockInfos.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty DockInfosProperty = DependencyProperty.Register(
        "DockInfos",
        typeof(DockInfo),
        typeof(PanelChild),
        new FrameworkPropertyMetadata(null, OnDockInfosChanged)
    );

    private static void OnDockInfosChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        ((PanelChild)d).DockInfos = (DockInfo)e.NewValue;
    }
}
