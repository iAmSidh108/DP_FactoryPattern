using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Generic Shield Factory", menuName ="Shield Factory/Generic")]
public class GenericShieldFactory : ShieldFactory
{
    public override IShield CreateShield()
    {
        return new Shield();
    }
}
