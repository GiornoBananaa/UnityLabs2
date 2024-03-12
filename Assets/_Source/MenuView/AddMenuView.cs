using EventSystem;
using UnityEngine;
using UnityEngine.UI;

namespace MenuView
{
    public class AddMenuView : MonoBehaviour
    {
        [SerializeField] private GameObject _menuPanel;
        [SerializeField] private Button _addButton;
        [SerializeField] private Dropdown _resourcesDropdown;
        [SerializeField] private InputField _countInputField;

        private ResourceAddEventSO _addEventSo;
        
        public void Construct(ResourceAddEventSO addEventSo, string[] resources)
        {
            _addEventSo = addEventSo;
            _resourcesDropdown.ClearOptions();
            foreach (var name in resources)
            {
                _resourcesDropdown.options.Add(new Dropdown.OptionData(name));
            }
        }
        
        private void Awake()
        {
            _addButton.onClick.AddListener(AddResource);
        }

        private void AddResource()
        {
            if(!int.TryParse(_countInputField.text,out var count))
                return;
            _addEventSo.Notify(_resourcesDropdown.options[_resourcesDropdown.value].text,count);
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
