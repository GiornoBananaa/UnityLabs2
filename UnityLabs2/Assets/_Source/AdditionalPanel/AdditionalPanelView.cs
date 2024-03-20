using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace AdditionalPanel
{
    public class AdditionalPanelView : MonoBehaviour
    {
        [SerializeField] private Button _closeButton;
        [SerializeField] private RectTransform _panel;

        public void CloseButtonSubscribe(UnityAction action)
        {
            _closeButton.onClick.AddListener(action);
        }
    
        public void CloseButtonUnsubscribe(UnityAction action)
        {
            _closeButton.onClick.RemoveListener(action);
        }

        public void ClosePanel()
        {
            _panel.gameObject.SetActive(false);
        }
        
        public void OpenPanel()
        {
            _panel.gameObject.SetActive(true);
        }
    }
}
