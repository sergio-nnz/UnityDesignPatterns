using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Decorator
{
    public abstract class CondimentDecorator : ICoffee
    {
        private ICoffee _coffee;

        protected string _name = "Undefined Condiment";
        protected double _price = 0.0;

        public CondimentDecorator(ICoffee coffee)
        {
            _coffee = coffee;
        }

        public virtual string GetDescription()
        {
            return string.Format("{0}, {1}", _coffee.GetDescription(), _name);
        }

        public double GetPrice()
        {
            return _coffee.GetPrice() + _price;
        }
    }
}