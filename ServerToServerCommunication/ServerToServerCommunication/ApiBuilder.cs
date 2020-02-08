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

        public void SetComm(String comm)
        {
            throw new NotImplementedException();
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