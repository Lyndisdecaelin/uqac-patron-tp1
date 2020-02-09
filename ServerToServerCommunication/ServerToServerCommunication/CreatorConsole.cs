using System;

namespace ServerToServerCommunication
{
    public class CreatorConsole : Creator
    {
        /// <summary>
        ///     @return
        /// </summary>
        public new IComm CreateComm()
        {
            ConsoleComm newConsole = new ConsoleComm();
            return newConsole;
        }
    }
}