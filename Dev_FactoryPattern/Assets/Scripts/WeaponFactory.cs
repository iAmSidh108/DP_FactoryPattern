using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class WeaponFactory: ScriptableObject
{
    public abstract IWeapon ProvideWeapon();
}
