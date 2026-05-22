using Strategy.Classes;

namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IpaymentService credit = new CreditCardPaymentService();
            IpaymentService paypal = new PayPalPaymentService();

            PaymentContext payment = new PaymentContext(credit);
            payment.Pay(100);

            payment = new PaymentContext(paypal);
            payment.Pay(100);
        }
    }
}
