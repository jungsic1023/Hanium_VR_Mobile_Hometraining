using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class rotate : MonoBehaviour
{
    public Transform from;
    public Transform to;
    public float speed = 0.1F;
    public enum RotateType { TwoD, ThreeD };
    public RotateType rotateType;

    // slerp 회전속도
    public float rotateSpeed = 5.0f;
    void Update()
    {
        switch (rotateType)
        {
           
            case RotateType.ThreeD: Rotate3D(); break;
        }

    }
    void Rotate3D()
    {
        // 방향키
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(h, 0.0f, v);
        transform.Translate(0f, 0f, v * speed * Time.deltaTime);
        if (dir != Vector3.zero)
        {
            float angle = Mathf.Atan2(dir.x, dir.z) * Mathf.Rad2Deg;
            // transform.rotation = Quaternion.Euler(0.0f, angle, 0.0f);
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0.0f, angle, 0.0f), rotateSpeed * Time.deltaTime);
        }
    }
}

