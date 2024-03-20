using Core;
using MainMenu;

namespace AdditionalPanel
{
    public class AdditionalPanelUIState : IUIState
    {
        private readonly AdditionalPanelView _additionalPanelView;
        private IUIStateMachine _owner;
        
        public AdditionalPanelUIState(AdditionalPanelView additionalPanelView)
        {
            _additionalPanelView = additionalPanelView;
        }

        public void SetOwner(IUIStateMachine owner)
        {
            _owner = owner;
        }

        public void Enter()
        {
            _additionalPanelView.CloseButtonSubscribe(CloseAdditionalPanel);
        }

        public void Exit()
        {
            _additionalPanelView.CloseButtonUnsubscribe(CloseAdditionalPanel);
        }

        private void CloseAdditionalPanel()
        {
            _additionalPanelView.ClosePanel();
            _owner.SwitchState<MainMenuUIState>();
        }
    }
}