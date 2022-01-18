namespace MVVMFramework.EventArgClasses;
public interface INotifyCanExecuteChanged //related to the other so decided to keep together.  not used too often though.
{
    event CanExecuteChangedEventHandler CanExecuteChanged;
}