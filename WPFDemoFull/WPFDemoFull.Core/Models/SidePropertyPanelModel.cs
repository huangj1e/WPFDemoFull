using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WPFDemoFull.Core.Models;

/// <summary>
/// 因为这些值只会定义一次所以不用继承 BindableBase
/// </summary>
public class SidePropertyPanelModel : DependencyObject
{
    /// <summary>
    /// GroupBoxTitle
    /// </summary>
    //public string GroupBoxTitle { get; set; }

    public string GroupBoxTitle
    {
        get { return (string)GetValue(GroupBoxTitleProperty); }
        set { SetValue(GroupBoxTitleProperty, value); }
    }

    // Using a DependencyProperty as the backing store for GroupBoxTitle.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty GroupBoxTitleProperty =
        DependencyProperty.Register("GroupBoxTitle", typeof(string), typeof(SidePropertyPanelModel), new PropertyMetadata(0));


    /// <summary>
    /// WPF 源码链接
    /// </summary>
    public LinkString SourceCodeUrl { get; set; }

    /// <summary>
    /// 微软定义链接
    /// </summary>
    public LinkString ControlDefinedUrl { get; set; }

    /// <summary>
    /// 当前页面Xaml源码 
    /// </summary>
    public LinkString DemoViewUrl { get; set; }

    /// <summary>
    /// 当前页面ViewModel源码
    /// </summary>
    public LinkString DemoViewModelUrl { get; set; }

    /// <summary>
    /// 重置控件的命令
    /// </summary>
    public ICommand Command { get; set; }

    public object CommandParameter { get; set; }
}
