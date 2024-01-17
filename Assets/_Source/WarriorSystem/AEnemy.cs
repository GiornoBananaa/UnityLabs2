using UnityEngine;

namespace Core
{
    public abstract class AEnemy: MonoBehaviour
    {
        [HideInInspector] public bool IsControlledByPlayer;
        public abstract void Attack();
    }
}
