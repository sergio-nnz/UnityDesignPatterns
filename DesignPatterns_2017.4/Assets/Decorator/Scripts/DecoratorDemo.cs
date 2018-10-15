using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Decorator;

public class DecoratorDemo : MonoBehaviour
{
    private void Awake()
    {
        ICoffee coffe1 = new ChocolateDecorator(new Filtered());
        ICoffee coffe2  = new ChocolateDecorator(new MilkDecorator(new Espresso()));

        Debug.Log(coffe1.GetDescription());
        Debug.Log(coffe2.GetDescription());
    }
}
