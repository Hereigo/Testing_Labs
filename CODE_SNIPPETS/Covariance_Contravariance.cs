using System;
using System.Threading;

namespace CODE_SNIPPETS
{
    public class Covariance_Contravariance
    {
        public void TestFor_FathersWork(Father father)
        {
            father.FathersWork();
        }

        public void Run()
        {
            TestFor_FathersWork((Father)new GrandFather()); // - cannot convert implicitly
            TestFor_FathersWork(new Son());
        }
    }

    public class GrandFather
    {
    }

    public class Father : GrandFather
    {
        public Father TestB()
        {
            return (Father)new GrandFather(); // - cannot convert implicitly
            return new Son();
        }

        public void FathersWork()
        {
            Console.WriteLine("Test B 2.");
        }
    }

    public class Son : Father
    {
    }

}