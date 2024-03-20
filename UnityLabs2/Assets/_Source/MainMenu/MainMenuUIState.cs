using AdditionalPanel;
using Core;

namespace MainMenu
{
    public class MainMenuUIState : IUIState
    {
        private readonly AdditionalPanelView _additionalPanelView;
        private readonly MainMenuView _mainMenuView;
        private IUIStateMachine _owner;
        
        public MainMenuUIState(AdditionalPanelView additionalPanelView, MainMenuView mainMenuView)
        {
            _additionalPanelView = additionalPanelView;
            _mainMenuView = mainMenuView;
        }

        public void SetOwner(IUIStateMachine owner)
        {
            _owner = owner;
        }

        public void Enter()
        {
            _mainMenuView.OpenButtonSubscribe(OpenAdditionalPanel);
        }

        public void Exit()
        {
            _mainMenuView.OpenButtonUnsubscribe(OpenAdditionalPanel);
        }

        private void OpenAdditionalPanel()
        {
            _additionalPanelView.OpenPanel();
            _owner.SwitchState<AdditionalPanelUIState>();
        }
    }
}