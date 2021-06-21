using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fffff : MonoBehaviour
{
    public CharacterController con;
    public float speed = 12f;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        //transform.Translate (0f, 0f, h * moveSpeed * Time.deltaTime);

        //Move
        Vector3 move = transform.right * x + transform.forward * z;
        con.Move(move * speed * Time.deltaTime);
    }
}
