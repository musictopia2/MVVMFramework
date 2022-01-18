namespace MVVMFramework.ViewModels;
public interface IBlazorParent<VM> : IHandle<OpenEventModel>, IHandle<CloseEventModel>
    where VM : ScreenViewModel
{
}