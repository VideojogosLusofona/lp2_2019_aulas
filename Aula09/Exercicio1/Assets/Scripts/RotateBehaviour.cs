using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBehaviour : MonoBehaviour, IAnimateBehaviour
{
    public void Animate()
    {
        transform.Rotate(0.2f, 0.2f, 0.2f);
    }
}
