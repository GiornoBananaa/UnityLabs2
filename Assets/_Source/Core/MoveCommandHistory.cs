using UnityEngine;

namespace Core
{
    public class MoveCommandHistory: CommandHistory
    {
        public Vector2 PreviousPosition;

        public MoveCommandHistory(ICommand command, Vector2 position,Vector2 previousPosition) : base(command, position)
        {
            PreviousPosition = previousPosition;
        }
    }
}