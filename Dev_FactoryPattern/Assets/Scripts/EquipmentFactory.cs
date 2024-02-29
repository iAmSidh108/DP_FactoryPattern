using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

[CreateAssetMenu(menuName ="Equipment Factory", fileName ="Equipment Factory")]
public class EquipmentFactory : ScriptableObject
{
    public WeaponFactory WeaponFactory;
    public ShieldFactory ShieldFactory;

    public IWeapon CreateWeapon()
    {
        if (WeaponFactory != null)
        {
            return WeaponFactory.ProvideWeapon();
        }

        return IWeapon.CreateDefault();
    }

    public IShield CreateShield()
    {
        if (ShieldFactory != null)
        {
            return ShieldFactory.ProvideShield();
        }

        return IShield.CreateDefault();
    }
}
