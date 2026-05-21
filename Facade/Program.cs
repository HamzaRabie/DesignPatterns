using Facade.Classes;

namespace Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OrderFacade order = new OrderFacade();
            order.PlaceOrder();
        }
    }
}
