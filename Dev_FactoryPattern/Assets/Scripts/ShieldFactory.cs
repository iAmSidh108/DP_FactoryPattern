using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ShieldFactory : ScriptableObject
{
    public abstract IShield CreateShield();
}






