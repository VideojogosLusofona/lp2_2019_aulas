using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedFirePower : Superpower
{

    // Speed can be defined in the editor
    [SerializeField] [Range(-1f, 1f)] private float speedBoostPercent = 0.1f;

    // Activate the SpeedFire power
    public override void Activate()
    {
        // This power consists of a speed boost and a fire particle effect
        BoostSpeed(speedBoostPercent);
        LightMyFire();
    }
}
