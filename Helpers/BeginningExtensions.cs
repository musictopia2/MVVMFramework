namespace MVVMFramework.Helpers;
public static class BeginningExtensions
{
    public static void Ask(this IEventAggregator aggregator, Type type)
    {
        aggregator.Publish(new AskEventModel(), type.Name);
    }
    public static void OpenView(this IScreen screen)
    {
        OpenEventModel open = new(screen);
        screen.Aggregator.Publish(open, screen.GetType().Name);
    }
    public static void CloseView(this IScreen screen)
    {
        screen.Aggregator.Publish(new CloseEventModel(), screen.GetType().Name);
    }
}