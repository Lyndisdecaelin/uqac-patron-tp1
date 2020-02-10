namespace ServerToServerCommunications.Communication
{
    public class CreatorHttps : Creator
    {
        public override IComm CreateComm()
        {
            HttpsComm newHttps = new HttpsComm();
            return newHttps;
        }
    }
}