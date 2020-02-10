using System.Threading;

namespace ServerToServerCommunications.TaskSystem
{
    
    /// <summary>
    ///
    /// WARN:
    /// Access to the singleton is not thread-safe, multiple instance of CommendExecutor can be created during
    /// simultaneous calls (we keep things simple for the prototype)
    /// </summary>
    public class CommandExecutor
    {
        private static CommandExecutor _instance;
        
        public static int NbThread
        {
            set
            {
                var nbThread = value > 0 ? value : 1;
                ThreadPool.SetMaxThreads(nbThread, nbThread);
            } 
        }

        private CommandExecutor() { }
        
        public static CommandExecutor GetInstance()
        {
            return _instance ??= new CommandExecutor();
        }

        public void Queue(ICommand command)
        {
            ThreadPool.QueueUserWorkItem((_) => command.Execute(), 1);
        }
    }
}