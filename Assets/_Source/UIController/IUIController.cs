﻿namespace Core
{
    public interface IUIController
    {
        void SetSwitcher(UISwitcher uiSwitcher);
        void Enter();
        void Exit();
    }
}