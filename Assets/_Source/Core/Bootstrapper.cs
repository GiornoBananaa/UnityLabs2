using System;
using System.Collections.Generic;
using Character;
using InputSystem;
using UnityEngine;

namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private CharacterMovement _characterMovement;
        [SerializeField] private GameObject _towerPrefab;
        [SerializeField] private InputListener _inputListener;

        private CommandInvoker _commandInvoker;
        private Dictionary<Type, ICommand> _commands;
        
        private void Awake()
        {
            _commands = new Dictionary<Type, ICommand>()
            {
                {typeof(MoveCommand),new MoveCommand(_characterMovement)},
                {typeof(SpawnCommand),new SpawnCommand(_towerPrefab)},
            };
            _commandInvoker = new CommandInvoker(_commands);

            _inputListener.Construct(_commandInvoker);
        }
    }
}