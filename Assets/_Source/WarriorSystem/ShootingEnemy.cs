using System;
using System.Collections;
using Core;
using UnityEngine;
using UnityEngine.Serialization;

namespace WarriorSystem
{
    public class ShootingEnemy : AEnemy
    {
        private static readonly int AttackAnimationHash = Animator.StringToHash("BelowSwing");
        
        [SerializeField] private Animator _animator;
        [SerializeField] private GameObject _energyBlastPrefab;
        [SerializeField] private float _attackCooldown;
        private float _elapsedTimeFromAttack;

        public override void Attack()
        {
            _animator.SetTrigger(AttackAnimationHash);
            Instantiate(_energyBlastPrefab, transform);
        }
        
        private void Update()
        {
            CheckCooldown();
        }

        private void CheckCooldown()
        {
            _elapsedTimeFromAttack += Time.deltaTime;
            if (_elapsedTimeFromAttack > _attackCooldown)
            {
                Attack();
                _elapsedTimeFromAttack = 0;
            }
        }
    }
}
