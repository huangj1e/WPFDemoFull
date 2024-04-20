using System.Globalization;
using System.Windows;
using WPFDemoFull.LangResource.Interface;

namespace WPFDemoFull.LangResource.Service;

public class LanguageService : ILanguageService
{
    public LanguageService(ResourceDictionary resourceDictionary)
    {
        ResourceDictionary = resourceDictionary;
        foreach (ResourceDictionary dictionary in Application.Current.Resources.MergedDictionaries)
        {
            if (dictionary.Source != null)
                if (dictionary.Source.AbsoluteUri.Contains("pack://application:,,,/WPFDemoFull.LangResource;component/Resources/"))
                    DictionaryList.Add(dictionary);
        }
    }

    /// <summary>
    /// 多语言字典
    /// </summary>
    public ResourceDictionary ResourceDictionary { get; set; }
    public List<ResourceDictionary> DictionaryList { get; set; } = new();

    public event ChangeLanguageDelegate? OnChangeLanguage;

    public void ChangeLanguage(string lang)
    {
        OnChangeLanguage?.Invoke(lang);
        ResourceDictionary = DictionaryList.FirstOrDefault(d => d.Source.OriginalString.Contains(lang));
    }

    public IEnumerable<CultureInfo> GetAllLanguage()
    {
        // 获取系统中所有可用的语言列表
        return CultureInfo.GetCultures(CultureTypes.AllCultures)
            .Where(cultureInfo => !cultureInfo.Equals(CultureInfo.InvariantCulture));
    }

    public string GetValue(string key) => (string)ResourceDictionary[key];

    public void SwitchDictionary(ResourceDictionary dic) => ResourceDictionary = dic;
}
