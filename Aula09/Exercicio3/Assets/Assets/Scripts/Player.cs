using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    // Interval between powers activation
    [SerializeField]
    [Range(0, 100f)]
    private float powerActivationInterval = 3f;

    // The powers this player has
    private IEnumerable<Superpower> powers = null;

    // Use this for initialization
    void Start()
    {
        // Does this player have any powers attached?
        powers = GetComponents<Superpower>();

        // Start powers co-routine
        StartCoroutine(ActivateSuperPowers());
    }

    // Co-routine which activates the powers of this player
    IEnumerator ActivateSuperPowers()
    {
        while (true)
        {
            // Wait some time
            yield return new WaitForSeconds(powerActivationInterval);
            // And activate powers
            Debug.Log($"~~~~~~~~~~~~~~~~~ {gameObject.name} ~~~~~~~~~~~~~~~~~");
            foreach (Superpower sp in powers)
            {
                Debug.Log($"===> {sp.GetType().Name} <===");
                sp.Activate();
            }
        }
    }
}
