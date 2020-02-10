using System;

namespace ServerToServerCommunications.TaskSystem
{
    public class GreetingCommand : ICommand
    {
        private readonly Action<string> _onFinished;
        private readonly string _name;
        
        public GreetingCommand(string name, Action<string> onFinished)
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