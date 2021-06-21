using System.Collections;
using UnityEngine;
using UnityEngine.XR;
public class dsaa : MonoBehaviour
{
    public float a = 0;
    public float moveSpeed = 5f;
    public float turnSpeed = 540f;

    // Update is called once per frame
    void Update()
    {


        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        //transform.Translate (0f, 0f, h * moveSpeed * Time.deltaTime);

        //Move
        transform.Translate(0f, 0f, v * moveSpeed * Time.deltaTime);

        transform.Translate(h * moveSpeed * Time.deltaTime, 0f,0f);




    }






}

