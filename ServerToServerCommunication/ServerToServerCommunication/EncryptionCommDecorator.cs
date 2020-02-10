using System;

namespace ServerToServerCommunication
{
    public class EncryptionCommDecorator : CommDecorator
    {
        public EncryptionCommDecorator(IComm wrappee) : base(wrappee)
        {
        }

        public override void Send(string dataSource)
        {
            _wrappee.Send("ENCRYPTION " + dataSource);
        }


        public override void Receive(string dataSource)
        {
            throw new NotImplementedException();
        }
    }
}