namespace LuckyShell.Order;

public class OrderApp : ShellOrder
{
    public OrderApp(string appName, string[] args)
    {
        AppName = appName;
        Args = args;
    }

    public string AppName { get; set; }
    public string[] Args { get; set; }
}