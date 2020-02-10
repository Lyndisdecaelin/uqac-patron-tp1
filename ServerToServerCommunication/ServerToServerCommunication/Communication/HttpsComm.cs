using System;

namespace ServerToServerCommunication
{
    public class HttpsComm : IComm
    {
        public void Send(string dataSource)
        {
            Console.WriteLine("https protocol " + dataSource);
        }

        public void Receive(string dataSource)
        {
            throw new NotImplementedException();
        }
    }
}