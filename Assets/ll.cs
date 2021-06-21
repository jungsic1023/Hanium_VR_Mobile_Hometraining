using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class ll : MonoBehaviour
{
    /* 시점 방향으로 이동하는 스크립트입니다. */


    // Update is called once per frame
    int speed = 3;
    void Update()
    {
        transform.Translate(Vector3.forward * 0, Space.World);
    }
   
   

   

}
