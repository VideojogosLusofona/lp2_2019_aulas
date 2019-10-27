using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListenAndDebugLog : MonoBehaviour
{
    private EventMaster em;

    private void Awake()
    {
        em = GetComponent<EventMaster>();
    }

    private void OnEnable()
    {
        em.KeyPress += PrintToDebugLog;
    }

    private void OnDisable()
    {
        em.KeyPress -= PrintToDebugLog;
    }

    private void PrintToDebugLog()
    {
        Debug.Log("A key was pressed");
    }
}
