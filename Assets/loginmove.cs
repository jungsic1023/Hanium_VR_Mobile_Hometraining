using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loginmove : MonoBehaviour
{
    Vector3 target = new Vector3(297, 640, 0);

    
    void Update()
    {
        transform.localPosition = Vector3.MoveTowards(transform.localPosition, target, 50f);

       
        
        


    }


   

}

    