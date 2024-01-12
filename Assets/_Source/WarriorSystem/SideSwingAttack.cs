using Core;
using UnityEngine;

namespace WarriorSystem
{
    public class SideSwingAttack : IAttackStrategy
    {
        public void Attack(Animator animator)
        {
            animator.SetTrigger("SideSwing");
        }
    }
}
