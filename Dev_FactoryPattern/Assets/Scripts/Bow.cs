using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : IWeapon
{
    public void Attack()
    {
        Debug.Log("Shooting an arrow.");
    }
}
