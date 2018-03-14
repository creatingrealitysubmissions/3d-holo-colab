using HoloToolkit.Unity.InputModule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImportButton : MonoBehaviour {

    public GameObject AssetToShow;

    public void OnInputClicked(InputClickedEventData eventData)
    {

        Debug.Log("OnInputClicked called");
        AssetToShow.SetActive(true);
    }
}
