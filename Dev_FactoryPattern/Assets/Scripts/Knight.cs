using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;


public class Knight : MonoBehaviour
{
    [SerializeField] WeaponFactory weaponFactory;
    IWeapon weapon= IWeapon.CreateDefault();

    private void Start()
    {
        if (weaponFactory != null)
        {
            weapon = weaponFactory.CreateWeapon();
        }

        Attack();
    }

    public void Attack()
    {
        weapon?.Attack();
    }
}
