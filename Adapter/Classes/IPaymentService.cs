using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Classes
{
    public interface IPaymentService
    {
        void Pay(decimal amount);
    }

    public class FirstPaymentService : IPaymentService
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} using Credit Card");
        }
    }

    public class PaymentAdapter : IPaymentService
    {
        private Gateway PayGateway;
        public PaymentAdapter(Gateway gateway)
        {
            PayGateway = gateway;
        }

        public void Pay(decimal amount)
        {
            PayGateway.SendPayment(amount);
        }

    }

    //public class SecondPaymentService : IPaymentService
    //{
    //    //i have to use gateway
    //    public void Pay(decimal amount)
    //    {
    //        Console.WriteLine($"Paid {amount} using Visa Card");
    //    }
    //}


}
