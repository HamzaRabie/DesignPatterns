using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.Classes
{
    public class PaymentService
    {
        public void Pay() => Console.WriteLine("Paid");
    }

    public class InventoryService
    {
        public void Reserve() => Console.WriteLine("Stock reserved");
    }

    public class ShippingService
    {
        public void Ship() => Console.WriteLine("Order shipped");
    }
}
