using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Classes
{
    public abstract class NotificationDecorator : INotificationService
    {
        protected readonly INotificationService _notificationService;
        protected NotificationDecorator(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        public abstract void Send(string message);
    }

    public class LoggingDecorator : NotificationDecorator
    {
        public LoggingDecorator(INotificationService service) : base(service) { }

        public override void Send(string message)
        {
            Console.WriteLine($"Logging: Done");
            _notificationService.Send(message);


        }
    }
        
    public class EncryptionDecorator : NotificationDecorator
    {
        public EncryptionDecorator(INotificationService service) : base(service) { }
        public override void Send(string message)
        {
            Console.WriteLine($"Encrypting: SXCSDS");
            _notificationService.Send(message);
        }
    }
}
