using System.Collections.Generic;
using EventSystem;
using UnityEngine;

namespace ResourceSystem
{
    public class ResourcePool: IResourcesRemovedEventListener,IResourcesAddEventListener
    {
        private Dictionary<string, int> _resources;
        private ResourceModifiedEventSO _valueChangedEvent;

        public ResourcePool(ResourceModifiedEventSO valueChangedEvent)
        {
            _valueChangedEvent = valueChangedEvent;
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
        }

        public void Reset()
        {
            foreach (var name in _resources.Keys)
            {
                _resources[name] = 0;
            }
        }


        public void OnGameEvent(string value1, int value2)
        {
            throw new System.NotImplementedException();
        }
    }
    
    [CreateAssetMenu(fileName = "ResourcesDataSO", menuName = "SO/Resources Data")]
    public class ResourcesDataSO : ScriptableObject
    {
        [field: SerializeField] public string[] Resources { get; private set; }
    }
}
