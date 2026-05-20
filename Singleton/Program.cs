using Singleton.Classes;

namespace Singleton
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            SingeltonClass c1 = SingeltonClass.GetInstance();
            SingeltonClass c2 = SingeltonClass.GetInstance();
            Console.WriteLine(c1 + "   "+c2);
            Console.WriteLine(c1==c2);
        }



    }
}
