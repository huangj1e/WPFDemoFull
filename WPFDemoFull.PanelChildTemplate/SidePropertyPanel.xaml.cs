using System.Windows;
using System.Windows.Controls;
using WPFDemoFull.Core.Models;
using WPFDemoFull.Core.Tools;

namespace WPFDemoFull.PanelChildTemplate;

/// <summary>
/// SidePropertyPanel.xaml 的交互逻辑
/// </summary>
public partial class SidePropertyPanel : ContentControl
{
    public SidePropertyPanel() => InitializeComponent();
    private SidePropertyPanelModel? ConversionType()
        => (DataContext is SidePropertyPanelModel model) ? model : null;

    private void OpenControlDefined(object sender, RoutedEventArgs e)
        => ConversionType()?.ControlDefinedUrl.OpenUrl();

    private void OpenWPFSourceCode(object sender, RoutedEventArgs e)
        => ConversionType()?.SourceCodeUrl.OpenUrl();

    private void OpenDemoView(object sender, RoutedEventArgs e)
        => ConversionType()?.DemoViewUrl.OpenUrl();

    private void OpenDemoViewModel(object sender, RoutedEventArgs e)
        => ConversionType()?.DemoViewModelUrl.OpenUrl();
}
