using Core;
using TMPro;
using UnityEngine;

namespace WarriorSystem
{
    public class AboveSwingAttack : IAttackStrategy
    {
        public void Attack(Animator animator)
        {
            animator.SetTrigger("AboveSwing");
        }
    }
}
