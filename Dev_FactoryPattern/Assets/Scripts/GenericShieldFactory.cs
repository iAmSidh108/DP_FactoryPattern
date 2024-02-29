using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Generic Shield Factory", menuName ="Shield Factory/Generic")]
public class GenericShieldFactory : ShieldFactory
{
    IShield shield;

    public override IShield ProvideShield()
    {
        if (shield == null)
        {
            shield = new Shield();
        }

        return shield;
    }
}
