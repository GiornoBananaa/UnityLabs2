using UnityEngine;

namespace Core
{
    public class SpawnCommand: ICommand
    {
        private GameObject _prefab;

        private GameObject _gameObject;
        
        public SpawnCommand(GameObject prefab)
        {
            _prefab = prefab;
        }
        
        public CommandHistory Invoke(Vector2 position)
        {
            _gameObject = Object.Instantiate(_prefab,position,Quaternion.identity);
            return new SpawnCommandHistory(this, position, _gameObject);
        }

        public void Undo(CommandHistory history)
        {
            SpawnCommandHistory spawnHistory = (SpawnCommandHistory)history;

            Object.Destroy(spawnHistory.SpawnedGameObject);
        }
    }
}