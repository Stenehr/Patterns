using System;

namespace Patterns.Decorator
{
    public static class DecoratorPattern
    {
        public static void Run()
        {
            var doer = new Doer();
            doer.Something();

            Console.WriteLine("--------------------");

            var another = new AnotherThing(doer);
            another.Something();

            Console.WriteLine("--------------------");

            var additional = new InAdditon(another);

            additional.Something();

            Console.WriteLine("--------------------");

            var secondAnother = new AnotherThing(additional);
            secondAnother.Something();
        }
    }

    public interface IDoSomething
    {
        void Something();
    }

    public class Doer : IDoSomething
    {
        public void Something()
        {
            Console.WriteLine("Doer doing");
        }
    }

    public class AnotherThing : IDoSomething
    {
        protected IDoSomething DoSomething;

        public AnotherThing(IDoSomething doSomething) => DoSomething = doSomething;

        public void Something()
        {
            DoSomething.Something();
            Console.WriteLine("Another thing does something");
        }
    }

    public class InAdditon : IDoSomething
    {
        protected IDoSomething DoSomething;

        public InAdditon(IDoSomething doSomething) => DoSomething = doSomething;

        public void Something()
        {
            DoSomething.Something();
            Console.WriteLine("Additonal thing does something");
        }
    }
}
