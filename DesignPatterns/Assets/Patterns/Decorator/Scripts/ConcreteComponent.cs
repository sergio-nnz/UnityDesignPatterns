using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Decorator
{
    public class Filtered : ICoffee
    {
        public string GetDescription()
        {
            return "Filtered with care";
        }

        public double GetPrice()
        {
            return 1.99;
        }
    }

    public class Espresso : ICoffee
    {
        public string GetDescription()
        {
            return "Espresso made with care";
        }

        public double GetPrice()
        {
            return 2.99;
        }
    }
}
