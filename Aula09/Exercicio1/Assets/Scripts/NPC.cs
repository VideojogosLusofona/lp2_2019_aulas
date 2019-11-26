using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    private IAnimateBehaviour animateBehaviour;

    private void Awake()
    {
        animateBehaviour = GetComponent<IAnimateBehaviour>();
    }

    // Update is called once per frame
    private void Update()
    {
        animateBehaviour.Animate();
    }

}
