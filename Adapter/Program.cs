using Adapter.Classes;

namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPaymentService firstPayment = new FirstPaymentService();
            firstPayment.Pay(100);

            Gateway newGateway = new Gateway();
            IPaymentService sencondPayment = new PaymentAdapter(newGateway);
            sencondPayment.Pay(200);


        }
    }
}
