using System;
using System.Collections.Generic;
using UnityEngine;

namespace Core
{
    public class CommandInvoker
    {
        private const int MaxHistoryCapacity = 5;
        private List<CommandHistory> _commandsHistory;
        private Dictionary<Type, ICommand> _commands;

        public CommandInvoker(Dictionary<Type, ICommand> commands)
        {
            _commands = commands;
            _commandsHistory = new List<CommandHistory>();
        }
        
        public void Execute<T>(Vector2 position) where T: ICommand
        {
            _commandsHistory.Add(GetCommand<T>().Invoke(position));
            if(_commandsHistory.Count > MaxHistoryCapacity)
                _commandsHistory.RemoveAt(0);
        }
        
        public void Undo()
        {
            if(_commandsHistory.Count==0) return;
            CommandHistory history = _commandsHistory[_commandsHistory.Count-1];
            history.Command.Undo(history);
            _commandsHistory.RemoveAt(_commandsHistory.Count-1);
        }

        private ICommand GetCommand<T>() where T: ICommand
        {
            return _commands[typeof(T)];
        }
    }
}