using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour {

    //bool buttonDown = false;

    [SerializeField]
    float rotateSpeed = 10f;

    //public GameObject ObjectToRotate;

    //public GameObject ButtonText; // to be used to switch button text from Rotate to Stop

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, rotateSpeed*Time.deltaTime, 0));
    }
}
