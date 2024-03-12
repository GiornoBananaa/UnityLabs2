using Core;
using MenuView;

namespace UIController
{
    public class RemoveMenuController : IUIController
    {
        private UISwitcher _uiSwitcher;
        private RemoveMenuView _removeMenuView;

        public RemoveMenuController(RemoveMenuView removeMenuView)
        {
            _removeMenuView = removeMenuView;
        }

        public void SetSwitcher(UISwitcher uiSwitcher)
        {
            _uiSwitcher = uiSwitcher;
        }

        public void Enter()
        {
            _removeMenuView.OpenMenu();
        }

        public void Exit()
        {
            _removeMenuView.CloseMenu();
        }
    }
}
