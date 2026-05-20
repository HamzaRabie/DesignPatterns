using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Classes
{
    public class SimpleFactory
    {
        public static INotification CreateNotification(string type)
        {
            //problem => will grow too much with new types (Not Best Solution)
            return type switch
            {
                "Email" => new EmailNotification(),
                "Sms" => new SmsNotification(),
                _ => throw new ArgumentException("Unkown Type")
            };
        }
    }
}
