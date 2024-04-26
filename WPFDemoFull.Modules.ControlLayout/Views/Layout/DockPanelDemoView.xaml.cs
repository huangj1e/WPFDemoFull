using System.Windows.Controls;

namespace WPFDemoFull.Modules.ControlLayout.Views.Layout;

/// <summary>
/// Interaction logic for DockPanelDemoView
/// </summary>
public partial class DockPanelDemoView : UserControl
{
    public DockPanelDemoView()
    {
        InitializeComponent();
    }

    /// <summary>
    /// 触发鼠标滚轮事件
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void TextBox_PreviewMouseWheel(object sender, System.Windows.Input.MouseWheelEventArgs e)
    {
        if (sender is TextBox textBoxTemp)
        {
            int textBoxNumver = int.Parse(textBoxTemp.Text);

            if (e.Delta < 0)
                textBoxNumver+=10;
            else
                textBoxNumver-=10;
            textBoxTemp.Text = textBoxNumver.ToString();
        }
    }
}
