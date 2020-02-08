using System;

namespace ServerToServerCommunication
{
    public class EncryptionComm : CommDecorator
    {

        public new void Send(DataSource dataSource)
        {
            throw new NotImplementedException();
        }

  
        public new void Receive(DataSource dataSource)
        {
            throw new NotImplementedException();
        }
    }
}