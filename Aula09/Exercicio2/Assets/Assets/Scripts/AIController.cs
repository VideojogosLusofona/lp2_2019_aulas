using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AIController : MonoBehaviour
{

    private ICollection<AnimalsAI> _AIs;

    private IEnumerator TakeTurns()
    {
        YieldInstruction wfs =
            new WaitForSeconds(2f);

        while (true)
        {
            foreach (AnimalsAI ai in _AIs)
            {
                ai.TakeTurn();
            }
            yield return wfs;
        }
    }

    private void Awake()
    {
        _AIs = new List<AnimalsAI>();
        _AIs.Add(new SheepAI());
        _AIs.Add(new WolvesAI());
    }

    private void Start()
    {
        StartCoroutine(TakeTurns());
    }

}
