using System.Windows.Controls;
using WPFDemoFull.Core.Tools;

namespace WPFDemoFull.Modules.ControlLayout.Views.Layout;

/// <summary>
/// Interaction logic for StackPanelDemoView
/// </summary>
public partial class StackPanelDemoView : UserControl
{
    public StackPanelDemoView() => InitializeComponent();

    private void OpenStackPanelDefined(object sender, System.Windows.RoutedEventArgs e) => 
        Link.OpenInBrowser(@"https://learn.microsoft.com/en-us/uwp/api/windows.ui.xaml.controls.stackpanel?view=winrt-22621");

    private void OpenStackPanelSourceCode(object sender, System.Windows.RoutedEventArgs e)
    {
        Link.OpenInBrowser(@"https://github.com/dotnet/wpf/blob/69680c66915b6e3d110db665dbdfd9ab9278851a/src/Microsoft.DotNet.Wpf/src/PresentationFramework/System/Windows/Controls/Stack.cs#L56");
    }

    //Link.OpenInBrowser("https://learn.microsoft.com/zh-cn/uwp/api/windows.ui.xaml.controls.stackpanel?view=winrt-22621");
}
