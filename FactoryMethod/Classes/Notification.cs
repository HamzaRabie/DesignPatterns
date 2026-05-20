using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Classes
{
    public interface INotification
    {
        void sendMessaage(string messaage);
    }

    public class EmailNotification : INotification
    {
        public void sendMessaage(string messaage) {
            Console.WriteLine(messaage);
        }
    }

    public class SmsNotification : INotification
    {
        public void sendMessaage(string messaage)
        {
            Console.WriteLine(messaage);
        }
    }
}
