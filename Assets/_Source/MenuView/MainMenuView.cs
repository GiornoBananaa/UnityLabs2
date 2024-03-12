using Core;
using EventSystem;
using UnityEngine;
using UnityEngine.UI;

namespace MenuView
{
    public class MainMenuView : MonoBehaviour
    {
        [SerializeField] private GameObject _menuPanel;
        [SerializeField] private Button _resetButton;

        private ResourcesResetEventSO _resetEventSo;
        
        public void Construct(ResourcesResetEventSO resetEventSo)
        {
            _resetEventSo = resetEventSo;
        }
        
        private void Awake()
        {
            _resetButton.onClick.AddListener(ResetResources);
        }

        private void ResetResources()
        {
            _resetEventSo.Notify();
        }

        public void OpenMenu()
        {
            _menuPanel.SetActive(true);
        }
        
        public void CloseMenu()
        {
            _menuPanel.SetActive(false);
        }
    }
}
