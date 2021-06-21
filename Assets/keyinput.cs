using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;



// Transform.rotation example.

// Rotate a GameObject using a Quaternion.
// Tilt the cube using the arrow keys. When the arrow keys are released
// the cube will be rotated back to the center using Slerp.

public class keyinput : MonoBehaviour
{
     RaycastHit hit;
    public float distance = 5;
    Ray ray;

    void Start()
    {
    }
    void Update()
    {

        ray = new Ray();
        ray.origin = this.transform.position;
        ray.direction = this.transform.right;
        
        /* if (Physics.Raycast(transform.position, transform.forward, out hit, maxDistance))
         { 
             Debug.Log("hit point : " + hit.point + ", distance : " + hit.distance + ", name : " + hit.collider.name);
             Debug.DrawRay(transform.position, transform.forward * hit.distance, Color.red); 
         } 

         else
         {
             Debug.DrawRay(transform.position, transform.forward * 1000f, Color.red); 
         }
        */

        if(Physics.Raycast(transform.position, ray.direction, out hit, distance))
        {
            Debug.Log(hit.collider.gameObject.name);

            transform.Rotate(0, 0, -90);
            //  transform.Rotate(Vector3.right * Time.deltaTime * 90);

        }
        transform.Translate(Vector3.right * Time.deltaTime*2);

     

    }
    void OnDrawGizmos()
    {
        Debug.DrawRay(transform.position, ray.direction, Color.red);
        
    }
}

