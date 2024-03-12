using System.Collections.Generic;
using EventSystem;
using ResourceSystem;
using UnityEngine;
using UnityEngine.UI;

namespace MenuView
{
    public class MainMenuView : MonoBehaviour, IResourcesModifiedEventListener
    {
        [SerializeField] private GameObject _menuPanel;
        [SerializeField] private Button _resetButton;
        [SerializeField] private RectTransform _resourcesLayout;
        [SerializeField] private GameObject _resourceViewPrefab;

        private ResourcesResetEventSO _resetEventSo;
        private Dictionary<string, ResourceView> _resourceViews;
        
        public void Construct(ResourcesResetEventSO resetEventSo, string[] resources)
        {
            _resetEventSo = resetEventSo;
            _resourceViews = new Dictionary<string, ResourceView>();
            foreach (var resource in resources)
            {
                ResourceView resourceView = Instantiate(_resourceViewPrefab, _resourcesLayout).GetComponent<ResourceView>();
                resourceView.ResourceName = resource;
                _resourceViews.Add(resource, resourceView);
            }
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

        void IResourcesModifiedEventListener.OnGameEvent(string resourceName, int count)
        {
            _resourceViews[resourceName].Count = count;
        }
    }
}
