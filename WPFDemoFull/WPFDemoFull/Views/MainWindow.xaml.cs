using System.Collections.Generic;
using System.Linq;
using System.Windows;
using WPFDemoFull.LangResource.Interface;

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

        //获取当前系统使用的语言名称
        string currentCulture = System.Globalization.CultureInfo.CurrentCulture.Name;

        _languageService.ChangeLanguage(currentCulture);
    }

    /// <summary>
    /// 主程序中实际修改语言的方法
    /// 这样的委托可以实现多个地方同时修改语言
    /// </summary>
    /// <param name="culture">
    /// 输入值如下：
    /// <list type="table">
    /// <item>en_US</item>
    /// <item>zh_Hans</item>
    /// <item>zh_TW</item>
    /// </list>
    /// </param>
    private void OnLangChange(string culture)
    {
        List<ResourceDictionary> dictionaryList = new();
        foreach (ResourceDictionary dictionary in Application.Current.Resources.MergedDictionaries)
        {
            dictionaryList.Add(dictionary);
        }

        string requestedCulture = string.Format(@"pack://application:,,,/WPFDemoFull.LangResource;component/Resources/StringResource.{0}.xaml", culture);
        ResourceDictionary resourceDictionary = null;

        if (dictionaryList.Any(d => d.Source?.OriginalString == requestedCulture))
        {
            /*
                 想要在资源清单中加载字典文件，需要在App.Xaml中添加如下代码：
                     <LanguageDictionary>
                         <LanguageDictionary.MergedDictionaries>
                             <LanguageDictionary Source="pack://application:,,,/WPFDemoFull.LangResource;component/Resources/StringResource.xaml"/>
                         </LanguageDictionary.MergedDictionaries>
                     </LanguageDictionary>
                 */
            resourceDictionary = dictionaryList.FirstOrDefault(d => d.Source.OriginalString.Equals(requestedCulture));
        }
        else
        {
            //加载默认语言
            requestedCulture = @"pack://application:,,,/WPFDemoFull.LangResource;component/Resources/StringResource.xaml";
            resourceDictionary = dictionaryList.FirstOrDefault(d => d.Source?.OriginalString == requestedCulture);
        }

        if (resourceDictionary != null)
        {
            //通过删除再添加的方式，实现刷新
            Application.Current.Resources.MergedDictionaries.Remove(resourceDictionary);
            Application.Current.Resources.MergedDictionaries.Add(resourceDictionary);
        }
    }
}
