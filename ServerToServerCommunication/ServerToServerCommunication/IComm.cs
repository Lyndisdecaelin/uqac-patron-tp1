namespace ServerToServerCommunication
{
    public interface IComm
    {
        public void Send(string dataSource);


        public void Receive(string dataSource);
    }
}