using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    // Start is called before the first frame update
    int speed = 10;
    public GameObject Target;
    void Update ()
    {


        int ran = Random.Range(1, 20);


        float fMove = Time.deltaTime * speed;
        transform.Translate(Vector3.forward * fMove);

        if (ran>=15)
        {
            transform.Rotate(0, 30, 0);
        }
        

     

    }
}
