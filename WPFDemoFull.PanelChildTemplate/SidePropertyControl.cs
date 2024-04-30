using Prism.Commands;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WPFDemoFull.Core.Models;

namespace WPFDemoFull.PanelChildTemplate;

/// <summary>
/// 按照步骤 1a 或 1b 操作，然后执行步骤 2 以在 XAML 文件中使用此自定义控件。
///
/// 步骤 1a) 在当前项目中存在的 XAML 文件中使用该自定义控件。
/// 将此 XmlNamespace 特性添加到要使用该特性的标记文件的根
/// 元素中:
///
///     xmlns:MyNamespace="clr-namespace:WPFDemoFull.PanelChildTemplate"
///
///
/// 步骤 1b) 在其他项目中存在的 XAML 文件中使用该自定义控件。
/// 将此 XmlNamespace 特性添加到要使用该特性的标记文件的根
/// 元素中:
///
///     xmlns:MyNamespace="clr-namespace:WPFDemoFull.PanelChildTemplate;assembly=WPFDemoFull.PanelChildTemplate"
///
/// 您还需要添加一个从 XAML 文件所在的项目到此项目的项目引用，
/// 并重新生成以避免编译错误:
///
///     在解决方案资源管理器中右击目标项目，然后依次单击
///     “添加引用”->“项目”->[浏览查找并选择此项目]
///
///
/// 步骤 2)
/// 继续操作并在 XAML 文件中使用控件。
///
///     <MyNamespace:SidePropertyControl/>
///
/// </summary>
public class SidePropertyControl : ContentControl
{
    static SidePropertyControl()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(SidePropertyControl), new FrameworkPropertyMetadata(typeof(SidePropertyControl)));
    }

    #region GroupBoxTitle

    public string GroupBoxTitle
    {
        get { return (string)GetValue(GroupBoxTitleProperty); }
        set { SetValue(GroupBoxTitleProperty, value); }
    }

    // Using a DependencyProperty as the backing store for GroupBoxTitle.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty GroupBoxTitleProperty = DependencyProperty.Register(
        "GroupBoxTitle",
        typeof(string),
        typeof(SidePropertyControl)
    );

    #endregion


    #region Url


    public SidePropertyPanelModel SidePropertyPanelModel
    {
        get { return (SidePropertyPanelModel)GetValue(SidePropertyPanelModelProperty); }
        set { SetValue(SidePropertyPanelModelProperty, value); }
    }

    // Using a DependencyProperty as the backing store for SidePropertyPanelModel.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty SidePropertyPanelModelProperty =
        DependencyProperty.Register("SidePropertyPanelModel", typeof(SidePropertyPanelModel), typeof(SidePropertyControl), new PropertyMetadata((SidePropertyPanelModel)null));


    /// <summary>
    /// WPF 源码链接
    /// </summary>
    public LinkString SourceCodeUrl
    {
        get { return (LinkString)GetValue(SourceCodeUrlProperty); }
        set { SetValue(SourceCodeUrlProperty, value); }
    }

    /// <summary>
    /// 默认是微软官方开源代码
    /// </summary>

    public static readonly DependencyProperty SourceCodeUrlProperty = DependencyProperty.Register(
        "SourceCodeUrl",
        typeof(LinkString),
        typeof(SidePropertyControl),
        new PropertyMetadata(
                new LinkString("https://github.com/dotnet/wpf/tree/main")
        )
    );

    /// <summary>
    /// 微软定义链接
    /// </summary>
    public LinkString ControlDefineUrl
    {
        get { return (LinkString)GetValue(ControlDefineUrlProperty); }
        set { SetValue(ControlDefineUrlProperty, value); }
    }

    /// <summary>
    /// 默认是微软官方控件Control的开发文档
    /// </summary>
    public static readonly DependencyProperty ControlDefineUrlProperty = DependencyProperty.Register(
        "ControlDefineUrl",
        typeof(LinkString),
        typeof(SidePropertyControl),
        new PropertyMetadata(
            new LinkString("https://learn.microsoft.com/en-us/uwp/api/windows.ui.xaml.controls?view=winrt-22621")
        )
    );



    /// <summary>
    /// 当前模块的View源码
    /// </summary>
    public LinkString DemoViewUrl
    {
        get { return (LinkString)GetValue(DemoViewUrlProperty); }
        set { SetValue(DemoViewUrlProperty, value); }
    }

    /// <summary>
    /// 默认为当前解决方案的GitHub地址
    /// </summary>
    public static readonly DependencyProperty DemoViewUrlProperty = DependencyProperty.Register(
        "DemoViewUrl",
        typeof(LinkString),
        typeof(SidePropertyControl),
        new PropertyMetadata(
            new LinkString("https://github.com/huangj1e/WPFDemoFull")
        )
    );


    /// <summary>
    /// 当前模块的 ViewModel 源码
    /// </summary>
    public LinkString DemoViewModelUrl
    {
        get { return (LinkString)GetValue(DemoViewModelUrlProperty); }
        set { SetValue(DemoViewModelUrlProperty, value); }
    }

    /// <summary>
    /// 默认为当前解决方案的GitHub地址
    /// </summary>
    public static readonly DependencyProperty DemoViewModelUrlProperty = DependencyProperty.Register(
        "DemoViewModelUrl",
        typeof(LinkString),
        typeof(SidePropertyControl),
        new PropertyMetadata(
            new LinkString("https://github.com/huangj1e/WPFDemoFull"))
    );

    #endregion

    #region OpenUrlCommand 
    public static readonly DependencyProperty OpenUrlCommandProperty = DependencyProperty.Register(
        "OpenUrlCommand",
        typeof(ICommand),
        typeof(SidePropertyControl),
        new PropertyMetadata(new DelegateCommand<object>(ExecOpenUrl)));
    private static void ExecOpenUrl(object obj)
    {
        if (obj is LinkString link)
            link.OpenUrl();
    }

    /// <summary>
    /// 此属性用于打开链接，不需在外部绑定
    /// </summary>
    public ICommand OpenUrlCommand
    {
        get { return (ICommand)GetValue(OpenUrlCommandProperty); }
        set { SetValue(OpenUrlCommandProperty, value); }
    }

    // Using a DependencyProperty as the backing store for OpenUrlCommand.  This enables animation, styling, binding, etc...
    #endregion

    #region ResetCommand

    public static readonly DependencyProperty ResetCommandProperty = DependencyProperty.Register(
        "ResetCommand",
        typeof(ICommand),
        typeof(SidePropertyControl)
    );

    /// <summary>
    /// 重置按钮的命令
    /// </summary>
    public ICommand ResetCommand
    {
        get { return (ICommand)GetValue(ResetCommandProperty); }
        set { SetValue(ResetCommandProperty, value); }
    }

    public static readonly DependencyProperty CommandParameterProperty = DependencyProperty.Register(
        "CommandParameter",
        typeof(object),
        typeof(SidePropertyControl));

    /// <summary>
    /// 重置按钮执行的参数，预留的
    /// </summary>
    public object CommandParameter
    {
        get { return GetValue(CommandParameterProperty); }
        set { SetValue(CommandParameterProperty, value); }
    }

    #endregion
}
