using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Classes
{
    public interface ICoffeService
    {
        public void Description();
        public int Cost();  
    }

    public class BasicCoffe : ICoffeService
    {
        public void Description()
        {
            Console.WriteLine("Basic Coffe");
        }
        public int Cost()
        {
            return 5;
        }
    }
}
