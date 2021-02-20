using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConcreteStateA : IState
{
    public void Handle(StatePatternContext context)
    {
        Debug.Log("Concrete State A was Selected");
        context.State = new ConcreteStateA();
    }
}