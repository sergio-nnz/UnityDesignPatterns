using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Decorator
{
    public class MilkDecorator : CondimentDecorator
    {
        public MilkDecorator(ICoffee coffee) : base(coffee)
        {
            _name = "Milk";
            _price = 0.19;
        }
    }

    public class ChocolateDecorator : CondimentDecorator
    {
        public ChocolateDecorator(ICoffee coffee) : base(coffee)
        {
            _name = "Chocolate";
            _price = 0.29;
        }
    }

    public class SpecialMessageOfDay : CondimentDecorator
    {
        private int m_DiscountRate = 5;

        public SpecialMessageOfDay(ICoffee coffee) : base(coffee)
        {
            _name = "Name Card";
            _price = 4.0;
        }

        public override string GetDescription()
        {
            return base.GetDescription() +
            string.Format("\n(Please Collect your discount card for {0}%)",
            m_DiscountRate);
        }
    }
}
