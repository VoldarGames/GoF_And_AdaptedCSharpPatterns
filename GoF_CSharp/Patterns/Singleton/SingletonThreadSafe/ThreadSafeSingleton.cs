using System;
using System.Threading.Tasks;

namespace GoF_CSharp.Patterns.Singleton.SingletonThreadSafe
{
    /// <summary>
    /// Thread safe singleton
    /// </summary>
    public class ThreadSafeSingleton
    {
        private static readonly object LockObject = new object();

        private static ThreadSafeSingleton _instance;

        public int MyInt { get; set; }

        protected ThreadSafeSingleton()
        {
            
        }

        public static ThreadSafeSingleton GetInstance()
        {
            lock (LockObject)
            {
                if (_instance == null)
                {
                    Task.Delay(new Random().Next(100));      //Simulation of thread delay, purpose: to demonstrate thread safe.
                    _instance = new ThreadSafeSingleton();   //Uncomment for run ThreadSafeTest correctly
                }
                return _instance;
            }
            

            //return _instance ?? (_instance = new ThreadSafeSingleton());     
        }
    }
}