using System;

namespace ServerToServerCommunication
{
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

        public void setEncrypted()
        {
            _api.Comm = new EncryptionCommDecorator(_api.Comm);
        }
        public void setCompression()
        {
            _api.Comm = new CompressionCommDecorator(_api.Comm);
        }
       public void setHttp()
        {
            _api.Comm = new CreatorHttps().CreateComm();
        }

        public void setConsole()
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