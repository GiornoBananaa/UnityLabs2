using Character;
using UnityEngine;

namespace Core
{
    public class MoveCommand: ICommand
    {
        private readonly CharacterMovement _characterMovement;

        public MoveCommand(CharacterMovement characterMovement)
        {
            _characterMovement = characterMovement;
        }
        
        public CommandHistory Invoke(Vector2 position)
        {
            Vector2 currentDestination = _characterMovement.CurrentDestination;
            _characterMovement.MoveTo(position);
            MoveCommandHistory moveCommandHistory = new MoveCommandHistory(this, position, currentDestination);
            
            return moveCommandHistory;
        }

        public void Undo(CommandHistory history)
        {
            MoveCommandHistory moveHistory = (MoveCommandHistory)history;
            
            _characterMovement.MoveTo(moveHistory.PreviousPosition);
        }
    }
}