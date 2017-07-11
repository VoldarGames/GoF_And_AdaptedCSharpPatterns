using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GoF_CSharp.Patterns.Singleton.Classic;
using GoF_CSharp.Patterns.Singleton.SingletonThreadSafe;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GoF_CSharp.Patterns.Singleton
{
    [TestClass]
    [TestCategory("Singleton Pattern")]
    public class SingletonTest
    {
        [TestMethod]
        public void SingletonClassicTest()
        {
            var targetOne = SingletonClassic.GetInstance();
            targetOne.MyInt = 1234;
            var targetTwo = SingletonClassic.GetInstance();

            Assert.AreSame(targetOne,targetTwo);
            Assert.IsTrue(targetOne.MyInt == 1234);
            Assert.IsTrue(targetTwo.MyInt == 1234);
        }

        [TestMethod]
        public void SingleClassicNonThreadSafeTest()
        {
            bool exceptionWasThrown = false;
            var target = new List<SingletonClassic>();
            try
            {
                Parallel.For(0, 10000, index =>
                {
                    target.Add(SingletonClassic.GetInstance());
                });
                for (var index = 0; index < target.Count; index++)
                {
                    if (index < target.Count - 1) Assert.AreSame(target[index], target[index++]);
                }
                
            }
            catch (Exception e)
            {
                Assert.IsNotNull(e);
                exceptionWasThrown = true;
            }
            Assert.IsTrue(exceptionWasThrown, "Expected unknown exception");

        }

        [TestMethod]
        public void SingletonThreadsafeTest()
        {
            var targetOne = ThreadSafeSingleton.GetInstance();
            targetOne.MyInt = 1234;
            var targetTwo = ThreadSafeSingleton.GetInstance();

            Assert.AreSame(targetOne,targetTwo);
            Assert.IsTrue(targetOne.MyInt == 1234);
            Assert.IsTrue(targetTwo.MyInt == 1234);
        }

        [TestMethod]
        public void SingletonThreadsafeThreadSafeTest()
        {
            var target = new List<ThreadSafeSingleton>();
            Parallel.For(0, 10000, index =>
            {
                target.Add(ThreadSafeSingleton.GetInstance());
            });
            for (var index = 0; index < target.Count; index++)
            {
                if(index<target.Count-1)Assert.AreSame(target[index], target[index++]);
            }
        }
    }
}
