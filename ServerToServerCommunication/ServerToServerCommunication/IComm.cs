namespace ServerToServerCommunication
{
    public interface IComm
    {
        public void Send(DataSource dataSource);


        public void Receive(DataSource dataSource);
    }
}