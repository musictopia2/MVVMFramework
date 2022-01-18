namespace MVVMFramework.ViewModels;
public interface IScreen
{
    Task ActivateAsync(); //i don't think we need anything to exit app for the game package anyways.
    IEventAggregator Aggregator { get; }
    Task TryCloseAsync();
}