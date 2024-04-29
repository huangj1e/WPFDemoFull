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


    public LinkString SourceCodeUrl
    {
        get { return (LinkString)GetValue(SourceCodeUrlProperty); }
        set { SetValue(SourceCodeUrlProperty, value); }
    }

    // Using a DependencyProperty as the backing store for SourceCodeUrl.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty SourceCodeUrlProperty = DependencyProperty.Register(
        "SourceCodeUrl",
        typeof(LinkString),
        typeof(SidePropertyControl));

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

    public ICommand OpenUrlCommand
    {
        get { return (ICommand)GetValue(OpenUrlCommandProperty); }
        set { SetValue(OpenUrlCommandProperty, value); }
    }

    // Using a DependencyProperty as the backing store for OpenUrlCommand.  This enables animation, styling, binding, etc...
    #endregion

    #region ResetCommand

    public static readonly DependencyProperty CommandProperty = DependencyProperty.Register(
        "Command",
        typeof(ICommand),
        typeof(SidePropertyControl)
    );

    /// <summary>
    /// 按钮的命令
    /// </summary>
    public ICommand Command
    {
        get { return (ICommand)GetValue(CommandProperty); }
        set { SetValue(CommandProperty, value); }
    }

    public static readonly DependencyProperty CommandParameterProperty = DependencyProperty.Register(
        "CommandParameter",
        typeof(object),
        typeof(SidePropertyControl));

    /// <summary>
    /// 按钮执行的参数
    /// </summary>
    public object CommandParameter
    {
        get { return GetValue(CommandParameterProperty); }
        set { SetValue(CommandParameterProperty, value); }
    }

    #endregion
}
