using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IShield
{
    void Defend();

    static IShield CreateDefault()
    {
        return new Shield();
    }
}
