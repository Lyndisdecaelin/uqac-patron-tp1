using System;

namespace ServerToServerCommunication
{
    public class CompressionCommDecorator : CommDecorator
    {
        public CompressionCommDecorator(IComm wrappee) : base(wrappee)
        {
        }

        public new void Send(string dataSource)
        {
            _wrappee.Send("COMPRESSION" + dataSource);
        }


        public new void Receive(string dataSource)
        {
            throw new NotImplementedException();
        }
    }
}