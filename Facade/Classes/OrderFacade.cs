using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.Classes
{
    public class OrderFacade
    {
        private PaymentService _payment = new PaymentService();
        private InventoryService _inventory = new InventoryService();
        private ShippingService _shipping = new ShippingService();

        public void PlaceOrder()
        {
            _payment.Pay();
            _inventory.Reserve();
            _shipping.Ship();
        }
    }
}
