using System;

namespace ServerToServerCommunications.Communication
{
    public class CommDecorator : IComm
    {
        protected IComm _wrappee;

        public CommDecorator(IComm wrappee)
        {
            _wrappee = wrappee;
        }

        public virtual void Send(string dataSource)
        {
            _wrappee.Send(dataSource);
        }


        public virtual void Receive(string dataSource)
        {
            _wrappee.Receive(dataSource);
        }
    }
}