namespace EventSystem
{
    public interface IObservable<in TListener> where TListener: IEventListener
    {
        void RegisterObserver(TListener listener);
        void RemoveObserver(TListener listener);
        void Notify();
    }
    
    public interface IObservable<in TListener,in TValue> where TListener: IEventListener
    {
        void RegisterObserver(TListener listener);
        void RemoveObserver(TListener listener);
        void Notify(TValue value);
    }
    
    public interface IObservable<in TListener,in TValue1,in TValue2> where TListener: IEventListener
    {
        void RegisterObserver(TListener listener);
        void RemoveObserver(TListener listener);
        void Notify(TValue1 value1, TValue2 value2);
    }
}