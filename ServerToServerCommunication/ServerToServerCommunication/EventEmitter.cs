using System;

namespace ServerToServerCommunication
{
    public class EventEmitter
    {
        public ICommandListener listeners;

        
        public void Subscribe(ICommandListener commandListener)
        {
            throw new NotImplementedException();
        }


        public void Unsubscribe(ICommandListener commandListener)
        {
            throw new NotImplementedException();
        }


        public void Notify(ICommand command)
        {
            throw new NotImplementedException();
        }
    }
}