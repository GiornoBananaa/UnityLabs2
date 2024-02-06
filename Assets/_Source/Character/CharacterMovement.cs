using UnityEngine;

namespace Character
{
    public class CharacterMovement : MonoBehaviour
    {
        [SerializeField] private float _speed;
        private Vector2 _destination;

        public Vector2 CurrentDestination => _destination;
        
        private void Update()
        {
            transform.position = Vector2.Lerp(transform.position,_destination, _speed*Time.deltaTime);
        }
        
        public void MoveTo(Vector2 position)
        {
            _destination = position;
        }
    }
}