using System;
using System.Collections.Generic;
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
using WPFDemoFull.Core.Tools;

namespace WPFDemoFull.PanelChildTemplate;

/// <summary>
/// SidePropertyPanel.xaml 的交互逻辑
/// </summary>
public partial class SidePropertyPanel : UserControl
{
    public SidePropertyPanel() => InitializeComponent();

    private void OpenControlDefined(object sender, RoutedEventArgs e)
    {
        if (DataContext is SidePropertyPanelModel model )
            Link.OpenInBrowser(model.ControlDefinedUrl);
    }

    private void OpenWPFSourceCode(object sender, RoutedEventArgs e)
    {
            Link.OpenInBrowser(ConversionType()?.SourceCodeUrl);
    }

    private SidePropertyPanelModel? ConversionType()
    {
        if (DataContext is SidePropertyPanelModel model)
            return model;
        return null;
    }
}
