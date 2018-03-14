using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// the object this script is attached to will act as a collision-based trigger (make sure your camera and this object both have colliders)
/// it will trigger the game object that is specified to become active when collision is happening, and become inactive when collision stops
/// </summary>

public class Hotspot : MonoBehaviour {

    public GameObject ObjectToToggleVisibility;

    [SerializeField]
    public bool StartInvisible;

    public delegate void HotspotEntered();
    public static HotspotEntered OnHotspotEntered;

    public delegate void HotspotExited();
    public static HotspotExited OnHotspotExited;

    bool CurrentState;

    private void Start()
    {
        if (StartInvisible)
        {
            CurrentState = true;
        }
        else {
            CurrentState = false;
        }
    }

    void OnTriggerEnter(Collider other)
    {

        ObjectToToggleVisibility.SetActive(CurrentState);
        Debug.Log("Trigger Entered");
        CurrentState = !CurrentState;
    }

    void OnTriggerExit(Collider other)
    {
        //Debug.Log("Trigger exit");
        ObjectToToggleVisibility.SetActive(CurrentState);
        Debug.Log("Trigger Exited");
        CurrentState = !CurrentState;
    }
}
