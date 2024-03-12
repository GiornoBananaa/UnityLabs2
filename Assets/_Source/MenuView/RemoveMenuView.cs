using Core;
using EventSystem;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace MenuView
{
    public class RemoveMenuView : MonoBehaviour
    {
        [SerializeField] private GameObject _menuPanel;
        [SerializeField] private Button _removeButton;
        [SerializeField] private Dropdown _resourcesDropdown;
        [SerializeField] private InputField _countInputField;
        
        private ResourceRemoveEventSO _removeEventSo;
        
        public void Construct(ResourceRemoveEventSO removeEventSo, string[] resources)
        {
            _removeEventSo = removeEventSo;
            _resourcesDropdown.ClearOptions();
            foreach (var name in resources)
            {
                _resourcesDropdown.options.Add(new Dropdown.OptionData(name));
            }
        }
        
        private void Awake()
        {
            _removeButton.onClick.AddListener(RemoveResource);
        }

        private void RemoveResource()
        {
            if(!int.TryParse(_countInputField.text,out var count))
                return;
            _removeEventSo.Notify(_resourcesDropdown.options[_resourcesDropdown.value].text,count);
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
