using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

    public void ChangeLanguage(string lang) => OnChangeLanguage?.Invoke(lang);


    public string GetValue(string key) => (string)ResourceDictionary[key];

    public void SwitchDictionary(ResourceDictionary dic) => ResourceDictionary = dic;
}
