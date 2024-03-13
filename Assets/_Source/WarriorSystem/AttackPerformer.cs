using Core;
using UnityEngine;

namespace WarriorSystem
{
    public class AttackPerformer
    {
        private IAttackStrategy _attackStrategy;
        private Animator _animator;
        
        // Внедрение зависимостей: через конструктор
        // И это правильно!
        public AttackPerformer(Animator animator)
        {
            _animator = animator;
        }
        
        public void SetStrategy(IAttackStrategy attackStrategy)
        {
            _attackStrategy = attackStrategy;
        }

        public void PerformAttack()
        {
            _attackStrategy.Attack(_animator);
        }
    }
}
