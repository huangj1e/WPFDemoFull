using Prism.Mvvm;

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
        set
        {
            if (value == 1) value = 0;
            SetProperty(ref _row, value);
        }
    }
}
