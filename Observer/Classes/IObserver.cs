using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Classes
{
    public interface IObserver
    {
        void update(string message);
    }

    public class Subscriber1 : IObserver
    {
        public void update(string message)
        {
            Console.WriteLine("Subscriber 1 received: " + message);
        }
    }

    public class Subscriber2 : IObserver
    {
        public void update(string message)
        {
            Console.WriteLine("Subscriber 1 received: " + message);
        }
    }
}
