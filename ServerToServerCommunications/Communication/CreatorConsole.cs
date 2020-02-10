namespace ServerToServerCommunications.Communication
{
    public class CreatorConsole : Creator
    {
        public override IComm CreateComm()
        {
            ConsoleComm newConsole = new ConsoleComm();
            return newConsole;
        }
    }
}