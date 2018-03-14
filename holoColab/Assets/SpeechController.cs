using HoloToolkit.Unity.InputModule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeechController : MonoBehaviour {

    public void OnSpeechKeywordRecognized(SpeechEventData eventData)
    {
        Debug.Log("heard: " + eventData);
    }
}
