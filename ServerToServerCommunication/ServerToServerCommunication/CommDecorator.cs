using System;

namespace ServerToServerCommunication
{
    public class CommDecorator : IComm
    {
        private IComm wrappee;


        public virtual void Send(DataSource dataSource)
        {
            throw new NotImplementedException();
        }


        public virtual void Receive(DataSource dataSource)
        {
            throw new NotImplementedException();
        }
    }
}