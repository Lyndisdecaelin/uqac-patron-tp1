using System;
using ServerToServerCommunications.Communication;

namespace ServerToServerCommunications
{
    /// <summary>
    /// Builder to create and configure an Api instance
    /// </summary>
    public class ApiBuilder
    {
        private Api _api = new Api();

        public ApiBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            _api = new Api();
        }

        public void SetEncrypted()
        {
            _api.Comm = new EncryptionCommDecorator(_api.Comm);
        }
        public void SetCompression()
        {
            _api.Comm = new CompressionCommDecorator(_api.Comm);
        }
       public void SetHttp()
        {
            _api.Comm = new CreatorHttps().CreateComm();
        }

        public void SetConsole()
        {
            _api.Comm = new CreatorConsole().CreateComm();
        }


        public void SetFlux()
        {
            throw new NotImplementedException();
        }

        public void SetThread(int nbThread)
        {
            _api.NbThread = nbThread;
        }

        public Api GetResult()
        {
            var result = _api;
            Reset();
            return result;
        }
    }
}