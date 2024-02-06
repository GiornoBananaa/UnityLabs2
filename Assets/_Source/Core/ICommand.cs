using UnityEngine;

namespace Core
{
    public interface ICommand
    {
        CommandHistory Invoke(Vector2 position);
        void Undo(CommandHistory history);
    }
}
