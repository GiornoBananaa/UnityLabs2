using System.Collections.Generic;
using UnityEngine;

namespace WarriorSystem
{
    [CreateAssetMenu(fileName = "EnemySpawnData", menuName = "SO/EnemySpawnData")]
    public class EnemySpawnDataSO : ScriptableObject
    {
        [SerializeField] private GameObject _oneAttackEnemy;
        [SerializeField] private GameObject _shootingEnemy;
        [SerializeField] private GameObject _controlledEnemy;
    
        public Dictionary<EnemyType,GameObject> GetEnemyPrefabs()
        {
            return new Dictionary<EnemyType, GameObject>
            {
                {EnemyType.OneAttack,_oneAttackEnemy},
                {EnemyType.Shooting,_shootingEnemy},
                {EnemyType.Controlled,_controlledEnemy}
            };
        }
    }
}
