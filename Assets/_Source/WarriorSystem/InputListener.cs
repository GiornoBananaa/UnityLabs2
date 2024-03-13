using UnityEngine;

namespace WarriorSystem
{
    public class InputListener : MonoBehaviour
    {
        /* Сериализованные поля заставляют вручную передовать сылки разыскивая обьекты в сцене, есть возможность того
         что поле равно null поетому нужна проверка*/
        
        // Внедрение зависимости: сериализованное поле
        [SerializeField] private KeyCode _attackKeyCode;
        private AttackPerformer _attackPerformer;
        
        /* Методы прокидывающие зависимости вынуждают помнить о том,
         что их вообще надо вызвать, кроме того они дают клиенту возможность
         когда угодно переопределить зависимости в runtime что может вызвать проблемы.*/
        
        // Внедрение зависимости: через метод
        public void Construct(AttackPerformer attackPerformer)
        {
            _attackPerformer = attackPerformer;
        }
        
        private void Update()
        {
            CheckAttack();
        }

        private void CheckAttack()
        {
            if (Input.GetKeyDown(_attackKeyCode))
            {
                _attackPerformer.PerformAttack();
            }
        }
    }
}
