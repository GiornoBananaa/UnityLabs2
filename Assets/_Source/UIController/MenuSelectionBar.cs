using Core;
using UnityEngine;
using UnityEngine.UI;

namespace UIController
{
    public class MenuSelectionBar: MonoBehaviour
    {
        [SerializeField] private Button _mainMenuButton;
        [SerializeField] private Button _addMenuButton;
        [SerializeField] private Button _removeMenuButton;

        private UISwitcher _uiSwitcher;
        
        public void Construct(UISwitcher uiSwitcher)
        {
            _uiSwitcher = uiSwitcher;
        }
        
        private void Start()
        {
            _mainMenuButton.onClick.AddListener(OpenMainMenu);
            _addMenuButton.onClick.AddListener(OpenAddMenu);
            _removeMenuButton.onClick.AddListener(OpenRemoveMenu);
        }

        private void OpenMainMenu()
        {
            _uiSwitcher.ChangeState<MainMenuController>();
        }
        private void OpenAddMenu()
        {
            _uiSwitcher.ChangeState<AddMenuController>();
        }
        private void OpenRemoveMenu()
        {
            _uiSwitcher.ChangeState<RemoveMenuController>();
        }
    }
}