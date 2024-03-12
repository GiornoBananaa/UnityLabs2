using Core;
using MenuView;

namespace UIController
{
    public class AddMenuController: IUIController
    {
        private UISwitcher _uiSwitcher;
        private AddMenuView _addMenuView;

        public AddMenuController(AddMenuView addMenuView)
        {
            _addMenuView = addMenuView;
        }

        public void SetSwitcher(UISwitcher uiSwitcher)
        {
            _uiSwitcher = uiSwitcher;
        }

        public void Enter()
        {
            _addMenuView.OpenMenu();
        }

        public void Exit()
        {
            _addMenuView.CloseMenu();
        }
    }
}
