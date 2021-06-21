using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bagunh : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 target = new Vector3(-2199, -309, 0);


    void Update()
    {
        transform.localPosition = Vector3.MoveTowards(transform.localPosition, target, 4f);

        if(transform.localPosition==target)
        {
            transform.localPosition = new Vector3(4207, -309, 0);
        }




    }

}
