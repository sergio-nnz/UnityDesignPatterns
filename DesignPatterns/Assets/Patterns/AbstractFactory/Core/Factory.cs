using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Factory
{
    public static FactoryBase Create(int id)
    {
        switch (id)
        {
            case 0:
                return new Derived1();
            case 1:
                return new Derived2();
            default:
                return null;
        }
    }
}
