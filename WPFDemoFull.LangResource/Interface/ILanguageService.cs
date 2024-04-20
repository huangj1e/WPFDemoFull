using System.Globalization;
using System.Windows;

namespace WPFDemoFull.LangResource.Interface;

/// <summary>
/// 修改语言的委托
/// </summary>
/// <param name="lang"></param>
public delegate void ChangeLanguageDelegate(string lang);

/// <summary>
/// 全球化多语言服务接口
/// </summary>
public interface ILanguageService
{
    #region 事件
    /// <summary>
    /// 修改语言的委托事件
    /// </summary>
    event ChangeLanguageDelegate OnChangeLanguage;
    #endregion

    #region 属性

    /// <summary>
    /// 多语言字典,用于在代码中访问多语言资源，全局只有一个
    /// </summary>
    static ResourceDictionary? LanguageDictionary { get; set; }

    /// <summary>
    /// 资源的所有语言字典
    /// </summary>
    List<ResourceDictionary> LanguageDictionaryList { get; set; }
    #endregion

    #region 方法
    /// <summary>
    /// 动态修改语言的方法
    /// </summary>
    /// <param name="lang"></param>
    void ChangeLanguage(string lang);
    /// <summary>
    /// 切换字典
    /// </summary>
    /// <param name="dic"></param>
    void SwitchDictionary(ResourceDictionary dic);

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
    #endregion
}
