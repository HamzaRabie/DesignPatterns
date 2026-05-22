using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Classes
{
    public interface IpaymentService
    {
        void Pay(decimal amount);
    }

    public class CreditCardPaymentService : IpaymentService
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Processing credit card payment of {amount:C}");
        }
    }

    public class PayPalPaymentService : IpaymentService
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Processing PayPal payment of {amount:C}");
        }
    }
}
