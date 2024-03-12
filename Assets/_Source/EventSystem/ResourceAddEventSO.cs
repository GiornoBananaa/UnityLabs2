using System.Collections.Generic;
using UnityEngine;

namespace EventSystem
{
    [CreateAssetMenu(fileName = "ResourceAddEventSO",menuName = "SO/GameEvents/Resource Add Event")]
    public abstract class ResourceAddEventSO: ScriptableObject, IObservable<IResourcesAddEventListener,string,int>
    {
        private List<IResourcesAddEventListener> _listeners = new();
        
        public void RegisterObserver(IResourcesAddEventListener listener)
        {
            _listeners.Add(listener);
        }
        
        public void RemoveObserver(IResourcesAddEventListener listener)
        {
            _listeners.Remove(listener);
        }

        public void Notify(string name,int count)
        {
            foreach (var listener in _listeners)
            {
                listener.OnGameEvent(name,count);
            }
        } 
    }
}