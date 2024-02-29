using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowFactory : WeaponFactory
{
    public override IWeapon CreateWeapon()
    {
        return new Bow();
    }
}
