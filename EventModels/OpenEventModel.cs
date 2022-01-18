namespace MVVMFramework.EventModels;
public class OpenEventModel
{
    public IScreen ViewModelUsed { get; set; }
    public OpenEventModel(IScreen viewModelUsed)
    {
        ViewModelUsed = viewModelUsed;
    }
}