using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class df : MonoBehaviour
{
    // Start is called before the first frame update

    Vector3 target = new Vector3(8, 1.5f, 0);
    // Update is called once per frame
    void Update()
    {
        Vector3 velo = Vector3.zero;

        transform.position =
            Vector3.SmoothDamp(transform.position, target, ref velo, 1f);

    }
}
