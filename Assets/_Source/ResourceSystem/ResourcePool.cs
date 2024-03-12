using System.Collections.Generic;
using EventSystem;

namespace ResourceSystem
{
    public class ResourcePool: IResourcesRemovedEventListener,IResourcesAddEventListener, IResetResourcesEventListener
    {
        private Dictionary<string, int> _resources;
        private ResourceModifiedEventSO _valueChangedEvent;
        
        public ResourcePool(ResourceModifiedEventSO valueChangedEvent, string[] resources)
        {
            _valueChangedEvent = valueChangedEvent;
            _resources = new Dictionary<string, int>();
            foreach (var resource in resources)
            {
                _resources.Add(resource,0);
            }
        }
        
        public void Add(string name,int count)
        {
            _resources[name] += count;
            _valueChangedEvent.Notify(name,_resources[name]);
        }
        
        public void Remove(string name,int count)
        {
            _resources[name] -= count;
            if (_resources[name] < 0) _resources[name] = 0;
            _valueChangedEvent.Notify(name,_resources[name]);
        }
        
        public void Reset()
        {
            List<string> keys = new List<string>(_resources.Keys);
            foreach (var name in keys)
            {
                _resources[name] = 0;
                _valueChangedEvent.Notify(name,0);
            }
        }
        
        void  IResourcesAddEventListener.OnGameEvent(string value1, int value2)
        {
            Add(value1,value2);
        }
        
        void IResourcesRemovedEventListener.OnGameEvent(string value1, int value2)
        {
            Remove(value1,value2);
        }
        
        void IResetResourcesEventListener.OnGameEvent()
        {
            Reset();
        }
    }
}
