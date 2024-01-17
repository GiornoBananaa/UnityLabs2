using System.Collections.Generic;
using Core;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace WarriorSystem
{
    public class EnemySwitcher : MonoBehaviour
    {
        [SerializeField] private RectTransform _buttonsLayout;
        [SerializeField] private GameObject _buttonPrefab;
        [SerializeField] private ColorBlock _chosenButtonColors;
        private EnemyPool _enemyPool;
        private List<Button> _buttons;
        private Button _chosenButton;
        private ColorBlock _defaultButtonColors;
        
        public void Construct(EnemyPool enemyPool)
        {
            _enemyPool = enemyPool;
        }
        
        private void Start()
        {
            _buttons = new List<Button>();
            SpawnEnemyChangeButton(EnemyType.OneAttack, "One attack enemy");
            SpawnEnemyChangeButton(EnemyType.Shooting,"Shooting enemy");
            SpawnEnemyChangeButton(EnemyType.Controlled,"Controlled enemy");
        }

        private void SpawnEnemyChangeButton(EnemyType enemyType, string buttonText)
        {
            GameObject buttonGameObject = Instantiate(_buttonPrefab,_buttonsLayout);
            Button button = buttonGameObject.GetComponent<Button>();
            button.onClick.AddListener(() => SetEnemy(enemyType,button));
            button.GetComponentInChildren<TMP_Text>().text = buttonText;
            _buttons.Add(button);
        }

        private void SetEnemy(EnemyType enemyType, Button button)
        {
            if(_chosenButton == button) return;
            
            _enemyPool.SetEnemy(enemyType);
            if(_chosenButton!=null)
                _chosenButton.colors = _defaultButtonColors;
            _defaultButtonColors = button.colors;
            button.colors = _chosenButtonColors;
            _chosenButton = button;
        }
    }
}
