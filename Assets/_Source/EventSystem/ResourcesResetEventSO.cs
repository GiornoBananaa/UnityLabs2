using System.Collections.Generic;
using UnityEngine;

namespace EventSystem
{
    [CreateAssetMenu(fileName = "ResourceModifiedEvent", menuName = "SO/Resource Modified Event")]
    public abstract class ResourcesResetEventSO : ScriptableObject, IObservable<IResetResourcesEventListener>
    {
        private List<IResetResourcesEventListener> _listeners = new();
        
        public void RegisterObserver(IResetResourcesEventListener listener)
        {
            _listeners.Add(listener);
        }
        
        public void RemoveObserver(IResetResourcesEventListener listener)
        {
            _listeners.Remove(listener);
        }

        public void Notify()
        {
            foreach (var listener in _listeners)
            {
                listener.OnGameEvent();
            }
        } 
    }
}