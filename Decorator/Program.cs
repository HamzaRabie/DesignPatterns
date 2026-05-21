using Decorator.Classes;

namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            INotificationService service = new EmailNotificationService();
            //  service.Send("Hello Base");

            // service = new LoggingDecorator(service);
            //  service = new EncryptionDecorator(service);
            //    service.Send("Hello Decorator");

            //   INotificationService service2 = new LoggingDecorator(new EncryptionDecorator(service));
            //  service2.Send("Hello Decorator 2");
            //********************************** Cofee Example **************************************//
            ICoffeService base_coffeService = new BasicCoffe();

            base_coffeService = new MilkCofeeDecorator(base_coffeService);
            base_coffeService = new SugarCofeeDecorator(base_coffeService);

            base_coffeService.Description();
            Console.WriteLine(base_coffeService.Cost());
        }
    }
}
