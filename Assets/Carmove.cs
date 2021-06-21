using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ArduinoBluetoothAPI;
using System;
using System.Text;

public class Carmove : MonoBehaviour
{

    
    public float sp = 0f;
    public float turnSpeed = 540f;
    int x = 0;
    int y = 0;

    BluetoothHelper bluetoothHelper;
    BluetoothHelper bluetoothHelper2;
    string deviceName;

    string received_message;

    void Start()
    {
        Debug.Log("sadf");
        deviceName = "HC-06"; //bluetooth should be turned ON;
        try
        {

            bluetoothHelper = BluetoothHelper.GetInstance(deviceName);
            bluetoothHelper.OnConnected += OnConnected;
            bluetoothHelper.OnConnectionFailed += OnConnectionFailed;


            bluetoothHelper.Connect();
            bluetoothHelper.setTerminatorBasedStream("\n");

        }
        catch (Exception ex)
        {
            Debug.Log(ex.Message);


        }

    }
    // Update is called once per frame
    void Update()
    {

        if (bluetoothHelper != null)
        {
            if (bluetoothHelper.Available)
            {
                received_message = bluetoothHelper.Read();
                string text = received_message;
                string[] split_text = new string[4];
                split_text = text.Split(' ');
                string[] Hall = new string[10];
                //Hall[10] = split_text[0];
                //for (int i = 0; i < split_text.Length; i++)
                //Debug.Log(split_text[i]);

                for (int i = 0; i < Hall.Length; i++)
                {
                    Hall[i] = split_text[0];
                    int a = int.Parse(split_text[0]);
                    if (a == 1)
                    {
                        x = x + 1;
                        sp = 1.0f;
                        float fMove = Time.smoothDeltaTime * sp;
                        transform.Translate(Vector3.forward * fMove);
                        Debug.Log("sp는" + sp);
                        if (x < 5)
                        {
                            sp = 1.0f;
                            fMove = Time.smoothDeltaTime * sp;
                            transform.Translate(Vector3.forward * fMove);
                            Debug.Log("sp는" + sp);
                        }
                        else if (x >= 5)
                        {
                            sp = 5.0f;
                            fMove = Time.smoothDeltaTime * sp;
                            transform.Translate(Vector3.forward * fMove);
                            Debug.Log("sp는" + sp);
                        }

                        if (i == 9)
                        {
                            x = 0;
                        }
                    }

                    if (a == 0)
                    {
                        y = y + 1;
                        if (y == 9)
                        {
                            sp = 0.0f;
                            float fMove = Time.smoothDeltaTime * sp;
                            transform.Translate(Vector3.forward * fMove);
                            Debug.Log("sp는" + sp);
                        }
                        if (i == 9)
                        {
                            y = 0;
                        }
                    }

                    Debug.Log(Hall[i]);
                    Debug.Log("x = " + x);
                    Debug.Log("y = " + y);


                  
                   


                }

                int b = int.Parse(split_text[1])/100;
               


                int c = int.Parse(split_text[2]) / 100;
               

                int d = int.Parse(split_text[3]) / 100;
               





            }
        }

        //float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        //transform.Translate (0f, 0f, h * moveSpeed * Time.deltaTime);

        //Move
        //transform.Translate(0f, 0f, v * moveSpeed * Time.deltaTime);

        //Turn
        //transform.Rotate(0f, h * turnSpeed * Time.deltaTime, 0f);



    }
    void OnConnected()
    {
        try
        {
            bluetoothHelper.StartListening();
            bluetoothHelper2 = BluetoothHelper.GetNewInstance();
        }
        catch (Exception ex)
        {
            Debug.Log(ex.Message);
        }

    }

    void OnConnectionFailed()
    {
        Debug.Log("Connection Failed");
    }

    void OnDestroy()
    {
        if (bluetoothHelper != null)
            bluetoothHelper.Disconnect();
    }

}
