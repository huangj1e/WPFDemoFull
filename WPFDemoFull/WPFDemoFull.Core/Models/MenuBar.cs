using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFDemoFull.Core.Models;

public class MenuBar:BindableBase
{
	private string _name;

	/// <summary>
	/// 名称
	/// </summary>
	public string Name
	{
		get { return _name; }
		set { SetProperty(ref _name, value); }
	}

	private string _icon;

	public string Icon
	{
		get { return _icon; }
		set { SetProperty(ref _icon, value); }
	}

	private string _navViewName;

	public string NavViewName
	{
		get { return _navViewName; }
		set { SetProperty(ref _navViewName, value); }
	}

	private string _title;

	public string Title
	{
		get { return _title; }
		set { SetProperty(ref _title, value); }
	}

}
