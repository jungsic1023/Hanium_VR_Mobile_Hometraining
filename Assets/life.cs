using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class life : MonoBehaviour
{
    /* 시점 방향으로 이동하는 스크립트입니다. */
    //public float turnSpeed = 1;

    // Update is called once per frame
    int speed = 10;
    void Start()
    {

    }

    void Update()
    {
      
            float fMove = Time.deltaTime * speed;
            transform.Translate(Vector3.forward * fMove);
        int a = 1000;
        float h = a;
       
           //transform.Rotate(0f, -30 * Time.deltaTime, 0f);
       // transform.rotation = Quaternion.Euler(new Vector3(0, 30, 0));
        transform.Rotate(0, 30, 0);

    }

   
   
}
