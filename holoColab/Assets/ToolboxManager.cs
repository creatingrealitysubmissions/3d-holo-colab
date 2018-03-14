using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToolboxManager : MonoBehaviour {

    public void ActivateAsset(GameObject Asset)
    {
        Debug.Log("Activate: " + Asset);
        Asset.SetActive(true);
    }

    public void DebugMessage()
    {
        Debug.Log("button clicked");
    }

}
