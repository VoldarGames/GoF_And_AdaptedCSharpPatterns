using System;
using System.Threading.Tasks;

namespace GoF_CSharp.Patterns.Singleton.Classic
{
    /// <summary>
    /// Non Thread safe singleton
    /// </summary>
    public class SingletonClassic
    {
        private static SingletonClassic _instance;

        public int MyInt { get; set; }

        protected SingletonClassic()
        {
            
        }

        public static SingletonClassic GetInstance()
        {
            if (_instance == null)
            {
                Task.Delay(new Random().Next(100));      //Simulation of thread delay, purpose: to demonstrate non thread safe.
                _instance = new SingletonClassic();      //Uncomment for run SingleClassicNonThreadSafeTest correctly
            }
            return _instance;

            //return _instance ?? (_instance = new SingletonClassic());     
        }
    }
}