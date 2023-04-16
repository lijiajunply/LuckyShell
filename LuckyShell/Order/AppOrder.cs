namespace LuckyShell.Order;

public class AppOrder : ShellOrder
{
    public AppOrder(string appName, string[] args)
    {
        AppName = appName;
        Args = args;
    }

    public string AppName { get; set; }
    public string[] Args { get; set; }
    public void Run()
    {
        throw new NotImplementedException();
    }
}