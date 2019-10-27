using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventMaster : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey) OnKeyPress();
    }

    private void OnGUI()
    {
        GUI.color = Color.blue;
        GUI.Label(new Rect(10, 10, 500, 20), "Press S to shoot.");
    }

    protected virtual void OnKeyPress()
    {
        if (KeyPress != null) KeyPress();
    }

    public event Action KeyPress;

}
