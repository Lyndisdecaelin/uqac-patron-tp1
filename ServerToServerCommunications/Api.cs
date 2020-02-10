using System;
using System.Linq;
using System.Threading;
using ServerToServerCommunications.Communication;
using ServerToServerCommunications.TaskSystem;

namespace ServerToServerCommunications
{
    public class Api
    {
        public IComm Comm;
        private CommandExecutor _commandExec;

        public Api()
        {
            _commandExec = CommandExecutor.GetInstance();
        }
       
        public int NbThread
        {
            set => CommandExecutor.NbThread = value;
        }
        
        /// <summary>
        /// Executes the appropriate command and sends the result on the communication flow.
        /// </summary>
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
                    command = new GreetingCommand(name, lambda);
                    break;
                default:
                    throw new Exception("Not supported command");
            }
            _commandExec.Queue(command);
        }
    }
}