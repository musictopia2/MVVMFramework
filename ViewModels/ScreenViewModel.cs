namespace MVVMFramework.ViewModels;
public abstract partial class ScreenViewModel : IScreen, IHandle<AskEventModel>
{
    public IEventAggregator Aggregator { get; set; }
    public ScreenViewModel(IEventAggregator aggregator)
    {
        Aggregator = aggregator;
        OpenAggregator();
    }
    private partial void Subscribe();
    private partial void Unsubscribe();
    Task IScreen.ActivateAsync()
    {
        this.OpenView();
        return ActivateAsync();
    }
    protected virtual Task ActivateAsync()
    {
        return Task.CompletedTask;
    }
    void IHandle<AskEventModel>.Handle(AskEventModel message)
    {
        this.OpenView();
    }
    Task IScreen.TryCloseAsync()
    {
        return TryCloseAsync();
    }
    protected virtual void OpenAggregator()
    {
        Subscribe();
    }
    protected virtual void CloseAggregator()
    {
        Unsubscribe();
    }
    protected virtual Task TryCloseAsync()
    {
        this.CloseView();
        CloseAggregator();
        return Task.CompletedTask;
    }
}