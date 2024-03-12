using System;
using EventSystem;
using MenuView;
using ResourceSystem;
using UIController;
using UnityEngine;

namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
        private string ResourcesDataPath = "ResourcesDataSO";
        
        [SerializeField] private AddMenuView _addMenuView;
        [SerializeField] private RemoveMenuView _removeMenuView;
        [SerializeField] private MainMenuView _mainMenuView;
        [SerializeField] private ResourceAddEventSO _addGameEvent;
        [SerializeField] private ResourceRemoveEventSO _removeGameEvent;
        [SerializeField] private ResourcesResetEventSO _resetGameEvent;

        private UISwitcher _uiSwitcher;
        
        private void Awake()
        {
            IUIController[] controllers =
            {
                new AddMenuController(_addMenuView),
                new RemoveMenuController(_removeMenuView),
                new MainMenuController(_mainMenuView),
            };
            ResourcesDataSO resourcesDataSO = Resources.Load<ResourcesDataSO>(ResourcesDataPath);
            _uiSwitcher = new UISwitcher(controllers);
            _addMenuView.Construct(_addGameEvent,resourcesDataSO.Resources);
            _removeMenuView.Construct(_removeGameEvent,resourcesDataSO.Resources);
            _mainMenuView.Construct(_resetGameEvent);
        }
    }
}
