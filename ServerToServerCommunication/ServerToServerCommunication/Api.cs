using System;
using System.Linq;
using System.Threading;
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
                    Console.WriteLine("Envoi du message ....");
                    Thread.Sleep(3000);
                    Action<string> lambda = result => Comm.Send(result);
                    command = new GreetingCommand(lambda, name);
                    break;
                default:
                    throw new Exception("Not supported command");
            }
            _commandExec.Queue(command);
        }
    }
}