using System.Globalization;
using System.Windows;
using WPFDemoFull.LangResource.Interface;

namespace WPFDemoFull.LangResource.Service;

public class LanguageService : ILanguageService
{
    public LanguageService()
    {
        foreach (ResourceDictionary dictionary in Application.Current.Resources.MergedDictionaries)
        {
            if (dictionary.Source != null)
                if (dictionary.Source.AbsoluteUri.Contains("pack://application:,,,/WPFDemoFull.LangResource;component/Resources/"))
                    LanguageDictionaryList.Add(dictionary);
        }
    }

    public List<ResourceDictionary> LanguageDictionaryList { get; set; } = new();

    public event ChangeLanguageDelegate? OnChangeLanguage;

    public void ChangeLanguage(string lang)
    {
        //执行修改语言的委托事件 在app.xaml.cs中实现修改语言的方法
        //完成在xaml 中动态修改语言
        OnChangeLanguage?.Invoke(lang);

        //触发修改语言事件之后 还要修改当前的语言字典，这样才能在cs代码中访问到修改后的语言
        ResourceDictionary? dic = LanguageDictionaryList.FirstOrDefault(d => d.Source.OriginalString.Contains(lang));
        SwitchDictionary(dic);
    }

    public IEnumerable<CultureInfo> GetAllLanguage()
    {
        // 获取系统中所有可用的语言列表
        return CultureInfo.GetCultures(CultureTypes.AllCultures)
            .Where(cultureInfo => !cultureInfo.Equals(CultureInfo.InvariantCulture));
    }

    public string GetValue(string key)
    {
        string result = ILanguageService.LanguageDictionary?[key] as string ?? string.Empty;
        return result;
    }

    public void SwitchDictionary(ResourceDictionary? dic)
    {
        if (dic != null)
            ILanguageService.LanguageDictionary = dic;
    }
}
