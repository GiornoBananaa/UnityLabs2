namespace EventSystem
{
    public interface IEventListener { }

    public interface IResetResourcesEventListener: IEventListener
    {
        void OnGameEvent();
    }

    public interface IResourcesModifiedEventListener : IEventListener
    {
        void OnGameEvent(string resourceName, int count);
    }

    public interface IResourcesRemovedEventListener : IEventListener
    {
        void OnGameEvent(string resourceName, int count);
    }

    public interface IResourcesAddEventListener : IEventListener
    {
        void OnGameEvent(string resourceName, int count);
    }
}