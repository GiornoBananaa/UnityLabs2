using UnityEngine;

namespace Core
{
    public abstract class CommandHistory
    {
        public ICommand Command;
        public Vector2 Position;

        public CommandHistory(ICommand command,Vector2 position)
        {
            Command = command;
            Position = position;
        }
    }
}