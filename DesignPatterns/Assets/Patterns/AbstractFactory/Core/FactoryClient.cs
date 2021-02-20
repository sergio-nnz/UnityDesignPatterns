using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryClient : MonoBehaviour
{
    private void Start()
    {
        FactoryBase factory1 = Factory.Create(0);
        Debug.Log(factory1.Title);
        FactoryBase factory2 = Factory.Create(1);
        Debug.Log(factory2.Title);
    }
}
