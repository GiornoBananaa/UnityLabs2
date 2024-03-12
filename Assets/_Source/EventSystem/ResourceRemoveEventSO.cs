using System.Collections.Generic;
using UnityEngine;

namespace EventSystem
{
    [CreateAssetMenu(fileName = "ResourceRemoveEventSO", menuName = "SO/GameEvents/Resource Remove Event")]
    public class ResourceRemoveEventSO : ScriptableObject, IObservable<IResourcesRemovedEventListener,string,int>
    {
    private List<IResourcesRemovedEventListener> _listeners = new();
        
    public void RegisterObserver(IResourcesRemovedEventListener listener)
    {
        _listeners.Add(listener);
    }
        
    public void RemoveObserver(IResourcesRemovedEventListener listener)
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