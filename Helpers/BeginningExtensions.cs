namespace MVVMFramework.Helpers;
public static class BeginningExtensions
{
    public static void Ask(this IEventAggregator aggregator, Type type)
    {
        aggregator.PublishAll(new AskEventModel(), type.Name); //try publishall to attempt to avoid the duplicate problem (could cause to be freaky but the risk i have to take)
    }
    public static void OpenView(this IScreen screen)
    {
        OpenEventModel open = new(screen);
        screen.Aggregator.PublishAll(open, screen.GetType().Name);
    }
    public static void CloseView(this IScreen screen)
    {
        screen.Aggregator.PublishAll(new CloseEventModel(), screen.GetType().Name); //trying to do publishall for all three for the mvvm framework.  taking a huge risk.  since its used for one specific purpose, testing it.
    }
}