using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class move : MonoBehaviour
{
    /* 시점 방향으로 이동하는 스크립트입니다. */


    // Update is called once per frame
    int speed = 10;
    void Start()
    {

    }

    void Update()
    {
        


            float fMove = Time.deltaTime * speed;
            transform.Translate(Vector3.forward * fMove);
         
       

    }

   

}
