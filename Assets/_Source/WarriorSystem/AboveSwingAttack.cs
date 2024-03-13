using Core;
using TMPro;
using UnityEngine;

namespace WarriorSystem
{
    public class AboveSwingAttack : IAttackStrategy
    {
        private static readonly int AboveSwingHash = Animator.StringToHash("AboveSwing");

        public void Attack(Animator animator)
        {
            animator.SetTrigger(AboveSwingHash);
        }
    }
}
