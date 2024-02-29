using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : MonoBehaviour
{
    [SerializeField] string weaponType = "Sword";
    IWeapon weapon;

    private void Start()
    {
        switch (weaponType)
        {
            case "Sword":
                weapon = new Sword();
                Attack();
                break;

            case "Bow":
                weapon = new Bow();
                Attack();
                break;
        }
    }

    public void Attack()
    {
        weapon?.Attack();
    }
}
