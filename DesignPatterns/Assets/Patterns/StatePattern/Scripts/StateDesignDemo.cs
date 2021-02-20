using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateDesignDemo : MonoBehaviour
{
    ConcreteStateA concreteStateA;
    ConcreteStateB concreteStateB;
    StatePatternContext context;

    private void Awake()
    {
        concreteStateA = new ConcreteStateA();
        concreteStateB = new ConcreteStateB();
        context = new StatePatternContext();
    }

    private void Start()
    {
        concreteStateA.Handle(context);
        concreteStateB.Handle(context);
    }
}
