using System.Collections.Generic;
using CryptoSystem;
using UnityEngine;

namespace Core
{
    public class ServiceUpdater : MonoBehaviour
    {
        private class UpdaterData
        {
            public readonly IUpdater Updater;
            public readonly float Frequency;
            public float TimeBeforeUpdate;

            public UpdaterData(IUpdater updater, float frequency)
            {
                Updater = updater;
                Frequency = frequency;
                TimeBeforeUpdate = frequency;
            }
        }
        
        private List<UpdaterData> _updaters;

        private void Awake()
        {
            _updaters = new List<UpdaterData>();
        }

        public void AddUpdater(IUpdater updater, float frequency)
        {
            _updaters.Add(new UpdaterData(updater, frequency));
        }
        
        private void Update()
        {
            foreach (var updaterData in _updaters)
            {
                updaterData.TimeBeforeUpdate -= Time.deltaTime;
                if(updaterData.TimeBeforeUpdate <= 0)
                {
                    updaterData.Updater.Update();
                    updaterData.TimeBeforeUpdate = updaterData.Frequency;
                }
            }
        }
    }
}