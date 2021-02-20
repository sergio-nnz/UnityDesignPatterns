using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConcreteStrategyA : IStrategy
{
    public string Algorithm()
    {
        return "Concrete Strategy A";
    }
}
