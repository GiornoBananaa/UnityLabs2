using UnityEngine;
using WarriorSystem;

namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
        /* Сериализованные поля заставляют вручную передовать сылки разыскивая обьекты в сцене,
         есть возможность того, что поле равно null поетому нужна проверка
        */
        
        // Внедрение зависимости: через сериализованные поля
        [SerializeField] private InputListener _inputListener; 
        [SerializeField] private AttackStrategySetter _attackStrategySetter;
        [SerializeField] private Animator _animator;
        
        private AttackPerformer _attackPerformer;
        
        private void Awake()
        {
            _attackPerformer = new AttackPerformer(_animator);
            _inputListener.Construct(_attackPerformer);
            _attackStrategySetter.Construct(_attackPerformer);
        }
    }
}
