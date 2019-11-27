using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealhierWhenHittingPower : Superpower
{

    // Health to gain and damage to deal
    [SerializeField] [Range(0, 100)] private float healthGain = 10;
    [SerializeField] [Range(0, 100)] private float damageToDeal = 5;

    // Activate the SpeedFire power
    public override void Activate()
    {
        // This power consists of dealing damage while gaining some health
        DealDamage(damageToDeal);
        Heal(healthGain);
    }
}
