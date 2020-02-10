using System;
using ServerToServerCommunication.TaskSystem;

namespace ServerToServerCommunication
{
    public class GreetingCommand : ICommand
    {
        private readonly Action<string> _onFinished;
        private readonly string _name;
        
        public GreetingCommand(Action<string> onFinished, string name)
        {
            _onFinished = onFinished;
            _name = name ?? "Unknown";
        }
        
        public void Execute()
        {
            _onFinished("Hello " + _name);
        }
    }
}