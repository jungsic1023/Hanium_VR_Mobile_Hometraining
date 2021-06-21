using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ArduinoBluetoothAPI;
using System;
using System.Text;
using UnityEngine.PlayerLoop;

using System.Linq;

public class doomap : MonoBehaviour
{

    //public float moveSpeed = 5f;
    public int q = 0;
    public float sp = 0;
    public float turnSpeed = 540f;
    public int x = 0;
    public int y = 0;

    BluetoothHelper bluetoothHelper;
    BluetoothHelper bluetoothHelper2;
    string deviceName;

    string received_message;

    void Start()
    {

        deviceName = "HC-06"; //bluetooth should be turned ON;
        try
        {
            Debug.Log("연결");
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

    void Update()
    {

        if (bluetoothHelper != null)
        {
            if (bluetoothHelper.Available)
            {
                received_message = bluetoothHelper.Read();
                string text = received_message;
                string[] split_text = new string[8];
                split_text = text.Split(' ');

                //4줄아님 string[] Hall = new string[10];              
                //Hall[10] = split_text[0];
                //for (int i = 0; i < split_text.Length; i++)
                //Debug.Log(split_text[i]);

                int a = int.Parse(split_text[7]);
                Debug.Log("센서값 :" + a);
                if (a == 0) //적외선센서 a는 0// 
                {
                    x = x + 1;
                    y = 0;
                    if (x == 1)
                    {
                        sp = 1;
                        x = 1;
                        y = 0;

                    }
                    else if (x == 2)
                    {
                        sp = 2;
                        y = 0;

                    }
                    else if (x == 3)
                    {
                        sp = 3;
                        y = 0;

                    }
                    else if (x == 4)
                    {
                        sp = 4;
                        y = 0;

                    }
                    else if (x == 5)
                    {
                        sp = 5;
                        y = 0;

                    }
                    else if (x == 6)
                    {
                        sp = 6;
                        y = 0;

                    }
                    else if (x == 7)
                    {
                        sp = 7;
                        y = 0;

                    }
                    else if (x == 8)
                    {
                        sp = 8;
                        y = 0;

                    }
                    else if (x == 9)
                    {
                        sp = 9;
                        y = 0;

                    }
                    else if (x == 10)
                    {
                        sp = 10;
                        y = 0;

                    }
                    else if (x == 11)
                    {
                        sp = 11;
                        y = 0;

                    }
                    else if (x == 12)
                    {
                        sp = 12;
                        y = 0;

                    }
                    else if (x > 12)
                    {
                        x = 12;
                        sp = 30;
                        y = 0;
                    }
                }



                if (a == 1)
                {
                    y = y + 1;
                    if (x == 0)
                    {
                        y = 0;
                    }
                    if (x == 1)
                    {
                        if (y == 130)
                        {
                            sp = 0;
                            x = 0;
                            y = 0;
                        }


                    }
                    else if (x == 2)
                    {
                        if (y == 130)
                        {
                            sp = 0;
                            x = 0;
                            y = 0;
                        }

                    }
                    else if (x == 3)
                    {
                        if (y == 130)
                        {
                            sp = 1;
                            x = 1;
                            y = 0;
                        }

                    }
                    else if (x == 4)
                    {
                        if (y == 100)
                        {
                            sp = 1;
                            x = 1;
                            y = 0;
                        }

                    }
                    else if (x == 5)
                    {
                        if (y == 100)
                        {
                            sp = 1;
                            x = 1;
                            y = 0;
                        }

                    }
                    else if (x == 6)
                    {
                        if (y == 100)
                        {
                            sp = 2;
                            x = 2;
                            y = 0;
                        }

                    }
                    else if (x == 7)
                    {
                        if (y == 100)
                        {
                            sp = 2;
                            x = 2;
                            y = 0;
                        }

                    }
                    else if (x == 8)
                    {
                        if (y == 100)
                        {
                            sp = 3;
                            x = 3;
                            y = 0;
                        }

                    }
                    else if (x == 9)
                    {
                        if (y == 100)
                        {
                            sp = 3;
                            x = 3;
                            y = 0;
                        }

                    }
                    else if (x == 10)
                    {
                        if (y == 100)
                        {
                            sp = 4;
                            x = 4;
                            y = 0;
                        }

                    }
                    else if (x == 11)
                    {
                        if (y == 100)
                        {
                            sp = 4;

                            x = 4;
                            y = 0;
                        }

                    }
                    else if (x == 12)
                    {
                        if (y == 100)
                        {
                            sp = 5;
                            x = 5;
                            y = 0;
                        }

                    }

                }

                //x값 범위 늘리기, y값 수정, 가속도 센서 세분화//

                int br = int.Parse(split_text[0]);
                if (br == 1) //브레이크//
                {
                    sp = 0;
                }

                Debug.Log(q);
                Debug.Log("x = " + x);
                Debug.Log("y = " + y);

                float fMove = Time.deltaTime * sp;
                transform.Translate(Vector3.forward * fMove);
                //transform.Translate(Vector3.forward * fMove);

                int b = int.Parse(split_text[1]);




                float sum = 0;
                if (b > 300 && b <= 2000)
                {
                    transform.Rotate(0, 0, 0);
                }
                else if (b > 2000 && b <= 3000)
                {
                    transform.Rotate(Vector3.up * Time.deltaTime * 15);
                }
                else if (b > 3000 && b <= 4000)
                {
                    transform.Rotate(Vector3.up * Time.deltaTime * 30);
                }
                else if (b > 4000)
                {
                    transform.Rotate(Vector3.up * Time.deltaTime * 45);
                } //오른쪽

                else if (b > 0 && b <= 300)
                {
                    transform.Rotate(Vector3.down * Time.deltaTime * 20);
                }
                else if (b > -2000 && b <= 0)
                {
                    transform.Rotate(Vector3.down * Time.deltaTime * 40);
                }
                else if (b <= -2000)
                {
                    transform.Rotate(Vector3.down * Time.deltaTime * 60);
                }//왼쪽

                Debug.Log("b = " + b);

                //transform.Rotate(0f, -10 * Time.deltaTime, 0f);

                //transform.Translate(Vector3.forward * fMove);
                // float h = Input.GetAxis("Horizontal");
                //float v = Input.GetAxis("Vertical");

                //transform.Translate (0f, 0f, h * moveSpeed * Time.deltaTime);

                //Move
                //transform.Translate(0f, 0f, v * moveSpeed * Time.deltaTime);

                //Turn
                //  transform.Rotate(0f, h * turnSpeed * Time.deltaTime, 0f);

            }
        }






    }
    void restrcitX()
    {
        if (x < 0)
        {
            x = 0;
        }
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
