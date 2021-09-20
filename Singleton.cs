using System;
using System.Threading.Tasks;

namespace Patterns
{
    public class Singleton
    {
        public static void Run()
        {
            int threads = 4;
            Task[] tasks = new Task[threads];
            for (int i = 0; i < threads; i++)
            {
                tasks[i] = Task.Run(MemoryCache.Create);
            }

            Task.WaitAll(tasks);
        }
    }

    public class MemoryCache
    {
        private static int _i = 0;
        private static MemoryCache _instance;
        private static object _cacheLock = new ();

        // static constructor
        //static MemoryCache()
        //{
        //    _instance = new MemoryCache();
        //}

        private MemoryCache()
        {
            Console.WriteLine($"Created: {_i++}");
        }

        public static MemoryCache Create()
        {
            if (_instance != null) return _instance;

            lock (_cacheLock)
            {
                if (_instance == null)
                {
                    return _instance = new MemoryCache();
                }
            }

            return _instance;
        }

        // static constructor
        //public static MemoryCache Create() => _instance;
    }
}
