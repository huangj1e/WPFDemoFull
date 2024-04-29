using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFDemoFull.Core.Models;

/// <summary>
/// 因为这些值只会定义一次所以不用继承 BindableBase
/// </summary>
public class SidePropertyPanelModel
{
    /// <summary>
    /// GroupBoxTitle
    /// </summary>
    public string GroupBoxTitle { get; set; }

    /// <summary>
    /// 重置控件的命令
    /// </summary>
    public DelegateCommand ResetControlCommand { get; set; }

    /// <summary>
    /// WPF 源码链接
    /// </summary>
    public string SourceCodeUrl { get; set; }


    /// <summary>
    /// 微软定义链接
    /// </summary>
    public string ControlDefinedUrl { get; set; }

    /// <summary>
    /// 当前页面Xaml源码 
    /// </summary>
    public string DemoViewUrl { get; set; }

    /// <summary>
    /// 当前页面ViewModel源码
    /// </summary>
    public string DemoViewModelUrl { get; set; }
}
