using FactoryMethod.Classes.FactoryMethod;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Classes
{
    public class NotificationService
    {
        //   public void sendNotification (string type , string message)
        public void sendNotification()
        {
            /*
             * if type == email => blaa 
             * if type == sms =>  blaa
             */

            //simple factory (not of GOF)
            /*
            INotification notification = SimpleFactory.CreateNotification(type);
            notification.sendMessaage(message);
            */



            //Factory Method
            NotificationCreator creator;

            creator = new EmailNotificationCreator();
            creator.Send("From EMAAAAAAAAAAAAAAAAAIl"); ;


        }
    }
}
