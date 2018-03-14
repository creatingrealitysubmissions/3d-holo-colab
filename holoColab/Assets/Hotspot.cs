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

    public delegate void HotspotEntered();
    public static HotspotEntered OnHotspotEntered;

    public delegate void HotspotExited();
    public static HotspotExited OnHotspotExited;

    void OnTriggerEnter(Collider other)
    {

        VisibilityOn();
        //Debug.Log("login popup");
    }

    void OnTriggerExit(Collider other)
    {
        //Debug.Log("Trigger exit");
        VisibilityOff();
        //Debug.Log("login go away");
    }


    private void VisibilityOn()
    {
        ObjectToToggleVisibility.SetActive(true);
    }

    private void VisibilityOff()
    {
        ObjectToToggleVisibility.SetActive(false);
    }
}
