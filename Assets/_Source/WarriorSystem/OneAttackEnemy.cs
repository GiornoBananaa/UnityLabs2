using Core;
using TMPro;
using UnityEngine;

namespace WarriorSystem
{
    public class OneAttackEnemy : AEnemy
    {
        private static readonly int AttackAnimationHash = Animator.StringToHash("AboveSwing");
        
        [SerializeField] private Animator _animator;
        
        private void OnEnable()
        {
            Attack();
        }
        
        public override void Attack()
        {
            _animator.SetTrigger(AttackAnimationHash);
        }
    }
}
