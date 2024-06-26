﻿using Prism.Ioc;
using Prism.Modularity;
using System.Windows;
using WPFDemoFull.LangResource.Interface;
using WPFDemoFull.LangResource.Service;
using WPFDemoFull.Modules.ControlLayout;
using WPFDemoFull.Services;
using WPFDemoFull.Services.Interfaces;
using WPFDemoFull.Views;

namespace WPFDemoFull
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //注册服务
            containerRegistry.RegisterSingleton<IMessageService, MessageService>();
            containerRegistry.RegisterSingleton<ILanguageService, LanguageService>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            //注册模块
            //moduleCatalog.AddModule<ModuleNameModule>();
            moduleCatalog.AddModule<ControlLayoutModule>();
        }
    }
}
