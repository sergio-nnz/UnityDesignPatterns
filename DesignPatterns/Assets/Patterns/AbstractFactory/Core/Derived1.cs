using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Derived1 : FactoryBase
{
    public override string Title
    {
        get
        {
            return "Derived1";
        }
    }
}
