using Prism.Events;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using WPFDemoFull.Core.EventArgs;
using WPFDemoFull.LangResource.Interface;
using WPFDemoFull.LangResource.Service;

namespace WPFDemoFull.Views;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private readonly ILanguageService _languageService;

    public MainWindow(ILanguageService languageService)
    {
        InitializeComponent();
        _languageService = languageService;
        _languageService.OnChangeLanguage += OnLangChange;
        //_languageService.ChangeLanguage("zh-CN");
        _languageService.ChangeLanguage("zh-Hans");
    }

    /// <summary>
    /// 主程序中实际修改语言的方法
    /// </summary>
    /// <param name="culture"></param>
    private void OnLangChange(string culture)
    {
        List<ResourceDictionary> dictionaryList = new();
        foreach (ResourceDictionary dictionary in Application.Current.Resources.MergedDictionaries)
        {
            dictionaryList.Add(dictionary);
        }

        string requestedCulture = string.Format(@"pack://application:,,,/WPFDemoFull.LangResource;component/Resources/StringResource.{0}.xaml", culture);
        ResourceDictionary resourceDictionary = null;
        try
        {
            resourceDictionary = dictionaryList.FirstOrDefault(d => d.Source.OriginalString.Equals(requestedCulture));
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
        }

        if (resourceDictionary == null)
        {
            //加载默认语言
            requestedCulture = @"pack://application:,,,/WPFDemoFull.LangResource;component/Resources/StringResource.xaml";
            resourceDictionary = dictionaryList.FirstOrDefault(d => d.Source.OriginalString.Equals(requestedCulture));
        }
        if (resourceDictionary != null)
        {
            //通过删除再添加的方式，实现刷新
            Application.Current.Resources.MergedDictionaries.Remove(resourceDictionary);
            Application.Current.Resources.MergedDictionaries.Add(resourceDictionary);
        }
    }
}
