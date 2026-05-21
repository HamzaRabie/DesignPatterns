using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Classes
{
    public class Gateway
    {
        public void SendPayment(decimal money)
        {
            Console.WriteLine($"Paid {money} using PayPal");
        }
    }


}
