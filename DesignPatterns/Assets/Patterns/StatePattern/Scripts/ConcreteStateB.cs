using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConcreteStateB : IState
{
    public void Handle(StatePatternContext context)
    {
        Debug.Log("Concrete State B was Selected");
        context.State = new ConcreteStateB();
    }
}
