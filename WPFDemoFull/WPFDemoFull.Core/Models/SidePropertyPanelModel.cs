using Prism.Commands;
using System;
using System.ComponentModel;
using System.Windows.Controls;
using System.Windows.Input;

namespace WPFDemoFull.Core.Models;

/// <summary>
/// 因为这些值只会定义一次所以不用继承 BindableBase
/// </summary>
public class SidePropertyPanelModel
{
    #region 构造函数
    public SidePropertyPanelModel()
    {
    }
    /// <summary>
    /// 用于初始化右边侧边栏的属性
    /// </summary>
    /// <param name="groupBoxTitle">标题</param>
    /// <param name="sourceCodeUrl">WPF开源代码链接</param>
    /// <param name="controlDefinedUrl">微软官方定义链接</param>
    /// <param name="demoViewUrl">解决方案页面的Xaml代码</param>
    /// <param name="demoViewModelUrl">解决方案页面的ViewModel代码</param>
    /// <param name="command"></param>
    public SidePropertyPanelModel(
        string groupBoxTitle,
        string sourceCodeUrl,
        string controlDefinedUrl,
        string demoViewUrl,
        string demoViewModelUrl,
        ICommand resetCommand = null)
    {
        GroupBoxTitle = groupBoxTitle;
        SourceCodeUrl = sourceCodeUrl;
        ControlDefinedUrl = controlDefinedUrl;
        DemoViewUrl = demoViewUrl;
        DemoViewModelUrl = demoViewModelUrl;
        ResetCommand = resetCommand;
    }

    #endregion

    #region 属性
    /// <summary>
    /// GroupBoxTitle
    /// </summary>
    [Bindable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public string GroupBoxTitle { get; set; }
    /// <summary>
    /// WPF 源码链接
    /// </summary>
    [Bindable(true)]
    public string SourceCodeUrl { get; set; }

    /// <summary>
    /// 微软定义链接
    /// </summary>
    [Bindable(true)]
    public string ControlDefinedUrl { get; set; }

    /// <summary>
    /// 当前页面Xaml源码 
    /// </summary>
    [Bindable(true)]
    public string DemoViewUrl { get; set; }

    /// <summary>
    /// 当前页面ViewModel源码
    /// </summary>
    [Bindable(true)]
    public string DemoViewModelUrl { get; set; }

    /// <summary>
    /// 重置控件的命令
    /// </summary>
    public ICommand ResetCommand { get; set; }

    /// <summary>
    /// 虚方法
    /// </summary>
    public virtual void ExecuteResetCommand() { }

    /// <summary>
    /// 预留的委托命令参数
    /// </summary>
    public object CommandParameter { get; set; }

    #endregion
}
