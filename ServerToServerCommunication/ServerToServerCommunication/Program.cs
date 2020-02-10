using System;

namespace ServerToServerCommunication
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Programme 8INF859");
            var apiBuilder = new ApiBuilder();
            apiBuilder.SetThread(4);
            apiBuilder.setHttp();
            apiBuilder.setCompression();
            apiBuilder.setEncrypted();
            var api = apiBuilder.GetResult();
            api.SendCommand("hello", "romain");
            Console.ReadKey();
           
        }
    }
}