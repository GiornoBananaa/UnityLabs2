using System.Collections.Generic;
using UnityEngine;

namespace EventSystem
{
    [CreateAssetMenu(fileName = "ResourceModifiedEvent",menuName = "SO/GameEvents/Resource Modified Event")]
    public class ResourceModifiedEventSO:ScriptableObject, IObservable<IResourcesModifiedEventListener,string,int>
    {
        private List<IResourcesModifiedEventListener> _listeners = new();
        
        public void RegisterObserver(IResourcesModifiedEventListener listener)
        {
            _listeners.Add(listener);
        }
        
        public void RemoveObserver(IResourcesModifiedEventListener listener)
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