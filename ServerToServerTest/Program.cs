using System;
using ServerToServerCommunications;

namespace ServerToServerTest
{
    /// <summary>
    /// Simple programme de test pour créer une instance de l'API et envoyer une commande (exécuter la commande
    /// et envoyer le résultat chiffré et compressé sur le cannal de communication de la console)
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programme 8INF859");
            var apiBuilder = new ApiBuilder();
            apiBuilder.SetThread(4);
            apiBuilder.SetConsole();
            apiBuilder.SetCompression();
            apiBuilder.SetEncrypted();
            
            var api = apiBuilder.GetResult();
            api.SendCommand("hello", "romain");
            api.SendCommand("hello");
            
            Console.ReadKey();
        }
    }
}