using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPFDemoFull.LangResource.Interface;

/// <summary>
/// 修改语言的委托
/// </summary>
/// <param name="lang"></param>
public delegate void ChangeLanguageDelegate(string lang);

public interface ILanguageService
{
    /// <summary>
    /// 修改语言的事件
    /// </summary>
    event ChangeLanguageDelegate OnChangeLanguage;
    /// <summary>
    /// 动态修改语言的方法
    /// </summary>
    /// <param name="lang"></param>
    void ChangeLanguage(string lang);

    /// <summary>
    /// 多语言字典
    /// </summary>
    ResourceDictionary ResourceDictionary { get; set; }
    /// <summary>
    /// 切换字典
    /// </summary>
    /// <param name="dic"></param>
    void SwitchDictionary(ResourceDictionary dic);

    List<ResourceDictionary> DictionaryList { get; set; }
    /// 取字典中 key 对应的 value
    /// </summary>
    /// <param name="key"></param>
    /// <returns></returns>
    string GetValue(string key);
}
