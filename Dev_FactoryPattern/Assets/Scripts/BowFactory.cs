using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Weapon/Bow", fileName ="Bow")]
public class BowFactory : WeaponFactory
{
    IWeapon weapon;

    public override IWeapon ProvideWeapon()
    {
        if (weapon == null)
        {
            weapon = new Bow();
        }
        return weapon;
    }
}
