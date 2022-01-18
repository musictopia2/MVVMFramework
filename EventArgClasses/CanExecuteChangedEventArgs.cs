namespace MVVMFramework.EventArgClasses;
public delegate void CanExecuteChangedEventHandler(object sender, CanExecuteChangedEventArgs e);
public class CanExecuteChangedEventArgs : EventArgs
{
    public string Name { get; set; }
    public CanExecuteChangedEventArgs(string name)
    {
        Name = name;
    }
}