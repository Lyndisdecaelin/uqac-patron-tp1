using System;

namespace ServerToServerCommunications.Communication
{
    public class ConsoleComm : IComm
    {
        public void Send(string dataSource)
        {
            Console.WriteLine(dataSource);
        }

        public void Receive(string dataSource)
        {
            throw new NotImplementedException();
        }
    }
}