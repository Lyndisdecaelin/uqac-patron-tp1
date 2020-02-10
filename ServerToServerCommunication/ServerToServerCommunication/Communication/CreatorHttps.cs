using System;

namespace ServerToServerCommunication
{
    public class CreatorHttps : Creator
    {
        /// <summary>
        ///     @return
        /// </summary>
        public new IComm CreateComm()
        {
            HttpsComm newHttps = new HttpsComm();
            return newHttps;
        }
    }
}