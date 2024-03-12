using System;
using System.Collections.Generic;

namespace Core
{
    public class UISwitcher
    {
        private Dictionary<Type, IUIController> _uiControllers;
        private IUIController _currUIControllers;
        
        public UISwitcher(params IUIController[] states)
        {
            SetupStates(states);
        }
        
        public bool ChangeState<T>() where T: IUIController
        {
            _currUIControllers?.Exit();
            if (_uiControllers.ContainsKey(typeof(T)))
            {
                _currUIControllers = _uiControllers[typeof(T)];
                _currUIControllers.Enter();
                return true;
            }

            return false;
        }

        private void SetupStates(params IUIController[] states)
        {
            _uiControllers = new();
            foreach (var state in states)
            {
                _uiControllers.Add(state.GetType(),state);
                state.SetSwitcher(this);
            }
        }
    }
}
