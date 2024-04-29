using Prism.Mvvm;

namespace WPFDemoFull.Core.Models;


/// <summary>
/// 控件Grid 的子项布局信息
/// </summary>
public class GridInfo : BindableBase
{
    /// <summary>
    /// 修改Grid 的 Name
    /// </summary>
    /// <param _name="name"></param>
    public void ChangeName(string name) => Name = name;

    private string _name;

    public string Name
    {
        get { return _name; }
        set { SetProperty(ref _name, value); }
    }

    private int _col;
    /// <summary>
    /// 用于绑定 Grid.Column
    /// </summary>

    public int Column
    {
        get { return _col; }
        set { SetProperty(ref _col, value); }
    }

    private int _row;

    /// <summary>
    /// 用于绑定 Grid.Row
    /// </summary>
    public int Row
    {
        get { return _row; }
        set
        {
            if (value == 1) value = 0;
            SetProperty(ref _row, value);
        }
    }
}
