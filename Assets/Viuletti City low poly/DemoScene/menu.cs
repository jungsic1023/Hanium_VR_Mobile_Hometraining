using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour
{
    public void ChangeScene(string scencName)
    {
        Application.LoadLevel(scencName);
    }
    // Start is called before the first frame update
 
}
