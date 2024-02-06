using UnityEngine;

namespace Core
{
    public class SpawnCommandHistory: CommandHistory
    {
        public GameObject SpawnedGameObject;

        public SpawnCommandHistory(ICommand command, Vector2 position,GameObject spawnedGameObject) : base(command, position)
        {
            SpawnedGameObject = spawnedGameObject;
        }
    }
}