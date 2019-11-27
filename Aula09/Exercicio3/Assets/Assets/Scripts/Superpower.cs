using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Superpower : MonoBehaviour
{

    // Activate superpower
    public abstract void Activate();

    // The following methods are available to concrete superpowers, which can
    // mix and match them

    // Deal some damage
    protected void DealDamage(float damage)
    {
        Debug.Log($"Caused {damage} damage!");
    }

    // Gain some health
    protected void Heal(float health)
    {
        Debug.Log($"I gained {health} health!");
    }

    // Show some fire with a particle system
    protected void LightMyFire()
    {
        Debug.Log($"FIRE! Something is burning!");
    }

    // Speed boost
    protected void BoostSpeed(float percent)
    {
        if (percent >= 0)
            Debug.Log($"I'm going {percent * 100}% faster!");
        else
            Debug.Log($"I'm going {percent * -100} percent slower!");
    }

    // Some more...
}

