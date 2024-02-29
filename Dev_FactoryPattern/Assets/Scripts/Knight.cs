using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;


public class Knight : MonoBehaviour
{
    [SerializeField] EquipmentFactory equipmentFactory;

    private void Start()
    {
        Attack();
        Defend();
    }

    public void Attack()
    {
        equipmentFactory.CreateWeapon().Attack();
    }

    public void Defend()
    {
        equipmentFactory.CreateShield().Defend();
    }
}
