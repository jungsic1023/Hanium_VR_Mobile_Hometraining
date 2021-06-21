using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ArduinoBluetoothAPI;
using System;
using System.Text;

public class test1 : MonoBehaviour
{

    // Use this for initialization
    BluetoothHelper bluetoothHelper;
    BluetoothHelper bluetoothHelper2;
    string deviceName;

    public Text text;

    public GameObject sphere;

    string received_message;

    void Start()
    {
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

    void Update()
    {
        if (bluetoothHelper != null)
            if (bluetoothHelper.Available)
            {
                received_message = bluetoothHelper.Read();
                string text = received_message;
                string[] split_text;
                split_text = text.Split(' ');
                for (int i = 0; i < split_text.Length; i++)
                    Debug.Log(split_text[i]);

            }
    }


    void OnConnected()
    {
        //sphere.GetComponent<Renderer>().material.color = Color.green;
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