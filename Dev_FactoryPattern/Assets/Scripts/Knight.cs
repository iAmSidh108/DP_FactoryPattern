using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : MonoBehaviour
{
    WeaponFactory weaponFactory;
    IWeapon weapon;

    private void Start()
    {
        weaponFactory = new SwordFactory();
        weapon = weaponFactory.CreateWeapon();
    }

    public void Attack()
    {
        weapon?.Attack();
    }
}
