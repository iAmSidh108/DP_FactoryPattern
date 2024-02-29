using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Weapon/Sword", fileName = "Sword")]
public class SwordFactory : WeaponFactory
{
    IWeapon weapon;
    public override IWeapon ProvideWeapon()
    {
        if(weapon == null)
        {
            weapon = new Sword();
        }
        return weapon;
    }
}
