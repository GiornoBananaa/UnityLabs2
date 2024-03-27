using UnityEngine;
using UnityEngine.UI;
using ILayoutElement = Core.ILayoutElement;

namespace Core
{
    public abstract class ScrollingLayout<T> : MonoBehaviour where T : MonoBehaviour, ILayoutElement
    {
        [SerializeField] private RectTransform _rectTransform;
        [SerializeField] private VerticalLayoutGroup _layout;
        [SerializeField] private T _layoutElementPrefab;
        
        public T InstantiateNewElement()
        {
            T newElement = Instantiate(_layoutElementPrefab).GetComponent<T>();
            AddElementToLayout(newElement.RectTransform);

            return newElement;
        }
        
        protected void AddElementToLayout(RectTransform newElement)
        {
            newElement.SetParent(_rectTransform);
            ResizeLayout(newElement);
        }
        
        protected void ResizeLayout(RectTransform newElement)
        {
            var sizeDelta = _rectTransform.sizeDelta;
            sizeDelta = new Vector2(sizeDelta.x,sizeDelta.y + newElement.sizeDelta.y + _layout.spacing);
            _rectTransform.sizeDelta = sizeDelta;
        }
    }
}
