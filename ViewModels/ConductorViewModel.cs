namespace MVVMFramework.ViewModels;
public class ConductorViewModel : ScreenViewModel
{
    public ConductorViewModel(IEventAggregator aggregator) : base(aggregator)
    {
    }
    protected static Task LoadScreenAsync(IScreen viewModel)
    {
        return viewModel.ActivateAsync();
    }
    virtual protected Task CloseSpecificChildAsync(IScreen viewModel)
    {
        return viewModel.TryCloseAsync();
    }
}