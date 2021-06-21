using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class time : MonoBehaviour
{
   
   
    void Start()
    {
      





         String a = DateTime.Now.ToString(("mm"));
         int b = int.Parse(a);
         int c = 60 - b;

         Debug.Log(c);

         if(c>=30 && c<=59)
         {
            

             GameObject.Find("Canvas").transform.Find("high").gameObject.SetActive(true);
         }

        else if (c >= 0 && c <= 29)
        {


            GameObject.Find("Canvas").transform.Find("night").gameObject.SetActive(true);
        }
    }




     public static string GetCurrentDate()
      {
         return DateTime.Now.ToString(("yyyy-MM-dd HH:mm:ss tt"));
    }


}
