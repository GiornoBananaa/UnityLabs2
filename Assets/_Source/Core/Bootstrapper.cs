using System;
using UnityEngine;
using UnityEngine.Serialization;
using WarriorSystem;

namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private InputListener _inputListener;
        [SerializeField] private EnemySwitcher _enemySwitcher;
        private EnemyPool _enemyPool;
        private EnemySpawnDataSO _enemySpawnData;

        private void Awake()
        {
            _enemySpawnData = Resources.Load<EnemySpawnDataSO>("EnemySpawnData");
            _enemyPool = new EnemyPool(_enemySpawnData.GetEnemyPrefabs());
            _inputListener.Construct(_enemyPool);
            _enemySwitcher.Construct(_enemyPool);
        }
    }
}
