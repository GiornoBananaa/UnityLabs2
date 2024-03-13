using Core;
using UnityEngine;

namespace WarriorSystem
{
    public class BelowSwingAttack : IAttackStrategy
    {
        private static readonly int BelowSwingHash = Animator.StringToHash("BelowSwing");

        public void Attack(Animator animator)
        {
            animator.SetTrigger(BelowSwingHash);
        }
    }
}
