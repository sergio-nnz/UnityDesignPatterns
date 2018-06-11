using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatePatternContext
{
    private IState state;

    public StatePatternContext()
    {
        state = null;
    }

    public void Request()
    {
        state.Handle(this);
    }

    public IState State
    {
        get
        {
            return state;
        }
        set
        {
            state = value;
        }
    }
}
