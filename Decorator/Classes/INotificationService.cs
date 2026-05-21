using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Classes
{
    public interface INotificationService
    {
        public void Send(string message);
    }

    public class EmailNotificationService : INotificationService
    {
        public void Send(string message)
        {
            //Add logs 
            //Add encryption
            //add caching
            //...etc 
            Console.WriteLine($"Email sent: {message}");
        }
    }
    //or make new subclass that handles new behaviour

    //both bad
}
