using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordFactory : WeaponFactory
{
    public override IWeapon CreateWeapon()
    {
        return new Sword();
    }
}
