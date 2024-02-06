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
                Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out RaycastHit hit);
                _commandInvoker.Execute<MoveCommand>(hit.point);
            }
        }
        private void CheckSpawn()
        {
            if (Input.GetMouseButtonDown(1))
            {
                Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out RaycastHit hit);
                _commandInvoker.Execute<SpawnCommand>(hit.point);
            }
        }
        private void CheckCommandUndo()
        {
            if (Input.GetMouseButtonDown(3))
            {
                _commandInvoker.Undo();
            }
        }
    }
}
