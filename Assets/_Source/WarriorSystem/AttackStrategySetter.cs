using System.Collections.Generic;
using Core;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace WarriorSystem
{
    public class AttackStrategySetter : MonoBehaviour
    {
        /* Сериализованные поля заставляют вручную передовать сылки разыскивая обьекты в сцене,
         есть возможность того, что поле равно null поетому нужна проверка.
        */
        
        // Внедрение зависимости: через сериализованные поля
        [SerializeField] private RectTransform _buttonsLayout;
        [SerializeField] private GameObject _buttonPrefab;
        [SerializeField] private ColorBlock _chosenButtonColors;
        
        private AttackPerformer _attackPerformer;
        private List<Button> _buttons;
        private Button _chosenButton;
        private ColorBlock _defaultButtonColors;
        
        /* Методы прокидывающие зависимости вынуждают помнить о том,
         что их вообще надо вызвать, кроме того они дают клиенту возможность 
         когда угодно переопределить зависимости в runtime что может вызвать проблемы.*/
        
        // Внедрение зависимости: через метод
        public void Construct(AttackPerformer attackPerformer)
        {
            _attackPerformer = attackPerformer;
        }
        
        private void Start()
        {
            _buttons = new List<Button>();
            SpawnStrategyChangeButton(new AboveSwingAttack(), "AboveSwingAttack");
            SpawnStrategyChangeButton(new BelowSwingAttack(),"BelowSwingAttack");
            SpawnStrategyChangeButton(new SideSwingAttack(),"SideSwingAttack");
        }

        private void SpawnStrategyChangeButton(IAttackStrategy attackStrategy, string buttonText)
        {
            GameObject buttonGameObject = Instantiate(_buttonPrefab,_buttonsLayout);
            Button button = buttonGameObject.GetComponent<Button>();
            button.onClick.AddListener(() => SetStrategy(attackStrategy,button));
            button.GetComponentInChildren<TMP_Text>().text = buttonText;
            _buttons.Add(button);
        }

        private void SetStrategy(IAttackStrategy attackStrategy, Button button)
        {
            _attackPerformer.SetStrategy(attackStrategy);
            if(_chosenButton!=null)
                _chosenButton.colors = _defaultButtonColors;
            _defaultButtonColors = button.colors;
            button.colors = _chosenButtonColors;
            _chosenButton = button;
        }
    }
}
