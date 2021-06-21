using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.XR;

public class StartVR : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        StartCoroutine(LoadDevice("cardboard"));
      
        
        XRSettings.enabled = true;
    }

    IEnumerator LoadDevice(string newDevice)
    {
        XRSettings.LoadDeviceByName(newDevice);
        yield return null;
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        XRSettings.enabled = true;
    }

}