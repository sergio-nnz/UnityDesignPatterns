using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrategyClient
{
    public IStrategy Strategy {get; set;}

    public void CallAlgorithm()
    {
        Debug.Log(Strategy.Algorithm());
    }
}
