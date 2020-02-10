using System;
using System.Linq;
using ServerToServerCommunication.TaskSystem;

namespace ServerToServerCommunication
{
    public class Api
    {
        public IComm Comm;
        private CommandExecutor _commandExec;


        public int NbThread
        {
            set => _commandExec = CommandExecutor.GetInstance();
        }
        

        public Api()
        {
        }

        public void SendCommand(string commandName, params string[] parameters)
        {
            ICommand command;
            switch (commandName)
            {
                case "hello":
                    var name = parameters.Any() ? parameters[0] : null;
                    Action<string> lambda = result => Console.WriteLine(result);
                    command = new GreetingCommand(lambda, name);
                    break;
                default:
                    throw new Exception("Not supported command");
            }
            _commandExec.Queue(command);
        }
    }
}