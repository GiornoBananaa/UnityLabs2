using System;

namespace Core
{
    public interface IUIState
    {
        void SetOwner(IUIStateMachine owner);
        void Enter();
        void Exit();
    }

    public interface IUIStateMachine
    {
        void SwitchState<T>() where T : IUIState;
    }
}
