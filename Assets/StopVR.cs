using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;

public class StopVR : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Screen.orientation = ScreenOrientation.AutoRotation;
        XRSettings.enabled = false;
    }

}