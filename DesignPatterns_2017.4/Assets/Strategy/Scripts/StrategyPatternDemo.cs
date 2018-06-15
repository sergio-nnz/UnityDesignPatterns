using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrategyPatternDemo : MonoBehaviour
{
    StrategyClient client;

    private void Awake()
    {
        client = new StrategyClient();
    }

    private void Start()
    {
        client.Strategy = new ConcreteStrategyA();
        client.CallAlgorithm();
        client.Strategy = new ConcreteStrategyB();
        client.CallAlgorithm();
    }
}
