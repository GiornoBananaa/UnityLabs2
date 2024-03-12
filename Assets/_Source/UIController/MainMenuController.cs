using Core;
using MenuView;

namespace UIController
{
    public class MainMenuController : IUIController
    {
        private UISwitcher _uiSwitcher;
        private MainMenuView _mainMenuView;

        public MainMenuController(MainMenuView mainMenuView)
        {
            _mainMenuView = mainMenuView;
        }

        public void SetSwitcher(UISwitcher uiSwitcher)
        {
            _uiSwitcher = uiSwitcher;
        }

        public void Enter()
        {
            _mainMenuView.OpenMenu();
        }

        public void Exit()
        {
            _mainMenuView.CloseMenu();
        }
    }
}
