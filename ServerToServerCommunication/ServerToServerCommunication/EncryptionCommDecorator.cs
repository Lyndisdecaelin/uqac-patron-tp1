using System;

namespace ServerToServerCommunication
{
    public class EncryptionCommDecorator : CommDecorator
    {
        public EncryptionCommDecorator(IComm wrappee) : base(wrappee)
        {
        }

        public new void Send(string dataSource)
        {
            _wrappee.Send("ENCRYPTION" + dataSource);
        }


        public new void Receive(string dataSource)
        {
            throw new NotImplementedException();
        }
    }
}