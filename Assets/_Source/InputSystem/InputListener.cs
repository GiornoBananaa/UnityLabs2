using Core;
using UnityEngine;

namespace InputSystem
{
    public class InputListener : MonoBehaviour
    {
        private CommandInvoker _commandInvoker;
        
        public void Construct(CommandInvoker commandInvoker)
        {
            _commandInvoker = commandInvoker;
        }

        private void Update()
        {
            CheckMove();
            CheckSpawn();
            CheckCommandUndo();
        }

        private void CheckMove()
        {
            if (Input.GetMouseButtonDown(0))
            {
                RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
                _commandInvoker.Execute<MoveCommand>(hit.point);
            }
        }
        private void CheckSpawn()
        {
            if (Input.GetMouseButtonDown(1))
            {
                RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
                _commandInvoker.Execute<SpawnCommand>(hit.point);
            }
        }
        private void CheckCommandUndo()
        {
            if (Input.GetMouseButtonDown(2))
            {
                _commandInvoker.Undo();
            }
        }
    }
}
