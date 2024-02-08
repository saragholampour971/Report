namespace ReportManager;

public interface ISubMenu
{
    string Label { get; }

    Func<string> Result { get;  }
}

public class Report
{
    public string Label { get;  }

    public List<ISubMenu> SubMenus { get;  }
    public Report(){}
}

public class SubMenu : ISubMenu
{
    public string Label { get; }

    public Func<string> Result { get; }


    public SubMenu(string label, Func<string> result)
    {
        Label = label;
        Result = result;
    }
}

