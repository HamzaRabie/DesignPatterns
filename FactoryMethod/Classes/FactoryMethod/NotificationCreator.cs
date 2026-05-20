using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Classes.FactoryMethod
{
    public abstract class NotificationCreator
    {
        public abstract INotification CreateNotification();

        public void Send(string message)
        {
            INotification notification = CreateNotification();
            notification.sendMessaage(message);
        }
    }

    public class EmailNotificationCreator : NotificationCreator
    {
        public override INotification CreateNotification()
        {
            return new EmailNotification();
        }
    }

    public class SmsNotificationCreator : NotificationCreator
    {
        public override INotification CreateNotification()
        {
            return new SmsNotification();
        }

    }
}
