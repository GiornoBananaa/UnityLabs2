using System;
using Core;
using UnityEngine;

namespace WarriorSystem
{
    public class ControlledEnemy : AEnemy
    {
        private static readonly int AttackAnimationHash = Animator.StringToHash("SideSwing");
        
        [SerializeField] private Animator _animator;

        private void Start()
        {
            IsControlledByPlayer = true;
        }

        public override void Attack()
        {
            _animator.SetTrigger(AttackAnimationHash);
        }
    }
}
