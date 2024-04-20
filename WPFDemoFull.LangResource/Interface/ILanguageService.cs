using System.Globalization;
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
    /// 修改语言的委托事件
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
    /// <summary>
    /// 取字典中 key 对应的 value
    /// </summary>
    /// <param name="key"></param>
    /// <returns></returns>
    string GetValue(string key);

    /// <summary>
    /// 获取所有语言
    /// </summary>
    /// <returns></returns>
    IEnumerable<CultureInfo> GetAllLanguage();
}
