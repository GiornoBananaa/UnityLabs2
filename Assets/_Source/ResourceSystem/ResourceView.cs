using TMPro;
using UnityEngine;

namespace ResourceSystem
{
    public class ResourceView : MonoBehaviour
    {
        [SerializeField] private TMP_Text _countText;
        [SerializeField] private TMP_Text _resourceNameText;
        private int _count;
        private string _resourceName;
        
        public int Count
        {
            get => _count;
            set
            {
                _count = value;
                _countText.text = _count.ToString();
            }
        }
        
        public string ResourceName
        {
            get => _resourceName;
            set
            {
                _resourceName = value;
                _resourceNameText.text = _resourceName;
            }
        }
    }
}