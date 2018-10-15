using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Decorator
{
    public interface ICoffee
    {
        string GetDescription();

        double GetPrice();
    }
}
