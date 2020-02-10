using System;

namespace ServerToServerCommunications.Communication
{
    public class CompressionCommDecorator : CommDecorator
    {
        public CompressionCommDecorator(IComm wrappee) : base(wrappee)
        {
        }

        public override void Send(string dataSource)
        {
            _wrappee.Send("COMPRESSION " + dataSource);
        }


        public override void Receive(string dataSource)
        {
            throw new NotImplementedException();
        }
    }
}