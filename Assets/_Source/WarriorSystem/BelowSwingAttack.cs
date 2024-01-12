using Core;
using UnityEngine;

namespace WarriorSystem
{
    public class BelowSwingAttack : IAttackStrategy
    {
        public void Attack(Animator animator)
        {
            animator.SetTrigger("BelowSwing");
        }
    }
}
