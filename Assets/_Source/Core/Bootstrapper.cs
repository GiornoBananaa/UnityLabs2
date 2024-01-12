using UnityEngine;
using WarriorSystem;

namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
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
