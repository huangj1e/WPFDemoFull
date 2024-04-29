using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFDemoFull.Core.Tools;

namespace WPFDemoFull.Core.Models;

/// <summary>
/// 有打开链接功能的字符串
/// </summary>
public class LinkString
{
    public LinkString(string url)
    {
        Url = url;
    }
    private string Url { get; set; }

    public void OpenUrl()
    {
        Link.OpenInBrowser(Url);
    }
    public override string ToString() => Url;
}
