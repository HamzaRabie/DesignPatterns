using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Classes
{
    public class PaymentContext
    {
        private readonly IpaymentService _paymentService;
        public PaymentContext(IpaymentService service)
        {
            _paymentService = service;
        }

        public void Pay(decimal amount)
        {
            _paymentService.Pay(amount);
        }
    }
}
