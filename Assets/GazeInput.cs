using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using System;
using UnityEngine.VR;

public class GazeInput : MonoBehaviour
{
    GameObject Currentgaze = null;

   


    void Update()
    {
       

        RaycastHit hitInfo;

        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward,
out hitInfo, 9999f))
        {
            if (Currentgaze == null)
            {
                hitInfo.collider.SendMessage("OnGazeEnter", SendMessageOptions.DontRequireReceiver);
               
                Currentgaze = hitInfo.collider.gameObject; 

                SendMessage("Onhitinfo", hitInfo, SendMessageOptions.DontRequireReceiver);
            }
        }
        else
        {
            if (Currentgaze != null) 
            {
                Currentgaze.SendMessage("OnGazeExit", SendMessageOptions.DontRequireReceiver);
              
                Currentgaze = null;
            }
        }
    }
    void OnDrawGizmos()
    {
        Gizmos.DrawLine(transform.position, transform.position + transform.forward * 1000f);
       
    }





}

