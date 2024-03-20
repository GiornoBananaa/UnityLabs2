using AdditionalPanel;
using MainMenu;
using UISwitchingSystem;
using UnityEngine;

namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private AdditionalPanelView _additionalPanelView;
        [SerializeField] private MainMenuView _mainMenuView;

        private IUIState[] _uiStates;
        private UISwitcher _uiSwitcher;
        
        private void Awake()
        {
            _uiStates = new IUIState[]
            {
                new AdditionalPanelUIState(_additionalPanelView),
                new MainMenuUIState(_additionalPanelView,_mainMenuView)
            };

            _uiSwitcher = new UISwitcher(_uiStates);
            _uiSwitcher.SwitchState<MainMenuUIState>();
        }
    }
}