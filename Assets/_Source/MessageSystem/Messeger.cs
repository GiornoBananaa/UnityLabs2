using TMPro;
using UnityEngine;

namespace MessageSystem
{
    public class Messeger : MonoBehaviour
    {
        [SerializeField] private TMP_Text _messageText;

        private int _messagesCount;
        
        public void WriteMessage(string message)
        {
            _messagesCount++;
            _messageText.text += $"<i>{_messagesCount}</i> {message}\n";
        }
    }
}
