using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Classes
{
    public abstract class CoffeeDecorator : ICoffeService
    {
        public ICoffeService _coffeService { get; }

        protected CoffeeDecorator(ICoffeService _coffeService)
        {
            this._coffeService = _coffeService;
        }

        public abstract int Cost();
        public abstract void Description();

    }

    public class MilkCofeeDecorator : CoffeeDecorator
    {
        public MilkCofeeDecorator(ICoffeService _coffeService) : base(_coffeService) { }

        public override int Cost()
        {
            return 3 * _coffeService.Cost();
        }

        public override void Description()
        {
            Console.WriteLine("Milk Added");
            _coffeService.Description();
        }
    }

    public class SugarCofeeDecorator : CoffeeDecorator
    {
        public SugarCofeeDecorator(ICoffeService _coffeService) : base(_coffeService) { }
        public override int Cost()
        {
            return 2 * _coffeService.Cost();
        }
        public override void Description()
        {
            Console.WriteLine("Sugar Added");
            _coffeService.Description();
        }
    }
}
