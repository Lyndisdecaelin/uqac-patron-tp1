using System;

namespace ServerToServerCommunication
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var apiBuilder = new ApiBuilder();
            apiBuilder.SetThread(4);

            var api = apiBuilder.GetResult();
            api.SendCommand("hello", "romain");
        }
    }
}