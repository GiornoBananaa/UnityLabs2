using Core;
using UnityEngine;

namespace WarriorSystem
{
    public class SideSwingAttack : IAttackStrategy
    {
        private static readonly int SideSwingHash = Animator.StringToHash("SideSwing");

        public void Attack(Animator animator)
        {
            animator.SetTrigger(SideSwingHash);
        }
    }
}
