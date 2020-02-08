namespace ServerToServerCommunication
{
    public interface ICommandListener
    {
        public void OnEvent(ICommand command);
    }
}