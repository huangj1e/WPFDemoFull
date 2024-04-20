using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFDemoFull.Core.Models;

public class GridInfo : BindableBase
{
    /// <summary>
    /// 修改Grid 的 Name
    /// </summary>
    /// <param name="name"></param>
    public void ChangeName(string name) => Name = name;

    private string name;

    public string Name
    {
        get { return name; }
        set { SetProperty(ref name, value); }
    }

    private int _col;
    /// <summary>
    /// 用于绑定 Grid 的 Column
    /// </summary>

    public int Col
    {
        get { return _col; }
        set { SetProperty(ref _col, value); }
    }

    private int _row;

    /// <summary>
    /// 用于绑定 Grid 的 Row
    /// </summary>
    public int Row
    {
        get { return _row; }
        set { SetProperty(ref _row, value); }
    }
}
