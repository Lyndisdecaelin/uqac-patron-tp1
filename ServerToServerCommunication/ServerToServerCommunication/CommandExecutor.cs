using System;

namespace ServerToServerCommunication
{
    
    /// <summary>
    /// No thread-safe, it's a prototype, we keep things simple.
    /// </summary>
    public class CommandExecutor
    {
        private static CommandExecutor _instance;
        private readonly int _nbThread;

        private CommandExecutor() { }
        private CommandExecutor(int nbThread)
        {
            _nbThread = nbThread;
        }

        public static CommandExecutor GetInstance()
        {
            return _instance ??= new CommandExecutor();
        }
        
        public void Queue(ICommand command)
        {
            command.Execute();
        }
    }
}